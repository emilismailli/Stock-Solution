CREATE PROCEDURE [dbo].[spTransport]
	@userId int,
	@fromWareHouseId INT=NULL,  --source anbar id
	@menuId INT,
	@companyId INT=NULL,
	@description NVARCHAR(200)=NULL,
	@operationtype TINYINT=NULL,
	@id INT = NULL, 
	@paymentId INT=NULL,
	@warehouseId INT=NULL, --destination anbar id
	 @includeDate DATETIME= NULL,
	@detail [Accounting].[UddtTransport] READONLY
AS

BEGIN

DECLARE @totalAmount decimal(26,6)=0, @accountId  INT,@payment decimal(26,6),
@amountBuy decimal(26,6),@goodId INT,@barcodeId INT,@series NVARCHAR(200),
@dateOfProduction DATETIME,@lastExpirationDate DATETIME,
@quantity decimal(26,6),@unitId INT,@priceBuy decimal(26,6),
@priceRetail decimal(26,6),@priceWholeSale decimal(26,6),
@totalPayment decimal(26,6)=0,@percent NVARCHAR(50);


IF @operationType IN (1,11)
GOTO spAdd;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4   
GOTO spSelect;


spAdd:
BEGIN
begin tran 

if exists(select * from @detail d
join Accounting.VwGoodStock st with(rowlock,holdlock) on d.GoodId=st.Id
where ISNULL(st.quantity,0) - d.Quantity<0 AND st.WarehouseId=@fromWareHouseId)
begin
	raiserror('Stokda kifayet qeder mehsul yoxdur',16,1);
	rollback;
	return;
end






else 
begin


INSERT INTO [Accounting].[Document]([IncludeDate],[CompanyId],[WareHouseId],[FromWareHouseId],[ContractId],[Description],[CreateId],[AccountId])
VALUES (@includeDate,@companyId,@warehouseId,@fromWareHouseId,1,@description,@userId,14)

SET @id=SCOPE_IDENTITY();

DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],
[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],
[PriceWholeSale],ISNULL([Percent]+' % Endirim','0')
FROM @detail)

OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,
@series ,@dateOfProduction ,@lastExpirationDate ,@quantity,@unitId,@priceBuy,
@priceRetail,@priceWholeSale,@percent

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalPayment=@totalPayment+@amountBuy;

DECLARE @sQuantity decimal(25,5), -- stock quantity
@stockId INT,@quantityDiff decimal(25,5)=0,
@tQuantity decimal(25,5)=0,@tPriceBuy decimal(26,6)=0,@tPriceRetail decimal(26,6)=0,
@tPriceWholeSale decimal(26,6)=0,@count int=0;

DECLARE stockList CURSOR FOR (SELECT s.Quantity,s.Id 
FROM Accounting.Stock s 
WHERE s.GoodId=@goodId and s.Quantity>0 AND s.WarehouseId=@fromWareHouseId 
AND UpdateId IS null)

OPEN stockList
FETCH NEXT FROM stockList INTO @sQuantity,@stockId
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @lastPriceBuy decimal(25,5),@lastPriceRetail decimal(25,5),
@lastPriceWholeSale decimal(25,5),@quantityScale decimal (25,2)


SELECT top (1) @lastPriceBuy=s.PriceBuy,
@lastPriceRetail=s.PrcieRetail,
@lastPriceWholeSale=s.PriceWholeSale 
FROM Accounting.Stock s 
WHERE GoodId=@goodId AND WarehouseId=@fromWareHouseId
order by s.Id desc --sonuncu uzre melumatlar 

IF(@quantityDiff IS NOT NULL)
BEGIN
set @count=@count + 1
IF(@sQuantity<@quantity AND @quantityDiff=0)

BEGIN
select @quantityDiff=@quantity-@sQuantity,
@quantityScale=(@sQuantity*100)/@quantity;

UPDATE Accounting.Stock
SET Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId;

select @tQuantity=@tQuantity+@sQuantity,
@tPriceBuy = @tPriceBuy + (@lastPriceBuy*@quantityScale)/100,
@tPriceRetail = @lastPriceRetail,
@tPriceWholeSale = @lastPriceWholeSale;

END

ELSE IF(@sQuantity<@quantity AND @quantityDiff>@sQuantity)
BEGIN
select @quantityDiff=@quantityDiff-@sQuantity,
@quantityScale=(@sQuantity*100)/@quantity;

UPDATE Accounting.Stock
SET Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId;
 
select @tQuantity=@tQuantity+@sQuantity,
@tPriceBuy = @tPriceBuy + (@lastPriceBuy*@quantityScale)/100,
@tPriceRetail = @lastPriceRetail,
@tPriceWholeSale = @lastPriceWholeSale;

END

ELSE IF(@sQuantity<@quantity AND @quantityDiff<=@sQuantity)
BEGIN
SET @quantityScale=(@quantityDiff*100)/@quantity;

UPDATE Accounting.Stock
SET Quantity = @sQuantity-@quantityDiff WHERE Id=@stockId;

select @tQuantity=@tQuantity+@quantityDiff,
@tPriceBuy = @tPriceBuy + (@lastPriceBuy*@quantityScale)/100,
@tPriceRetail = @lastPriceRetail,
@tPriceWholeSale = @lastPriceWholeSale,
@quantityDiff=NULL;

