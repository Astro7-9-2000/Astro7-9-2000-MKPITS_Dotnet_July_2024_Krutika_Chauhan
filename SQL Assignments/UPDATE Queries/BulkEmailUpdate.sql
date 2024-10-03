
/*
 7. Bulk Update Customers' Email Domains: Write a query to update the Email domain
 (e.g., from @oldmail.com to @newmail.com) for all customers with a specific
 domain
*/

UPDATE Customer
SET Email = REPLACE(Email, '@gmail.com', '@RediffMail.com')
WHERE Email LIKE '%@gmail.com';