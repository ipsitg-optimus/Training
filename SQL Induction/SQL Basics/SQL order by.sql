--displays top 5 highest paid employees
select top 5 * from employee e,(select * from employee_salary ) as id where id.salary_id=e.salary_id order by id.basic_salary desc