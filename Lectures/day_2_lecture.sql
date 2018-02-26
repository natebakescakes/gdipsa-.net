-- Inner Join Example

SELECT Customers.CustomerID, Orders.OrderID -- [TableName].* can also be done
FROM Customers, Orders
WHERE Customers.CustomerID = Orders.CustomerID

SELECT C.CustomerID, O.OrderID
FROM Customers C
INNER JOIN Orders O
ON C.CustomerID = O.CustomerID

-- Join if you want to display columns from multiple tables
-- Always include the WHERE clause when joining
-- By default, the commas will join via INNER JOIN keyword

-- Left Outer Join Example

SELECT C.CompanyName, C.CustomerID, O.OrderID
FROM Customers C
LEFT OUTER JOIN Orders O -- For MSSQLServer, OUTER keyword can be left out
ON C.CustomerID = O.CustomerID

-- Self Join Example

SELECT Staff.FirstName AS Staff, Mgr.FirstName AS Manager
FROM Employees Staff, Employees Mgr
WHERE Staff.ReportsTo = Mgr.EmployeeID

-- Can also use LEFT OUTER JOIN keyword

-- Group By Example using Dafesty DB

SELECT MemberCategory
FROM Customers
GROUP BY MemberCategory

-- HAVING Example
-- Conditions for Aggregate Function columns

SELECT CountryCode, COUNT(*) AS CustomerCount
FROM Customers
GROUP BY CountryCode
HAVING COUNT(*) > 1

-- HAVING is used together with GROUP BY in sequence, applying to the GROUP BY columns
-- WHERE simply applies to all rows

SELECT CountryCode, MemberCategory, COUNT(*) AS CustomerCount
FROM Customers
WHERE CountryCode = 'SIN'
GROUP BY CountryCode, MemberCategory -- Multiple GROUP BY will subcategorise the groups
HAVING COUNT(*) > 5

-- Subquerying in HAVING statement

SELECT CountryCode, COUNT(*) AS CustomerCount
FROM Customers
GROUP BY CountryCode
HAVING COUNT(*) >
	(SELECT COUNT(*) FROM Customers
	WHERE CountryCode = 'BRA') -- DB engine will process statements in parenthesis first

-- In this case, the subquery will equate to 1, thus COUNT(*) > 1

-- UNION Examples
-- Tables that are being performed on must have identical columns

-- TOP Keyword for MSSQLServer

SELECT TOP 2 CountryCode, MemberCategory, COUNT(*) AS CustomerCount
FROM Customers
WHERE Customers.CountryCode = 'SIN'
GROUP BY CountryCode, MemberCategory