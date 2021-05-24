CREATE VIEW [Accounting].[VwDocumentDetailTmp]
	AS SELECT 
	  ddTemp.[Id] 
	 ,ddTemp.GoodId StoGoodId
	 ,ddTemp.[DocumentTmpId]
	 ,d.ContractId
	 ,c.ContractTypeId
	 ,c.CompanyId
	 ,comp.CompanyName
	 ,c.CustomerId
	 ,cust.CustomerName
	 ,ddTemp.AccountId
	 ,a.ParentId AccountParentId
	 ,a.Code AccountCode
	 ,a.Name AccountName
     ,ddTemp.[GoodId] 
	 ,g. [GoodName]
	 ,ddTemp.BarCodeId
	 ,g.[FullGoodName]
     ,ddTemp.[Series] 
     ,ddTemp.[DateOfProduction] 
     ,ddTemp.[LastExpirationDate] 
     ,ddTemp.[Quantity] 
	 ,ddTemp.[UnitId]
	 ,u.Name UnitName
     ,ddTemp.[PriceBuy] 
     ,ddTemp.[PriceRetail]
     ,ddTemp.[PriceWholeSale] 
     ,ddTemp.[AmountBuy]
     ,ddTemp.[AmountRetail]
     ,ddTemp.[AmountWholeSale]
	 --,ddTemp.[Payment]
	 --,ddTemp.[Deficit]

	
	FROM [Accounting].[DocumentDetailTmp] ddTemp
	left join Accounting.DocumentTmp d on ddTemp.DocumentTmpId=d.Id
	left join Accounting.[Contract] c on c.Id=d.ContractId
	left join [Accounting].[VwGood] g on ddTemp.GoodId=g.Id
	left join [Accounting].[Account] a on ddTemp.AccountId=a.Id
	left join [dbo].[Unit] u on ddTemp.UnitId=u.Id
	left join [Accounting].[Barcode] b on ddTemp.BarcodeId=b.Id
	left join Accounting.Stock sto on ddTemp.Id=sto.GoodId
	left join Accounting.Company comp on d.CompanyId=comp.Id
	left join Accounting.Customer cust on c.CustomerId=cust.Id

	

