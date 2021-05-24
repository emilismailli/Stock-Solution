CREATE FUNCTION [Accounting].[IFnImageGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  [Accounting].[ImagesGood]  where GoodId=@id
)
