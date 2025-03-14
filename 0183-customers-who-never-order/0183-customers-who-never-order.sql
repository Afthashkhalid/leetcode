/* Write your T-SQL query statement below */
SELECT name AS Customers FROM Customers WHERE Customers.id NOT IN (SELECT CustomerId FROM Orders);
