create VIEW [Accounting].[VwWholeSaleReport]
	AS select
DD.GoodName
,dd.Quantity 
,dd.PriceWholeSale
,dd.AmountWholeSale
,dd.DocumentId
,d.CustomerName
,d.IncludeDate


 from Accounting.VwDocumentDetail dd

 left join Accounting.ContractType ct on ct.Id=dd.ContractTypeId 
 left join Accounting.VwDocument d on dd.DocumentId=d.Id

 where ContractTypeId=2