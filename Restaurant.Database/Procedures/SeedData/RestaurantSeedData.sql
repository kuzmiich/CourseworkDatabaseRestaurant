CREATE PROCEDURE RestaurantSeedData
AS
BEGIN
	EXECUTE dbo.DeliverySeedData;
	EXECUTE dbo.ManufacturersSeedData;
	EXECUTE dbo.ProvidersSeedData;
	EXECUTE dbo.GoodsLogsSeedData;
	EXECUTE dbo.DeliverySeedData;
END
GO