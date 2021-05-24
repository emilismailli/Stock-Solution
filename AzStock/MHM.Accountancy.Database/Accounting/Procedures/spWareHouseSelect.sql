CREATE PROCEDURE [dbo].[spWareHouseSelect]
	@userId int null,
	@menuId INT null
AS
BEGIN
	SELECT wh.Id,wh.[Name] FROM WareHouses.WareHouse wh
JOIN dbo.WarehouseMenuCollection wmc ON wh.Id = wmc.WareHouseId AND wmc.Allow=1 AND wmc.UserId=@userId AND wmc.MenuId=@menuId

END