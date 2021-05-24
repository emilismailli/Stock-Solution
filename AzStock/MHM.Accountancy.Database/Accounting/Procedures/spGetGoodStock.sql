CREATE PROCEDURE [dbo].[spGetGoodStock]
	@userId int null,
	@wareHouseId INT 
AS
BEGIN
	SELECT * from Accounting.VwGoodStock  
 
	WHERE WarehouseId=@wareHouseId  
end
