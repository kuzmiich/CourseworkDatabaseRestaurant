CREATE TRIGGER GoodsAudit_Update_Delete ON Goods AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @manufacturerId_old INT, @manufacturerId_new INT
    DECLARE @goodsName_old NVARCHAR(50), @goodsName_new NVARCHAR(50)
    DECLARE @price_old DECIMAL(18, 2), @price_new DECIMAL(18, 2)
    DECLARE @count_old INT, @count_new INT
	DECLARE @isDeleted_old BIT, @isDeleted_new BIT

    SET @manufacturerId_old = (SELECT ManufacturerId FROM deleted) 
    SET @manufacturerId_new = (SELECT ManufacturerId FROM inserted)
    
    SET @goodsName_old = (SELECT GoodsName FROM deleted) 
    SET @goodsName_new = (SELECT GoodsName FROM inserted) 

    SET @price_old = (SELECT Price FROM deleted) 
    SET @price_new = (SELECT Price FROM inserted) 

    SET @count_old = (SELECT Price FROM deleted) 
    SET @count_new = (SELECT Price FROM inserted) 

    SET @IsDeleted_old = (SELECT IsDeleted FROM deleted)
    SET @IsDeleted_new = (SELECT IsDeleted FROM inserted)

    INSERT INTO GoodsAudit
    (GoodsAuditDate, ManufactureId_old, ManufactureId_new, GoodsName_old, GoodsName_new, Price_old, Price_new, Count_old, Count_new, IsDeleted_old, IsDeleted_new)
    VALUES
    (GETDATE(), @manufacturerId_old, @manufacturerId_new, @goodsName_old, @goodsName_new, @price_old, @price_new, @count_old, @count_new, @isDeleted_old, @isDeleted_new)
END
GO