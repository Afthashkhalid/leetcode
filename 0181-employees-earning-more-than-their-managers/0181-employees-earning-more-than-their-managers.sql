/* Write your T-SQL query statement below */
SELECT e.name AS Employee FROM Employee e INNER JOIN Employee m ON e.managerId = m.Id WHERE e.salary > m.salary