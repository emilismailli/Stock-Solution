CREATE FUNCTION [dbo].[SFnCurrencyBuyAzn]
(
	@currencyId int,
	@value decimal(26,6)
)
RETURNS decimal(26,6)
AS
BEGIN
	RETURN (select @value*Buy from [Accounting].[Currency] where id=@currencyId)
END
