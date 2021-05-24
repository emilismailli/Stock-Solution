CREATE PROCEDURE [Accounting].[spBank]
@userId int,
@operationType tinyint = NULL,
@groupId int=null,
@name nvarchar(200)=null,
@swift nvarchar(200)=null,
@voen varchar(70)=null,
@currencyId int=null,
@cityId int=null,
@docTypeId int =null,
@docCertId int =null,
@docSeriesId int=null,
@isFiltered bit=1,
@id int=NULL
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
insert into [Accounting].[Bank] ([GroupId],[Name],[Swift],[Voen],[CurrencyId],[CityId],[CreateId],[DocTypeId],[DocSeriesId],[DocCertId])
values(@groupId,@name,@swift,@voen,@currencyId,@cityId,@userId,@docTypeId,@docSeriesId,@docCertId);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].[Bank]
set
[GroupId]=@groupId,
[Name]=@name,
[Swift]=@swift,
[Voen]=@voen,
[CurrencyId]=@currencyId,
[CityId]=@cityId,
[DocTypeId]=@docTypeId,
[DocSeriesId]=@docSeriesId,
[DocCertId]=@docCertId,
[UpdateId]=@userId,
[UpdateDate]=GETDATE()
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[Bank]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [Accounting].[VwBank] where (@isFiltered=0 OR (@isFiltered=1 and isnull([DocTypeId],0) <>1)) and [DeleteId] is null;
RETURN 0
end
