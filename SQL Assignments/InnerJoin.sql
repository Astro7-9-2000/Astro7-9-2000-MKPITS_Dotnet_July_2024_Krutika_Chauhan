-------------- INNER JOIN -------------------
-- 9. Write a SQL Query to retrieve all orders with customer information (name , email) from the 'orders' and 'customers' tables using Inner Join. --
SELECT o.Order_id, o.Order_date, C.customer_name, C.customer_contact
FROM orders O
INNER JOIN customers C
ON O.customer_id = C.customer_id;