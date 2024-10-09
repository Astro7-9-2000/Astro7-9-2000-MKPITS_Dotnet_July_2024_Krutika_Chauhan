with New_CTE
as
(
select * from student where gender = 'Male'
)
select 'Hello World'                     -- This line will destroy the CTE since it is not used --
select * from New_CTE where age >= 17