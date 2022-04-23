CREATE FUNCTION GetRestaurantTotalPrice()
RETURNS DECIMAL(18, 2)
AS
BEGIN
	RETURN (
		SELECT Goods.Price * GoodsLogs.GoodsCount AS RestaurantTotalPrice
		FROM GoodsLogs
			INNER JOIN dbo.Goods ON dbo.GoodsLogs.GoodsId = dbo.Goods.Id
		)
END
GO 