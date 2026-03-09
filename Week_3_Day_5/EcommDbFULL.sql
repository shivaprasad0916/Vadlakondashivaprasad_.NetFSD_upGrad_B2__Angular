
--Creation of DATABASE EcommDb--
CREATE DATABASE EcommDb;
GO

USE EcommDb;
.
--Creation of Tables--
CREATE TABLE categories(
category_id INT PRIMARY KEY,
category_name VARCHAR(255) NOT NULL
);

CREATE TABLE brands(
brand_id INT PRIMARY KEY,
brand_name VARCHAR(255) NOT NULL
);

CREATE TABLE products(
product_id INT PRIMARY KEY,
product_name VARCHAR(255) NOT NULL,
brand_id INT NOT NULL,
category_id INT NOT NULL,
model_year SMALLINT NOT NULL,
list_price DECIMAL(10,2) NOT NULL,

FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
FOREIGN KEY (category_id) REFERENCES categories(category_id)
);


CREATE TABLE customers(
customer_id INT PRIMARY KEY,
first_name VARCHAR(255) NOT NULL,
last_name VARCHAR(255) NOT NULL,
phone VARCHAR(25),
email VARCHAR(255) NOT NULL,
street VARCHAR(255),
city VARCHAR(50),
state VARCHAR(25),
zip_code VARCHAR(5)
);


CREATE TABLE stores(
store_id INT PRIMARY KEY,
store_name VARCHAR(255) NOT NULL,
phone VARCHAR(25),
email VARCHAR(255),
street VARCHAR(255),
city VARCHAR(255),
state VARCHAR(10),
zip_code VARCHAR(5)
);




--Insert data into categories table--
INSERT INTO categories (category_id, category_name) VALUES
(1,'Mountain Bikes'),
(2,'Road Bikes'),
(3,'Electric Bikes'),
(4,'Hybrid Bikes'),
(5,'Kids Bikes');

INSERT INTO brands VALUES
(1,'Trek'),
(2,'Giant'),
(3,'Specialized'),
(4,'Cannondale'),
(5,'Scott');


INSERT INTO products VALUES
(1,'Trek Marlin 7',1,1,2022,900),
(2,'Giant Escape 3',2,4,2021,700),
(3,'Specialized Turbo Vado',3,3,2023,3200),
(4,'Cannondale Quick 4',4,4,2022,850),
(5,'Scott Scale 965',5,1,2023,1500);


INSERT INTO customers VALUES
(1,'John','Smith','9876543210','john@email.com','Street1','Dallas','TX','75001'),
(2,'David','Miller','9876543211','david@email.com','Street2','Austin','TX','75002'),
(3,'Robert','Brown','9876543212','robert@email.com','Street3','Dallas','TX','75003'),
(4,'Michael','Wilson','9876543213','michael@email.com','Street4','Houston','TX','75004'),
(5,'James','Taylor','9876543214','james@email.com','Street5','Austin','TX','75005');


INSERT INTO stores VALUES
(1,'Dallas Bike Store','1234567890','dallas@store.com','StreetA','Dallas','TX','75001'),
(2,'Austin Bike Store','1234567891','austin@store.com','StreetB','Austin','TX','75002'),
(3,'Houston Bike Store','1234567892','houston@store.com','StreetC','Houston','TX','75003'),
(4,'Plano Bike Store','1234567893','plano@store.com','StreetD','Plano','TX','75004'),
(5,'Irving Bike Store','1234567894','irving@store.com','StreetE','Irving','TX','75005');


--Retrieve Products with Brand and Category--
SELECT 
p.product_name,
b.brand_name,
c.category_name,
p.model_year,
p.list_price
FROM products p
JOIN brands b 
ON p.brand_id = b.brand_id
JOIN categories c 
ON p.category_id = c.category_id;


--Retrieve Customers from Specific City--
SELECT *
FROM customers
WHERE city = 'Dallas';


--Display Total Products in Each Category--
SELECT 
c.category_name,
COUNT(p.product_id) AS total_products
FROM categories c
LEFT JOIN products p
ON c.category_id = p.category_id
GROUP BY c.category_name;