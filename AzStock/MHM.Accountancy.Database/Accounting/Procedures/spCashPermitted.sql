CREATE PROCEDURE [dbo].[spCashPermitted]
	@userId int,@menuId int
	AS
	BEGIN
SELECT ch.*,cast((CASE WHEN cmc.Id IS NOT NULL THEN cmc.Allow 
WHEN cmc.Id IS NULL then 0 ELSE 0 END



)AS bit) Allow,cmc.UserId,cmc.MenuId FROM Accounting.Cash ch




LEFT JOIN dbo.CashMenuCollection cmc ON cmc.CashId=ch.Id AND cmc.UserId=@userId AND cmc.MenuId=@menuId
end