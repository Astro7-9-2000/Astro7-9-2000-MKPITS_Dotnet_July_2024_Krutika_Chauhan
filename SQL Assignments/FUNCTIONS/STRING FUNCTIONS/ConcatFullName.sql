/*
 5. Concatenate Full Name: Write a query to concatenate FirstName and LastName into a single FullName field using the CONCAT function
*/

select  Id , CONCAT(FirstName , ' ' , LastName) AS FullName
From
Customer;