--displays details of employees whose salaries are less than 50000 and designation are Manager/Tech Lead
select * from employee where salary > 50000 and (desig='Manager' or desig='Tech Lead')