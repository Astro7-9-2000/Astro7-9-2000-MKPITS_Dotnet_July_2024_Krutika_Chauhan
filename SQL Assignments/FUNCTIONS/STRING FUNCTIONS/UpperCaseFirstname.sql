*
1.Select Customers with Uppercased First Names: Write a query to select the CustomerID and FirstName of all customers with their FirstName converted to
 uppercase using the UPPER function
*/

Select Id , UPPER(FirstName) AS UppercasedFirstName
FROM Customer
Where Upper(FirstName) = FirstName;