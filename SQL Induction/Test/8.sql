select 
Name
from 
EmployeeAttendance ea,
Employee e
where ea.EmpID=e.Id 
and 
(
select 
(
	CASE 
	when 
	SUM(WorkingDays)=SUM(PresentDays) 
	then 'True' 
	else 'False' 
	end
) from EmployeeAttendance 
where EmpID=e.Id)='True'
group by Name
order by Name


select 
Name
from 
EmployeeAttendance ea,
Employee e
group by ea.EmpID,e.Id,Name
having ea.EmpID=e.Id and SUM(WorkingDays)=SUM(PresentDays) 