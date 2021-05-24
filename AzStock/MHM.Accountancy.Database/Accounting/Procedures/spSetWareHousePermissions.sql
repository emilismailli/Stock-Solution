CREATE PROCEDURE [dbo].[spSetWareHousePermissions]
@userId int,
	@principialId int ,
	@permission  dbo.[UddtWareHousePermission] readonly

AS

begin

merge 	 dbo.WarehouseMenuCollection target
using (select WareHouseId,Allow,ReserveMenuId
 from @permission) source on target.MenuId=source.ReserveMenuId and target.UserId=@principialId AND target.WareHouseId=source.WareHouseId
when MATCHED and target.UserId=@principialId THEN
update set Allow=source.Allow,WareHouseId=source.WareHouseId,MenuId=source.ReserveMenuId
when NOT MATCHED BY target then 
insert (MenuId,UserId,Allow,WareHouseId)
values(ReserveMenuId,@principialId,Allow,WareHouseId);

RETURN 0
end