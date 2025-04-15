/* Write your T-SQL query statement below */
select distinct coalesce(max(salary), null) as SecondHighestSalary from Employee where salary < (select max(salary) from Employee)