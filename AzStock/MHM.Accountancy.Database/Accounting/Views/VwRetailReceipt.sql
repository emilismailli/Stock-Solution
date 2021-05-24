CREATE VIEW [Accounting].[VwRetailReceipt]
	AS SELECT
	 rr.Id
	 ,rr.GoodId
	 ,g.FullGoodName
	 ,g.Barcode
	 ,rr.BarcodeId
	 ,rr.Quantity
	 ,rr.StatusId
	 ,s.StatusName
	 ,rr.CreateId
	 ,rr.CreateDate,
	 rr.InfoJson 
	 
	
	
	 FROM [Accounting].[RetailReceipt] rr
	 join Accounting.VwGood g on g.Id=rr.GoodId
	 join Accounting.[ReceiptsStatus] s ON s.Id=rr.StatusId 
