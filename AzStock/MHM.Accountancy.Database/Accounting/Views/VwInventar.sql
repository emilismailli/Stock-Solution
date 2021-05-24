CREATE VIEW [Accounting].[VwInventar]
	AS 
	SELECT 
	i.FullGoodName,
	i.DocumentInventarId,
	i.Quantity,
	i.DifferenceQuantity,
	i.StockQuantity,
	i.WareHouseId,
	w.[Name] WarehouseName,
	u.[Name] UserName,
	i.CreateDate
	,i.CreateId
	,i.[DeleteId]   

	FROM [Accounting].[Inventar] i
	JOIN WareHouses.VwWareHouse w ON w.Id=i.WareHouseId
	JOIN dbo.[Principial] u ON u.Id=i.CreateId
