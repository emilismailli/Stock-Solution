CREATE FUNCTION [Accounting].[IFnDocumentDetailReport]
(
	@documentId int
	
)
RETURNS TABLE AS RETURN
(
	
	
	SELECT  dd.[Id]  
	 ,dd.[DocumentId] 
	 ,d.ContractId
	 ,c.ContractTypeId
	 ,c.CompanyId
	 ,comp.CompanyName
	 ,c.CustomerId
	 ,cust.CustomerName
	 

	 ,d.PaymentTypeId
	 ,pt.Name PaymentTypeName

	 ,dd.AccountId
	 ,a.ParentId AccountParentId
	 ,a.Code AccountCode
	 ,a.Name AccountName
     ,dd.[GoodId] 
	 ,g. [GoodName] 
	 ,dd.BarCodeId
	 
	 ,g.[FullGoodName]
     ,dd.[Series] 
     ,dd.[DateOfProduction] 
     ,dd.[LastExpirationDate] 
     ,dd.[Quantity] 
	 ,dd.[UnitId]
	 ,u.Name UnitName
     ,dd.[PriceBuy] 
     ,dd.[PriceRetail]
     ,dd.[PriceWholeSale] 
     ,dd.[AmountBuy]
     ,dd.[AmountRetail]
     ,dd.[AmountWholeSale]
	 ,dd.[Percent]
	 ,dd.[CostInclude]
	 ,dd.[CostDeficit]
	 ,dd.DiscountPrice
	
	FROM [Accounting].[DocumentDetail] dd
	left join Accounting.Document d on dd.DocumentId=d.Id
	left join Accounting.[Contract] c on c.Id=d.ContractId
	left join [Accounting].[VwGood] g on dd.GoodId=g.Id
	left join [Accounting].[Account] a on dd.AccountId=a.Id
	left join [dbo].[Unit] u on dd.UnitId=u.Id
	left join [Accounting].[Barcode] b on dd.BarcodeId=b.Id
	left join Accounting.Company comp on d.CompanyId=comp.Id
	left join Accounting.Customer cust on c.CustomerId=cust.Id
	left join Accounting.PaymentType pt on d.PaymentTypeId=pt.Id 
	
	WHERE DocumentId=@documentId and d.DeleteId is null
)