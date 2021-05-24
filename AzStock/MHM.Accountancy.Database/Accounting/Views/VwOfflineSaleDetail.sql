CREATE VIEW [Accounting].[VwOfflineSaleDetail]
	AS SELECT
	
	 ld.[Id]  
	,ld.[BarcodeId]   
	,ld.[LogisticId]  
    ,ld.[GoodId]  
	,ld.[PriceWholeSale] 
	,ld.[AmountWholeSale]
	,g.Id LogGoodId
	,g.FullGoodName
	,ld.[Quantity]  
	,ld.[UnitId]  
	,u.Name 
	,ld.[Description]  
	,ld.[Percent] 
	FROM [Accounting].[OfflineSaleDetail] ld


	left join [Accounting].[VwGood] g on ld.GoodId=g.Id 
	left join [dbo].[Unit] u on ld.UnitId=u.Id 
