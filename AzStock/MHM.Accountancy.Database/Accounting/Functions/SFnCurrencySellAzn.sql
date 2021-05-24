CREATE FUNCTION [dbo].[SFnCurrencySellAzn]
(
	@currencyId int,
	@value decimal(26,6)
)
RETURNS decimal(26,6)
AS
BEGIN
	RETURN (select @value*Sell from [Accounting].[Currency] where id=@currencyId)
END