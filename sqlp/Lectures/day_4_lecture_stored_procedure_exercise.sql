/* Solution for SQL Stored Procedure Lecture Exercise */


-------------- Question 1 --------------

CREATE PROCEDURE ACategoryCustomers AS
SELECT * FROM Customers WHERE MemberCategory = 'A'

EXEC ACategoryCustomers

-------------- Question 2 --------------

CREATE PROCEDURE CategoryCustomers (@var1 CHAR(1)) AS
SELECT * FROM Customers
WHERE MemberCategory = @var1

EXEC CategoryCustomers 'B'