select distinct 
isnull(Emp_f_name,'')+' '+isnull(Emp_m_name,'')+' '+isnull(Emp_l_name,'') as Name ,
CASE when (select COUNT(*) from t_salary where Emp_ID=e.Emp_ID)>0 then 'Yes' else 'No' end as 'Got increment in salary',
(select sum(atten_end_hrs) from t_atten_det where Emp_Id=e.Emp_id) as 'total worked hours',
(select top 1 Activity_description from t_atten_det,t_activity where Emp_Id=e.Emp_id and t_activity.Activity_id=t_atten_det.Activity_id order by Atten_start_datetime desc) as 'last worked activity',
(select top 1 Atten_end_hrs from t_atten_det where Activity_id=(select top 1 t_activity.Activity_id from t_atten_det,t_activity where Emp_Id=e.Emp_id and t_activity.Activity_id=t_atten_det.Activity_id order by Atten_start_datetime desc ) and e.Emp_id=Emp_Id order by Atten_start_datetime desc) as 'Total worked hours',
(select top 1 New_Salary from t_salary where e.Emp_id=Emp_Id order by Changed_date desc) as 'Current Salary',
(select ISNULL(temp.New_salary,0) from (select New_Salary, MAX(changed_date) as max from t_salary where Emp_Id=e.Emp_id and Changed_date<(select MAX(changed_date) from t_salary where Emp_Id=e.Emp_id) group by New_Salary ) as temp) as 'Previous salary'
from t_emp e,t_salary s, t_atten_det a where e.Emp_ID=s.Emp_ID  and e.Emp_id=a.Emp_id