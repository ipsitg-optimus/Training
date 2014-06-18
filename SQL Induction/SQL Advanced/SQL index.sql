--creates a unique index named name on columns first_name, last_name in employee table.
create unique index 
name on employee (first_name, last_name)


--displays records of employees with unique index named name.
select * from employee with(INDEX(name))