CREATE FUNCTION [Accounting].[IFnReturnRetailSaleGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.VwDocumentDetail where DocumentId=@id
)
