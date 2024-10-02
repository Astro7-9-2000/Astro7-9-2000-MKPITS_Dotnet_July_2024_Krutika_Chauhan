
/*
 4. Insert Customer with a Unique Email Constraint: Attempt to insert a new customer
 into the database, ensuring that the Email field is unique across all records. If the
 email already exists, the insertion should fail.
*/

Create Unique Index UX_Customer_Email ON Customer (Email);

Select Email , COUNT(*) AS DuplicateCount 
from Customer
GROUP BY Email
Having COUNT(*) > 1;