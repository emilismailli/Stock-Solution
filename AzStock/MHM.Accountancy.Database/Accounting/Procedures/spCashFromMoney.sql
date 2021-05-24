CREATE PROCEDURE [Accounting].[spCashFromMoney]
	@userId int =null,
	@menuId INT =null
AS
BEGIN
	SELECT ch.Id,ch.CashName 
	
	
	FROM Accounting.Cash ch


--JOIN dbo.CashMenuCollection cmc ON ch.Id = cmc.CashId


--AND cmc.Allow=1 
--AND cmc.UserId=@userId 
--AND cmc.MenuId=@menuId

END