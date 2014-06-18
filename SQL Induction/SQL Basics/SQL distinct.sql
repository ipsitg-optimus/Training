-- displays all distinct designations present in the employee table
select designation from designation d,(select distinct designation_id from employee) as id where id.designation_id =d.designation_id