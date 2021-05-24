CREATE PROCEDURE [dbo].[spSetCashPermissions]
@userId int,
	@principialId int ,
	@permission  dbo.[UddtCashPermission] readonly

AS

begin

merge 	 dbo.CashMenuCollection target
using (select CashId,Allow,ReserveMenuId

 from @permission) source on target.MenuId=source.ReserveMenuId and target.UserId=@principialId AND target.CashId=source.CashId
when MATCHED and target.UserId=@principialId THEN
update set Allow=source.Allow,CashId=source.CashId,MenuId=source.ReserveMenuId
when NOT MATCHED BY target then 
insert (MenuId,UserId,Allow,CashId)
values(ReserveMenuId,@principialId,Allow,CashId);

RETURN 0
end