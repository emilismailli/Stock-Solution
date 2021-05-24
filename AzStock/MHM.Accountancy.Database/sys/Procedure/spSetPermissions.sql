CREATE PROCEDURE [dbo].[spSetPermissions]
@userId int,
	@principialId int ,
	@permission  dbo.[UddtSetPermissions] readonly

AS

begin

merge 	 dbo.MenuUserAccess target
using (select Id, AllowShow, AllowCreate, AllowUpdate, AllowDelete, AllowInContainer,AllowRetail,AllowApplyDocument,ShowCreate,ShowUpdate,ShowDelete,ShowApplyDocument
 from @permission) source on target.MenuItemId=source.Id and target.UserId=@principialId
when MATCHED and target.UserId=@principialId THEN



update set Show=source.AllowShow
,[Create]=source.AllowCreate
,[Update]=source.AllowUpdate
,[Delete]=source.AllowDelete
,AllowInContainer=source.AllowInContainer
,AllowRetail=source.AllowRetail
,ApplyDocument=source.AllowApplyDocument
,ShowCreate=source.ShowCreate
,ShowUpdate=source.ShowUpdate
,ShowDelete=source.ShowDelete 
,ShowApplyDocument=source.ShowApplyDocument
when NOT MATCHED BY target then 



insert (MenuItemId,UserId, [Show], [Create], [Update], [Delete],ApplyDocument, AllowInContainer,AllowRetail,ShowCreate,ShowUpdate,ShowDelete,ShowApplyDocument)
values(Id,@principialId ,AllowShow,AllowCreate,AllowUpdate,AllowDelete,AllowApplyDocument,AllowInContainer,AllowRetail,ShowCreate,ShowUpdate,ShowDelete,ShowApplyDocument);

RETURN 0
end
GO

