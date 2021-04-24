Module TableData

    Public inventoryTables As String =
"DROP TABLE If EXISTS bar_item_closing;
CREATE TABLE If Not EXISTS bar_item_closing (
	id	INTEGER Not NULL,
	item_name	TEXT Not NULL,
    opening_qty DECIMAL(4,2),
    closing_qty DECIMAL(4,2),
	PRIMARY KEY(id)
);"

    Public inventorySamples As String = "
INSERT INTO bar_item_closing VALUES 
 (1, 'Hennessey', 3.00, 3.00),
 (2, 'Jim Bean', 5.00, 5.00),
 (3, 'Jack Danials', 4.00, 3.50),
 (4, 'Patron', 2.00, 2.00),
 (5, 'Ciroc', 4.50, 4.00);
"


    Public posTables() As String = {
    "DROP TABLE IF EXISTS menu_item;
    CREATE TABLE IF NOT EXISTS menu_item (
	id		INTEGER,
	name		TEXT NOT NULL,
	short_name		TEXT NOT NULL,
	type		INTEGER NOT NULL,
	price		INTEGER NOT NULL,
	PRIMARY KEY(id)
);",
"DROP TABLE IF EXISTS item_type;
 CREATE TABLE IF NOT EXISTS item_type (
	id	INTEGER,
	type	TEXT NOT NULL,
	PRIMARY KEY(id)
);",
"DROP TABLE IF EXISTS item_order;
CREATE TABLE IF NOT EXISTS item_order (
	id	BIGINT,
	order_id	BIGINT NOT NULL,
	item_id	INTEGER NOT NULL,
	quantity	INTEGER Not NULL,
	notes	TEXT,
	PRIMARY KEY(id)
);", "DROP TABLE IF EXISTS orders;
CREATE TABLE IF NOT EXISTS orders (
	id	BIGINT,
	date	BIGINT NOT NULL,
	employee_id	INTEGER Not NULL,
	customer_id	INTEGER NOT NULL,
	table_num	INTEGER NOT NULL,
	PRIMARY KEY(id)
);",
"DROP TABLE IF EXISTS customer;
CREATE TABLE IF NOT EXISTS customer (
	id	INTEGER,
	phone	INTEGER Not NULL,
	name	TEXT Not NULL,
	notes	TEXT,
	PRIMARY KEY(id)
);",
"DROP TABLE IF EXISTS employees;
CREATE TABLE IF NOT EXISTS employees (
	id	INTEGER NOT NULL,
	first_name	TEXT,
	last_name	TEXT,
	type	INTEGER,
	PRIMARY KEY(id)
);",
"DROP TABLE IF EXISTS employee_type;
CREATE TABLE IF NOT EXISTS employee_type (
	id	INTEGER,
	type	TEXT NOT NULL,
	PRIMARY KEY(id)
);"
    }

    Public posSamples As String = "INSERT INTO menu_item VALUES (101,'filet mignon','fmign',1,23),
 (102,'shrimp','shrmp',1,18),
 (103,'chicken','chkn',1,16),
 (104,'scallops','sclps',1,22),
 (105,'norwegian salmon','slmn',1,17),
 (106,'red snapper','snpr',1,17),
 (107,'ribeye steak','stek',1,18),
 (108,'vegetables','vegbl',1,12),
 (201,'appetizer shrimp','app shrmp',2,4),
 (202,'filet mignon','app fmign',2,9),
 (203,'ribeye steak','app stek',2,6),
 (204,'teriyaki chicken','app chkn',2,3),
 (205,'scallops','app sclps',2,6),
 (206,'calamari','app clmri',2,4),
 (207,'salmon','app slmn',2,5),
 (208,'red snapper','app snpr',2,5),
 (209,'lobster','app lbstr',2,18),
 (210,'fried rice','app frice',2,2),
 (211,'vegetables','app vegbl',2,2),
 (212,'steamed rice','app srice',2,1),
 (301,'dipping sauce','xtra saus',3,1),
 (302,'dressing','xtra dres',3,1),
 (401,'vanilla ice cream','vncream',4,2),
 (402,'green tea ice cream','gtcream',4,2),
 (403,'orange sherbet','orshbt',4,2),
 (404,'chocolate cake','chcake',4,4),
 (501,'v stawberry daiquiri','vdaqri',5,4),
 (502,'v pina colada','vpclda',5,4),
 (503,'perrier','perr',5,3),
 (504,'shirley temple','shtempl',5,2),
 (505,'roy rogers','rrogrs',5,2),
 (506,'blue smurf','bsmrf',5,2),
 (507,'soft drink','pop',5,1),
 (508,'bottled water','water',5,1),
 (509,'green tea','gtea',5,1),
 (601,'kids shrimp','kidshmp',6,8),
 (602,'kids steak','kidstek',6,9),
 (603,'kids chicken','kidchkn',6,8),
 (701,'petite filet, shrimp, teriyaki chicken','wkdyspc',7,19),
 (702,'shrimp, norwegian salmon','wkdyspc',7,16),
 (703,'aioli japonais shrimp, teriyaki chicken','wkdyspc',7,17),
 (704,'ribeye steak, sesame tuna','wkdyspc',7,18),
 (705,'aioli japonais shrimp','wkdyspc',7,5),
 (706,'sesame tuna','wkdyspc',7,4),
 (707,'6oz kids juice box','wkdyspc',7,1),
 (708,'plain milk box','wkdyspc',7,2),
 (709,'chocolate milk box','wkdyspc',7,1),
 (801,'petite filet, shrimp, 1/2 lobster tail','wkndspc',8,24),
 (802,'ribeye steak, aioli japonais shrimp','wkdnspc',8,23);

INSERT INTO item_type VALUES (1,'entree'),
 (2,'appetizer'),
 (3,'extra'),
 (4,'dessert'),
 (5,'drink'),
 (6,'kids'),
 (7,'weekday special'),
 (8,'weekend special');

INSERT INTO item_order VALUES (10929639130153835,1132295688302607578,212,1,''),
 (10329639130153835,6132296391254038359,103,1,''),
 (10729638841414578,4132296388414116484,107,1,''),
 (10829640382984890,7132296403829848906,108,2,''),
 (20929639125403835,6132296391254038359,209,2,'');

INSERT INTO orders VALUES (1132295688302607578,132295688302607578,1,1,1),
 (4132296376361284453,132296376361284453,1,0,4),
 (4132296388414116484,132296388414116484,1,0,4),
 (6132296375280395781,132296375280395781,1,0,6),
 (6132296391254038359,132296391254038359,1,0,6),
 (7132296403829848906,132296403829848906,1,465478,7);

INSERT INTO customer VALUES (1,123,'John Smith',''),
 (465478,465478,'Haley Parker','');

INSERT INTO employees VALUES (1,'jim','stevenson',4),
 (2,'sussie','freeman',3);

INSERT INTO employee_type VALUES (1,'manager'),
 (2,'chef'),
 (3,'bartender'),
 (4,'waiter'),
 (5,'helper');
"

End Module
