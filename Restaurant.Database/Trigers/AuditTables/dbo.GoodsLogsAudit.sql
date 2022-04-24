CREATE TABLE [dbo].[GoodsLogsAudit]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [GoodsLogsAuditDate] DATETIME NOT NULL,
    [GoodsId_old] INT, 
    [GoodsId_new] INT NULL, 
    [ProviderId_old] INT, 
    [ProviderId_new] INT NULL, 
    [DeliveryId_old] INT, 
    [DeliveryId_new] INT NULL, 
    [DateOfRegistration_old] DATETIME, 
    [DateOfRegistration_new] DATETIME NULL,
);