select 
DeptName,
COUNT(*) as 'Number of Employees' 
from 
Department d,
Employee e
where d.DeptID=e.DeptID 
and 
(
select COUNT(*) 
from 
Employee 
where DeptID=e.DeptID
)>3
group by DeptName