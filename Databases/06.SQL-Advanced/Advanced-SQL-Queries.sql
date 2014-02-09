-- 1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company. Use a nested SELECT statement.
select e.FirstName, e.Lastname, e.Salary
from Employees e
where e.Salary = (select min(Salary) 
					from Employees)

-- 2. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
select e.FirstName, e.LastName, e.Salary
from Employees e
where e.Salary < (select min(Salary) * 1.1
					from Employees)

-- 3. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department. Use a nested SELECT statement.
select e.FirstName + ' ' + e.LastName as FullName, d.Name, Salary
from Employees e join Departments d
on e.DepartmentID = d.DepartmentID
where Salary = (select min(Salary) from Employees where DepartmentID = d.DepartmentID)
order by Salary

-- 4. Write a SQL query to find the average salary in the department #1.
select floor(avg(e.Salary)) as Average
from Employees e
where e.DepartmentID = 1

-- 5. Write a SQL query to find the average salary  in the "Sales" department.
Select floor(avg(e.Salary)) as Average
from Employees e join Departments d
on d.Name = 'Sales' and d.DepartmentID = e.DepartmentID

-- 6. Write a SQL query to find the number of employees in the "Sales" department.
select count(e.EmployeeID) as NumberOfEmployees
from Employees e join Departments d
on e.DepartmentID = d.DepartmentID and d.Name = 'Sales'

-- 7. Write a SQL query to find the number of all employees that have manager.
select count(e.EmployeeID) as NumberOfEmployees
from Employees e
where e.ManagerID is not null

-- 8. Write a SQL query to find the number of all employees that have no manager.
select count(e.EmployeeID) as NumberOfEmployees
from Employees e
where e.ManagerID is null

-- 9. Write a SQL query to find all departments and the average salary for each of them.
select d.Name, floor(avg(e.Salary)) as [Average Salary]
from Departments d join Employees e
on d.DepartmentID = e.DepartmentID
group by d.Name

-- 10. Write a SQL query to find the count of all employees in each department and for each town.
select d.Name as Department, t.Name as Town, count(e.EmployeeID) as Employees
from Employees e join Departments d
	on e.DepartmentID = d.DepartmentID
	join Addresses a
	on a.AddressID = e.AddressID
	join Towns t
	on t.TownID = a.TownID
group by d.Name, t.Name

-- 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
select e.FirstName, e.LastName
from Employees e join Employees em
on e.EmployeeID = em.ManagerID
group by e.FirstName, e.LastName
having count(*) = 5

-- 12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
select em.FirstName + ' ' + em.LastName as [Employee Name], coalesce(e.FirstName + ' ' + e.LastName , '(no manager)') as [Manager Name]
from Employees e right outer join Employees em
on e.EmployeeID = em.ManagerID
order by [Manager Name]

-- 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
select e.FirstName + ' ' + e.LastName as [Employees whose last name has 5 chars]
from Employees e
where len(e.LastName) = 5

-- 14. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
select convert(varchar(24), getdate(), 113)

-- 15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
--- Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint. 
--- Define the primary key column as identity to facilitate inserting records. Define unique constraint to avoid repeating usernames.
--- Define a check constraint to ensure the password is at least 5 characters long.
create table Users(
UserID int identity,
UserName nvarchar(100) not null unique,
UserPassword nvarchar(100) not null,
Last_login_date date not null default convert(varchar(24), getdate(), 113),
constraint chk_pass check (Len(UserPassword) > 5))

   -- later edit of table users, because i forgot to define a primary key
   alter table Users
	add constraint PK_def primary key(UserID)

-- 16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today. Test if the view works correctly.
select UserName 
from Users
where Last_login_date = convert(varchar(24), getdate(), 113)

-- 17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint). Define primary key and identity column.
create table Groups(
GroupID int not null Identity,
Name nvarchar(50) not null unique,
constraint key_chk primary key(GroupID)
)

-- 18. Write a SQL statement to add a column GroupID to the table Users. Fill some data in this new column and as well in the Groups table.
-- Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
alter table Users
	add GroupID int
alter table Users
	add constraint FK_Users_Groups
	foreign key(GroupID)
	references Groups(GroupID)

-- 19. Write SQL statements to insert several records in the Users and Groups tables.
insert into Users(UserName, UserPassword)
	values ('Genadii Petkov', '123456')
insert into Users(UserName, UserPassword)
	values ('Ivena Hlebarova','Sk@r@Bir@')

insert into Groups(Name)
	values ('Fellow-citizens')
insert into Groups(Name)
	values ('Drinkers')

-- 20. Write SQL statements to update some of the records in the Users and Groups tables.
Update Users
set UserPassword = 'Obich@mSk@r@Bir@'
where UserID = (select userID from Users where UserName like 'Ivena%')

update Groups
set Name= 'Fellow-townsman'
where GroupID = (select GroupID from Groups where Name like '%fellow%')

-- 21. Write SQL statements to delete some of the records from the Users and Groups tables.
delete from Users
where UserName like '%niko%'

delete from Groups
where GroupID = 3

-- 22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
-- Combine the first and last names as a full name. For username use the first letter of the first name + the
-- last name (in lowercase). Use the same for the password, and NULL for last login time.
insert into Users(UserName, UserPassword)
	select FirstName + ' ' + LastName as UserName, FirstName + ' ' + LastName as UserPassword from Employees

-- 23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
alter table Users
alter column UserPassword nvarchar(100) null

update Users
set UserPassword = null
where Last_login_date < '2010-03-10'

-- 24. Write a SQL statement that deletes all users without passwords (NULL password).
delete from Users
where UserPassword is null

