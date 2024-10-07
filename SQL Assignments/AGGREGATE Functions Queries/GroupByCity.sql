
/*42. Group Customers by City: Retrieve the count of customers in each City using the
 GROUP BY and COUNT functions.*/

 Select City , Count(*)
 from Customer
 group by City;