------------- Join with SubQuery -------------
-- 17. Retrieve all employees whose salary is greater than the average salary of their department.--

Alter table Employee Add constraint pk_Id Primary key(EmpId)

Select EmployeeName.Salary from EmpData
where salary > (Select avg(salary)
from EmpData groupBy DepartmentName)
