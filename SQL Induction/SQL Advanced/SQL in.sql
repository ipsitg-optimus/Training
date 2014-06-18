--displays records of employees whose salaries are either 20000 or 15000
select * from employee e,employee_salary es where es.basic_salary in (20000,15000) and e.salary_id=es.salary_id