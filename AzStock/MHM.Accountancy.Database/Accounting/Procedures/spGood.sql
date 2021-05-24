create procedure [Accounting].[spGood]
@operationType tinyint=null,
@userId int,
@id int =null,
@barcodeId bigint=null,
@documentDetailId int=null,
@goodName nvarchar(200)= null,
@goodTypeId int = null,
@regionId int =null,
@manufacturerCompanyId int =null,
@unitId int=null,
@doseId int=null,
@packingTypeId int=null,
@description nvarchar(500)=null,
@goodCode nvarchar(200)=null,

  @photo varbinary(max)=null,
@docTypeId int =null,
@docCertId int =null,
@docSeriesId int=null,
@isFiltered bit=1,
@detail [Accounting].[UddtBarcodeGood] readonly,
@images [Accounting].[UdttImagesGood] readonly
with encryption
as
begin 
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in(3,13)
goto spDelete;
else if @operationType=4
goto spSelect;

spAdd:
begin 
begin transaction
insert into  [Accounting].[Good]([BarcodeId],[GoodName],[DocumentDetailId],[GoodTypeId],[ManufacturerCompanyId],[RegionId],[UnitId],[DoseId],[PackingTypeId],[Description],[GoodCode],[Photo],[CreateId],[DocTypeId],[DocCertId],[DocSeriesId])
VALUES (@barcodeId,@goodName,@documentDetailId,@goodTypeId,@manufacturerCompanyId,@regionId,@unitId,@doseId,@packingTypeId,@description,@goodCode,@Photo,@userId,@docTypeId,@docCertId,@docSeriesId);

set @id=SCOPE_IDENTITY();

DECLARE @barcode NVARCHAR(20),@barId int

SELECT @barcode=Barcode FROM @detail

INSERT into [Accounting].[Barcode]([GoodId],[Barcode])
SELECT @id,Barcode
from @detail
 
SELECT @barId= Id FROM Barcode WHERE GoodId=@id AND Barcode=@barcode
UPDATE  Accounting.Good
SET 
BarcodeId=@barId
WHERE Id=@id

insert into [Accounting].[ImagesGood]([GoodId],[IsMain],[Image])
select @id,[IsMain],[Image]  
from @images


if @@TRANCOUNT>0
commit;

if @operationType=11 goto spSelect;
return 0
end
spEdit:
begin
begin transaction

update [Accounting].[Good]
set
[GoodName]=@goodName
,[DocumentDetailId]=@documentDetailId
,[GoodTypeId]=@goodTypeId
,[RegionId]=@regionId
,[ManufacturerCompanyId]=@manufacturerCompanyId
,[UnitId]=@unitId
,[DoseId]=@doseId
,[PackingTypeId]=@packingTypeId
,[Description]=@description
,[GoodCode]=@goodCode
 , [Photo]=@photo
,[DocTypeId]=@docTypeId
,[DocCertId]=@docCertId
,[DocSeriesId]=@docSeriesId
,[ModifyId]=@userId
,[ModifyDate]=GETDATE()

WHERE id=@id

merge [Accounting].[Barcode] target
using (select [Id],[Barcode],@id [GoodId] 
from @detail ) source on target.Id=source.Id
when MATCHED and target.GoodId=@id THEN UPDATE SET  [GoodId]=source.[GoodId],[Barcode]=source.[Barcode]
when NOT MATCHED BY target then insert (GoodId,Barcode)
values (@id,[Barcode])
when not matched  by source and  target.GoodId=@Id then update set  [DeleteId]=@userId,[DeleteDate]=getdate();

if @@TRANCOUNT>0
commit;

if @operationType=12 goto spSelect;
return 0
end

spDelete:
begin 
update Accounting.Barcode
set [DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

update Accounting.ImagesGood
set [DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;


update [Accounting].[Good]
set [DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect
return 0
end
spSelect:

select  
g.[Id]
,B.[Id] BarcodeId
,b.Barcode
,g.[GoodName]
,g.[FullGoodName]
,g.[DocumentDetailId]
,g.[GoodTypeId]
,g.[GoodTypeName]
,g.[RegionId]
,g.[RegionName]
,g.[ManufacturerCompanyId]
,g.[ManufacturerCompanyName]
,g.[UnitId]
,g.[UnitName]
,g.[DoseId]
,g.[DoseName]
,g.[PackingTypeId]
,g.[PackingTypeName]
,g.[Description]
,g.[GoodCode]
,g.[Photo]
      ,g.[CreateId]
      ,g.[CreateDate]
      ,g.[DocTypeId]
      ,g.[DocCertId]
      ,g.[DocSeriesId]

from [Accounting].[VwGood] g

left join [Accounting].[Barcode] B ON G.Id=b.GoodId
left join [Accounting].[ImagesGood]  ig on g.Id=ig.GoodId
group by 
g.[Id]

,b.[Id] 
,b.Barcode
,g.[GoodName]
,g.[FullGoodName]
,g.[DocumentDetailId]
,g.[GoodTypeId]
,g.[GoodTypeName]
,g.[RegionId]
,g.[RegionName]
,g.[ManufacturerCompanyId]
,g.[ManufacturerCompanyName]
,g.[UnitId]
,g.[UnitName]
,g.[DoseId]
,g.[DoseName]
,g.[PackingTypeId]
,g.[PackingTypeName]
,g.[Description]
,g.[GoodCode]
,g.[Photo]
      ,g.[CreateId]
      ,g.[CreateDate]
      ,g.[DocTypeId]
      ,g.[DocCertId]
      ,g.[DocSeriesId]
return 0 
end