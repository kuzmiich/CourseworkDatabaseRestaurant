CREATE PROCEDURE GoodsLogsSeedData
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM GoodsLogs)
	BEGIN
	INSERT GoodsLogs(GoodsId, ProviderId, DeliveryId, DateOfRegistration) VALUES 
			(1, 1, 1, '2022-04-23 13:33:57'),
			(3, 2, 2, '2021-02-21 11:30:00'),
			(2, 3, 3, '2020-03-20 10:30:20'),
			(4, 4, 4, '2022-04-20 8:30:20')
	END
END
GO