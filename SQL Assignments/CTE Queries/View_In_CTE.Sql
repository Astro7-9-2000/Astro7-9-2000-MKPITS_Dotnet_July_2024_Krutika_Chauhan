create view MyNewView
as
with New_CTE
as
(
select * from student where [standard] = 12
)
select * from New_CTE

select * from MyNewView

/*
CTE exists in memory only while the query is running. After the query is run , the CTE is discarded; 
it cannot be used for the next SQL query unless we define it again. Still , the same CTE might be 
referenced several times in the main query and any subqueries.

A view is a stored SQL query that is executed each time you reference it in another query.
Note that a view doesn,t store the output of a particular query - It stores the query itself.
*/

-- CTE,s are limited in scope to the execution of the outer query. Hence when the outer query ends , the lifetime of the CTE will end. --
/*
A view is a physical object in a database unlike a CTE and is stored on the disk.
Views store the query only , not the data returned by the query. 
The data is computed each time you reference the view in your query.
*/