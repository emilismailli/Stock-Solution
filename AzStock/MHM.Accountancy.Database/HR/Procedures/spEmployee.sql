CREATE PROCEDURE [HR].[spEmployee]
@userId int,
@operationType tinyint,
@parentId int=null,
@personId int=null,
@departmentId int=null,
@positionId int=null,
@startDate datetime=null,
@endDate datetime=null,
@salary decimal(26,6)=null,
--@orderInId int=null,
@orderInNo varchar(100)=null,
@orderInDate datetime=null,
@orderInBase nvarchar(500)=null,
@orderOutId int=null,
@isStaff bit=null,
@staffTypeId int=null,
@description nvarchar(500)=null,
@workEmail nvarchar(250)=null,
@workPhone nvarchar(250)=null,
@statusId int=null,
@docTypeId   int=NULL,
@docCertId  int=NULL,
@docSeriesId int=NULL,
@isFiltered bit=1,
@id int=null
with encryption
AS
begin

if @id is not null and @parentId=@id
set @parentId=null;

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
insert into [HR].[VwEmployee]([ParentId],[PersonId],[DepartmentId],[PositionId],[StartDate],[EndDate],[Salary],[OrderInNo],[OrderInDate],[OrderInBase],[OrderOutId],[IsStaff],[StaffTypeId],[Description],[WorkEmail],[WorkPhone],[StatusId],[DocType],[DocCert],[DocSeries],[CreatedUser])
values(@parentId,@personId,@departmentId,@positionId,@startDate,@endDate,@salary,@orderInNo,@orderInDate,@orderInBase,@orderOutId,@isStaff,@staffTypeId,@description,@workEmail,@workPhone,@statusId,@docTypeId,@docCertId,@docSeriesId,@userId);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
--update [HR].[Employee]
--set
--[ParentId]=@parentId,
--[PersonId]=case when @personId is not null then @personId else [PersonId] end,
--[PositionId]=@positionId,
--[StartDate]=case when @startDate is not null then @startDate else [StartDate] end,
--[EndDate]=case when @endDate is not null then @endDate else [EndDate] end,
--[Salary]=case when @salary is not null then @salary else [Salary] end,
----[OrderInId]=case when @orderInId is not null then @orderInId else [OrderInId] end,
--[OrderOutId]=case when @orderOutId is not null then @orderOutId else [OrderOutId] end,
--[IsStaff]=@isStaff,
--[StaffTypeId]=@staffTypeId,
--[Description]=@description,
--[WorkEmail]=@workEmail,
--[WorkPhone]=@workPhone,
--[StatusId]=case when @statusId is not null then @statusId else [StatusId] end,
--[DocType]=@docTypeId,
--[DocCert]=@docCertId,
--[DocSeries]=@docSeriesId,
--[UpdatedUser]=@userId,
--[UpdatedDate]=getdate()
--where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [HR].[Employee]
set
[DeletedUser]=@userId,
[DeletedDate]=getdate()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [HR].[VWEmployee] where @isFiltered=0 OR (@isFiltered=1 and isnull([DocType],0) <>1) and DeletedDate is null
RETURN 0
end
