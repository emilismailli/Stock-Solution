CREATE VIEW [Accounting].[VwDocumentDetail]
	AS SELECT distinct
	 dd.[Id] 
	 ,dd.GoodId StoGoodId
	 ,dd.[DocumentId]
	 ,dd.[TotalId]
	 ,dd.PaymentId
	 ,r.[TotalAmount]
	 ,r.[TotalCost]
	 ,r.[TotalProfit]
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
	 ,b.Barcode
	 
	 ,g.[FullGoodName]
     ,dd.[Series] 
     ,dd.[DateOfProduction] 
     ,dd.[LastExpirationDate] 
     ,dd.[Quantity] 
     ,dd.[StoQuantity] 
	 ,dd.[UnitId]
	 ,u.Name UnitName
     ,dd.[PriceBuy] 
     ,dd.[PriceRetail]
     ,dd.[PriceWholeSale] 
     ,dd.[AmountBuy]
     ,dd.[AmountRetail]
     ,dd.[AmountWholeSale]
	 ,dd.[Payment]
	 ,dd.[Deficit] 
	 ,dd.[Description] 
	 --,dd.[DiscountPercent]
	,dd.[Percent] 
	,dd.[DiscountNumber]
	 ,dd.[CostInclude]
	 ,dd.[CostDeficit]
	 ,dd.[DiscountPrice]
	
	
	
	FROM [Accounting].[DocumentDetail] dd
	
	left join Accounting.Document d on dd.DocumentId=d.Id
	LEFT join Accounting.Payment p on dd.PaymentId=p.Id
	left join Accounting.[Contract] c on c.Id=d.ContractId
	left join [Accounting].[VwGood] g on dd.GoodId=g.Id
	left join [Accounting].[Account] a on dd.AccountId=a.Id
	left join [dbo].[Unit] u on dd.UnitId=u.Id
	left join [Accounting].[Barcode] b on dd.BarcodeId=b.Id
	left join Accounting.Stock sto on dd.GoodId=sto.GoodId
	left join Accounting.Company comp on d.CompanyId=comp.Id
	left join Accounting.Customer cust on c.CustomerId=cust.Id
	left join Accounting.PaymentType pt on d.PaymentTypeId=pt.Id
	left join Accounting.TotalReport r on dd.TotalId=r.Id 
	
