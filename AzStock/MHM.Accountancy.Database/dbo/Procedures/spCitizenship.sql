CREATE PROCEDURE [dbo].[spCitizenship]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
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
insert into [dbo].[Citizenship]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[Citizenship]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[Citizenship]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwCitizenship]
RETURN 0
end
