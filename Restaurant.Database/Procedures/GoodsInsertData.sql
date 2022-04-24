CREATE PROCEDURE GoodsInsertData
	@manufacturerId INT,
	@goodsName NVARCHAR(50),
	@price DECIMAL(18, 2),
	@count INT,
	@Id INT OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT Goods(ManufacturerId, GoodsName, Price, Count) VALUES (@manufacturerId, @goodsName, @price, @count);
	SET @Id = @@IDENTITY
END
GO