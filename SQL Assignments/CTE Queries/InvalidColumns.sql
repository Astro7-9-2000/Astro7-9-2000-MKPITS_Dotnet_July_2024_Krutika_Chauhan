-- This CTE will throw error because the column names are invalid --

with New_CTE(std_id , std_name , std_class)      
/* The number of columns defined in the parenthesis should be equal to the number of columns inn the next select query. */
           
as
(
select id , name , [standard] from student where gender = 'Male'
)
select std_id , std_name from New_CTE