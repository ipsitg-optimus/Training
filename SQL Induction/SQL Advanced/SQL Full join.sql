--displays details of employees from employee and employee_slabs tables with right join on department_id column
select * from employee FULL OUTER JOIN department on employee.department_id=department.department_id