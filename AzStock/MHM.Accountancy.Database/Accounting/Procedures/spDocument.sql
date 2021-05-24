 create PROCEDURE [Accounting].[spDocument]
	@userId int ,
	@operationType tinyint = null,
	@id INT = NULL, 
	@menuId INT ,
	@paymentid INT=NULL,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
	@description nvarchar(500)=NULL,
	@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
    @accountCode varchar(40)=null,
	@paymentDate datetime =null, 
	@partnerOrderNo nvarchar(200)=null,
	@additionalCost decimal(26,6) =null, 
	
	--@cashierId int=null,
	@docTypeId int =null,
    @docCertId int =null,
    @docSeriesId int=null,
	
	@detail [Accounting].[UddtIncludeGood] READONLY
	--@isFiltered bit=1
	

AS

BEGIN
IF @operationType IN (1,11)
GOTO spAdd;
ELSE IF @operationType IN (2,12)
GOTO spedit;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4   
GOTO spSelect;


spAdd:
BEGIN
BEGIN TRAN 


INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],[ContractId],[SaleNo],[CreateId],AccountId,[PaymentDate],[PartnerOrderNo],[AdditionalCost],[DocTypeId],[DocCertId],[DocSeriesId])
VALUES (@includeDate,@companyId,@wareHouseId,@description,@paymentTypeId,@contractId,[Accounting].[SFnNewSaleNo](@userId,@accountCode),@userId,3,@paymentDate,@partnerOrderNo,@additionalCost,@docTypeId,@docCertId,@docSeriesId)

SET @id=SCOPE_IDENTITY();

DECLARE @accountId  INT,@payment DECIMAL(26,6),@amountBuy DECIMAL(26,6),@goodId INT,@barcodeId INT,@series NVARCHAR(200),@dateOfProduction DATETIME,@lastExpirationDate DATETIME
,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6),@totalPayment DECIMAL(26,6)=0,@percent NVARCHAR(50)
 ,@costInclude decimal (26,6),@costDeficit decimal (26,6),@discountPrice decimal(26,6)
 
DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],ISNULL([Percent]+' % Endirim','0')
 ,ISNULL([CostInclude] ,'0' ) ,ISNULL([CostDeficit] ,'0' ), ISNULL([DiscountPrice] ,'0' )
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent
 ,@costInclude,@costDeficit,@discountPrice

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalPayment=@totalPayment+(@quantity*(@priceBuy- @discountPrice))


 --set @totalAmount=@totalAmount+(@TQuantity*(@TpriceWholeSale-@discountPrice))
 
INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[Percent]
 ,[CostInclude],[CostDeficit]
 ,[DiscountPrice]
,[CreateId],[CreateDate])
VALUES(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy,@quantity*@priceRetail,@quantity*@priceWholeSale
,@payment,@amountBuy,@percent
 ,@costInclude,@costDeficit
,@discountPrice 
,@userId,GETDATE())


declare @stockgoodId int=0, @p1 DECIMAL (26,6),@p2 DECIMAL (26,6),@p3 DECIMAL (26,6)
select @stockgoodId=isnull(GoodId,0),@p1=PriceBuy,@p2=PrcieRetail,@p3=PriceWholeSale from Accounting.Stock where GoodId=@goodId  AND WarehouseId=@wareHouseId

 

INSERT into [Accounting].[Stock] (DocumentId,WarehouseId,GoodId,CreatId,Series,Quantity,PriceBuy,PrcieRetail,PriceWholeSale,CreateDate)
VALUES (@id,@wareHouseId,@goodId,@userId,@series,@quantity,@priceBuy,@priceRetail,@priceWholeSale,GETDATE())

 


FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent
 ,@costInclude,@costDeficit,@discountPrice


end

close crs
deallocate crs
INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit)
VALUES(@id,@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@totalPayment)


SET @paymentid=SCOPE_IDENTITY();

if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].[Document]
set 





[IncludeDate]=@includeDate,
[AccountId]=3,
[CompanyId]=@companyId,
[WareHouseId]=@wareHouseId,
[Description]=@description,
[PaymentTypeId]=@paymentTypeId,
[ContractId]=@contractId,
[PartnerOrderNo]=@partnerOrderNo,
[PaymentDate]=@paymentDate,
--[CashierId]=@cashierId,
[UpdateId]=@userId,
[UpdateDate]=getdate()

where Id=@id;

-------------PaymentOrder-------------


--SET @totalAmount=@totalAmount+(@TQuantity*(@TpriceWholeSale-@discountPrice))

--SET @totalAmount=@totalAmount+(@TQuantity*(@TpriceWholeSale-@discountPrice))
   
 
 -------------
 
 ---------
