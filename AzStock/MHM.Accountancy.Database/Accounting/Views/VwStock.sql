CREATE VIEW [Accounting].[VwStock]
	AS SELECT 
	s.DocumentId
	,s.GoodId
	,s.WarehouseId
	,w.[Name] Warehouse
	,g.GoodName
	,CreateId
	,s.Series
	,sum(s.Quantity) Quantity
	,s.PriceBuy
	,s.PrcieRetail
	,s.PriceWholeSale
	,s.CreateDate
	,UpdateDate
	,UpdateId 
	--,s.ContractId
	--,s.ContractTypeId
	
	

	FROM [Accounting].[Stock] s

left  join Accounting.Good g on s.GoodId=g.Id
LEFT JOIN WareHouses.WareHouse w ON w.Id=s.WarehouseId
   --join Accounting.[Contract] c on c.Id=d.ContractId

GROUP BY 
s.DocumentId
,s.GoodId
,s.WarehouseId
,w.[Name]
,g.GoodName
,CreateId
,s.Series
,s.PriceBuy
,s.PrcieRetail
,s.PriceWholeSale
,s.CreateDate
,UpdateDate
,UpdateId

	--,s.ContractId
	--,s.ContractTypeId
