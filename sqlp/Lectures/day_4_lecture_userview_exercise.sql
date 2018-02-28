/* Solution for SQL UserViews Lecture Exercise */


-------------- Question 1 --------------

--CREATE VIEW Customer1998 AS
--SELECT DISTINCT C.CustomerID, C.CompanyName, ODE.ProductID, ODE.ProductName, O.OrderDate
--FROM Customers C, Orders O, [Order Details Extended] ODE
--WHERE C.CustomerID = O.CustomerID AND O.OrderID = ODE.OrderID
--AND C.CustomerID IN (SELECT CustomerID FROM Orders WHERE YEAR(OrderDate) = 1998)

CREATE VIEW Customer1998 AS
SELECT DISTINCT C.CustomerID, C.CompanyName, ODE.ProductID, ODE.ProductName, O.OrderDate
FROM Customers C, Orders O, [Order Details Extended] ODE
WHERE C.CustomerID = O.CustomerID AND O.OrderID = ODE.OrderID
AND YEAR(O.OrderDate) = 1998

-------------- Question 2 --------------

SELECT DISTINCT C.CompanyName AS CustomerName, C.ProductName, S.CompanyName AS SupplierName
FROM Customer1998 C, Products P, Suppliers S
WHERE C.ProductID = P.ProductID AND P.SupplierID = S.SupplierID

-------------- Question 3 --------------

SELECT CompanyName, COUNT(*) AS ProductCount
FROM Customer1998
GROUP BY CompanyName

-------------- Question 4 --------------

-- Part A

CREATE VIEW TotalBusinessPerCustomer AS
SELECT O.CustomerID, SUM(OD.UnitPrice * OD.Quantity) AS Amount
FROM Orders O, [Order Details] OD
WHERE O.OrderID = OD.OrderID
GROUP BY O.CustomerID

-- Part B

SELECT SUM(Amount) / COUNT(*) AS AverageBusiness
FROM TotalBusinessPerCustomer