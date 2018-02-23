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