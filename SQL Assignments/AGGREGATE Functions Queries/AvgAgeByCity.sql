/*43. Calculate Average Age by City: Write a query to calculate the average age of
 customers in each City using the GROUP BY and AVG functions*/

 select City , Avg(Customer_Age)
 from Customer
 group by City;

 Alter table Customer Add Customer_Age Int;

 INSERT INTO Customer (Customer_Age) VALUES (25);
 Insert into Customer(City , Customer_Age) values 
 ('Delhi' , 25) ,  
 ('Aurangabad' , 42) ,
 ('Faridabad' , 26) , 
 ('Lucknow' , 45) ,
 ('Gurugram' , 32);