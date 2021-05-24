CREATE PROCEDURE [dbo].[spUserPermissions]
	@principalId int
AS
begin
select m.[Id]
      ,m.[ParentId]
      ,m.[Code]
      ,m.[Caption]
      ,m.[TypePath]
      ,m.[Parameters]
      ,m.[AllowNotify]
      ,m.[IconId]
      ,m.[OrderNumber] 
	  ,cast(case when  ma.Show is null then 0 else ma.Show end as bit)  AllowShow
	  ,cast(case when  ma.[Create] is null then 0 else ma.[Create] end as bit)  AllowCreate
	  ,cast(case when  ma.[Update] is null then 0 else ma.[Update] end as bit)  AllowUpdate
	  ,cast(case when  ma.[Delete] is null then 0 else ma.[Delete] end as bit)  AllowDelete
	  ,cast(case when  ma.[ApplyDocument] is null then 0 else ma.[ApplyDocument] end as bit)  AllowApplyDocument
	  ,cast(case when  ma.[ShowCreate] is null then 0 else ma.[ShowCreate] end as bit)  ShowCreate
	  ,cast(case when  ma.[ShowUpdate] is null then 0 else ma.[ShowUpdate] end as bit)  ShowUpdate
	  ,cast(case when  ma.[ShowDelete] is null then 0 else ma.[ShowDelete] end as bit)  [ShowDelete]
	  ,cast(case when  ma.ApplyDocument is null then 0 else ma.ApplyDocument end as bit)  [ShowApplyDocument]
	  ,cast(case when  ma.AllowInContainer is null then 0 else ma.AllowInContainer end as bit)  AllowInContainer
	  ,cast(case when  ma.AllowRetail is null then 0 else ma.AllowRetail end as bit)  AllowRetail
	  from [dbo].[Menu] m
      left join [dbo].[MenuUserAccess] ma on m.Id=ma.MenuItemId and isnull(ma.UserId,@principalId)=@principalId
RETURN 0
end