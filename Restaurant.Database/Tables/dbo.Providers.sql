CREATE TABLE [dbo].[Providers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [ProviderName] NVARCHAR(40) NOT NULL UNIQUE, 
    [Description] NVARCHAR(100) NULL
)
