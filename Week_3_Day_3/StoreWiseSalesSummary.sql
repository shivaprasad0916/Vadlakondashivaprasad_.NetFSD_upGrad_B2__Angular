
use EcommAppDb

--Store wise sales summary--
SELECT S.store_name, SUM(OI.list_price * OI.quantity) AS 'TOTAL SALES' FROM stores S

--join between stores and orders--
INNER JOIN orders O
    ON S.store_id=O.store_id

--join between order_items and orders--
INNER JOIN order_items OI
    ON OI.order_id = O.order_id

WHERE O.order_status IN(1,4)
GROUP BY S.store_name
ORDER BY 'TOTAL SALES' DESC;

