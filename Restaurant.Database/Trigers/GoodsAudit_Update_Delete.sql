CREATE TRIGGER GoodsAudit_Update_Delete ON Goods AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @manufactureId_old INT, @manufactureId_new INT
    DECLARE @goodsName_old NVARCHAR(50), @goodsName_new NVARCHAR(50)
    DECLARE @price_old DECIMAL(18, 2), @price_new DECIMAL(18, 2)
	DECLARE @isDeleted_old BIT, @isDeleted_new BIT

    SET @manufactureId_old = (SELECT ManufactureId FROM deleted) 
    SET @manufactureId_new = (SELECT ManufactureId FROM inserted)
    
    SET @goodsName_old = (SELECT GoodsName FROM deleted) 
    SET @goodsName_new = (SELECT GoodsName FROM inserted) 

    SET @price_old = (SELECT Price FROM deleted) 
    SET @price_new = (SELECT Price FROM inserted) 

    SET @IsDeleted_old = (SELECT IsDeleted FROM deleted)
    SET @IsDeleted_new = (SELECT IsDeleted FROM inserted)

    INSERT INTO GoodsAudit
    (GoodsAuditDate, ManufactureId_old, ManufactureId_new, GoodsName_old, GoodsName_new, Price_old, Price_new, IsDeleted_old, IsDeleted_new)
    VALUES
    (GETDATE(), @manufactureId_old, @manufactureId_new, @goodsName_old, @goodsName_new, @price_old, @price_new, @isDeleted_old, @isDeleted_new)
END
GO