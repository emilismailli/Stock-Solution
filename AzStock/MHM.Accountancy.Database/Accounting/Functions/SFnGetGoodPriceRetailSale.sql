CREATE FUNCTION [Accounting].[SFnGetGoodPriceRetailSale]
(
	@id int
)
RETURNS decimal(26,6)
AS
BEGIN
	RETURN 
	(
		select top (1) PriceRetail from Accounting.DocumentDetail d where GoodId=@id AND AccountId=3 and DeleteId is null
		order by d.CreateDate desc
	)
END
