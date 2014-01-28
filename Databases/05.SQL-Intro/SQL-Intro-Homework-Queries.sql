--4. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
select * from Departments

--5. Write a SQL query to find all department names.
select Name from Departments

--6. Write a SQL query to find the salary of each employee.
select FirstName + ' ' + LastName as FullName, Salary from Employees

--07.Write a SQL to find the full name of each employee.
select FirstName + ' ' + LastName as FullName from Employees

--08.Write a SQL query to find the email addresses of each employee (by his first and last name).
--Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".
select FirstName + ' '+ LastName as FullName, FirstName + '.' + LastName + '@telerik.com' as EmailAddress from Employees

--09.Write a SQL query to find all different employee salaries.
select distinct Salary from Employees

--10. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
select * from Employees where JobTitle = 'Sales Representative'

--11. Write a SQL query to find the names of all employees whose first name starts with "SA".
select FirstName from Employees where FirstName like 'sa%'

--12. Write a SQL query to find the names of all employees whose last name contains "ei".
select LastName from Employees where LastName like '%ei%'

--13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
select FirstName, LastName, Salary from Employees where Salary >= 20000 and Salary <= 30000 order by Salary

--14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
select FirstName, LastName, Salary from Employees where Salary in (12500, 14000, 23600, 25000) order by Salary

--15. Write a SQL query to find all employees that do not have manager.
select FirstName + ' ' + LastName + ' ' + 'does not have manager' as Message from Employees where ManagerID is null

--16. Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
select FirstName + ' ' + LastName as FullName, Salary from Employees where Salary > 50000 order by Salary desc

--17.Write a SQL query to find the top 5 best paid employees.
select top 5 FirstName + ' ' + LastName as FullName, Salary from Employees order by Salary desc

--18. Write a SQL query to find all employees along with their address. Use inner join with ON clause.
select e.FirstName, e.LastName, a.AddressText from Employees e Join Addresses a on e.AddressID = a.AddressID

--19. Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
select e.FirstName, e.LastName, a.AddressText from Employees e, Addresses a where e.AddressID = a.AddressID

--20. Write a SQL query to find all employees along with their manager.
select e.FirstName, e.LastName, m.FirstName + ' ' + m.LastName as Manager from Employees e left join Employees m on e.ManagerID = m.EmployeeID

--21. Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.
select e.FirstName, e.LastName, m.FirstName + ' ' + m.LastName as Manager, a.AddressText 
from Employees e left join Employees m on e.ManagerID = m.EmployeeID join Addresses a on e.AddressID = a.AddressID order by Manager

--22. Write a SQL query to find all departments and all town names as a single list. Use UNION.
select Name from Departments union select Name from Towns

--23. Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager.
-- Use right outer join. Rewrite the query to use left outer join.
select e.FirstName, e.LastName, m.FirstName + ' ' + m.LastName as Manager from Employees e left join Employees m on e.ManagerID = m.EmployeeID

select e.FirstName, e.LastName, m.FirstName + ' ' + m.LastName as Manager from Employees e full outer join Employees m on e.ManagerID = m.EmployeeID order by Manager

--24. Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
select e.FirstName, e.LastName, e.HireDate from Employees e join Departments d on e.DepartmentID = d.DepartmentID where d.Name in('Sales','Finance') and 
e.HireDate >= '1995-01-01 00:00:00' and e.HireDate <= '2005-12-31 23:59:59' order by HireDate