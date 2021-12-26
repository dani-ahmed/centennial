CREATE TABLE comm_customer(
customer_id INT,
firstname VARCHAR(255),
lastname VARCHAR(255),
email VARCHAR(255),
phone VARCHAR(255),
address VARCHAR(255),
cart_id INT,
PRIMARY KEY (customer_id)
);
CREATE TABLE comm_shoppingcart(
cart_id INT,
product VARCHAR(255),
quantity INT,
status_id INT,
shipping VARCHAR(255),
PRIMARY KEY (cart_id)
);
CREATE TABLE comm_shippingstatus(
status_id VARCHAR(3),
name VARCHAR(255)
);
CREATE TABLE comm_products(
product_id int,
name VARCHAR(255),
price INT,
size VARCHAR(255),
color_id CHAR,
category_id VARCHAR(3),
PRIMARY KEY(product_id)
);
CREATE TABLE comm_category(
category_id VARCHAR(3),
name VARCHAR(255),
PRIMARY KEY (category_id)
);
CREATE TABLE comm_colours(
color_id CHAR,
name VARCHAR(255),
PRIMARY KEY (color_id)
);

ALTER TABLE comm_products
ADD CONSTRAINT products_color_fk FOREIGN KEY (color_id)
REFERENCES comm_colours(color_id);

ALTER TABLE comm_products
ADD CONSTRAINT products_category_fk FOREIGN KEY (category_id)
REFERENCES comm_category(category_id);

ALTER TABLE comm_shoppingcart
ADD CONSTRAINT cart_status_fk FOREIGN KEY (status_id)
REFERENCES comm_shippingstatus(status_id);

ALTER TABLE comm_customer
ADD CONSTRAINT customer_cart_fk FOREIGN KEY (cart_id)
REFERENCES comm_shoppingcart(cart_id);

INSERT INTO comm_shippingstatus
VALUES ('del','delivered');
INSERT INTO comm_shippingstatus
VALUES ('shp','shipped');
INSERT INTO comm_shippingstatus
VALUES ('trs','in transit');

INSERT INTO comm_category
VALUES ('REC','RECREATION');
INSERT INTO comm_category
VALUES ('HEA','HEALTH');
INSERT INTO comm_category
VALUES ('CKG','COOKING');
INSERT INTO comm_category
VALUES ('ELE','ELECTRONIC');
INSERT INTO comm_category
VALUES ('CLG','CLOTHING');

INSERT INTO comm_colours
VALUES ('R','RED');
INSERT INTO comm_colours
VALUES ('G','GREEN');
INSERT INTO comm_colours
VALUES ('B','BLUE');
INSERT INTO comm_colours
VALUES ('Y','YELLOW');
INSERT INTO comm_colours
VALUES ('O','ORANGE');
INSERT INTO comm_colours
VALUES ('V','VIOLET');

INSERT INTO comm_products
VALUES (1,'car',10,'2kg','R','REC');
INSERT INTO comm_products
VALUES (2,'bat',20,'4kg','G','REC');
INSERT INTO comm_products
VALUES (3,'camera',100,'1kg','B','ELE');
INSERT INTO comm_products
VALUES (4,'hat',15,'1lb','Y','CLG');
INSERT INTO comm_products
VALUES (5,'bandaid',5,'1lb','Y','HEA');

INSERT INTO comm_shoppingcart
VALUES(1,'car',2,'del','home');
INSERT INTO comm_shoppingcart
VALUES(2,'hat',1,'shp','other');
INSERT INTO comm_shoppingcart
VALUES(3,'bat',3,'trs','home');
INSERT INTO comm_shoppingcart
VALUES(4,'ball',20,'del','home');
INSERT INTO comm_shoppingcart
VALUES(5,'camera',23,'shp','other');

INSERT INTO comm_customer
VALUES (1,'john','smith','jsmith@gmail.com','4161112222','45 Longmore rd.');
INSERT INTO comm_customer
VALUES (2,'caleb','cabral','ccabral@gmail.com','4162352222','45 Longmore rd.');
INSERT INTO comm_customer
VALUES (3,'tom','jackson','tjackson@gmail.com','4161346682','45 Longmore rd.');
INSERT INTO comm_customer
VALUES (4,'bill','smith','bsmith@gmail.com','4166783476','45 Longmore rd.');
INSERT INTO comm_customer
VALUES (5,'arthur','hughes','hughes@gmail.com','4163468909','45 Longmore rd.');
