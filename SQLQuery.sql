CREATE TABLE Groups (
  gr_id INT IDENTITY NOT NULL,
  gr_name NVARCHAR(50),
  gr_temp DECIMAL(5, 1),
  CONSTRAINT [PK_Groups] PRIMARY KEY (gr_id)
);

CREATE TABLE Analysis (
  an_id INT IDENTITY NOT NULL,
  an_name NVARCHAR(50),
  an_cost DECIMAL(10, 2),
  an_price DECIMAL(10, 2),
  an_group INT NOT NULL,
  CONSTRAINT [PK_Analysis] PRIMARY KEY (an_id),
  CONSTRAINT [FK_Analysis_Groups] FOREIGN KEY (an_group) REFERENCES Groups(gr_id)
);

CREATE TABLE Orders (
  ord_id INT IDENTITY NOT NULL,
  ord_datetime DATETIME,
  ord_an INT NOT NULL,
  CONSTRAINT [PK_Orders] PRIMARY KEY (ord_id),
  CONSTRAINT [FK_Orders_Analysis] FOREIGN KEY (ord_an) REFERENCES Analysis(an_id)
);

INSERT INTO Groups (gr_name, gr_temp) VALUES 
	('group1', 20.5),
	('group2', -2),
	('group3', -1);

SELECT * FROM Groups;

INSERT INTO Analysis (an_name, an_cost, an_price, an_group) VALUES
	('analysis1', 100, 120, 1),
	('analysis2', 50.5, 70.95, 2),
	('analysis3', 1025, 1500, 1),
	('analysis4', 20.7, 31, 3),
	('analysis5', 40, 45, 1),
	('analysis6', 110.25, 200.1, 2),
	('analysis7', 80.4, 90, 2),
	('analysis8', 783, 9021, 3);

SELECT * FROM Analysis;

INSERT INTO Orders (ord_datetime, ord_an) VALUES
	('2020-8-2', 1),
	('2020-5-18', 2),
	('2020-2-13', 2),
	('2020-1-13', 6),
	('2020-7-1', 3),
	('2020-9-1', 6),
	('2020-12-3', 7),
	('2020-11-27', 7),
	('2020-6-22', 1),
	('2020-12-17', 6),
	('2020-10-17', 5),
	('2020-11-8', 2),
	('2020-2-6', 1),
	('2020-7-12', 4),
	('2020-2-11', 2),
	('2020-11-2', 6),
	('2020-8-16', 2),
	('2020-1-6', 7),
	('2020-11-9', 6),
	('2020-9-14', 2),
	('2020-12-28', 6),
	('2020-8-22', 2),
	('2020-9-22', 2),
	('2020-1-4', 7),
	('2020-3-23', 7),
	('2020-9-15', 4),
	('2020-8-12', 5),
	('2020-8-24', 6),
	('2020-9-28', 5),
	('2020-3-13', 1),
	('2020-12-13', 6),
	('2020-3-8', 6),
	('2020-11-5', 1),
	('2020-11-16', 2),
	('2020-12-9', 1),
	('2020-12-14', 6),
	('2020-2-13', 3),
	('2020-11-23', 2),
	('2020-10-1', 4),
	('2020-2-17', 1),
	('2020-8-26', 4),
	('2020-6-3', 5),
	('2020-4-13', 5),
	('2020-4-18', 1),
	('2020-11-26', 3),
	('2020-2-21', 2),
	('2020-7-16', 3),
	('2020-10-17', 6),
	('2020-6-8', 6),
	('2020-11-24', 4),
	('2020-2-19', 1),
	('2020-11-6', 2),
	('2020-2-8', 1),
	('2020-6-27', 3),
	('2020-1-3', 2),
	('2020-8-26', 1),
	('2020-8-3', 3),
	('2020-1-16', 2),
	('2020-10-21', 7),
	('2020-7-9', 3),
	('2020-8-10', 5),
	('2020-8-22', 5),
	('2020-9-4', 3),
	('2020-11-5', 2),
	('2020-7-25', 1),
	('2020-7-16', 4),
	('2020-10-7', 3),
	('2020-10-20', 5),
	('2020-2-24', 3),
	('2020-11-16', 6),
	('2020-4-18', 5),
	('2020-8-20', 2),
	('2020-10-13', 7),
	('2020-10-18', 4),
	('2020-2-5', 5),
	('2020-3-2', 4),
	('2020-11-28', 4),
	('2020-3-18', 1),
	('2020-12-26', 1),
	('2020-12-12', 5),
	('2020-9-24', 5),
	('2020-4-8', 5),
	('2020-4-3', 3),
	('2020-5-5', 3),
	('2020-9-7', 6),
	('2020-5-20', 3),
	('2020-2-15', 3),
	('2020-7-13', 3),
	('2020-2-8', 5),
	('2020-1-26', 4),
	('2020-8-11', 1),
	('2020-3-28', 5),
	('2020-4-11', 5),
	('2020-4-4', 2),
	('2020-6-3', 4),
	('2020-8-28', 2),
	('2020-8-10', 4),
	('2020-6-13', 1),
	('2020-10-4', 4),
	('2020-12-15', 7),
	('2020-2-5', 5),
	('2020-2-6', 6),
	('2020-2-10', 6),
	('2020-2-20', 7),
	('2020-2-7', 5),
	('2020-2-8', 6),
	('2020-2-5', 5),
	('2020-2-11', 7)

