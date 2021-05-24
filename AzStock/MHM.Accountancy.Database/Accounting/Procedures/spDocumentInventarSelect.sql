--CREATE PROCEDURE [dbo].[spDocumentInventarSelect]
--	@userId int ,
--	@menuId int
--AS


--	select di.Id
--	,di.WareHouseId
--	,wh.[Name] WareHouseName
--	,di.CreateId
--	,di.CreateDate
--	,p.[Name] 
--	,di.[Id]                
--	,di.[DocumentInventarId]
--	,di.[GoodId]            
--	,di.[FullGoodName]      
--	,di.[DifferenceQuantity]
--	,di.[StockQuantity]     
--	,di.[Quantity]             
	
--	from	Accounting.VwInventar di



--JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = di.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
--JOIN WareHouses.WareHouse wh ON di.WareHouseId = wh.Id
--JOIN dbo.[Principial] p ON p.Id=di.CreateId
--WHERE DeleteId IS NULL
--RETURN 0