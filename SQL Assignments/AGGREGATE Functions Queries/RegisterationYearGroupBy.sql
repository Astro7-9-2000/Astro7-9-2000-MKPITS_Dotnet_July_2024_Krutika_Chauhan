/*
 46. Select Customers Grouped by Registration Year: Group customers by the year
 they registered and count the number of customers in each group using the GROUP
 BY and YEAR functions
*/

Alter Table Customer 
Add registeration_Date Date

INSERT INTO Customer (registeration_Date)
VALUES ('2020-10-12'),
       ('2020-11-05'),
       ('2021-09-09');
SELECT year (registeration_date) As registeration_year , COUNT(*) AS number_customers
from Customer
Group BY Year(registeration_date)
order by registeration_year;

