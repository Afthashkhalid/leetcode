/* Write your T-SQL query statement below */
SELECT player_id, MIN(event_date) AS first_login
FROM Activity
Group By player_id