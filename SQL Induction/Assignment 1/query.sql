select
u2.User_Name,
u3.Product_Name,
u1.Ordered_Quantity,
u1.Amount_Paid,
u1.Last_Transaction_Date,
u1.Balance
from 
t_user_master u2,
t_product_master u3, 
(
	select 
	User_ID, 
	t_transaction.Product_Id,
	Cost_Per_Item,
	sum
	(
		CASE when transaction_type='Order' 
		then Transaction_amount else 0 END
	) 
	as Ordered_Quantity,
	sum
	(
		CASE when transaction_type='Payment'
		then Transaction_amount else 0 END
	)
	as Amount_Paid,
	MAX(transaction_date) as Last_Transaction_Date,
	SUM
	(
		CASE when transaction_type='Order' 
		then
		Cost_Per_Item*Transaction_Amount
		else
		-Transaction_AMount
		END
	) 
	as Balance
from t_transaction join t_product_master on t_transaction.Product_ID=t_product_master.Product_ID
group by 
User_ID,
t_transaction.Product_ID,
Cost_Per_Item
) 
as u1
where 
u1.User_Id=u2.User_Id and u1.Product_Id=u3.Product_ID