CREATE FUNCTION GoodsLogsFromInputProvider
(	
	@providerName NVARCHAR(30)
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT * From RestaurantView WHERE ProviderName = @providerName
)