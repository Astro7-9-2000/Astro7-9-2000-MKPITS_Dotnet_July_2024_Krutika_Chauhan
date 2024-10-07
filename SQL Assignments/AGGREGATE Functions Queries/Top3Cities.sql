/*
 44.Select Top 3 Cities with Most Customers: Write a query to select the top 3 cities
 with the highest number of customers using the GROUP BY, ORDER BY, and TOP
 clauses
*/

 Select Top 3
 City , 
 Count(Id) AS num_Customers
 from
 Customer
 GROUP BY
 City
 ORDER BY
 num_Customers DESC;