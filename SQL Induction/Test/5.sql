select top 1 
Id,
Name 
from 
Employee 
where 
Basic < (select MAX(Basic) from Employee)
