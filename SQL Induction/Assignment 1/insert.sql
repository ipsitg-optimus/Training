--insert queries for t_product_master table.
insert into t_product_master values('P1','Pen',10)
insert into t_product_master values('P2','Scale',15)
insert into t_product_master values('P3','Notebook',25)

--insert queries for t_user_master table.
insert into t_user_master values('U1','Alfred Lawrence')
insert into t_user_master values('U2','William Paul')
insert into t_user_master values('U3','Edward Fillip')

--insert queries for t_transaction table.
insert into t_transaction values('U1','P1','10-25-2010','Order',150)
insert into t_transaction values('U1','P1','11-20-2010','Payment',750)
insert into t_transaction values('U1','P1','11-20-2010','Order',200)
insert into t_transaction values('U1','P3','11-25-2010','Order',50)
insert into t_transaction values('U3','P2','11-26-2010','Order',100)
insert into t_transaction values('U2','P1','12-15-2010','Order',75)
insert into t_transaction values('U3','P2','01-15-2011','Payment',250)