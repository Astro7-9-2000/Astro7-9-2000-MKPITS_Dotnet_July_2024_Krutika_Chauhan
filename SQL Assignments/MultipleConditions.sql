--------------  Join with Multiple Conditions ---------------
-- 18.Retrieve the orders made by customers who are located in the 'USA' and whose order amount is greater than $100 --

Select  o.orders , c.customers
from Orders 
Join Customers 
on o.Customer_id = c.Customer_id 
where o.orders_amount > 100