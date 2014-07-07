select 
distinct DeptName,
COUNT(*) 
as 'No. of Employees',
MAX(Basic+HR+DA+TAX) 
as 'Highest Gross Salary',
SUM(Basic+HR+DA+TAX) 
as 'Total Salary' 
from Employee e, 
Department d where e.DeptID=d.DeptID
group by DeptName
order by DeptName 