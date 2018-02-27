/* Solution for SQL Select Workshop */

-- Day 1 Homework: Question 1 to Question 16


-------------- Question 1 --------------

-- Part A
SELECT * FROM Shippers;

-- Part B
SELECT * FROM Shippers ORDER BY CompanyName ASC;

-------------- Question 2 --------------

-- Part A
SELECT FirstName, LastName, Title, BirthDate, City FROM Employees;

-- Part B
SELECT DISTINCT Title FROM Employees;

-------------- Question 3 --------------

/* Clarified with lecturer that there is no need to
retrieve from OrderDetails table */

SELECT * FROM Orders
WHERE OrderDate = '2017-05-19'

-------------- Question 4 --------------

SELECT * FROM Customers
WHERE City IN ('London', 'Madrid')

-------------- Question 5 --------------

SELECT CustomerID, CompanyName FROM Customers
WHERE Country = 'UK'
ORDER BY CompanyName ASC

-------------- Question 6 --------------

SELECT OrderID, OrderDate FROM Orders
WHERE CustomerID = 'Hanar'

-------------- Question 7 --------------

-- Part A

SELECT TitleOfCourtesy + ' ' + FirstName + ' ' + LastName AS QualifiedNames
FROM Employees

-- Part B

SELECT TitleOfCourtesy + ' ' + FirstName + ' ' + LastName AS QualifiedNames
FROM Employees
ORDER BY LastName ASC

-------------- Question 8 --------------

SELECT OrderID, OrderDate FROM Orders
WHERE CustomerID IN 
	(SELECT CustomerID FROM Customers
	WHERE CompanyName = 'Maison Dewey')

-------------- Question 9 --------------

SELECT * FROM Products
WHERE ProductName LIKE '%lager%'

-------------- Question 10 -------------

SELECT CustomerID, ContactName FROM Customers
WHERE CustomerID NOT IN 
	(SELECT DISTINCT CustomerID FROM Orders)

-------------- Question 11 -------------

SELECT AVG(UnitPrice) AS AveragePrice FROM Products

-------------- Question 12 -------------

SELECT DISTINCT City FROM Customers
WHERE City IS NOT NULL

-------------- Question 13 -------------

SELECT COUNT(DISTINCT CustomerID) AS NoOfOrderingCustomers FROM Orders

-------------- Question 14 -------------

SELECT CompanyName, Phone FROM Customers
WHERE Fax IS NULL

-------------- Question 15 -------------

SELECT SUM(UnitPrice * Quantity) AS TotalSales FROM Invoices

-------------- Question 16 -------------

SELECT OrderID FROM Orders
WHERE CustomerID IN 
	(SELECT CustomerID FROM Customers
	WHERE CompanyName IN ('Alan Out', 'Blone Coy'))