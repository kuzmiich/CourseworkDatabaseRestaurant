CREATE TABLE [dbo].[Manufacturers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [ManufacturerName] NVARCHAR(50) NOT NULL UNIQUE,
	[IsDeleted] BIT NOT NULL DEFAULT 0,
)
