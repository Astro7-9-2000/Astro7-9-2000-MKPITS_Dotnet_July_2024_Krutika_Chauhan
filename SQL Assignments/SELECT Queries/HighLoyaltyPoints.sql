/*
Select Customers with High Loyalty Points: Retrieve the details of all customers whose
LoyaltyPoints exceed a certain threshold.
*/

Insert into Customer (FirstName , LastName , City , Country , Phone , Customer_Address , Email , Customer_State , Zipcode , Street , LoyaltyPoints) values 
('Shilpa', 'Shetty', 'Mumbai', 'India', '9147526385', 'Bandra', 'ShilpaShettyK@gmail.com', 'Maharashtra', '447185', 'Chapel Road', 700) ,
('Kunal', 'kapoor', 'Andheri', 'India', '5551234567', '303, Lokhandwala Complex', 'kunalkapoor@gmail.com', 'Maharashtra', '400053', 'Lokhandwala Road', 1300),
('Alka', 'Mehra', 'Juhu', 'India', '4567890123', '505, Juhu Tara Road', 'AlkaMehra54@gmail.com', 'Maharashtra', '408574', 'Juhu Tara Road', 500);


SELECT *
FROM Customer
WHERE LoyaltyPoints > 1000;

