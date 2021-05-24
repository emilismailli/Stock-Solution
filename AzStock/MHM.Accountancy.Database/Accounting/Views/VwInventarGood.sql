--CREATE VIEW [Accounting].[VwInventarGood]
 
--AS
--	select
--	di.Id
--	,di.WareHouseId
--	,wh.[Name] WareHouseName
--	,di.CreateId
--	,di.CreateDate
--	,p.[Name]
	
--	from dbo.DocumentInventar di
-- join Accounting.Inventar invent  on invent.DocumentInventarId=di.Id
--JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = di.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
--JOIN WareHouses.WareHouse wh ON di.WareHouseId = wh.Id
--JOIN dbo.[Principial] p ON p.Id=di.CreateId