CREATE PROCEDURE [dbo].[spRegion]
    @userId int,
    @operationType tinyint,
	@name nvarchar(100)=null,
	@parentId int=null,
	@regionTypeId int=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[Region]([Name],[ParentId],[RegionTypeId],[Description])
values(@name,@parentId,@regionTypeId,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[Region]
set
[Name]=case when @name is null then [Name] else @name end,
[ParentId]=@parentId,
[RegionTypeId]=@regionTypeId,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[Region]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwRegion]
RETURN 0
end
