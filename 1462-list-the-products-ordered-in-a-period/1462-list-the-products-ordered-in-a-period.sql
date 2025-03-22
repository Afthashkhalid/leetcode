/* Write your T-SQL query statement below */
SELECT product_name, SUM(unit) AS unit
FROM Products P JOIN Orders O ON P.product_id = O.product_id
WHERE O.order_date like '2020-02%'
GROUP BY product_name
HAVING SUM(unit) >= 100