-- 25. Write a SQL query to display the average employee salary by department and job title.
select e.JobTitle, avg(e.Salary) as [Average salary], d.Name as [Department Name]
from Employees e join Departments d
on e.DepartmentID = d.DepartmentID
group by e.JobTitle, d.Name
order by [Average salary]

-- 26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
select e.FirstName + ' ' + e.LastName as [Full name], e.JobTitle, min(e.Salary) as [Minimal salary], d.Name as [Department name]
from Employees e join Departments d
on e.DepartmentID = d.DepartmentID
group by e.JobTitle, d.Name, e.FirstName + ' ' + e.LastName
order by [Minimal salary]

-- 27. Write a SQL query to display the town where maximal number of employees work.
select top 1 t.Name, count(e.EmployeeID) as [Number Employees]
from Employees e 
	join Addresses ad
		on e.AddressID = ad.AddressID
	join Towns t
		on ad.TownID = t.TownID
group by t.Name
order by [Number Employees] desc

-- 28. Write a SQL query to display the number of managers from each town.
select t.Name, count(e.EmployeeID) as [Managers]
from Employees e 
	join Addresses ad
		on e.AddressID = ad.AddressID
	join Towns t 
		on t.TownID = ad.TownID
where e.EmployeeID in (select distinct ManagerID from Employees)
group by t.Name

-- 29. Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
-- Don't forget to define  identity, primary key and appropriate foreign key. 
-- Issue few SQL statements to insert, update and delete of some data in the table.
-- Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers. For each change keep
-- the old record data, the new record data and the command (insert / update / delete).
create table WorkHours(
TaskID int identity,
EmployeeID int,
[Date] date,
Task nvarchar(50),
[Hours] int,
Comments nvarchar(50)
constraint PK_empID primary key(TaskID),
constraint FK_WorkHours_Emplyees foreign key(EmployeeID) references Employees(EmployeeID)
)

insert into WorkHours(EmployeeID,Date,Task, Hours,Comments)
	values(7,getdate(), 'Dish washing', 2, 'Nicely cleaned')
insert into WorkHours(EmployeeID,Date,Task, Hours,Comments)
	values(89, getdate(), 'Watch TV', 3, 'Nothing to watch on TV')
insert into WorkHours(EmployeeID,Date,Task, Hours,Comments)
	values(15, getdate(), 'Sitting on chair', 5, 'Comfortable chair indeed')

update WorkHours
set Hours = Hours + 1
where Hours > 0

delete from WorkHours
where Hours > 5

use TelerikAcademy
GO

-----
create table WorkHoursLogs(
LogID int identity,
TaskID int,
EmployeeID int,
[Date] date,
Task nvarchar(50),
[Hours] int,
Comments nvarchar(50),
NewEmployeeID int,
NewDate date,
NewTask nvarchar(50),
NewHours int,
NewComments nvarchar(50),
Commands nvarchar(15),
constraint pk_logID primary key(LogID),
constraint fk_WorkHoursLog_Employees foreign key(EmployeeID) references Employees(EmployeeID))


create trigger tr_WorkHoursInsertChange on WorkHours for Update
as
if(exists(select * from deleted))
begin
	declare @taskID int, @employeeID int , @date date , @task nvarchar(50), @hours int, @comments nvarchar(50)
	set @taskID = (select taskID from deleted)
	set @employeeID = (select employeeID from deleted)
	set @date = (select [Date] from deleted)
	set @task = (select Task from deleted)
	set @hours = (select [Hours] from deleted)
	set @comments = (select [comments] from deleted)

	declare @newEmployeeID int , @newDate date , @newTask nvarchar(50), @newHours int, @newComments nvarchar(50)	
	set @newEmployeeID = (select employeeID from inserted)
	set @newDate = (select [Date] from inserted)
	set @newTask = (select Task from inserted)
	set @newHours = (select [Hours] from inserted)
	set @newComments = (select [comments] from inserted)

	insert into WorkHoursLogs(TaskID, EmployeeID, [Date], Task, [Hours], Comments, NewEmployeeID, NewDate, NewTask, NewHours, NewComments, Commands)
		values(@taskID, @employeeID, @date, @task, @hours, @comments, @newEmployeeID, @newDate, @newTask, @newHours, @newComments, 'UPDATE')
end

create trigger tr_WorkHoursInsert on WorkHours for Insert
as
if(exists(select * from inserted))
begin
	declare @taskID int, @employeeID int , @date date , @task nvarchar(50), @hours int, @comments nvarchar(50)
	set @taskID = (select taskID from inserted)
	set @employeeID = (select employeeID from inserted)
	set @date = (select [Date] from inserted)
	set @task = (select Task from inserted)
	set @hours = (select [Hours] from inserted)
	set @comments = (select [comments] from inserted)

	insert into WorkHoursLogs(TaskID, NewEmployeeID, NewDate, NewTask, NewHours, NewComments, Commands)
		values(@taskID, @employeeID, @date, @task, @hours, @comments, 'INSERT')
end

insert into WorkHours(EmployeeID,[Date],Task, [Hours],Comments)
	values(14, getdate(), 'Newspaper reading', 4, 'Entirely read')


create trigger tr_WorkHoursDelete on WorkHours for DELETE
as
if(exists(select * from deleted))
begin
	declare @taskID int, @employeeID int , @date date , @task nvarchar(50), @hours int, @comments nvarchar(50)
	set @taskID = (select taskID from deleted)
	set @employeeID = (select employeeID from deleted)
	set @date = (select [Date] from deleted)
	set @task = (select Task from deleted)
	set @hours = (select [Hours] from deleted)
	set @comments = (select [comments] from deleted)

	insert into WorkHoursLogs(TaskID, EmployeeID, [Date], Task, [Hours], Comments, Commands)
		values(@taskID, @employeeID, @date, @task, @hours, @comments, 'DELETE')
end

delete from WorkHours
where TaskID = 7