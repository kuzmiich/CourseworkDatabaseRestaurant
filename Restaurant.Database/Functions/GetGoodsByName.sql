CREATE FUNCTION GetGoodsByName(	
	@goodsName NVARCHAR(40)
)
RETURNS TABLE
AS
	RETURN (SELECT * FROM Goods WHERE Goods.GoodsName = @goodsName)
GO 