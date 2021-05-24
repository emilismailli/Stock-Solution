CREATE FUNCTION [Accounting].[IFnAmountPricesByGoodId]
(
	@id int
)
RETURNS TABLE
AS
return (
select Quantity,PriceBuy,PriceRetail,PriceWholeSale,PriceBuy * Quantity AmountBuy,PriceRetail* Quantity AmountRetail,PriceWholeSale * Quantity AmountWholeSale ,Payment,Deficit
	from accounting.DocumentDetail  where id=(select max(Id)  from Accounting.DocumentDetail where GoodId=@id)
)
