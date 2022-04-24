CREATE TABLE [dbo].[GoodsAudit]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [GoodsAuditDate] DATETIME NOT NULL,
	[ManufactureId_old] INT,
	[ManufactureId_new] INT NULL,
    [GoodsName_old] NVARCHAR(50), 
    [GoodsName_new] NVARCHAR(50) NULL, 
    [Price_old] DECIMAL(18, 2),
    [Price_new] DECIMAL(18, 2) NULL, 
    [Count_old] INT,
    [Count_new] INT NULL,
	[IsDeleted_old] BIT,
	[IsDeleted_new] BIT NULL,
);