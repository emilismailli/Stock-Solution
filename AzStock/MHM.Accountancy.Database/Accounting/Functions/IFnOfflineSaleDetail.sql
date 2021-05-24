CREATE FUNCTION [Accounting].[IFnOfflineSaleDetail]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  [Accounting].[OfflineSaleDetail]  where LogisticId=@id
)
