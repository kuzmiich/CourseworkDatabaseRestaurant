CREATE PROCEDURE ManufacturersSeedData
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM Manufacturers)
	BEGIN
		INSERT INTO Manufacturers (ManufacturerName)
		VALUES
			('Amazon'),
			('Microsoft'),
			('Apple'),
			('AliExpress')
	END
END
GO