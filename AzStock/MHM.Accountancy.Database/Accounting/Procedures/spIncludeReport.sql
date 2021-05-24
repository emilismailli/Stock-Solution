CREATE PROC [Accounting].[spIncludeReport]
@userId INT
,@menuId int
AS
BEGIN
SELECT * FROM Accounting.VwIncludeReport ir



JOIN dbo.WarehouseMenuCollection wmc ON wmc.WarehouseId=ir.WarehouseId AND wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId

end