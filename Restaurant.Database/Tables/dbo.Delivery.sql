﻿CREATE TABLE [dbo].[Delivery]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [DeliveryName] NVARCHAR(50) NULL UNIQUE
)