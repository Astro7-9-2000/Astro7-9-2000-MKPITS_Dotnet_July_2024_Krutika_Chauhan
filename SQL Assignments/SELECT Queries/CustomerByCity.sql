/*
Select Customers by City: Retrieve the CustomerID, FirstName, LastName, and
 Email of all customers who live in a specific City
*/

SELECT Id, FirstName, LastName, Email
FROM Customer
WHERE City = 'Tokyo';