CREATE VIEW [WareHouses].[VwWareHouse]
with encryption
	AS SELECT 
	
	 wh.[Id],
	 wh.CompanyId,
	 c.CompanyName
	,wh.[Name]
	,wh.[WareHouseTypeId]
	,wh.[Description]
	,wh.[IsActive]
	,wht.Name WareHouseTypeName
	FROM [WareHouses].[WareHouse] wh

	left join WareHouses.WareHouseType  wht on wh.WareHouseTypeId= wht.Id
	LEFT JOIN Accounting.Company c ON  c.Id=wh.CompanyId
	--where wh.Id=1;

