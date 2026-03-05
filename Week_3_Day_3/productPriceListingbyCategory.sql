
use EcommAppDb

--product price listing by categoty--
SELECT P.product_name, B.brand_name, C.category_name, P.model_year, P.list_price FROM brands B

--join between brands and products--
INNER JOIN products P
	ON B.brand_id=P.brand_id

--join between catogories and products--
INNER JOIN categories C
	ON C.category_id=P.category_id

WHERE list_price > 500
ORDER BY list_price ASC;
