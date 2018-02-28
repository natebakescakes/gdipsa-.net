/* ------------------ USER VIEWS ------------------ */

-- Creating a UserView

CREATE VIEW Nov20TranView AS
SELECT TransactionID, CustomerID, VideoCode FROM IssueTran
WHERE DateIssue = '20 Nov 2000'

-- Querying a user view

SELECT * FROM Nov20TranView
WHERE VideoCode = 55

-- Creating a view does not provide any constraints

CREATE VIEW GoodCustomer AS
SELECT CustomerID, CustomerName, MemberCategory, CountryCode
FROM Customers
WHERE MemberCategory IN ('A', 'B');

-- Check out both tables

SELECT CustomerID, CustomerName, MemberCategory, CountryCode
FROM Customers WHERE CustomerID = 1001;
SELECT * FROM GoodCustomers WHERE CustomerID = 1001;

-- UPDATE will go through

UPDATE GoodCustomers
SET MemberCategory = 'C'
WHERE CustomerID = 1001

CREATE VIEW GoodCustomers AS
SELECT CustomerID, CustomerName, MemberCategory
FROM Customers
WHERE MemberCategory IN ('A', 'B')
WITH CHECK OPTION

/* ------------------ STORED PROCEDURES ------------------ */
-- NorthWind DB

CREATE PROCEDURE sp_test_1
AS
BEGIN
	SELECT * FROM Customers;
	SELECT * FROM Products;
END

-- Stored procedures pre-compile statements
-- As such, they will perform things like syntax checks

CREATE PROCEDURE sp_test_2
AS
BEGIN
	SELECT * FRO Customers;
	SELECT * FROM Products;
END

-- From Dafesty DB
-- Creating stored procedures with argument parameters

CREATE PROCEDURE MyProcedure (@var1 CHAR(2), @var2 INTEGER)
AS
	SELECT * FROM Movies
	WHERE Rating = @var1 AND TotalStock > @var2;

-- Executing stored procedures

Exec MyProcedure 'PG', 1