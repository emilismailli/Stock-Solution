CREATE PROCEDURE [dbo].[spWareHousePermitted]
	@userId int,@menuId int
	AS
	BEGIN
SELECT wh.*,cast((CASE WHEN wmc.Id IS NOT NULL THEN wmc.Allow 
WHEN wmc.Id IS NULL then 0 ELSE 0 END
)AS bit) Allow,wmc.UserId,wmc.MenuId FROM WareHouses.WareHouse wh
LEFT JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId=wh.Id AND wmc.UserId=@userId AND wmc.MenuId=@menuId
end