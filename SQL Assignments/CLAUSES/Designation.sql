Alter table Employee Add Hours_Worked Decimal(18,2);
Alter table Employee Add Designation varchar(20);

Insert into Employee (Hours_Worked) values (9);
Insert into Employee (Hours_Worked) values (10);
Insert into Employee (Hours_Worked) values (6.4);
Insert into Employee (Hours_Worked) values (7.6);
Insert into Employee (Hours_Worked) values (10);
Insert into Employee (Hours_Worked) values (12);

Insert into Employee (Designation) values ('Manager');
Insert into Employee (Designation) values ('Clerk');
Insert into Employee (Designation) values ('Developer');
Insert into Employee (Designation) values ('Manager');
Insert into Employee (Designation) values ('Tester');

/* 21.Write an SQL query that returns all works on records where hours worked is less than 10 and the responsibility is ‘Manager’*/

Select * from Employee 
Where Hours_Worked < 10
AND Designation = 'Manager';
