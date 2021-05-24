CREATE VIEW [Accounting].[VwBarcode]
	AS 
	SELECT 
	 b.[Id]
	,b.[GoodId]
	,g.[FullGoodName]
	,b.[Barcode]
	,g.Quantity
	
	
	
	FROM [Accounting].[Barcode] b
	left join Accounting.VwGood g on b.Id=g.BarcodeId
	--where g.Quantity >0
