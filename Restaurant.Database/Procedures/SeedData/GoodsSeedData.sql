CREATE PROCEDURE GoodsSeedData
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM Goods)
	BEGIN
	INSERT Goods(ManufactureId, GoodsName, Price) VALUES 
			(1, 'sandwich', 1.5),
			(2, 'fish', 2.5),
			(3, 'shrimp', 10),
			(4, 'chips', 1)
	END
END
GO