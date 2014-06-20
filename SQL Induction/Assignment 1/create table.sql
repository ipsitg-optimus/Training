--creates a new table t_product_master 
--with primary key Product_ID, Product_Name, Cost_Per_Item
create table t_product_master 
(
Product_ID varchar(10) PRIMARY KEY,
Product_Name varchar(25),
Cost_Per_Item int,
CHECK(Cost_Per_Item > 0)
)

--creates a new table t_user_master
--with User_ID as primary key, User_Name
--as other column
create table t_user_master
(
User_ID varchar(10) PRIMARY KEY,
User_Name varchar(25)
)

--creates a new table t_transaction
--with columns User_ID, Product_Id as foreign keys from 
--t_user_master, t_product_master tables respectively.
--and other columns as Transaction_Date, Transaction_Type, Transaction_Amount
create table t_transaction
(
User_ID varchar(10) FOREIGN KEY references t_user_master(User_ID),
Product_ID varchar(10) FOREIGN KEY references t_product_master(Product_ID),
Transaction_Date date NOT NULL,
Transaction_Type varchar(20) NOT NULL,
Transaction_Amount int,
CHECK(Transaction_Amount > 0) 
)