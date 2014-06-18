--creates 3 new tables with same struecture as employee table and inserts entries into them.

create table ABC (employee_id int PRIMARY KEY, first_name varchar(50),last_name varchar(50),designation_id int DEFAULT 1,department_id int NULL,salary_id int,age int default 18,sex char(1),active bit, half_yearly_grade int)


insert into ABC values(1,'Akash','Shrivastava',1,1,1,25,'M','True',2)
insert into ABC values(2,'Anchal','Gangwar',1,1,2,40,'F','True',2)
insert into ABC values(3,'Chandan','Soni',3,2,3,55,'M','True',4)
insert into ABC values(4,'Gaurav','Sharma',3,NULL,4,30,'M','True',4)


create table MNO (employee_id int PRIMARY KEY, first_name varchar(50),last_name varchar(50),designation_id int DEFAULT 1,department_id int NULL,salary_id int,age int default 18,sex char(1),active bit, half_yearly_grade int)


insert into MNO values(5,'Akash','Shrivastava',1,1,1,25,'M','True',2)
insert into MNO values(6,'Anchal','Gangwar',1,1,2,40,'F','True',2)
insert into MNO values(7,'Chandan','Soni',3,2,3,55,'M','True',4)
insert into MNO values(8,'Gaurav','Sharma',3,NULL,4,30,'M','True',4)


create table XYZ (employee_id int PRIMARY KEY, first_name varchar(50),last_name varchar(50),designation_id int DEFAULT 1,department_id int NULL,salary_id int,age int default 18,sex char(1),active bit, half_yearly_grade int)


insert into XYZ values(9,'Akash','Shrivastava',1,1,1,25,'M','True',2)
insert into XYZ values(10,'Anchal','Gangwar',1,1,2,40,'F','True',2)
insert into XYZ values(11,'Chandan','Soni',3,2,3,55,'M','True',4)
insert into XYZ values(12,'Gaurav','Sharma',3,NULL,4,30,'M','True',4)


--displays data from 3 tables by creating a union over ABC, MNO, XYZ
select * from ABC
UNION 
select * from MNO
UNION 
select * from XYZ