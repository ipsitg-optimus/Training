--displays records of employees whose salaries lies between 20000 and 50000
--diplays records of employees where salary lies between 20000 and 50000
select * from employee e,employee_salary es where es.basic_salary between 20000 and 50000 and e.salary_id=es.salary_id