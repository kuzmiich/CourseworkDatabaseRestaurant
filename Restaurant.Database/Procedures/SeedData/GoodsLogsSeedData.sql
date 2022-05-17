CREATE PROCEDURE GoodsLogsSeedData
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM GoodsLogs)
	BEGIN
	INSERT GoodsLogs(GoodsId, ProviderId, DeliveryId, DateOfRegistration) VALUES 
			(1, 1, 1, '2022-04-23 13:33:57'),
			(3, 2, 2, '2001-02-21 11:00:00'),
			(2, 3, 3, '2010-03-20 10:30:20'),
			(4, 4, 4, '2019-01-20 8:30:20'),
			(1, 3, 2, '2008-01-10 9:30:10')
	END
END
GO