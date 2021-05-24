CREATE PROCEDURE [dbo].[spWareHouseChangedPrice]
	@userId int null,
	@warehouseId INT null
AS
	select * from warehouses.warehouse w where  w.Id<>@warehouseId
RETURN 0
