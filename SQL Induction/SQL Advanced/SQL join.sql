--displays details of employees from employee and employee_slabs tables with join on department_id column
select * from employee e, employee_slabs es where e.designation_id=es.designation_id