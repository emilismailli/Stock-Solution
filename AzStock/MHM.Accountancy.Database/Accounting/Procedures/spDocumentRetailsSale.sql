CREATE PROCEDURE [Accounting].[spDocumentRetailsSale]
	@userId int ,
	@operationType tinyint = null,
	@menuId int,
	@id INT = NULL,
	@paymentid int =null,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
		@description nvarchar(500)=null,
	@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
	 @accountCode varchar(40)=null,
	@paymentDate datetime =null, 
		@partnerOrderNo nvarchar(200)=null,
    
	@detail [Accounting].[UddtRetailsSaleGood] readonly
	

--with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
--else if @operationType in (2,12)
--goto spedit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
begin tran 

if exists(select * from @detail d
join Accounting.VwGoodStock st with(rowlock,holdlock) on d.GoodId=st.Id
where ISNULL(st.quantity,0) - d.Quantity<0 AND st.WarehouseId=@wareHouseId)
begin
raiserror('Stokda kifayet qeder mehsul yoxdur',16,1)
rollback
return
end
else 
begin



INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],[ContractId],[SaleNo],Accounting.Document.CreateId,AccountId,[PaymentDate],[PartnerOrderNo])
VALUES (@includeDate,@companyId,@wareHouseId,@description,@paymentTypeId,@contractId,[Accounting].[SFnNewSaleNo](@userId,@accountCode),@userId,7,@paymentDate,@partnerOrderNo)

SET @id=SCOPE_IDENTITY();

DECLARE @totalAmount DECIMAL(26,6)=0,@accountId  INT,@payment DECIMAL(26,6),@amountWholeSale DECIMAL(26,6),@goodId INT,@barcodeId INT,@series nvarchar(200),@dateOfProduction datetime,@lastExpirationDate DATETIME
,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6),@percent NVARCHAR(50)
DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountWholeSale],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],ISNULL([Percent]+' % Endirim','0')
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent

WHILE @@FETCH_STATUS=0
BEGIN

 


 

DECLARE @q1 decimal(25,5),@stockId INT,@t3 DECIMAL(25,5)=0,@Tquantity DECIMAL(25,5)=0,@TpriceBuy DECIMAL(26,6)=0,@TpriceRetail DECIMAL(26,6)=0,@TpriceWholeSale DECIMAL(26,6)=0,@count int=0
DECLARE css CURSOR FOR (SELECT s.Quantity,s.Id FROM Accounting.Stock s WHERE s.GoodId=@goodId and s.Quantity>0 and s.WarehouseId=@wareHouseId AND UpdateId IS null)
OPEN css
FETCH NEXT FROM css INTO @q1,@stockId
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @p1 decimal(25,5),@p2 decimal(25,5),@p3 decimal(25,5),@ff Decimal (25,2)


SET @p1=(
    SELECT s.PriceBuy FROM Accounting.Stock s 
WHERE s.Id=@stockId)

SET @p2=(
    SELECT s.PrcieRetail FROM Accounting.Stock s 
WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId) )

SET @p3=(
    SELECT s.PriceWholeSale FROM Accounting.Stock s 
WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId) )

IF(@t3 IS NOT NULL)
BEGIN
set @count=@count + 1
IF(@q1<@quantity AND @t3=0)

BEGIN

 set @t3=@quantity-@q1
 SET @ff=(@q1*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId

   set @TQuantity=@Tquantity+@q1
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3


END

ELSE IF(@q1<@quantity AND @t3>@q1)
BEGIN

 set @t3=@t3-@q1
 SET @ff=(@q1*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId
 
 set @TQuantity=@Tquantity+@q1
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3

END

ELSE IF(@q1<@quantity AND @t3<=@q1)
BEGIN
SET @ff=(@t3*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

   SET @TQuantity=@Tquantity+@t3
   SET @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   SET @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3


 SET @t3=NULL
END

ELSE IF(@q1>=@quantity AND @t3>0)
BEGIN
SET @ff=(@t3*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

   SET @TQuantity=@Tquantity+@t3
   SET @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   SET @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3


 SET @t3=NULL
END

ELSE

BEGIN
      UPDATE Accounting.Stock
SET 
   Quantity =  @q1-@quantity WHERE GoodId=@goodId AND Id=@stockId 
   SET @TQuantity=@Tquantity+@quantity
   SET @TpriceBuy = (@TpriceBuy + @p1)
   SET @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3

  SET @t3=NULL



  
END
END



FETCH NEXT FROM css INTO @q1,@stockId
SET @totalAmount=@totalAmount+(@TQuantity*@TpriceRetail)
   END
CLOSE css
DEALLOCATE css


   INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId]
   ,[Series],[DateOfProduction],[LastExpirationDate],[Quantity]
   ,[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[Percent],[CreateId],[CreateDate])
VALUES(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@TQuantity,@unitId
,@TpriceBuy,@TpriceRetail,@TpriceWholeSale,@TQuantity*@TpriceBuy,@TQuantity*@TpriceRetail,@TQuantity*@TpriceWholeSale,@payment, @TQuantity*@TpriceRetail,@percent,@userId,getdate())







FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent
end

close crs
deallocate crs
END
INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
VALUES(@id,@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@totalAmount)
 SET @paymentid=SCOPE_IDENTITY();

if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end
 

spDelete:
begin

DECLARE @totalAmount1 DECIMAL(26,6)=0,@payment1 DECIMAL(26,6),@amountBuy1 DECIMAL(26,6),@goodId1 INT,@barcodeId1 INT,@series1 NVARCHAR(200),@dateOfProduction1 DATETIME,@lastExpirationDate1 DATETIME
,@quantity1 DECIMAL(26,6),@unitId1 INT,@priceBuy1 DECIMAL(26,6),@priceRetail1 DECIMAL(26,6),@priceWholeSale1 DECIMAL(26,6)

DECLARE crs CURSOR FOR 
(SELECT ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)
OPEN crs
FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1 
,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount1=@totalAmount1+@amountBuy1


UPDATE Accounting.Stock
SET
UpdateId=@userId,
UpdateDate=GETDATE(),
Quantity=Quantity+@quantity1
WHERE Id=(select max(s.Id) FROM Accounting.Stock s WHERE s.GoodId=@goodId1 AND s.PriceBuy=@priceBuy1 and s.WarehouseId=@wareHouseId AND UpdateId IS null)



FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1


END

CLOSE crs
DEALLOCATE crs

DELETE FROM Accounting.Payment WHERE DocumentId=@id

UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id


update [Accounting].[Document]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where Id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
select  d.[Id]  
    ,d.[IncludeDate]  
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
	,d.[PaymentDate]   
		,d.[PartnerOrderNo]
     
         ,max(dd.AmountBuy) AmountBuy
         ,max(dd.AmountRetail) AmountRetail
         ,max(dd.AmountWholeSale) AmountWholeSale
		 ,max(dd.PriceWholeSale) PriceWholeSale
	     ,max(dd.Payment) Payment
	     ,max(dd.Deficit) Deficit
from [Accounting].[VwDocumentRetailsSale] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
 left join [Accounting].[VwContract] c on c.id=d.ContractId
 JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
 where AccountId=8 and d.DeleteId is null
 group by 
     d.[Id]  
    ,d.[IncludeDate]  
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
	,d.[PaymentDate]   
		,d.[PartnerOrderNo];
 RETURN 0
end