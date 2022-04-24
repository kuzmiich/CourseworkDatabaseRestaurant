CREATE TRIGGER GoodsLogsAudit_Update_Delete ON GoodsLogs AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @goodsId_old INT, @goodsId_new INT
    DECLARE @providerId_old INT, @providerId_new INT
    DECLARE @deliveryId_old INT, @deliveryId_new INT
    DECLARE @dateOfRegistration_old DATETIME, @dateOfRegistration_new DATETIME
    DECLARE @goodsCount_old INT, @goodsCount_new INT

    SET @goodsId_old = (SELECT GoodsId FROM deleted)
    SET @goodsId_new = (SELECT GoodsId FROM inserted) 
    SET @providerId_old = (SELECT ProviderId FROM deleted) 
    SET @providerId_new = (SELECT ProviderId FROM inserted) 
    SET @deliveryId_old = (SELECT DeliveryId FROM deleted) 
    SET @deliveryId_new = (SELECT DeliveryId FROM inserted) 
    SET @dateOfRegistration_old = (SELECT DateOfRegistration FROM deleted) 
    SET @dateOfRegistration_new = (SELECT DateOfRegistration FROM inserted)

    INSERT INTO GoodsLogsAudit 
    (GoodsLogsAuditDate, GoodsId_old, GoodsId_new, ProviderId_old, ProviderId_new, DeliveryId_old, DeliveryId_new, DateOfRegistration_old, DateOfRegistration_new)
    VALUES
    (GETDATE(), @goodsId_old, @goodsId_new, @providerId_old, @providerId_new, @deliveryId_old, @deliveryId_new, @dateOfRegistration_old, @dateOfRegistration_new)
END
GO