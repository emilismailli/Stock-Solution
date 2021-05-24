CREATE VIEW [Accounting].[VwRetailSale]
	AS SELECT 
	 rs.BarcodeId
	 ,b.Barcode
	 ,dd.[DocumentId]
	 ,dd.AccountId
	 ,a.Name AccountName
     ,dd.[GoodId] 
	 ,dd.[FullGoodName]
     ,dd.[Quantity] 
     ,dd.[PriceRetail]
	 ,dd.[PriceBuy]
	 ,dd.[PriceWholeSale]
	 ,rs.[Percent]
	 ,rs.[DiscountNumber]
	FROM [Accounting].[VwDocumentDetail] dd
	left join Accounting.RetailSale rs on rs.DocumentDetailId=dd.Id
	left join [Accounting].[VwGood] g on dd.GoodId=g.Id
	left join [Accounting].[Account] a on dd.AccountId=a.Id
	left join [dbo].[Unit] u on dd.UnitId=u.Id
	left join [Accounting].[Barcode] b on rs.BarcodeId=b.Id
	left join Accounting.Stock sto on dd.GoodId=sto.GoodId
	where dd.AccountId=8
