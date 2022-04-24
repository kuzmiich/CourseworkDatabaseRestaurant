GO
CREATE VIEW GoodsView 
AS 
SELECT 
	Goods.Id,	
	Goods.GoodsName,
	Manufacturers.ManufacturerName,
	Goods.Price,
	Goods.Count,
	Goods.IsDeleted
FROM Goods 
	INNER JOIN Manufacturers ON Manufacturers.Id = Goods.ManufacturerId