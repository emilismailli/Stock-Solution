CREATE PROCEDURE [dbo].[spMenuPermitted]
@userId int,@forRepermission bit=0
AS
begin

declare @groupId int=null
select @groupId = GroupId from [dbo].[VwSysMember] where UserId=@userId -- istifadecinin qrupunu tapmaq

;WITH cteGroupped AS (
  select distinct [Id],[ParentId],ParentId GroupId
  from [dbo].[Menu] m
  where m.Id in (select MenuItemId from [dbo].[MenuUserAccess] where UserId=@userId  and isnull(Show,0)=1) or  @forRepermission=1
    
  union all
  
  SELECT  m.[Id],m.[ParentId],isnull(g.GroupId,g.Id) GroupId/*, Lavel +1 Lavel*/ 
  FROM cteGroupped g
  inner join [dbo].[Menu] AS m ON m.Id=g.[ParentId]
)
,permission as (
select  top(case when isnull(@groupId,0)=2 or  @forRepermission=1 then 1 else 0 end/*superadmindirse gruplar  tabin gorsun*/) 
20000 Id,1 ParentId,'Groups' [Caption],'group' [TypePath],null [AllowNotify],0 [OrderNumber]
,null Code,null IconId,0 [Parameters],1 GroupId
union
select Id,20000 ParentId,[Name] [Caption],'group' [TypePath],null [AllowNotify],0 [OrderNumber]
,null Code,null IconId,20000 [Parameters],1 GroupId
from [dbo].[VwSysGroup]
where isnull(@groupId,0)=2--superadmindirse gruplari gorsun
 or  @forRepermission=1
union 
select top(case when isnull(@groupId,0)=2 or  @forRepermission=1 then 1 else 0 end/*superadmindirse userler tabin gorsun*/) 
21000 Id,1 ParentId,'Users' [Caption],'user' [TypePath],null [AllowNotify],0 [OrderNumber]
,null Code,null IconId,1 [Parameters],1 GroupId
union
select Id,21000 ParentId,[Name] [Caption],'user' [TypePath],null [AllowNotify],0 [OrderNumber]
,null Code,null IconId,21000 [Parameters],1 GroupId
from [dbo].[VwSysMember]
where isnull(@groupId,0)=2--superadmindirse userlerin siyahisini gorsun
 or  @forRepermission=1
)
,menus as (
SELECT m.Id
	  ,isnull(m.ParentId,0) ParentId
      ,m.[Caption]
      ,m.[TypePath]
      ,m.[AllowNotify]
      ,isnull(m.[OrderNumber],200) [OrderNumber]
	  ,m.Code
	  ,m.IconId
	  ,m.[Parameters]
	  ,g.GroupId
FROM cteGroupped g
join [dbo].[Menu] m on g.Id=m.Id


union all
SELECT m.Id
	  ,isnull(m.ParentId,0) ParentId
      ,m.[Caption]
      ,m.[TypePath]
      ,m.[AllowNotify]
      ,isnull(m.[OrderNumber],200) [OrderNumber]
	  ,m.Code
	  ,m.IconId
	  ,m.[Parameters]
	  ,g.GroupId
FROM cteGroupped g
join [dbo].[Menu] m on g.Id=m.Id
join menus mm on mm.ParentId=m.Id
)

select m.Id
	  ,isnull(m.ParentId,0) ParentId
      ,m.[Caption]
      ,m.[TypePath]
      ,m.[AllowNotify]
      ,isnull(m.[OrderNumber],200) [OrderNumber]
	  ,m.Code
	  ,m.IconId
	  ,m.[Parameters]
	  ,max(GroupId) GroupId from menus m
group by m.Id,isnull(m.ParentId,0),m.[Caption]
      ,m.[TypePath]
      ,m.[AllowNotify]
	  ,isnull(m.[OrderNumber],200)
	  ,m.Code
	  ,m.IconId
	  ,m.[Parameters]
union
select * from permission


end

 
