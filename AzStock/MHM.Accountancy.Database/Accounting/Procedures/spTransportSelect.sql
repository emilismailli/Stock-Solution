CREATE PROCEDURE [dbo].[spTransportSelect]
	@userId int,
	@menuId int
AS
	SELECT * FROM dbo.Transport i
	JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = i.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
JOIN WareHouses.WareHouse wh ON i.WareHouseId = wh.Id

where  DeleteId IS NULL
RETURN 0
