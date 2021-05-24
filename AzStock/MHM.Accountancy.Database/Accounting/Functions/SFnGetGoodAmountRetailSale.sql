CREATE FUNCTION [Accounting].[SFnGetGoodAmountRetailSale]
(
	@id int
)
RETURNS decimal(26,6)
AS
BEGIN
	RETURN 
	(
		select top (1) PriceRetail * Quantity AmountRetail from Accounting.DocumentDetail d where GoodId=@id
		order by d.CreateDate desc
	)
END
