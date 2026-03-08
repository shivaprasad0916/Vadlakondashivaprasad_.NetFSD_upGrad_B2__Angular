
use EcommAppDb

--STEP:1 - Create a ArchiveTable--
CREATE TABLE archived_orders
(
    order_id INT,
    customer_id INT,
    order_status TINYINT,
    order_date DATE,
    required_date DATE,
    shipped_date DATE,
    store_id INT,
    staff_id INT
);

--STEP:2 - Insert Archive Orders (INSERT INTO SELECT)--
INSERT INTO archived_orders
SELECT *
FROM orders
WHERE order_status = 3
AND order_date < DATEADD(YEAR, -1, GETDATE());


--STEP:3 - Delete Archived Orders from Original Table--
DELETE FROM orders
WHERE order_status = 3
AND order_date < DATEADD(YEAR, -1, GETDATE());


--STEP:4 - Customer Whose All Orders Are Completed(Nested Query)--
SELECT customer_id, phone, city, state
FROM customers
WHERE customer_id NOT IN
(
    SELECT customer_id
    FROM orders
    WHERE order_status <> 4
);


--STEP:5 - Display  Order Processing Delay--
SELECT 
order_id,
order_date,
shipped_date,
DATEDIFF(DAY, order_date, shipped_date) AS processing_delay
FROM orders;


--STEP:6 - Mark Orders as Delayed or On Time--
SELECT 
order_id,
order_date,
required_date,
shipped_date,

CASE
WHEN shipped_date > required_date THEN 'Delayed'
ELSE 'On Time'
END AS delivery_status

FROM orders;
