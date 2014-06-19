--Lists the employee list whose salary is greater than average employee salary.
declare @avg as float(10)
select @avg=AVG(basic_salary) from employee_salary
select * from employee e, employee_salary es where e.salary_id=es.salary_id and es.basic_salary > @avg


--Lists all the departments and respective employee count in it. 
select department.department_name,(select COUNT(*) from employee where department_id=department.department_id) from department


--List the employee list whose salary is lesser than highest employee salary.
declare @max as float(10)
select @max=MAX(basic_salary) from employee_salary
select * from employee e, employee_salary es where e.salary_id=es.salary_id and es.basic_salary < @max


--List the employee list whose salary is lesser than lowest employee salary.
declare @min as float(10)
select @min=MIN(basic_salary) from employee_salary
select * from employee e, employee_salary es where e.salary_id=es.salary_id and es.basic_salary > @min

--Display sum of all the employees salary.
declare @sum as int
select @sum=SUM(basic_salary) from employee_salary
print @sum

--List all the departments and respective employee count in it. 
select COUNT(*) from employee group by designation_id,department_id having department_id=1

--select the content of the "LastName" and "FirstName" columns from employee table, and convert the "LastName" column to uppercase
select first_name,UPPER(last_name) from employee

--select the content of the "LastName" and "FirstName" columns from employee table, and convert the "LastName" column to lowercase
select first_name,LOWER(last_name) from employee

 --select the length of the values in the "Names" column in employee table.
 select LEN(first_name) from employee

--Display the employee name and the salary rounded to the nearest integer from the employee_salary table.
select first_name,last_name,ROUND(es.basic_salary,0) from employee e,employee_salary es where e.salary_id=es.salary_id

--Display list of all the employee with the current date information.
select *,GETDATE() from employee

--Display the employee and salaries per today's date (with today's date displayed in the following format "DD-MM-YYYY"). Display multiple combination of day, month and year.
select *,CONVERT(varchar(15),GETDATE(),103) from employee

--use cast() to change datatype of empid column to Varchar(10)
select CAST(employee_id as varchar(10)) from employee

--"Show ""Yes"" for employees whose salary is more than 50000 and age is less than 35 else ""No""
select first_name,last_name,CASE WHEN es.basic_salary > 50000 THEN 'Yes' ELSE 'No' END as 'Status' from employee e, employee_salary es where e.salary_id=es.salary_id

--display top 5 highest paid employees
select top 5 * from employee join employee_salary on employee.salary_id=employee_salary.salary_id order by basic_salary desc 

--display top 5 alternate highest paid employees
select e.first_name,e.last_name, es.basic_salary from employee e, (select top 10 basic_salary,salary_id,DENSE_RANK() over(order by basic_salary desc) as row_num   from employee_salary ) es where es.row_num%2=1 and e.salary_id=es.salary_id order by basic_salary desc