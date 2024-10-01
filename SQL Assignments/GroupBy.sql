------------ Group by ---------------

 select c.customer_name , c.customer_email 
 from customers c
 left join orders o
 On c.customer_id = o.customer_id
 Group By c.customer_name , c.customer_email;