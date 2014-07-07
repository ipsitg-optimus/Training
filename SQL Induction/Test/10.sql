select distinct Name
from EmployeeAttendance ea,
Employee e,
(
select 
EmpID,
SUM(WorkingDays-PresentDays) 
as leave
from EmployeeAttendance 
group by 
EmpID
) as ea1
where ea1.EmpID=ea.EmpID
and ea.EmpId=e.Id
and ea1.leave>=3