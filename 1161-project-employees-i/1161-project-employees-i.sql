/* Write your T-SQL query statement below */
SELECT p.project_id, CAST(ROUND(AVG(CAST(e.experience_years AS DECIMAL(10, 4))), 2) AS DECIMAL(10, 2)) AS average_years
 FROM Project AS p JOIN Employee AS e 
 ON e.employee_id = p.employee_id
 GROUP BY p.project_id;
