GO
CREATE VIEW GoodsView 
AS 
SELECT 
	dbo.Goods.Id,	
	dbo.Goods.GoodsName,
	dbo.Manufacturers.ManufacturerName
FROM dbo.Goods 
	INNER JOIN dbo.Manufacturers ON dbo.Manufacturers.Id = dbo.Goods.ManufactureId