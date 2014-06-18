--updates designation, salary of employees to Manager, 50000 respectively 
--whose salary is greater than 40000 and age is greater than 35
update employee set designation_id=(select designation_id from designation
 where designation='Manager') from employee_salary INNER JOIN employee on employee.salary_id=employee_salary.salary_id 
 where employee_salary.basic_salary>40000 and age > 35 and 
 employee.salary_id=employee_salary.salary_id