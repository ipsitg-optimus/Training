--creates a new table name employee with columns First name, Last name, Designation, Salary, Age and Half yearly grade with Designation 
--having default value "Trainee" and Age having default value "18"
create table employee (fname varchar(50),lname varchar(50),desig varchar(50) default 'Trainee',salary int,age int default 18,hyg int)