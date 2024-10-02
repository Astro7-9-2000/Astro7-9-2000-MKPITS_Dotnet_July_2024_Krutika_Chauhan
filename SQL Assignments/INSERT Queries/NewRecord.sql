/* 1. Insert New Customer Record: Write a query to insert a new customer with fields such
 as CustomerID, FirstName, LastName, Email, PhoneNumber, Address, City,
 State, ZipCode, and Country */

 INSERT INTO Customer (FirstName ,LastName,City,Country , Phone , Customer_Address , Email , Customer_State)VALUES 
	 ('Sana','Khan','New York','USA' ,'8527541826' , '1456 Oak Street, New York, NY 10021' , 'Sana19@gmail.com' , 'New York');

Select * from Customer;
Alter table Customer 
Add Zipcode varchar(20) , Street varchar(50);
Add Customer_Address varchar (100) , Email varchar(50) , Customer_State varchar(20);