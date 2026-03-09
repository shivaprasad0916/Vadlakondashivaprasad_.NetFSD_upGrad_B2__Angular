--Indexes on order_items table--
CREATE INDEX idx_product_id
ON order_items(product_id);

SELECT p.product_id, p.product_name, o.quantity FROM products p
JOIN order_items o
ON p.product_id = o.product_id
WHERE p.product_id=2;

--Indexes on orders table--
CREATE INDEX idx_order_store_id
ON orders(store_id);

SELECT s.store_id,o.order_id, o.order_date, s.store_name, s.phone, s.city FROM orders o
JOIN stores s
ON o.store_id = s.store_id
WHERE s.store_id IN(1,2);

CREATE INDEX idx_orders_staff_id
ON orders(staff_id);

SELECT st.staff_id, o.order_id, o.order_date, CONCAT(st.first_name,' ',st.last_name) AS 'staff_name', st.email FROM orders o
JOIN staffs st
ON o.staff_id = st.staff_id
WHERE st.staff_id IN(1,2);


--Indexes on Products table--
CREATE INDEX idx_product_id_brand_id 
ON products(brand_id);

SELECT p.product_id, p.product_name, b.brand_name FROM products p
JOIN brands b
ON p.brand_id = b.brand_id
WHERE b.brand_name = 'Haro';

CREATE INDEX idx_product_id_category_id
ON products(category_id);

SELECT p.product_id, p.product_name, c.category_name FROM products p
JOIN categories c
ON p.category_id = c.category_id
WHERE c.category_name = 'Mountain Bikes';

--To find Existing Indexes on products table--
EXEC sp_helpindex 'products';

--To find Existing Indexes on orders table--
EXEC sp_helpindex 'order_items';

--To find Existing Indexes on order_items table--
EXEC sp_helpindex 'brands';

--IN MICROSOFT SQL SERVER, TO FIND THE EXISTING INDEXES ON A TABLES, WE USE sp_helpindex STORED PROCEDURE.--