
/*
 50. Find Customers with More Than One Order: Write a query to select customers
 who have placed more than one order by grouping by CustomerID and using the
 HAVING clause with COUNT
*/

 Select id 
 from Orders
 Group by Id
 having Count(OrdersNumber) > 1;
