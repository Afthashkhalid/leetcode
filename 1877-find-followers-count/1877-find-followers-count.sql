/* Write your T-SQL query statement below */
Select user_id, count(user_id) as followers_count from Followers Group by user_id Order By user_id Asc;