--inserts entries into designation table
insert into designation values(1,'Trainee')
insert into designation values(2,'Senior Developer')
insert into designation values(3,'Manager')
insert into designation values(4,'Technical Leader')

--inserts entries into department table
insert into department values(1,'Technical')
insert into department values(2,'Management')
insert into department values(3,'Human Resource')

--insetrs entries into employee_salary table
insert into employee_salary values(1,7000,3000,100,1000)
insert into employee_salary values(2,10000,5000,500,3000)
insert into employee_salary values(3,200000,3000,700,4000)
insert into employee_salary values(4,250000,3000,1000,2000)
insert into employee_salary values(5,60000,3000,900,500)
insert into employee_salary values(6,70000,5000,900,600)
insert into employee_salary values(7,100000,6000,800,1000)
insert into employee_salary values(8,155000,4000,900,1200)

-- inserts entries into the table employee
insert into employee (employee_id,first_name,last_name,designation_id,department_id,salary_id,age,sex,active,half_yearly_grade) values(1,'Akash','Shrivastava',1,1,1,25,'M','True',2)
insert into employee (employee_id,first_name,last_name,designation_id,department_id,salary_id,age,sex,active,half_yearly_grade) values(2,'Anchal','Gangwar',1,1,2,40,'F','True',2)
insert into employee (employee_id,first_name,last_name,designation_id,department_id,salary_id,age,sex,active,half_yearly_grade) values(3,'Chandan','Soni',3,2,3,55,'M','True',4)
insert into employee (employee_id,first_name,last_name,designation_id,department_id,salary_id,age,sex,active,half_yearly_grade) values(4,'Gaurav','Sharma',3,NULL,4,30,'M','True',4)
insert into employee (employee_id,first_name,last_name,designation_id,department_id,salary_id,age,sex,active,half_yearly_grade) values(5,'Adarsh','Gaur',4,NULL,5,60,'M','True',5)
insert into employee (employee_id,first_name,last_name,designation_id,department_id,salary_id,age,sex,active,half_yearly_grade) values(6,'Neha','Goyal',4,1,6,55,'F','True',6)
insert into employee (employee_id,first_name,last_name,department_id,salary_id,sex,active,half_yearly_grade) values(7,'Paras','Mishra',1,7,'M','True',3)
insert into employee (employee_id,first_name,last_name,department_id,salary_id,sex,active,half_yearly_grade) values(8,'Chiransh','Vashistha',1,8,'M','True',3)

--inserts entries into the orders
insert into orders values (1,'06-06-14','Desktops','Ankit')
insert into orders values (2,'07-06-14','CPUs','Bahavna')
insert into orders values (3,'08-06-14','Monitors','Ankit')
insert into orders values (4,'09-06-14','CDs','Ankit')

--inserts entries into the employee_slabs table
insert into employee_slabs values(1,5000,10000)
insert into employee_slabs values(2,15000,30000)
insert into employee_slabs values(3,30000,80000)
insert into employee_slabs values(4,50000,300000)