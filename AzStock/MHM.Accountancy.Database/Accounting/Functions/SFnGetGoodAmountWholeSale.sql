CREATE FUNCTION [Accounting].[SFnGetGoodAmountWholeSale]
(
	@id int
)
RETURNS decimal(26,6)
AS
BEGIN
	RETURN 
	(
		select top (1) PriceWholeSale *Quantity AmountWholeSale from Accounting.DocumentDetail d where GoodId=@id
		order by d.CreateDate desc
	)
END
