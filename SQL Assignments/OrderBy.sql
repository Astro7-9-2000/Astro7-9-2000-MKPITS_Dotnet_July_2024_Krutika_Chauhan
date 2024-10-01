------------- Order By -------------
-- 20.Retrieve all customers along with the total amount of orders they have placed , ordered by the total amount in descending order.--

select c.customer_name , o.orders_name
from customer c 
left join orders o
on c.customer_id = o.customer_id
Order by o.orders_name desc;

