CREATE PROCEDURE RestaurantSeedData
AS
BEGIN
	EXECUTE dbo.DeliverySeedData;
	EXECUTE dbo.ProvidersSeedData;
	EXECUTE dbo.ManufacturersSeedData;
	EXECUTE dbo.GoodsSeedData;
	EXECUTE dbo.GoodsLogsSeedData;
END
GO