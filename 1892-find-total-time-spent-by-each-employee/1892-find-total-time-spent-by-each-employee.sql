/* Write your T-SQL query statement below */
SELECT event_day AS [day], emp_id, SUM(out_time - in_time) AS total_time FROM
(SELECT DISTINCT emp_id, event_day, in_time, out_time FROM Employees) AS DistinctEntries
GROUP BY emp_id, event_day ORDER BY event_day, emp_id;