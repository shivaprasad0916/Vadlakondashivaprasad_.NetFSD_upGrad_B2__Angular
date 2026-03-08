
use EcommAppDb;

-- Customer Activity Classification--
SELECT c.first_name + ' ' + c.last_name AS Customer_Name,

    -- Total Order Value
    (SELECT SUM(oi.quantity * oi.list_price * (1 - oi.discount))
     FROM orders o
     JOIN order_items oi ON o.order_id = oi.order_id
     WHERE o.customer_id = c.customer_id) AS Total_Order_Value,

    -- Customer Classification
    CASE 
        WHEN (SELECT SUM(oi.quantity * oi.list_price * (1 - oi.discount))
              FROM orders o
              JOIN order_items oi ON o.order_id = oi.order_id
              WHERE o.customer_id = c.customer_id) > 10000 
        THEN 'Premium'

        WHEN (SELECT SUM(oi.quantity * oi.list_price * (1 - oi.discount))
              FROM orders o
              JOIN order_items oi ON o.order_id = oi.order_id
              WHERE o.customer_id = c.customer_id) BETWEEN 5000 AND 10000
        THEN 'Regular'

        ELSE 'Basic'
    END AS Customer_Type

FROM customers c
WHERE c.customer_id IN (SELECT customer_id FROM orders)

UNION

-- Customers without orders
SELECT 
    c.first_name + ' ' + c.last_name AS Customer_Name,
    0 AS Total_Order_Value,
    'No Orders' AS Customer_Type

FROM customers c
WHERE c.customer_id NOT IN (SELECT customer_id FROM orders);