/*
2.Select Customers with Lowercased Email Domains: Retrieve the CustomerID and the lowercased Email domain (portion after '@') using the LOWER and
 SUBSTRING functions.
*/

SELECT Id, LOWER(SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(Email))) AS LowercasedEmailDomain
FROM Customer;