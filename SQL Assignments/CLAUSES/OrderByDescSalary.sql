-- 23.  Write an SQL query that returns the employees(nameonly) in  department ‘D1’ordered by decreasing salary--

select emp_name from Employee
where dept_id = 'D1'
Order by salary DESC;
