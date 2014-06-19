--E.g. Suppose employee_salary table, having column basic, HR & DA and Gross salary. 
--By default Gross salary is empty. 
--Use trigger to update the gross salary column as (Basic+HRA+DA)*12, 
--whenever records are entered in the employee_salary table.
create trigger employee_trigger on employee_salary
after insert as
declare @salary_id int
select @salary_id=i.salary_id from inserted i
update employee_salary set gross_salary=(basic_salary+house_rentals+daily_allowance)*12 where salary_id=@salary_id
go