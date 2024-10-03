/*
8. Update Customer Record with New Timestamp: Modify a customer’s record to
 include a LastUpdated timestamp with the current date and time whenever any
 field is updated.
*/

CREATE TRIGGER update_customer_lastupdated
on Customer
after UPDATE
as
begin
    UPDATE Customer
    set LastUpdated = GETDATE()
    where Id = (select Id from inserted);
End;

Update Customer Set City = 'Tokyo' where Id = 1;
