CREATE FUNCTION [Accounting].[IFnLogisticDetailReport]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT
	
	ld.[BarcodeId]   
	,ld.[LogisticId]  
    ,ld.[GoodId]  
	,g.FullGoodName
	,ld.[Quantity]  
	,ld.[UnitId]  
	,u.Name
	,ld.[Description]  
	FROM [Accounting].[LogisticDetail] ld


	left join [Accounting].[VwGood] g on ld.GoodId=g.Id 
	left join [dbo].[Unit] u on ld.UnitId=u.Id 
 where LogisticId=@id
)
