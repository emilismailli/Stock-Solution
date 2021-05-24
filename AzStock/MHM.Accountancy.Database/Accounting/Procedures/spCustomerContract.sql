CREATE PROCEDURE [Accounting].[spCustomerContract]
@userId int,
@operationType tinyint,
@id int=null,
@customerName NVARCHAR(200) =NULL, 
@customerLeader NVARCHAR(200) =NULL, 
@workTypeId INT =NULL, 
@voen NVARCHAR(50) =NULL, 
@currencyId INT =NULL, 
@bankId INT =NULL, 
@bankSwift NVARCHAR(200) =NULL, 
@regionId int =null,
@legalAddress NVARCHAR(200) =NULL, 
@actualAddress NVARCHAR(200) =NULL, 
@email NVARCHAR(200) =NULL, 
@tel NVARCHAR(200) =NULL, 
@date datetime =NULL,
@description nvarchar(500) =NULL,
@parentId int =null,
@typeId INT =NULL,
@docTypeId int =null,
@docCertId int =null,
@docSeriesId int=null,

@contract [Accounting].[UddtContractCustomer] readonly

with encryption
AS 
begin
set xact_abort on;
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
begin transaction
insert into [Accounting].[Customer]([CustomerName],[ParentId],[TypeId] ,[CustomerLeader],[WorkTypeId],[Voen] ,[CurrencyId] ,[BankId],[BankSwift]  ,[RegionId],[LegalAddress],[ActualAddress],[Email] ,[Tel],[Date],[Description],[CreateId],[DocTypeId],[DocCertId],[DocSeriesId])
values(@customerName,@parentId,@typeId,@customerLeader,@workTypeId,@voen,@currencyId,@bankId,@bankSwift,@regionId,@legalAddress,@actualAddress,@email,@tel,@date,@description,@userId,@docTypeId,@docCertId,@docSeriesId);

set @id=SCOPE_IDENTITY();

insert into [Accounting].[Contract]([CustomerId],[ContractDate],[CurrencyId],[OperationTypeId],[CompanyId],[ContractTypeId],[Description])
select @id,[ContractDate],[CurrencyId],[OperationTypeId] ,[CompanyId] ,[ContractTypeId],[Description] from @contract

if @@TRANCOUNT>0
   commit;


if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
begin transaction

UPDATE [Accounting].[Customer]
   SET
       
	   [CustomerName] = @customerName
	   ,[ParentId]=@parentId
	   ,[TypeId]=@typeId
      ,[CustomerLeader] = @customerLeader
      ,[WorkTypeId] = @WorkTypeId 
      ,[Voen] = @Voen
      ,[CurrencyId] = @CurrencyId
      ,[BankId] = @bankId
	  ,[BankSwift]=@bankSwift
	  ,[RegionId]=@regionId
      ,[LegalAddress] = @LegalAddress
      ,[ActualAddress] = @ActualAddress
      ,[Email] = @Email
      ,[Tel] = @Tel
      ,[Date] = @Date
      ,[Description] = @Description
      ,[UpdateId]=@userId
      ,[UpdateDate]= getdate()
      ,[DocTypeId]=@docTypeId
      ,[DocSeriesId]=@docSeriesId
      ,[DocCertId]=@docCertId

where Id=@id;

merge [Accounting].[Contract] target
using(select [Id],@id [CustomerId],[ContractDate],[ContractTypeId],[CurrencyId],[OperationTypeId],[CompanyId],[Description] 
from @contract) source on target.Id=source.Id
when MATCHED and target.CustomerId=@id THEN 
update 
set [CustomerId]=source.[CustomerId],[ContractDate]=source.[ContractDate],[ContractTypeId]=source.[ContractTypeId],[CurrencyId]=source.[CurrencyId],[OperationTypeId]=source.[OperationTypeId]
,[CompanyId]=source.[CompanyId],[Description]=source.[Description]
when NOT MATCHED BY target then 
insert ([CustomerId] ,[ContractDate] ,[ContractTypeId] ,[CurrencyId] ,[OperationTypeId]  ,[CompanyId],[Description])
values(@id ,[ContractDate],[ContractTypeId],[CurrencyId],[OperationTypeId],[CompanyId],[Description])
when NOT MATCHED BY source and target.CustomerId=@Id  then update set [DeleteId]=@userId,[DeleteDate]=getdate();

if @@TRANCOUNT>0
   commit;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[Customer]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end



spSelect:
select c.[Id]
      ,c.[CustomerName] 
	  ,c.[ParentId]
	  ,c.TypeId
	  ,c.TypeName
      ,c.[CustomerLeader]
      ,c.[Voen]
      ,c.[CurrencyId]
      ,c.[WorkTypeId]
      ,c.[WorkTypeName]
      ,c.[BankId]
	  ,c.[BankName]
	  ,c.[BankSwift]
	  ,c.[RegionId]
	  ,c.[RegionName]
      ,c.[LegalAddress]
      ,c.[ActualAddress]
      ,c.[Email]
      ,c.[Tel]
      ,c.[Date]
      ,c.[Description]
from [Accounting].[VwCustomer] c
join [Accounting].[Contract] co on c.id=co.CustomerId
group by 
       c.[Id]
      ,c.[CustomerName] 
	  ,c.[ParentId]
	  ,c.TypeId,c.TypeName
      ,c.[CustomerLeader]
      ,c.[Voen]
      ,c.[CurrencyId]
      ,c.[WorkTypeId]
      ,c.[WorkTypeName]
      ,c.[BankId]
	  ,c.[BankName]
	  ,c.[BankSwift]
	  ,c.[RegionId]
	  ,c.[RegionName]
      ,c.[LegalAddress]
      ,c.[ActualAddress]
      ,c.[Email]
      ,c.[Tel]
      ,c.[Date]
      ,c.[Description]
   select * from [Accounting].[VwCustomer] ;
RETURN 0
end
