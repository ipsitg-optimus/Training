--use "with rollup" and "with cube" on employee salary column.
select basic_salary,house_rentals,COUNT(*) as 'Count' from employee_salary group by basic_salary,house_rentals with rollup



select basic_salary,house_rentals,COUNT(*) as 'Count' from employee_salary group by basic_salary,house_rentals with cube