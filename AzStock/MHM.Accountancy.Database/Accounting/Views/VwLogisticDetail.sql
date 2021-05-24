CREATE VIEW [Accounting].[VwLogisticDetail]
	AS SELECT
	
	 ld.[Id]  
	,ld.[BarcodeId]   
	,ld.[LogisticId]  
    ,ld.[GoodId]  
	,g.Id LogGoodId
	,g.FullGoodName
	,ld.[Quantity]  
	,ld.[UnitId]  
	,u.Name
	,ld.[Description]  
	FROM [Accounting].[LogisticDetail] ld


	left join [Accounting].[VwGood] g on ld.GoodId=g.Id 
	left join [dbo].[Unit] u on ld.UnitId=u.Id 
