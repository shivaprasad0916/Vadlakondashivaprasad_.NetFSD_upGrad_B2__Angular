
use EcommAppDb

--product analysis using nested queries--
SELECT CONCAT(product_name,'(',model_year,')' ) AS product_details, product_name, model_year, list_price -(
    SELECT AVG(list_price) FROM products P2
    WHERE P2.category_id = P1.category_id) 
AS price_difference FROM products P1

WHERE list_price > (
    SELECT AVG(list_price) FROM products P2
    WHERE P2.category_id = p1.category_id
    )
ORDER BY product_name;