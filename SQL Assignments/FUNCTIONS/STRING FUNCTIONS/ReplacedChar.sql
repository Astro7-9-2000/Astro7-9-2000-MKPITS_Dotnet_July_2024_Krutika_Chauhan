/*
6. Select Customers with Replaced Characters in Address: Retrieve the Address of customers, replacing occurrences of 'Street' with 'St.' using the REPLACE function
*/

Select Id , REPLACE(Customer_Address , 'Street' , 'St.') AS ModifiedAddress from Customer;
