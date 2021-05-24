create  procedure [Accounting].[spCompany]

@userId int,
@operationType tinyint=null,
@privateNumber NVARCHAR(200)= null,
@companyName nvarchar(200) null,
@companyLeader NVARCHAR(200) null,
@workTypeId int,
@voen NVARCHAR(50) null,
@currencyId int null,
@operatorBankId int null,
@bankSwift NVARCHAR(200) null,
@legalAddress nvarchar(200) null,
@actualAddress nvarchar(200) null,
@email nvarchar(200) null,
@tel NVARCHAR(200) null,
@contractNumber nvarchar(100)=null,
@contractDate  datetime=null,

@date datetime null,
@description nvarchar(500)=null,
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
insert into [Accounting].[Company] ([PrivateNumber],[CompanyName],[CompanyLeader],[WorkTypeId],[Voen]
,[CurrencyId],[OperatorBankId],[BankSwift],[Date],[LegalAddress],[ActualAddress]
,[Email],[Tel],[ContractNumber],[ContractDate],[Description],[DocTypeId],[DocCertId],[DocSeriesId])
values (@privateNumber,@companyName,@companyLeader,@workTypeId,@voen
,@currencyId,@operatorBankId,@bankSwift,@date,@legalAddress,@actualAddress
,@email,@tel,@contractNumber,@contractDate,@description,@docTypeId,@docCertId,@docSeriesId)

if @operationType=11 goto spSelect;
RETURN 0
end


spEdit:
 begin update 
 [Accounting].[Company]
 set
  [PrivateNumber]  = @privateNumber  
 ,[CompanyName]	 = @companyName
 ,[CompanyLeader] = @companyLeader
 ,[WorkTypeId]  = @workTypeId
 ,[Voen] =@voen
 ,[CurrencyId] = @currencyId
 ,[OperatorBankId] = @operatorBankId
 ,[BankSwift] = @bankSwift
 ,[Date] = @date
 ,[LegalAddress] = @legalAddress
 ,[ActualAddress] = @actualAddress
 ,[Email] = @email
 ,[Tel] = @tel
 ,[ContractNumber]=@contractNumber
 ,[ContractDate]=@contractDate
 ,[Description]=@description
 ,[DocTypeId]=@docTypeId
 ,[DocSeriesId]=@docSeriesId
 ,[DocCertId]=@docCertId
 ,[UpdateId]=@userId
 ,[UpdateDate]=GETDATE()

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[Company]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [Accounting].[VwCompany] where (@isFiltered=0 OR (@isFiltered=1 and isnull([DocTypeId],0) <>1)) and [DeleteId] is null;
RETURN 0
end


