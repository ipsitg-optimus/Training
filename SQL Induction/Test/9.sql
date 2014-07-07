select Name 
from 
EmployeeAttendance e1,
Employee e,
(
select EmpId,DENSE_RANK() over(order by SUM(PresentDays))
as rank from 
EmployeeAttendance 
group by EmpID
) 
as e3
where 
e3.rank=1 
and e1.EmpID=e3.EmpID
and e.Id=e1.EmpID
group by Name

declare @att int;
select 
@att = Max(WorkingDays-PresentDays) from EmployeeAttendance e1 join
Employee e on e.Id=e1.EmpID 

select @att,
Name from EmployeeAttendance e1 join
Employee e on e.Id=e1.EmpID 
group by WorkingDays,PresentDays,Name
having WorkingDays-PresentDays = MIN(@att)