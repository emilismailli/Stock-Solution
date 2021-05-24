CREATE PROC [Accounting].[spDeficitStock]
@userId INT
,@menuId int
AS
BEGIN
SELECT * FROM Accounting.VwDeficitGoodStock vdgs
JOIN dbo.WarehouseMenuCollection wmc ON wmc.WarehouseId=vdgs.WarehouseId AND wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId

end