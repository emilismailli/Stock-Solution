CREATE VIEW [Accounting].[VwIncludeReport]
	AS select
DD.GoodName
,dd.Quantity
,dd.PriceBuy  
,dd.AmountBuy
,dd.DocumentId

,d.CustomerName
,d.IncludeDate
,d.WareHouseId
,d.WareHouseName


 from Accounting.VwDocumentDetail dd

 left join Accounting.ContractType ct on ct.Id=dd.ContractTypeId 
 left join Accounting.VwDocument d on dd.DocumentId=d.Id

 where ContractTypeId=1
