 --CREATE FUNCTION [Accounting].[SFnGetGoodPriceInclude]
--(
--	@id int
--)
--RETURNS decimal(26,6)
--AS
--BEGIN
--	RETURN 
--	(
--		select top (1) PriceBuy from Accounting.DocumentDetail d where GoodId=@id
--		order by d.CreateDate desc
--	)
--END



CREATE FUNCTION [Accounting].[IFnBuyPricesByGoodId]
(
	@id int
)
RETURNS TABLE
AS
return (
select PriceBuy,PriceRetail,PriceWholeSale,AmountBuy,AmountRetail,AmountWholeSale ,Payment,Deficit
	from Accounting.DocumentDetail  WHERE id=(select max(Id)  from Accounting.DocumentDetail where GoodId=@id AND AccountId=3 and DeleteId is null)
)

