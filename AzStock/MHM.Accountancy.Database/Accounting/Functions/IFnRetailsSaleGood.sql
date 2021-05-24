CREATE FUNCTION [Accounting].[IFnRetailsSaleGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.VwDocumentDetail where DocumentId=@id
)
