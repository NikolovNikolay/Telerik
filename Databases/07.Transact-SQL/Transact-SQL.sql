-- 1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).
-- Insert few records for testing. Write a stored procedure that selects the full names of all persons.

create database TelerikTestAccounts -- Creating the Database first
Go

Use TelerikTestAccounts -- selecting the created database
Go

create table Persons(   -- create the first table
ID int identity,
FirstName nvarchar(50),
LastName nvarchar(50),
SSN nvarchar(50),
constraint Pk_ID primary key(ID))

create table Accounts(  -- create the second table
ID int identity,
PersonID int,
Balance money
constraint PK_ID_acc primary key(ID),
constraint FK_Persons_Accounts foreign key (PersonID) references Persons(ID)
)

insert into Persons(FirstName,LastName,SSN)  -- adding records to Persons table
	values ('Peter','Ivanov','123NK56987F'),
		   ('Ivanka' ,'Metodieva', '798POTRES456'),
		   ('Irina' , 'Georgieva', 'GHJ9784P120'),
		   ('Samuil' , 'Todorov', '98723JKHRT0')

insert into Accounts(PersonID,Balance)
	values (3, 4500.56),
		   (2, 1345),
		   (4, 550.23),
		   (1, 2876.65)

-- writing stored procedure
use TelerikTestAccounts
Go

create proc usp_SelectFullNameOfPerson
as 
	select FirstName + ' ' + LastName as [Full Name]
	from Persons
Go

-- executing stored procedure
exec usp_SelectFullNameOfPerson

-- 2 . Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.
use TelerikTestAccounts
Go

create proc usp_ReturnPeopleWithCustomBallance @balance money
as 
	select p.FirstName + ' ' + p.LastName as [Full Name]
	from Persons p join Accounts a
	on p.ID = a.PersonID
	where a.Balance > 1000
Go

exec usp_ReturnPeopleWithCustomBallance 1000

-- 3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
-- It should calculate and return the new sum. Write a SELECT to test whether the function works as expected.
use TelerikTestAccounts
GO

	-- functions might be marked in red. That is because it is better to be executed in new query
	-- also the select statement under it might also be marked in red, but works fine
create function ufn_CalcNewSum(@sum money, @interest float, @months int)
returns money
as
begin
	return @sum*power((1 + ((@interest/100)/12)),@months)
end

select dbo.ufn_CalcNewSum(a.Balance, 10, 12) as New from Accounts a

-- 4. Create a stored procedure that uses the function from the previous example to give an interest to a person's account
-- for one month. It should take the AccountId and the interest rate as parameters.

use TelerikTestAccounts
GO

create proc usp_CalculateInterestForOnePerson(@account_id int, @interest float)
as
	select dbo.ufn_CalcNewSum(a.Balance,@interest, 1) - a.Balance as Interest
	from Accounts a
	where @account_id = a.ID
GO

exec usp_CalculateInterestForOnePerson 2, 6.5

-- 5. Add two more stored procedures WithdrawMoney( AccountId, money) and DepositMoney (AccountId, money) that operate in transactions.

create procedure usp_WithdrawMoney(@account_id int, @sum money)
as
begin tran
	declare @currentBalance money
	set @currentBalance = (select a.Balance from Accounts a where a.ID = @account_id)

	if(@currentBalance - @sum < 0)
	begin
			rollback tran
	end
	else
	begin
			update Accounts
			set Balance = (@currentBalance - @sum) 
			where Accounts.ID = @account_id
			commit tran
	end
GO

exec usp_WithdrawMoney 1, 100

-------

create proc usp_DepositMoney(@account_id int, @sum money)
as
begin tran
	declare @currentBalance money
	set @currentBalance = (select a.Balance 
							from Accounts a
							where a.ID = @account_id)
	if(@currentBalance is null)
	begin
			rollback tran
	end
	else
	begin
			update Accounts
			set Balance = @currentBalance + @sum 
			where Accounts.ID = @account_id
			commit tran
	end
GO

exec usp_DepositMoney 1, 4501

-- 6. Create another table – Logs(LogID, AccountID, OldSum, NewSum). Add a trigger to the Accounts table that enters a new entry
-- into the Logs table every time the sum on an account changes.
use TelerikTestAccounts
GO

create table Logs(
LogID int identity,
AccountID int,
[Old sum] money,
[New sum] money,
constraint pk_LogID primary key(LogID),
constraint fk_Logs_Accounts foreign key(AccountID) references Accounts(ID))

create trigger tr_AccountBallanceChange on Accounts for Update
as
if(exists(select * from deleted))
begin
	declare @account_id int
	set @account_id = (select ID from deleted)
	declare @oldSum money
	set @oldSum = (select Balance from deleted)
	declare @newSum money
	set @newSum = (select Balance from inserted)

	insert into Logs(AccountID,[Old sum], [New sum])
		values(@account_id, @oldSum, @newSum)
end

exec usp_DepositMoney 1, 500

truncate table Logs

-- 7. Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name)
-- and all town's names that are comprised of given set of letters. Example 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

use TelerikAcademy
GO

create function ufn_FindEmployeesAndTownsByLetter(@string nvarchar(20))
returns @resultTable table([Employees and towns] nvarchar(50))
as 
begin
	declare @index int
	declare @char nchar
	declare @tempTable table(One nvarchar(50), Two nvarchar(50))

	set @index = 0
	insert into @tempTable(One)
			select LastName from Employees union select FirstName from Employees union select  MiddleName from Employees

	insert into @tempTable(Two)
			select t.Name from Towns t

	while(@index < LEN(@string))	
	begin	
		set @char = SUBSTRING(@string,@index,1)
		insert into @resultTable([Employees and towns])
			select distinct One from @tempTable where One Like '%'+@char+ '%' or One like @char+ '%' or One like '%'+@char
				union
			select distinct Two from @tempTable where Two like '%'+@char+ '%' or Two like @char+ '%' or Two like '%'+@char

	set @index = @index + 1
	end
	return
end

select * 
from dbo.ufn_FindEmployeesAndTownsByLetter('oistmiahf') 
order by [Employees and towns]