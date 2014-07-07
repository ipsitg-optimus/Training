select 
d.DeptName,
e.Name,
(e.Basic+e.HR+e.DA+e.TAX) as 'Highest Gross Salary'
from
Department d,
Employee e
where e.DeptID=d.DeptID
and 
(e.Basic+e.HR+e.DA+e.TAX)=
(
select 
MAX(Basic+HR+DA+TAX)
from Employee where DeptID=d.DeptID
)
order by DeptName,Name