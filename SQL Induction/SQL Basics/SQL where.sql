--displays details of employees whose salaries are less than 20000
select * from employee e,employee_salary es where es.basic_salary < 20000 and e.salary_id=es.salary_id