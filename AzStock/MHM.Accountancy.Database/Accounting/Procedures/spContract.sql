CREATE PROCEDURE [Accounting].[spContract]
@userId int,
@operationType tinyint,
	@contractName nvarchar(100) null,
	@contractDate datetime null,
	@contractNo int null,
	@currencyId int null,
	@operationTypeId int null,
	@description nvarchar(500) null,
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
insert into [Accounting].[Contract]([ContractName],[ContractDate],[ContractNo],[CurrencyId],[OperationType],[Description])
values(@contractName,@contractDate,@contractNo,@currencyId,@operationTypeId,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].[Contract]
set
[ContractName]= @contractName ,
[ContractDate]=@contractDate,
[ContractNo]=@contractNo,
[CurrencyId]=@currencyId,
[OperationType]=@operationTypeId,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[Contract]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [Accounting].[VwContract]
RETURN 0
end
