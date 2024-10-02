/*
9. Insert Customer with Timestamp: Write a query to insert a new customer with fields
 such as CustomerID, FirstName, LastName, and Email, along with a CreatedAt timestamp field capturing the current date and time.*/

Insert into Customer (FirstName , LastName , City , Country , Phone , Customer_Address , Email , Customer_State , Zipcode , Street) values
('Sunita' , 'Williams' , 'Houstan' , 'USA' , +1857496258 , '4567 Oakbrook Drive Houston, TX 77245' , 'AstroSuni13@gmail.com' , 'Texas' , '77002' ,'Memorial Drive');  
