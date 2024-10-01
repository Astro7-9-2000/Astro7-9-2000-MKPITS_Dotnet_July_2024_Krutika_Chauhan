---------- Self join ---------------
 -- 13. Retrieve all employees and their managers. Assume that each employee has a manager specified by the 'managaer id' column --

 Select e1.emp_name , e2.emp_name AS manager_name
 from employee e1
 Join employee e2
 On e1.manager_id = e2.emp_id;