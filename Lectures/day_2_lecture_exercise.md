# Day 2 Lecture Exercises

## Question 1
*SELECT o.custId FROM orders o  
GROUP BY custId*

CustId |
:---: |
c1 |
c2 |
c4 |
<br>

---

## Question 2
*SELECT o.custId, count(\*), count(o.orderId)  
FROM orders o GROUP BY custId*

CustId | COUNT(*) | COUNT(o.OrderId)
:---: | :---: | :---: |
c1 | 2 | 2 |
c2 | 1 | 1 |
c4 | 1 | 1 |
<br>

---

## Question 3
*SELECT o.custId, o.orderId FROM orders o  
GROUP BY custId*

**Compilation Error**
<br>
<br>

---

## Question 4
*SELECT o.custid, o.orderid FROM orders o  
GROUP BY custId, orderId*

CustId | OrderId |
:---: | :---: |
c1 | x1
c1 | x3
c2 | x2
c4 | x4
<br>

---

## Question 5
*SELECT c.custid, o.orderid FROM customers c, orders o 
WHERE c.custId = o.custId*

CustId | OrderId
:---: | :---: 
c1 | x1
c1 | x2
c2 | x3
<br>

---

## Question 6
*SELECT c.custid, c.phoneNo, o.orderid FROM customers c, orders o  
WHERE c.custId = o.custId*

CustId | PhoneNo | OrderId
:---: | :---: | :---:
c1 | 4831 | x1
c1 | 4831 | x2
c2 | 4832 | x3
<br>

---

## Question 7
*SELECT c.custId, o.orderId, od.productId FROM customers c, orders o,  
[order details] od WHERE c.custId = o.custId AND o.orderId = od.orderId*

CustId | OrderId | ProductId
:---: | :---: | :---:
c1 | x1 | p1
c1 | x1 | p2
c1 | x2 | p3
<br>

---

## Question 8
*SELECT c.custid, count(\*) FROM customers c, orders o  
WHERE c.custId = o.custId GROUP BY c.custId*

 CustId | Count(*)
 :---: | :---:
 c1 | 2
 c2 | 1
 <br>

---

 ## Question 9

*SELECT c.custid, count(\*) FROM customers c, orders o  
WHERE c.custId = o.custId GROUP BY c.custId HAVING count(\*) > 1*

CustId | Count(*)
:---: | :---:
c1 | 2
<br>

---

## Question 10

*SELECT c.custid, o.orderId, count(\*) FROM customers c, orders o  
WHERE c.custId = o.custId GROUP BY c.custId, o.orderId*

CustId | OrderId | Count(*)
:---: | :---: | :---:
c1 | x1 | 1
c1 | x2 | 1
c2 | x3 | 1
<br>

---

## Question 11
*SELECT c.custid, o.orderId, count(\*) FROM customers c, orders o  
WHERE c.custId = o.custId having count(\*) > 1*

**Compilation Error**
<br>
<br>

---

## Question 12

*SELECT c.custid, o.orderId FROM customers c  
LEFT OUTER JOIN orders o ON c.custId = o.custId*

CustId | OrderId
:---: | :---:
c1 | x1
c1 | x2
c2 | x3
c3 | *null*