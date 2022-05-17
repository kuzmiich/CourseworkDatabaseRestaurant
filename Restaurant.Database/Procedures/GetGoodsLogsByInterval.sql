CREATE PROCEDURE GetGoodsLogsByDateInterval
	@FromDate date,
	@ToDate date
AS
BEGIN
	SET NOCOUNT ON; -- Delete the numbers of rows in result statement
	SELECT dbo.Delivery.DeliveryName,
		dbo.Manufacturers.ManufacturerName,
		dbo.GoodsLogs.DateOfRegistration,
		dbo.Goods.GoodsName,
		dbo.Goods.Count AS GoodsCount,
		dbo.Goods.Count * dbo.Goods.Price AS GoodsTotalPrice,
		dbo.Providers.ProviderName
	FROM dbo.GoodsLogs 
		INNER JOIN dbo.Delivery ON dbo.GoodsLogs.DeliveryId = dbo.Delivery.Id
		INNER JOIN dbo.Goods ON dbo.GoodsLogs.GoodsId = dbo.Goods.Id
		INNER JOIN dbo.Manufacturers ON dbo.Goods.ManufacturerId = dbo.Manufacturers.Id
		INNER JOIN dbo.Providers ON dbo.GoodsLogs.ProviderId = dbo.Providers.Id
	WHERE DateOfRegistration between @FromDate and @ToDate
	ORDER BY DateOfRegistration ASC
END