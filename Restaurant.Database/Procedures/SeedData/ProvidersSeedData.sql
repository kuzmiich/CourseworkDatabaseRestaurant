CREATE PROCEDURE ProvidersSeedData
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM Providers)
	BEGIN
		INSERT INTO Providers (ProviderName, Description) VALUES 
			('Provider1', 'Description'),
			('Provider2', 'Description'),
			('Provider3', 'Description'),
			('Provider4', 'Description')
	END
END
GO