CREATE PROCEDURE [Accounting].[spCash] 
    @userId int,
    @operationType tinyint,
	@companyId int =null,
	@cashName nvarchar(100)=null,
	--@wareHouseId int=null, 
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
insert into [Accounting].[Cash] (CompanyId,[CashName],  [Description],CreateId)
values(@companyId,@cashName,  @description,@userId);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update Accounting.Cash
set
[CashName]=case when @cashName is null then [CashName] else @cashName end,
CompanyId=@companyId,
--WareHouseId=@wareHouseId,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update Accounting.Cash
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from Accounting.VwCash
RETURN 0
end

