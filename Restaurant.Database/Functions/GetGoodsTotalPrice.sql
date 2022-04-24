CREATE FUNCTION GetGoodsTotalPrice()
RETURNS DECIMAL(18, 2)
AS
BEGIN
	RETURN (SELECT SUM(Goods.Price  * Goods.Count) AS GoodsTotalPrice FROM Goods)
END
GO 