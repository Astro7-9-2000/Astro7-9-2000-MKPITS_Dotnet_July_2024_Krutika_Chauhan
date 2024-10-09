--- CTE in SQL SERVER ---

/*
1. CTE Stands for Common Table Expressions.
2. CTE is introduced in SQL Server 2005.
3. A CTE allows you to define a temporary result set , that can be linked immediately with 
   the select , insert , update or delete statement.
4. CTE is a similar to a temporary resultSet defined within the execution scope of a single
   SELECT , INSERT , UPDATE , DELETE or CREATE VIEW statement.
5. The CTE can also be used in a view.
6. A CTE is defined at the start of a query and can be referenced several times in the outer query.
7. Key advantages of CTEs are - Improved readability and ease in maintainance of complex queries.
8. A single CTE can be referenced multiple times in the same query with 1 defination.
9. It is possible to use inline or external aliases for columns in CTEs.
*/


/*
WITH expression_name (column1 , column2 , ....)
AS
(
CTE_defination
)

*/

Create table Student (Id int primary key Identity(1,1) , Name varchar(50) , Gender varchar(50) , Age int , Standard int);

Insert into Student values ('Aarav' , 'Male' , 18 , 11);
Insert into Student values ('Dev' , 'Male' , 16 , 11);
Insert into Student values ('Kanishka' , 'Female' , 19 , 10);
Insert into Student values ('Kareena' , 'female' , 15 , 9);
Insert into Student values ('Ashutosh' , 'Male' , 16 , 12);
Insert into Student values ('Kapil' , 'Male' , 21 , 11);
Insert into Student values ('Ishika' , 'Female' , 20 , 7);
Insert into Student values ('Awais' , 'Male' , 18 , 7);
Insert into Student values ('Elon' , 'Male' , 17 , 12);
Insert into Student values ('Brat' , 'Male' , 19 , 10);
Insert into Student values ('John' , 'Male' , 21 , 8);
Insert into Student values ('Rani' , 'Female' , 14 , 7);
Insert into Student values ('Prakash' , 'Male' , 11 , 7);
delete from Student where Id = 13;

Select * from Student;
