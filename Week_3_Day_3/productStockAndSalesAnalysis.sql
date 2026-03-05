
use EcommAppDb

--product stock and sales analysis--
SELECT P.product_name, S.store_name, SUM(ST.quantity) AS 'available_stock_quantity',
SUM(OI.quantity) AS 'total_quantity_sold' FROM products P

--join between products and stocks--
INNER JOIN stocks ST
    ON P.product_id = ST.product_id

--join between stores and stocks--
INNER JOIN stores S 
    ON ST.store_id = S.store_id

--join between order_items and products--
INNER JOIN order_items OI 
    ON P.product_id = OI.product_id

GROUP BY 
    P.product_name,
    S.store_name
ORDER BY 
    P.product_name;
