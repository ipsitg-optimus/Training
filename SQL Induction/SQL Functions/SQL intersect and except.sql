--creates a new table employee_experience with columns employee_id as foreign key from employee table and experience.
create table employee_experience (employee_id int FOREIGN KEY references employee(employee_id),experience int)
insert into employee_experience values(1,6)
insert into employee_experience values(2,7)
insert into employee_experience values(3,8)
insert into employee_experience values(4,2)
insert into employee_experience values(5,5)
insert into employee_experience values(6,30)
insert into employee_experience values(7,50)
insert into employee_experience values(8,4)

--shows details of employees whose experience is greater than 6 months using intersect
select employee_id from employee
INtersect
select employee_id from employee_experience where experience<6


--shows details of employees whose experience is greater than 6 months using except
select employee_id from employee
except
select employee_id from employee_experience where experience>=6

