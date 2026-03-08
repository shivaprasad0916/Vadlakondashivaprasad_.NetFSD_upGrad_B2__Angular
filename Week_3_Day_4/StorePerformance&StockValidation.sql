


use EcommAppDb

--STORE PERFORMANCE AND STOCK VALIDATION--

--STORE Performance (Using EXCEPT and Nested Query--
SELECT 
    st.store_name,
    pr.product_name,
    SUM(oi.quantity) AS total_quantity_sold,
    SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_revenue
FROM orders o
JOIN order_items oi 
    ON o.order_id = oi.order_id
JOIN stores st 
    ON o.store_id = st.store_id
JOIN products pr 
    ON oi.product_id = pr.product_id
JOIN
(
    SELECT o.store_id, oi.product_id
    FROM orders o
    JOIN order_items oi 
        ON o.order_id = oi.order_id

    EXCEPT

    SELECT store_id, product_id
    FROM stocks
    WHERE quantity > 0
) AS out_of_stock
ON o.store_id = out_of_stock.store_id
AND oi.product_id = out_of_stock.product_id

GROUP BY st.store_name, pr.product_name;




--Query Usig INTERSECT (Validate Sold Products Exist in Stock Table)--
SELECT store_id, product_id
FROM
(
    SELECT o.store_id, oi.product_id
    FROM orders o
    JOIN order_items oi 
        ON o.order_id = oi.order_id
) AS SoldProducts

INTERSECT

SELECT store_id, product_id
FROM stocks;




--Update Query (Simulation for Discontinued Products)--
UPDATE stocks
SET quantity = 0
WHERE product_id IN
(
    SELECT product_id
    FROM products
    WHERE model_year < 2017
);



--Revenue Calculation Formula USED--
Revenue = quantity * list_price * (1 - discount)


