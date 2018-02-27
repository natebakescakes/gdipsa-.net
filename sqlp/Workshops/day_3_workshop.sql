/* Solution for SQL DDL/DML Workshop */

-- Day 3 Homework: Question 1 to Question 20


-------------- Question 1 --------------

CREATE TABLE MemberCategories
(MemberCategory			nvarchar(2)		NOT NULL,
MemberCatDescription	nvarchar(200)	NOT NULL,
PRIMARY KEY (MemberCategory))

-------------- Question 2 --------------

INSERT INTO MemberCategories
VALUES 
	('A', 'Class A Members'),
	('B', 'Class B Members'),
	('C', 'Class C Members')

-------------- Question 3 --------------

CREATE TABLE GoodCustomers
(CustomerName nvarchar(50),
Address nvarchar(65),
PhoneNumber nvarchar(9),
MemberCategory nvarchar(2),
PRIMARY KEY (CustomerName, PhoneNumber),
CONSTRAINT MemberCategory_FK_01 FOREIGN KEY (MemberCategory) REFERENCES MemberCategories (MemberCategory))

-------------- Question 4 --------------

INSERT INTO GoodCustomers
(CustomerName, Address, PhoneNumber, MemberCategory)
SELECT CustomerName, NULL, PhoneNumber, MemberCategory
FROM Customers
WHERE MemberCategory IN ('A', 'B')

-------------- Question 5 --------------

INSERT INTO GoodCustomers
(CustomerName, PhoneNumber, MemberCategory)
VALUES ('Tracy Tan', '736572', 'B')

-------------- Question 6 --------------

INSERT INTO GoodCustomers
VALUES ('Grace Leong', '15 Bukit Permei Road, Singapore 0904', '278865', 'A')

-------------- Question 7 --------------

-- Should fail, referential integrity violation
INSERT INTO GoodCustomers
VALUES ('Lynn Lim', '15 Bukit Permei Road, Singapore 0904', '278865', 'P')

-------------- Question 8 --------------

UPDATE GoodCustomers
SET Address = '22 Bukit Permei Road, Singapore 0904'
WHERE CustomerName = 'Grace Leong'

-------------- Question 9 --------------

UPDATE GoodCustomers
SET MemberCategory = 'B'
WHERE CustomerName = 
	(SELECT CustomerName FROM Customers
	WHERE CustomerID = 5108)

-------------- Question 10 --------------

DELETE FROM GoodCustomers
WHERE CustomerName = 'Grace Leong'

-------------- Question 11 --------------

DELETE FROM GoodCustomers
WHERE MemberCategory = 'B'

-------------- Question 12 --------------

ALTER TABLE GoodCustomers
ADD FaxNumber nvarchar(25)

-------------- Question 13 --------------

ALTER TABLE GoodCustomers
ALTER COLUMN Address nvarchar(80)

-------------- Question 14 --------------

ALTER TABLE GoodCustomers
ADD ICNumber nvarchar(10)

-------------- Question 15 --------------

-- Error due to duplicate NULL values
CREATE UNIQUE INDEX IK_ICNumber
ON GoodCustomers(ICNumber)

-------------- Question 16 --------------

CREATE INDEX IX_FaxNumber
ON GoodCustomers(FaxNumber)

-------------- Question 17 --------------

DROP INDEX IX_FaxNumber ON GoodCustomers

-------------- Question 18 --------------

ALTER TABLE GoodCustomers
DROP COLUMN FaxNumber

-------------- Question 19 --------------

DELETE FROM GoodCustomers

-------------- Question 20 --------------

DROP TABLE GoodCustomers