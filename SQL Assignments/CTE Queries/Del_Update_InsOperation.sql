with New_CTE
as
(
select * from student 
)
delete New_CTE where id = 10
update New_CTE  set Name = 'Akash' where Id = 11
insert New_CTE values('Sakshi' , 'Female' , 15 , 9)