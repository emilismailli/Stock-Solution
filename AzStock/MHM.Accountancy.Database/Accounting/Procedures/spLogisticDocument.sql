 
CREATE PROCEDURE [Accounting].[spLogisticDocument]
@userId int,
@operationType tinyint,
@id int=null,
@driver nvarchar(200) =null,
@fin nvarchar(200)=null,
@transportation nvarchar(200)=null,
@cart nvarchar(200)=null,
@sender nvarchar(200)=null,
@senderAddress nvarchar(200)=null,
@senderManager nvarchar(200)=null,
@received nvarchar(200)=null,
@receivedAddress nvarchar(200)=null,
@receivedManager nvarchar(200)=null,
@date datetime =null,
@deliveryDate datetime=null,
@description nvarchar(500)=null,
@docTypeId INT =null,
@docCertId int =null,
@docSeriesId int =null,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
		@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
@details [Accounting].[UddtLogisticDetail]  readonly 


with encryption
AS 
begin
set xact_abort on;
if @operationType in (1,11)
goto spAdd;
--else if @operationType in (2,12)
--goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;

spAdd:
begin
begin transaction
insert into [Accounting].[Logistic]([Driver],[Fin],[Transportation],[Cart],[Sender],[SenderAddress]
,[SenderManager],[Received],[ReceivedAddress],[ReceivedManager],[Date],[DeliveryDate],[Description],[CreateId],[DocTypeId],[DocCertId],[DocSeriesId],[CompanyId],[WareHouseId],[PaymentTypeId],[ContractId])


VALUES (@driver,@fin,@transportation,@cart,@sender,@senderAddress,@senderManager,@received,@receivedAddress,@receivedManager,@date,@deliveryDate
,@description,@userId,@docTypeId,@docCertId,@docSeriesId,@companyId,@wareHouseId,@paymentTypeId,@contractId);

 set @id=SCOPE_IDENTITY();

 insert into [Accounting].[LogisticDetail]([LogisticId],[BarcodeId],[GoodId],[Quantity],[UnitId],[Description])
                                    select @id,[BarcodeId],[GoodId],[Quantity],[UnitId],[Description] from @details
	if @@TRANCOUNT>0
	COMMIT;
	if @operationType=11 goto spSelect;
RETURN 0
end
spDelete:
begin
update [Accounting].[Logistic]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end

spSelect:
select  
l.[Id]
,l.[Driver]
,l.[Fin]
,l.[Transportation]
,l.[Cart]
,l.[Sender]
,l.[SenderAddress]
,l.[SenderManager]
,l.[Received]
,l.[ReceivedAddress]
,l.[ReceivedManager]
,l.[Date]
,l.[DeliveryDate]
,l.[Description]
,l.CompanyId
,l.CompanyName
,l.WareHouseId
,l.WareHouseName
,l.ContractId
,l.CustomerId
,l.CustomerName
,l.PaymentTypeId
,l.PaymentTypeName
from [Accounting].[VwLogistic] l

join [Accounting].[LogisticDetail] ld on l.id=ld.LogisticId
 group by
 l.[Id]
, l.[Driver]
,l.[Fin]
,l.[Transportation]
,l.[Cart]
,l.[Sender]
,l.[SenderAddress]
,l.[SenderManager]
,l.[Received]
,l.[ReceivedAddress]
,l.[ReceivedManager]
,l.[Date]
,l.[DeliveryDate]
,l.[Description]
,l.CompanyId
,l.CompanyName
,l.WareHouseId
,l.WareHouseName
,l.ContractId
,l.CustomerId
,l.CustomerName
,l.PaymentTypeId
,l.PaymentTypeName
select * from Accounting.VwLogistic ;
RETURN 0
end