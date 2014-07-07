select 
distinct DeptName,
Gender,
COUNT(*) 
as 'No. of Employees'
from Employee e, 
Department d where e.DeptID=d.DeptID
group by DeptName,Gender
order by DeptName, Gender 