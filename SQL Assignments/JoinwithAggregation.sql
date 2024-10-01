-------------- Join with Aggregation ---------------
/* 15.	Retrieve the total number of orders placed by each customers placed by each customer along 
with their name and email --*/

Select c.customer_name , c.customer_email , Sum(o.orders)
from Customers c
Join Orders o ON c.customer_email , c.customer_name 
on c.Customer_id = o.Customer_id 
Group by c.customer_name