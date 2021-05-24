CREATE FUNCTION [Accounting].[SFnGetGoodPriceWholeSale]
(
	@id int
)
RETURNS decimal(26,6)
AS
BEGIN
	RETURN 
	(
		select top (1) PriceWholeSale from Accounting.DocumentDetail d where GoodId=@id AND AccountId=3 and DeleteId is NULL
		order by d.CreateDate desc
	)
END