UPDATE Accounting.Payment 
SET 
   @totalPayment=@totalPayment+(@quantity*(@priceBuy- @discountPrice))
 
	WHERE AccountId=3
 ----------------------

--------------  Stock -------------

;with chck as (
select d.GoodId,sum(d.Quantity-isnull(dd.Quantity,0)) Quantity from @detail d 
left join [Accounting].[DocumentDetail] dd on d.Id=dd.Id
group by d.GoodId
)


merge [Accounting].[Stock] target
using (select [GoodId] ,Quantity  from chck)source  on target.GoodId=source.GoodId
when Matched then
update set [Quantity]=target.Quantity+source.[Quantity]
when not matched by target then insert ([GoodId],[Quantity]) values(source.GoodId,source.Quantity);
----------------------
 


--------
merge [Accounting].[DocumentDetail] target
using (select [Id],[GoodId],@id [DocumentId],[AccountId],[BarCodeId],[Series],[DateOfProduction]
,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
,[Quantity]*[PriceBuy] [AmountBuy],[Quantity]*[PriceRetail] [AmountRetail]
,[Quantity]*[PriceWholeSale] [AmountWholeSale],ISNULL([Payment],0) [Payment],[AmountBuy]  [Deficit]
from @detail) source on target.Id=source.Id
when MATCHED and target.DocumentId=@id THEN 


update set [AccountId]=source.[AccountId]
,[BarCodeId]=source.[BarCodeId]
,[Series]=source.[Series]
,[DateOfProduction]=source.[DateOfProduction]
,[LastExpirationDate]=source.[LastExpirationDate]
,[Quantity]=source.[Quantity]
,[UnitId]=source.[UnitId]
,[PriceBuy]=source.[PriceBuy]
,[PriceRetail]=source.[PriceRetail]
,[PriceWholeSale]=source.[PriceWholeSale]
,[AmountBuy]=source.[AmountBuy]
,[AmountRetail]=source.[AmountRetail]
,[AmountWholeSale]=source.[AmountWholeSale]
,[Payment]=isnull(target.[Payment],0)
,[Deficit]=source.[Deficit]
,[UpdateDate]=getdate()
,[UpdateId]=@userid


when NOT MATCHED BY target then 
insert  ( [DocumentId] ,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction]
,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy]
,[AmountRetail],[AmountWholeSale],[Payment],[Deficit])
values (@id,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate]
,[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[Quantity]*[PriceBuy]
, [Quantity] * [PriceRetail] ,[Quantity]*[PriceWholeSale] ,isnull([Payment],0),[AmountBuy])

when NOT MATCHED BY source and target.DocumentId=@Id then update set [DeleteId]=@userId
,[DeleteDate]=getdate(); 
if @@TRANCOUNT>0
   commit;
if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
BEGIN
--Silinen qaime nomresine gore mehsullarin sifirlanmasi
UPDATE Accounting.Stock
SET
UpdateDate=GETDATE(),
UpdateId=@userId,
Quantity=0
WHERE DocumentId=@id

--Silinen qaime nomresine gore yaranan borcun silinmesi
DELETE FROM Accounting.Payment 
WHERE DocumentId=@id

--Silinen qaime nomresine gore documentdetail cedveline delete ye silen userin dusmesi
UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id

--Silinen qaime nomresine gore Document cedveline silen userin id sinin dusmesi 
UPDATE [Accounting].[Document]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
WHERE id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
select  d.[Id]   
    ,d.[IncludeDate]  
	,d.[PaymentDate]   
	,d.[PartnerOrderNo]
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[AdditionalCost]
          ,d.[DocTypeId]
      ,d.[DocCertId]
      ,d.[DocSeriesId]
         ,sum(dd.AmountBuy) AmountBuy
         ,sum(dd.AmountRetail) AmountRetail
         ,sum(dd.AmountWholeSale) AmountWholeSale
	     ,sum(dd.Payment) Payment
	     ,sum(dd.Deficit) Deficit
	     --,sum(dd.DiscountNumber) DisocuntPrice
from [Accounting].[VwDocument] d

 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
 left join [Accounting].[VwContract] c on c.id=d.ContractId
JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
 where c.ContractTypeId=1--aliw ucun
  and d.DeleteId is null and AccountId=3
  --and (@isFiltered=0 OR (@isFiltered=1 and isnull([DocTypeId],0) <>1))
   --AND (@docCertId IS NULL OR [DocCertId]=@docCertId)
 group by 
     d.[Id]   
    ,d.[IncludeDate]  
	,d.[PaymentDate]   
    ,d.[PartnerOrderNo]
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[AdditionalCost]
    ,d.[DocTypeId]
    ,d.[DocCertId]
    ,d.[DocSeriesId];
 RETURN 0
end