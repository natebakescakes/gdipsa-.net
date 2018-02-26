/* Solution for SQL Select Workshop */

-- Day 2 Homework: Question 17 to Question 36


-------------- Question 17 --------------

SELECT CustomerID, COUNT(*) AS OrderCount
FROM Orders
GROUP BY CustomerID

-------------- Question 18 --------------

SELECT C.CompanyName, O.OrderID
FROM Customers C, Orders O 
WHERE C.CustomerID = O.CustomerID AND C.CustomerID = 'BONAP'

-------------- Question 19 --------------

-- Part A

SELECT C.CustomerID, C.CompanyName, COUNT(*) AS OrderCount
FROM Customers C, Orders O
WHERE C.CustomerID = O.CustomerID
GROUP BY C.CustomerID, C.CompanyName
HAVING COUNT(*) > 10
ORDER BY COUNT(*) DESC

-- Part B

SELECT C.CustomerID, C.CompanyName, COUNT(*) AS OrderCount
FROM Customers C, Orders O
WHERE C.CustomerID = O.CustomerID AND C.CustomerID = 'BONAP'
GROUP BY C.CustomerID, C.CompanyName

-- Part C

SELECT C.CustomerID, C.CompanyName, COUNT(*) AS OrderCount
FROM Customers C, Orders O
WHERE C.CustomerID = O.CustomerID
GROUP BY C.CustomerID, C.CompanyName
HAVING COUNT(*) > 
	(SELECT COUNT(*) FROM Orders 
	WHERE Orders.CustomerID = 'BONAP')

-------------- Question 20 --------------

-- Part A

SELECT * FROM Products
WHERE CategoryID IN (1, 2)
ORDER BY ProductID, ProductName ASC

-- Part B
-- Both are fine, but since you only need to display from one table, subqueries should be more appropriate

-- Using Subqueries
SELECT * FROM Products
WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE CategoryName IN ('Beverages', 'Condiments'))
ORDER BY ProductID, ProductName ASC

-- Using JOIN
SELECT P.* FROM Products P, Categories C
WHERE P.CategoryID = C.CategoryID AND C.CategoryName IN ('Beverages', 'Condiments')	
ORDER BY ProductID, ProductName ASC

-------------- Question 21 --------------

-- Part A

SELECT COUNT(*) AS NoOfEmployees
FROM Employees

-- Part B

SELECT COUNT(*) AS NoOfEmployeesInUSA
FROM Employees
WHERE Country = 'USA'

-------------- Question 22 --------------

-- Using Subqueries

SELECT * FROM Orders
WHERE EmployeeID IN	(SELECT EmployeeID FROM Employees WHERE TITLE = 'Sales Representative')
AND ShipVia = (SELECT ShipperID FROM Shippers WHERE CompanyName = 'United Package')

-- Using JOIN

SELECT * FROM Orders O, Employees E, Shippers S
WHERE O.EmployeeID = E.EmployeeID AND O.ShipVia = S.ShipperID
AND E.Title = 'Sales Representative' AND S.CompanyName = 'United Package'

-------------- Question 23 --------------

SELECT E.FirstName, E.LastName, M.FirstName AS ManagerFirstName, M.LastName AS ManagerLastName
FROM Employees E, Employees M
WHERE E.ReportsTo = M.EmployeeID

-------------- Question 24 --------------

SELECT TOP 5 P.ProductID, P.ProductName, SUM(OD.Discount * OD.UnitPrice * OD.Quantity) AS TotalDiscount
FROM Products P, [Order Details] OD
WHERE P.ProductID = OD.ProductID
GROUP BY P.ProductID, P.ProductName
ORDER BY TotalDiscount DESC

-------------- Question 25 --------------

SELECT CompanyName FROM Customers
WHERE City NOT IN (SELECT DISTINCT City FROM Suppliers)

-------------- Question 26 --------------

SELECT C.City FROM Customers C, Suppliers S
WHERE C.City = S.City

-------------- Question 27 --------------

-- Part A

SELECT C.CompanyName, C.Address, C.Phone
FROM (SELECT CompanyName, Address, Phone FROM Customers) AS C
UNION (SELECT CompanyName, Address, Phone FROM Suppliers)

-- Part B

SELECT C.CompanyName, C.Address, C.Phone
FROM (SELECT CompanyName, Address, Phone FROM Customers) AS C
UNION (SELECT CompanyName, Address, Phone FROM Suppliers)
UNION (SELECT CompanyName, NULL, Phone FROM Shippers)

-------------- Question 28 --------------

SELECT M.FirstName, M.LastName FROM Employees E, Orders O, Employees M
WHERE E.EmployeeID = O.EmployeeID AND E.ReportsTo = M.EmployeeID AND O.OrderID = 10248

-------------- Question 29 --------------

SELECT ProductID, ProductName, UnitPrice FROM Products
WHERE UnitPrice > (SELECT AVG(UnitPrice) FROM Products)

-------------- Question 30 --------------

SELECT OrderID, (UnitPrice * Quantity) AS Amount 
FROM [Order Details]
WHERE (UnitPrice * Quantity) > 10000

-------------- Question 31 --------------

SELECT O.CustomerID, O.OrderID
FROM Orders O, [Order Details] OD
WHERE OD.OrderID = O.OrderID
AND (OD.Quantity * OD.UnitPrice) > 10000

-------------- Question 32 --------------

SELECT C.CompanyName, O.CustomerID, O.OrderID
FROM Customers C, Orders O, [Order Details] OD
WHERE C.CustomerID = O.CustomerID AND O.OrderID = OD.OrderID
AND (OD.Quantity * OD.UnitPrice) > 10000

-------------- Question 33 --------------

SELECT O.CustomerID, SUM(OD.UnitPrice * OD.Quantity) AS Amount
FROM Orders O, [Order Details] OD
WHERE O.OrderID = OD.OrderID
GROUP BY O.CustomerID

-------------- Question 34 --------------

SELECT
	(SELECT SUM(OD.UnitPrice * OD.Quantity) AS Amount
	FROM Orders O, [Order Details] OD
	WHERE O.OrderID = OD.OrderID) / 
	(SELECT COUNT(DISTINCT CustomerID) FROM Orders) AS AverageBusiness

-------------- Question 35 --------------

SELECT O.CustomerID, C.CompanyName, SUM(OD.UnitPrice * OD.Quantity) AS Amount
FROM Customers C, Orders O, [Order Details] OD
WHERE O.OrderID = OD.OrderID AND O.CustomerID = C.CustomerID
GROUP BY O.CustomerID, C.CompanyName
HAVING SUM(OD.UnitPrice * OD.Quantity) >
	(SELECT SUM(OD.UnitPrice * OD.Quantity) AS Amount
	FROM Orders O, [Order Details] OD
	WHERE O.OrderID = OD.OrderID) / 
	(SELECT COUNT(DISTINCT CustomerID) FROM Orders)

-------------- Question 36 --------------

SELECT O.CustomerID, SUM(OD.Quantity * OD.UnitPrice) AS Amount
FROM Orders O, [Order Details] OD
WHERE O.OrderID = OD.OrderID
AND YEAR(O.OrderDate) = 1997
GROUP BY O.CustomerID