
CREATE FUNCTION [Accounting].[IFnBuyAmountByGoodId]
(
	@id int
)
RETURNS TABLE
AS
return (
select PriceBuy,PriceRetail,PriceWholeSale,PriceBuy * Quantity AmountBuy,AmountRetail,AmountWholeSale ,Payment,Deficit
	from accounting.DocumentDetail  where id=(select max(Id)  from Accounting.DocumentDetail where GoodId=@id)
)

