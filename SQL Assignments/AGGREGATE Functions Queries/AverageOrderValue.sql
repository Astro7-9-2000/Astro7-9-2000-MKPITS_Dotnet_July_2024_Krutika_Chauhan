/*
 48. Find Average Order Value by Age Group: Write a query to calculate the average
 order value per age group using the AVG, GROUP BY, and CASE functions
*/

Select 
Case 
When Customer_Age < 25 Then 'Under 25' 
When Customer_Age BETWEEN 25 AND 34 Then '25-34'
When Customer_Age BETWEEN 35 AND 44 Then '35-44'
When Customer_Age BETWEEN 45 AND 54 Then '45-54'
ELSE '55 and Above'

END AS age_group ,
AVG(OrdersNumber) AS avg_order_value
from orders
JOIN Customer ON Orders.CustomerId = Customer.Id
GROUP BY
CASE 
When Customer_Age < 25 Then 'Under 25' 
When Customer_Age BETWEEN 25 AND 34 Then '25-34'
When Customer_Age BETWEEN 35 AND 44 Then '35-44'
When Customer_Age BETWEEN 45 AND 54 Then '45-54'
ELSE '55 and Above'
END;