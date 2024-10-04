/*
Select Customers by Partial Name Match: Retrieve customer details where the
 FirstName or LastName contains a specific substring (e.g., "John" in "Johnson")
*/

Select * 
from Customer where FirstName LIKE '%John%' OR LastName LIKE '%Chauhan%';
