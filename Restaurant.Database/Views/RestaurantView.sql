GO
CREATE VIEW RestaurantView 
AS 
SELECT      
	GoodsLogs.DateOfRegistration,
	Delivery.DeliveryName,
	Manufacturers.ManufacturerName, 
	Goods.GoodsName,
	Goods.Count AS GoodsCount,
	Providers.ProviderName
FROM GoodsLogs 
	INNER JOIN Delivery ON Delivery.Id = GoodsLogs.DeliveryId 
	INNER JOIN Goods ON GoodsLogs.GoodsId = Goods.Id 
	INNER JOIN Manufacturers ON Goods.ManufacturerId = Manufacturers.Id 
	INNER JOIN Providers ON GoodsLogs.ProviderId = Providers.Id