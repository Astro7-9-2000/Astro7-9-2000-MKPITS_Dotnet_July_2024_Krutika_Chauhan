/*
 9. Check Length of Customer Names: Write a query to select CustomerID, FirstName, and the length of FirstName using the LEN function.
*/

Select Id , FirstName , LEN(FirstName) AS FirstNameLength
from Customer;
