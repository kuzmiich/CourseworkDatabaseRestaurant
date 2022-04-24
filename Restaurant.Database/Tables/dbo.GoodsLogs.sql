CREATE TABLE [dbo].[GoodsLogs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [GoodsId] INT NOT NULL, 
    [ProviderId] INT NOT NULL, 
    [DeliveryId] INT NOT NULL, 
    [DateOfRegistration] DATETIME NOT NULL,

    CONSTRAINT [FK_GoodsLogs_Goods] FOREIGN KEY ([GoodsId]) REFERENCES [Goods]([Id]) 
        ON DELETE CASCADE
        ON UPDATE CASCADE, 
    CONSTRAINT [FK_GoodsLogs_Provider] FOREIGN KEY ([ProviderId]) REFERENCES [Providers]([Id])
        ON DELETE CASCADE
        ON UPDATE CASCADE, 
    CONSTRAINT [FK_GoodsLogs_Delivery] FOREIGN KEY ([DeliveryId]) REFERENCES [Delivery]([Id])
        ON DELETE CASCADE
        ON UPDATE CASCADE, 
)
