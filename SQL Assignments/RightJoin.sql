------------ Left join --------------------
-- 10. Retrieve all employees along with their department names. Some employees might not have a department assigned. --
Select e.emp_name , d.dept_name
frpm employee e 
left join department d
on e.dept_id = d.dept_id;