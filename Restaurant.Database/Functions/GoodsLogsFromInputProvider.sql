CREATE FUNCTION GoodsLogsFromInputProvider
(	
	@providerName NVARCHAR(40)
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT * From RestaurantView WHERE ProviderName = @providerName
)