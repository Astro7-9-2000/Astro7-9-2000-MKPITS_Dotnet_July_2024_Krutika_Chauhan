with New_CTE
as
(
select * from student where gender = 'Male'
)
select count(*) from New_CTE             -- Returns the count of Male students --
