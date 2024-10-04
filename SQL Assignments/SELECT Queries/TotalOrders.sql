/*
Select Customers and Their Total Orders Value: Write a query to select customers along
 with the total value of their orders by joining the Customers and Orders tables and
 summing the OrderAmount for each customer
*/

Select c.Id , c.Firstname , c.LastName , SUM(o.TotalAmount) AS TotalOrdersValue
from Customer c
Join Orders o ON c.Id = o.Id
Group by c.Id , c.FirstName , c.LastName;