GO
CREATE VIEW RestaurantView 
AS 
SELECT      
	Delivery.DeliveryName,
	Manufacturers.ManufacturerName, 
	Goods.GoodsName,
	Goods.Count AS GoodsCount,
	Goods.Price AS GoodsPrice,
	Providers.ProviderName,
	Providers.Description AS ProviderDescription,
	GoodsLogs.DateOfRegistration
FROM GoodsLogs 
	INNER JOIN Delivery ON Delivery.Id = GoodsLogs.DeliveryId 
	INNER JOIN Goods ON GoodsLogs.GoodsId = Goods.Id 
	INNER JOIN Manufacturers ON Goods.ManufacturerId = Manufacturers.Id 
	INNER JOIN Providers ON GoodsLogs.ProviderId = Providers.Id