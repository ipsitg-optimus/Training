--creates 
--new table named designation with columns designation_id as primary key and designation name
create table designation (designation_id int PRIMARY KEY,designation varchar(50) NOT NULL)

--creates 
--new table named department with columns department_id as primary key and department_name.
create table department (department_id int PRIMARY KEY,department_name varchar(50))

--creates 
--new table named employee_salary with columns salary_id as primary key, basic_salary, house_rentals, daily_allowances and gross_salary
create table employee_salary (salary_id int PRIMARY KEY, basic_salary int,house_rentals int, daily_allowance int, gross_salary int)

--creates 
--new table named employee with columns employee_id as primary key, first_name, last_name, designation_id as foreign key from designation table,department_id as foreign key from departmant table, salary_id as foreign key from employee_salary table, age, sex, active and half_yearly_grade with designation 
--having default value "Trainee" and age having default value "18".
create table employee (employee_id int PRIMARY KEY, first_name varchar(50),last_name varchar(50),designation_id int DEFAULT 1,department_id int,salary_id int,age int default 18,sex char(1),active bit, half_yearly_grade int,FOREIGN KEY (designation_id) REFERENCES designation(designation_id),FOREIGN KEY(salary_id) REFERENCES employee_salary(salary_id),FOREIGN KEY(department_id) REFERENCES department(department_id))

--creates
--new table named orders with columns order_id as primary key, order_date, order_name, customer_name
create table orders (order_id int PRIMARY KEY, order_date date NOT NULL, order_name varchar(100),customer_name varchar(50))

--creates 
--new table named employee_slabs with columns designation_id as foreign key from designation table, min_salary, max_salary
create table employee_slabs (designation_id int, min_salary int NOT NULL,max_salary int NOT NULL,FOREIGN KEY(designation_id) REFERENCES designation(designation_id))