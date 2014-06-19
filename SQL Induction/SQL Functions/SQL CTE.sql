--creates a new Common table expression which gets names of all employees whose age is
--greater than 40, and then shows them using select over it.

with first_cte(first_name,last_name)
as 
(
select first_name,last_name from employee where age>40
)
select *  from first_cte