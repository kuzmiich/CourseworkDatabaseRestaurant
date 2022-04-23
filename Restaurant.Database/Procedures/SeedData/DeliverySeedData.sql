CREATE PROCEDURE DeliverySeedData
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM Delivery)
	BEGIN
	INSERT Delivery(DeliveryName) VALUES
			('Noname1'),
			('Noname2'),
			('Noname3'),
			('Noname4')
	END
END
GO