CREATE FUNCTION [Accounting].[IFnSaleGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.VwDocumentDetail where DocumentId=@id
)
