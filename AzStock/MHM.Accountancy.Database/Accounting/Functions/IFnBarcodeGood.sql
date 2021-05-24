CREATE FUNCTION [Accounting].[IFnBarcodeGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.Barcode where Id=@id
)