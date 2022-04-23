﻿CREATE PROCEDURE GetGoodsLogsByDateInterval 
	@FromDate date,
	@ToDate date
AS
BEGIN
	SET NOCOUNT ON; -- Delete the numbers of rows in result statement
	SELECT dbo.Deliveries.DeliveryName,
		dbo.GoodsLogs.DateOfRegistration,
		dbo.GoodsLogs.GoodsCount AS GoodsCount,
		dbo.Manufactures.ManufacturerName,
		dbo.Goods.GoodsName,
		dbo.Providers.ProviderName
	FROM dbo.GoodsLogs 
		INNER JOIN dbo.Deliveries ON dbo.GoodsLogs.DeliveryId = dbo.Deliveries.Id
		INNER JOIN dbo.Goods ON dbo.GoodsLogs.GoodsId = dbo.Goods.Id
		INNER JOIN dbo.Manufacturer ON dbo.Goods.ManufactureId = dbo.Manufactures.Id
		INNER JOIN dbo.Providers ON dbo.GoodsLogs.ProviderId = dbo.Providers.Id
	WHERE DateOfRegistration between @FromDate and @ToDate
	ORDER BY DateOfRegistration ASC
END
GO 
