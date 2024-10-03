/*
 1. Update Customer Email Address: Write a query to update the Email address of a
 customer based on their CustomerID
*/
select * from Customer
Alter Table Customer 
--Add lastUpdated Date
Add PreferredContactMethod char(20)
Add LoyaltyPoints int
Update Customer set Email = 'sandy21@yahoo.com' where Id = 96; 

