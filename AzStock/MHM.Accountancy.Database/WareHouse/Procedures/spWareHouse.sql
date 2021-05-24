CREATE PROCEDURE [WareHouses].[spWareHouse]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@wareHouseTypeId int=null,
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
insert into [WareHouses].[WareHouse]([Name],[WareHouseTypeId],[Description])
values(@name,@wareHouseTypeId,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [WareHouses].[WareHouse]
set
[Name]=case when @name is null then [Name] else @name end,
[WareHouseTypeId]= case when @wareHouseTypeId  is null then  [WareHouseTypeId] else  @wareHouseTypeId end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [WareHouses].[WareHouse]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [WareHouses].[VwWareHouse]
RETURN 0
end

