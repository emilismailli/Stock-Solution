CREATE FUNCTION [Accounting].[IFnLogisticDetail]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  [Accounting].[LogisticDetail]  where LogisticId=@id
)