INSERT INTO Orders (ord_datetime, ord_an) VALUES
	('2021-6-6', 7),
	('2021-12-22', 3),
	('2021-2-12', 7),
	('2021-12-17', 6),
	('2021-5-19', 3),
	('2021-11-11', 3),
	('2021-4-17', 6),
	('2021-12-3', 4),
	('2021-1-25', 6),
	('2021-9-4', 6),
	('2021-7-20', 6),
	('2021-5-11', 3),
	('2021-8-20', 2),
	('2021-2-12', 4),
	('2021-11-4', 1),
	('2021-7-14', 6),
	('2021-9-15', 3),
	('2021-6-2', 5),
	('2021-12-8', 1),
	('2021-6-15', 5),
	('2021-6-15', 7),
	('2021-8-25', 1),
	('2021-9-22', 1),
	('2021-1-11', 6),
	('2021-11-10', 1),
	('2021-1-10', 7),
	('2021-10-18', 5),
	('2021-2-5', 1),
	('2021-7-19', 5),
	('2021-7-5', 3),
	('2021-7-5', 3),
	('2021-1-16', 3),
	('2021-4-25', 1),
	('2021-7-21', 7),
	('2021-6-14', 1),
	('2021-6-8', 1),
	('2021-11-12', 4),
	('2021-2-20', 2),
	('2021-10-5', 7),
	('2021-3-19', 5),
	('2021-5-18', 1),
	('2021-4-28', 1),
	('2021-3-16', 2),
	('2021-5-4', 3),
	('2021-12-22', 6),
	('2021-6-2', 2),
	('2021-4-11', 2),
	('2021-1-20', 4),
	('2021-6-18', 2),
	('2021-1-2', 4),
	('2021-2-7', 6),
	('2021-1-9', 5),
	('2021-4-5', 5),
	('2021-9-9', 4),
	('2021-9-22', 7),
	('2021-9-13', 7),
	('2021-1-4', 6),
	('2021-6-16', 6),
	('2021-11-6', 5),
	('2021-5-21', 6),
	('2021-3-12', 5),
	('2021-9-2', 1),
	('2021-2-7', 5),
	('2021-1-9', 2),
	('2021-10-15', 4),
	('2021-6-27', 5),
	('2021-5-5', 6),
	('2021-5-27', 7),
	('2021-7-14', 1),
	('2021-5-28', 2),
	('2021-10-12', 6),
	('2021-6-18', 5),
	('2021-1-9', 4),
	('2021-8-7', 5),
	('2021-4-27', 2),
	('2021-11-15', 6),
	('2021-6-20', 2),
	('2021-11-9', 1),
	('2021-9-5', 7),
	('2021-2-9', 6),
	('2021-12-12', 1),
	('2021-10-11', 2),
	('2021-12-12', 5),
	('2021-2-2', 4),
	('2021-6-28', 6),
	('2021-11-9', 2),
	('2021-7-10', 4),
	('2021-3-27', 7),
	('2021-1-6', 6),
	('2021-12-27', 6),
	('2021-1-7', 4),
	('2021-1-28', 1),
	('2021-9-27', 4),
	('2021-3-4', 2),
	('2021-10-13', 6),
	('2021-8-14', 7),
	('2021-8-23', 5),
	('2021-2-19', 4),
	('2021-11-12', 5),
	('2021-6-5', 6)

SELECT * FROM Orders;

SELECT DISTINCT an_name, an_price
FROM Analysis
INNER JOIN Orders ON Analysis.an_id = Orders.ord_an
WHERE ord_datetime BETWEEN '2020-02-05' AND DATEADD(day, 7, '2020-02-05');

SELECT gr_name, 
       YEAR(ord_datetime) AS [year], 
       MONTH(ord_datetime) AS [month],
	   COUNT(ord_id) AS sales,
       SUM(COUNT(ord_id)) OVER (PARTITION BY gr_name, YEAR(ord_datetime) ORDER BY MONTH(ord_datetime)) AS cumulative_sales
FROM Orders
INNER JOIN Analysis ON Orders.ord_an = Analysis.an_id
INNER JOIN Groups ON Analysis.an_group = Groups.gr_id
GROUP BY gr_name, YEAR(ord_datetime), MONTH(ord_datetime)
ORDER BY gr_name, YEAR(ord_datetime), MONTH(ord_datetime);