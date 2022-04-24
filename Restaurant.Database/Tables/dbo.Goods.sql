CREATE TABLE [dbo].[Goods]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[ManufacturerId] INT NOT NULL,
    [GoodsName] NVARCHAR(50) NOT NULL UNIQUE, 
    [Price] DECIMAL(18, 2) NOT NULL, 
    [Count] INT NOT NULL, 
	[IsDeleted] BIT NOT NULL DEFAULT 0,

    CONSTRAINT [FK_Goods_Manufacturers] FOREIGN KEY ([ManufacturerId]) REFERENCES [Manufacturers]([Id])
)
