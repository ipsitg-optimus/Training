alter view dbo.manager
as 
select e.first_name, e.last_name, e.sex ,e.age,e.half_yearly_grade,e.date_of_joining from employee e, employee_salary es where e.salary_id=es.salary_id and es.basic_salary > 60000 and e.designation_id=(select designation_id from designation where designation='Manager')