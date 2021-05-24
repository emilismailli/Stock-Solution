CREATE FUNCTION [Accounting].[IFnPricesByGoodId]
(
	@id int
)
RETURNS TABLE
AS
return (
select 


--isnull  (PriceBuy,0)
PriceBuy


,PriceRetail,PriceWholeSale,AmountBuy,AmountRetail,AmountWholeSale ,Payment,Deficit
	from Accounting.DocumentDetail  where id=(select max(Id)  from Accounting.DocumentDetail where GoodId=@id AND AccountId=3 and DeleteId is null)
)
