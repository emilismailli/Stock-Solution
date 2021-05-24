CREATE PROCEDURE [Accounting].[spCashToMoney]
	@userId int =null,
	@cashId INT =null
AS
	select * from Accounting.Cash c where  c.Id<>@cashId
RETURN 0
