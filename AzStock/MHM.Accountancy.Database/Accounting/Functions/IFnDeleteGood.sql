CREATE FUNCTION [Accounting].[IFnDeleteGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.VwDocumentDetail where DocumentId=@id
)
