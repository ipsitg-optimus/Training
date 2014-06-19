--Create a stored procedure that takes input as 'employeid' and 
--return the complete information regarding; personnel information, 
--department information & salary information.

create procedure emp_procedure @empid int output as
select e.first_name,e.last_name,e.age,e.sex,d.department_name,es.basic_salary,
es.daily_allowance,es.house_rentals,es.gross_salary 
from employee e,department d,employee_salary es
where e.salary_id=es.salary_id and e.department_id=d.department_id
go


--executes procedure
exec emp_procedure @empid=1