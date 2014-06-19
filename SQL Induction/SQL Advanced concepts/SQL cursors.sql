--Create a procedure having a cursor which fetch complete list of employee 
--and update any one field of the employee table. 
--E.g. Suppose employee_salary table, having column basic,
-- HR & DA and Gross salary. By default Gross salary is empty.
-- Use cursors and update the gross salary column as (Basic+HRA+DA)*12
declare mycursor CURSOR for 
select salary_id from employee
open mycursor
declare @salaryid int
fetch next from mycursor into @salaryid
while @@FETCH_STATUS=0
	begin
		update employee_salary set gross_salary=(basic_salary+house_rentals+daily_allowance)*12 where salary_id=@salaryid
		fetch next from mycursor into @salaryid
	end
close mycursor
deallocate mycursor