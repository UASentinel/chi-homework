SELECT * FROM Categories;
INSERT INTO Categories ([Name]) VALUES
	('Food'),
	('Transport'),
	('Mobile connection'),
	('Internet'),
	('Entertainment');

SELECT * FROM Spendings;
INSERT INTO Spendings ([Sum], CategoryId, Comment, [DateTime]) VALUES
	(100, 1, null, '2023-05-14 10:15:00'),
	(15, 1, null, '2023-05-14 10:15:00'),
	(140, 1, null, '2023-05-10 18:21:00'),
	(78, 1, null, '2023-05-08 17:20:00'),
	(53, 1, null, '2023-04-28 09:30:00'),
	(810.80, 1, null, '2023-04-04 11:20:00'),
	(210, 1, 'Pizza', '2023-05-10 20:11:00'),
	(850, 1, 'Products', '2023-04-19 17:00:00'),
	(120, 1, 'Coffe with cupcake', '2023-04-05 15:08:00'),
	(26.50, 1, 'Ice cream', '2023-03-30 10:45:00'),
	(930.80, 1, 'Products', '2023-03-15 07:58:00'),
	(327, 1, 'Sushi', '2023-03-02 18:47:00'),
	(15, 2, 'Bus', '2023-05-13 11:30:00'),
	(15, 2, 'Bus', '2023-05-13 09:30:00'),
	(15, 2, 'Bus', '2023-05-04 20:15:00'),
	(15, 2, 'Bus', '2023-05-04 18:27:00'),
	(15, 2, 'Bus', '2023-04-30 12:55:00'),
	(15, 2, 'Bus', '2023-04-30 10:00:00'),
	(15, 2, 'Bus', '2023-04-17 17:15:00'),
	(15, 2, 'Bus', '2023-04-17 08:00:00'),
	(15, 2, 'Bus', '2023-03-18 10:15:00'),
	(15, 2, 'Bus', '2023-03-18 07:45:00'),
	(15, 2, 'Bus', '2023-03-10 18:01:00'),
	(15, 2, 'Bus', '2023-03-10 16:43:00'),
	(15, 2, 'Bus', '2023-02-01 20:18:00'),
	(15, 2, 'Bus', '2023-02-01 08:57:00'),
	(175, 3, 'Kyivstar', '2023-05-05 20:18:00'),
	(175, 3, 'Kyivstar', '2023-04-05 19:30:00'),
	(175, 3, 'Kyivstar', '2023-03-05 21:40:00'),
	(175, 3, 'Kyivstar', '2023-02-05 18:15:00'),
	(300, 4, 'Internet', '2023-05-01 19:57:00'),
	(300, 4, 'Internet', '2023-04-01 22:18:00'),
	(300, 4, 'Internet', '2023-03-01 20:47:00'),
	(300, 4, 'Internet', '2023-02-01 18:21:00'),
	(200, 5, 'Cinema', '2023-05-07 17:30:00'),
	(800, 5, 'Present for a friend', '2023-04-15 10:10:00'),
	(80, 5, 'Ferris wheel', '2023-03-19 16:18:00'),
	(180, 5, 'Cinema', '2023-03-30 20:00:00'),
	(145, 5, 'Theatre', '2023-02-17 18:20:00'),
	(120, 5, 'Ice rink', '2023-02-06 17:48:00'),
	(300, 5, null, '2023-05-14 20:05:00'),
	(50, 5, null, '2023-04-20 19:19:00'),
	(75, 5, null, '2023-02-18 09:15:00')