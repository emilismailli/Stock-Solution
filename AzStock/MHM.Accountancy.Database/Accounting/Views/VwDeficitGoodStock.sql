CREATE VIEW [Accounting].[VwDeficitGoodStock]
	AS  


	SELECT g.FullGoodName
	,g.GoodName,
SUM(s2.Quantity) Quantity,
s2.Series
,s2.PriceBuy
,s2.PriceWholeSale
,s2.PrcieRetail
 ,s2.WarehouseId
 ,s2.Warehouse
,g.GoodTypeName
,g.Barcode
,g.ManufacturerCompanyName
,g.RegionName
,g.[Description]
,s2.DocumentId 
,d.CustomerName 
,c.ContractTypeId 

FROM Accounting.VwStock s2



join Accounting.VwGood g on s2.GoodId=g.Id
left join Accounting.VwDocument d on s2.DocumentId=d.Id
   
   join Accounting.[Contract] c on c.Id=d.ContractId

where s2.Quantity>0  and ContractTypeId in (1)

 GROUP BY g.FullGoodName,
 g.GoodName,
s2.Series
,s2.PriceBuy
,s2.PriceWholeSale
,s2.PrcieRetail
  ,s2.WarehouseId
 ,s2.Warehouse
,g.GoodTypeName
,g.Barcode
,g.ManufacturerCompanyName
,g.RegionName
,g.[Description]
,s2.DocumentId 
,d.CustomerName  
,c.ContractTypeId 


 
