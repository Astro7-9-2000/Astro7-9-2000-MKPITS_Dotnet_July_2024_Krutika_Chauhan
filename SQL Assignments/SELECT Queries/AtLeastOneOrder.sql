/*
 Find Customers with Orders: Write a query to select all customers who have placed at
 least one order, joining the Customers and Orders tables based on CustomerID
*/

Select * from Customer c
Join orders o 
ON c.Id = o.Id;

