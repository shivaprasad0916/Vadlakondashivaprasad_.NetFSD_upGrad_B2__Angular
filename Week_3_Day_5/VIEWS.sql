
--Creating View on Product Details--
CREATE VIEW view_product
AS
SELECT P.product_name, b.brand_name, c.category_name, p.model_year, p.list_price FROM products p
JOIN brands b
	ON 
	p.brand_id = b.brand_id
JOIN categories c
	ON 
	p.category_id = c.category_id

--Display the view data--
SELECT *FROM view_product


---------------order details----------------

--Creating View on Order Details--
CREATE VIEW view_order
AS
SELECT 
o.order_id, 
CONCAT(c.first_name,' ',c.last_name) AS 'customer_name', 
s.store_name, 
CONCAT(st.first_name,' ',st.last_name) AS 'staff_name',
o.order_date FROM orders o

JOIN customers c
	ON
	o.customer_id = c.customer_id

JOIN stores s
	ON
	o.store_id = s.store_id

JOIN staffs st
	ON
	o.store_id = st.store_id

SELECT * FROM view_order

