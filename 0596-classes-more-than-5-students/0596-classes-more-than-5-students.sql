/* Write your T-SQL query statement below */
SELECT class FROM Courses Group By class HAVING Count(student) >= 5;