--creates a new view named manager which contains details of the managers with salary greater than 60000.
create view manager as
select e.first_name, e.last_name, e.sex ,e.age,e.half_yearly_grade from employee e, employee_salary es where e.salary_id=es.salary_id and es.basic_salary > 60000 and e.designation_id=(select designation_id from designation where designation='Manager')

--alters table employee by adding a new column date_of_joining of type date and 
--updating it to current date.
alter table employee add date_of_joining date
update employee set date_of_joining='06-06-14'

select * from manager
--displays records of the view manager.select * from manager