END

ELSE IF(@sQuantity>=@quantity AND @quantityDiff>0)
BEGIN

SET @quantityScale=(@quantityDiff*100)/@quantity;

UPDATE Accounting.Stock
SET Quantity = @sQuantity-@quantityDiff WHERE Id=@stockId

   select @tQuantity=@tQuantity+@quantityDiff,
   @tPriceBuy = @tPriceBuy + (@lastPriceBuy*@quantityScale)/100,
   @tPriceRetail = @lastPriceRetail,
   @tPriceWholeSale = @lastPriceWholeSale,
   @quantityDiff=NULL;

END

ELSE

BEGIN
   UPDATE Accounting.Stock
	  SET Quantity =  @sQuantity-@quantity WHERE Id=@stockId;

   select @tQuantity=@tQuantity+@quantity,
   @tPriceBuy = @tPriceBuy + @lastPriceBuy,
   @tPriceRetail = @lastPriceRetail,
   @tPriceWholeSale = @lastPriceWholeSale,
   @quantityDiff=NULL;  
END
END

   FETCH NEXT FROM stockList INTO @sQuantity,@stockId;
   SET @totalAmount=@totalAmount+(@tQuantity*@tPriceWholeSale);
END
CLOSE stockList
DEALLOCATE stockList


INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[Percent],[CreateId],[CreateDate])
VALUES(@id,@paymentId,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@tQuantity,@unitId,@tPriceBuy,@tPriceRetail,@tPriceWholeSale,@tQuantity*@tPriceBuy,@tQuantity*@tPriceRetail,@tQuantity*@tPriceWholeSale,@payment, @tQuantity*@tPriceBuy,@percent,@userId,getdate())


INSERT into [Accounting].[Stock] (DocumentId,WarehouseId,GoodId,CreatId,Series,Quantity,PriceBuy,PrcieRetail,PriceWholeSale,CreateDate)
VALUES (@id,@warehouseId,@goodId,@userId,@series,@tQuantity,@tPriceBuy,@tPriceRetail,@tPriceWholeSale,GETDATE())

FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,@series ,
@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,
@priceWholeSale,@percent;

end

close crs
deallocate crs

END

INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerWareHouseId,Payment,Deficit)
VALUES(@id,@accountId,@warehouseId,@payment,@totalPayment);
SET @paymentId=SCOPE_IDENTITY();

if @@TRANCOUNT>0 
commit;

if @operationType=11 goto spSelect;
RETURN 0;
end

spDelete:
BEGIN

UPDATE Accounting.Stock 
SET

UpdateDate=GETDATE(),
UpdateId=@userId
,
Quantity=@quantityScale
WHERE DocumentId=@id AND WarehouseId!=@fromWareHouseId ;

--DECLARE @totalAmount1 decimal(26,6)=0,@payment1 decimal(26,6),
--@amountBuy1 decimal(26,6),@goodId1 INT,@barcodeId1 INT,@series1 NVARCHAR(200),
--@dateOfProduction1 DATETIME,@lastExpirationDate1 DATETIME,
--@quantity1 decimal(26,6),@unitId1 INT,@priceBuy1 decimal(26,6),
--@priceRetail1 decimal(26,6),@priceWholeSale1 decimal(26,6);

DECLARE crd CURSOR FOR 
(SELECT ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)

OPEN crd
FETCH NEXT FROM crd INTO @payment ,@amountBuy ,@goodId,@barcodeId,@series,
@dateOfProduction ,@lastExpirationDate
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale;

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount=@totalAmount+@amountBuy;

INSERT INTO Accounting.Stock (GoodId,CreatId,CreateDate,WarehouseId,DocumentId,Quantity,PriceBuy,PrcieRetail,PriceWholeSale) 
VALUES (@goodId,@userId,GETDATE(),@fromWareHouseId,@id,@quantity,@priceBuy,@priceRetail,@priceWholeSale)

FETCH NEXT FROM crd INTO @payment ,@amountBuy ,@goodId,@barcodeId,@series,
@dateOfProduction ,@lastExpirationDate
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale;

END

CLOSE crd
DEALLOCATE crd

DELETE FROM Accounting.Payment WHERE DocumentId=@id;

UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id;


UPDATE [Accounting].[Document]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
WHERE id=@id;

if @operationType=13 goto spSelect;
RETURN 0
END

spSelect:
BEGIN
select  d.[Id]   
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId]  
    ,d.[FromWarehouseId] 
	,d.[FromWareHouseName]
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
          ,d.[DocTypeId]
      ,d.[DocCertId]
      ,d.[DocSeriesId]
         ,sum(dd.AmountBuy) AmountBuy
         ,sum(dd.AmountRetail) AmountRetail
         ,sum(dd.AmountWholeSale) AmountWholeSale
	     ,sum(dd.Payment) Payment
	     ,sum(dd.Deficit) Deficit
from [Accounting].[VwDocument] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
  and d.DeleteId is null and AccountId=12
 group by 
     d.[Id]   
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	
	,d.[FromWareHouseName]
	,d.[WareHouseName]
	,d.[FromWarehouseId]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	 ,d.[DocTypeId]
      ,d.[DocCertId]
      ,d.[DocSeriesId];
	  END
 RETURN 0
end

