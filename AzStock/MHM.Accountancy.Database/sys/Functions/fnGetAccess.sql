CREATE FUNCTION [dbo].[fnGetAccess](@userId int,@managerId int)
RETURNS TABLE 
AS
RETURN 
(
  select cast(case when  ma.Show is null then 0 else ma.Show end as bit)  AllowShow
	  ,cast(case when  ma.[Create] is null then 0 else ma.[Create] end as bit)  AllowCreate
	  ,cast(case when  ma.[Update] is null then 0 else ma.[Update] end as bit)  AllowUpdate
	  ,cast(case when  ma.[Delete] is null then 0 else ma.[Delete] end as bit)  AllowDelete
	  ,cast(case when  ma.[ApplyDocument] is null then 0 else ma.[ApplyDocument] end as bit)  AllowApplyDocument
	  ,cast(case when  ma.[ShowCreate] is null then 0 else ma.[ShowCreate] end as bit)  [ShowCreate]
	  ,cast(case when  ma.[ShowUpdate] is null then 0 else ma.[ShowUpdate] end as bit)  [ShowUpdate]
	  ,cast(case when  ma.[ShowDelete] is null then 0 else ma.[ShowDelete] end as bit)  [ShowDelete]
	  ,cast(case when  ma.[ShowApplyDocument] is null then 0 else ma.[ShowApplyDocument] end as bit)  [ShowApplyDocument]
      from [dbo].[MenuUserAccess] ma where UserId=@userId and MenuItemId=@managerId
)