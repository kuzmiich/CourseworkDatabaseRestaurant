CREATE PROCEDURE GoodsSeedData
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM Goods)
	BEGIN
	INSERT Goods(ManufacturerId, GoodsName, Price, Count) VALUES 
			(1, 'sandwich', 1.5, 2),
			(2, 'fish', 2.5, 4),
			(3, 'shrimp', 10, 10),
			(4, 'chips', 1, 50)
	END
END
GO