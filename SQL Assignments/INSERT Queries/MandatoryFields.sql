/*
2.Add Customer with Mandatory Fields Only: Insert a new customer record into the
 database, ensuring that only mandatory fields (CustomerID, FirstName,LastName, Email) are populated, 
 while the rest are left as NULL or with default values
*/

Insert into Customer (FirstName , LastName , Email) values ('Sandy' , 'Vajpayee' , 'Sandy32@gmail.com');