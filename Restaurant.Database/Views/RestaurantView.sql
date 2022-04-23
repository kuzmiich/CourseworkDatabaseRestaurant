GO
CREATE VIEW RestaurantView 
AS 
SELECT      
	dbo.GoodsLogs.GoodsCount,
	dbo.GoodsLogs.DateOfRegistration,
	dbo.Delivery.DeliveryName,
	dbo.Manufacturers.ManufacturerName, 
	dbo.Goods.GoodsName,
	dbo.Providers.ProviderName
FROM dbo.GoodsLogs 
	INNER JOIN dbo.Delivery ON dbo.Delivery.Id = dbo.GoodsLogs.DeliveryId 
	INNER JOIN dbo.Goods ON dbo.GoodsLogs.GoodsId = dbo.Goods.Id 
	INNER JOIN dbo.Manufacturers ON dbo.Goods.ManufactureId = dbo.Manufacturers.Id 
	INNER JOIN dbo.Providers ON dbo.GoodsLogs.ProviderId = dbo.Providers.Id