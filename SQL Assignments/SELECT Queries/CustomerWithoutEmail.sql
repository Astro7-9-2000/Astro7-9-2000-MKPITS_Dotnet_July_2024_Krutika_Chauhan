/*
Select Customers without Email: Retrieve the CustomerID, FirstName, and PhoneNumber of all customers who do not have an Email address on file.
*/
Select Id , FirstName , Phone
from Customer where Email IS NUll;

