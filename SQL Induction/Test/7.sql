select 
DeptName,
Name as 'Dept Head Name'
from Department d,
Employee e
where d.DeptHeadID=e.Id

select DeptName, Name from Department d join Employee e on d.DeptHeadID=e.Id