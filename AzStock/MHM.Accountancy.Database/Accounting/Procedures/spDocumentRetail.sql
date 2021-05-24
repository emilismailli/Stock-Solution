create PROCEDURE [Accounting].[spDocumentRetail]
@userId int,
@payment  decimal(26,6),
@deficit DECIMAL(26,6),
@totalsum DECIMAL(26,6),
@basket Accounting.UddtRetailSale readonly,
@accountCode varchar(20),
@warehouseId int=null,
@paymentTypeId int=null,
@contractId int,
@percent nvarchar(50) null,
@discountNumber nvarchar(50) null
as

BEGIN

if exists(select 0 from (
select d.GoodId,sum(ISNULL(st.quantity,0))- d.Quantity QuantityPerGood from @basket d
join Accounting.VwGoodStock st with(rowlock,holdlock) on d.GoodId=st.Id
WHERE st.WarehouseId=@wareHouseId
group by d.GoodId,d.Quantity
)x where x.QuantityPerGood<0)
begin
raiserror('Stokda kifayet qeder mehsul yoxdur',16,1)
return
end
else 
BEGIN

declare @dayStart date=getdate(),@dayEnd date , @documentId int,@documentDetailId int,@companyId int 
set @dayEnd=DATEADD(day,1,@dayStart)
--select @dayStart,@dayEnd
set @companyId=@userId -- todo:  Burda userId-e  gore CompanyId-ni tapib getiririk. Hleki demo-dur


insert into Accounting.Document(IncludeDate,CompanyId,ContractId,WareHouseId,PaymentTypeId,CreateId,AccountId)
values (GETDATE(),@companyId,@contractId,@warehouseId,@paymentTypeId,@userId,8)



 update  Accounting.Cash  set [Balance] = isnull  (Balance,0) +@payment

   
   where Id=1


set @documentId=SCOPE_IDENTITY() 

DECLARE @quantity DECIMAL(26,6),@barcodeId INT,@goodId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6),@accountId INT,@goodName VARCHAR(50),@fullGoodName VARCHAR(50),@barcode VARCHAR(50)

DECLARE crs CURSOR FOR(SELECT [GoodId],ISNULL([Quantity],1),[FullGoodName],[BarCodeId],[Barcode],[AccountId],[GoodName]
,[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM @basket)
OPEN crs
FETCH NEXT FROM crs INTO @goodId,@quantity,@fullGoodName,@barcodeId,@barcode,@accountId,@goodName,@priceBuy,@priceRetail,@priceWholeSale
WHILE @@FETCH_STATUS=0
BEGIN
 





DECLARE @q1 DECIMAL(25,5),@stockId INT,@t3 DECIMAL(25,5)=0,@Tquantity DECIMAL(25,5)=0,@TpriceBuy DECIMAL(26,6)=0,@TpriceRetail DECIMAL(26,6)=0,@TpriceWholeSale DECIMAL(26,6)=0,@count int=0

DECLARE css CURSOR FOR (SELECT s.Quantity,s.Id FROM Accounting.Stock s WHERE s.GoodId=@goodId and s.Quantity>0 AND s.WarehouseId=@warehouseId AND UpdateId IS null)
OPEN css
FETCH NEXT FROM css INTO @q1,@stockId
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @p1 decimal(25,5),@p2 decimal(25,5),@p3 decimal(25,5),@ff Decimal (25,2)


SET @p1=(
    SELECT s.PriceBuy FROM Accounting.Stock s 
WHERE s.Id=@stockId AND WarehouseId=@wareHouseId)

SET @p2=(
    SELECT s.PrcieRetail FROM Accounting.Stock s 
WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId AND WarehouseId=@wareHouseId) )

SET @p3=(
    SELECT s.PriceWholeSale FROM Accounting.Stock s 
WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId AND WarehouseId=@wareHouseId) )

if(@t3 is not null)
begin
set @count=@count + 1
if(@q1<@quantity and @t3=0)

BEGIN

 set @t3=@quantity-@q1
 SET @ff=(@q1*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId

   set @TQuantity=@Tquantity+@q1
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   set @TpriceWholeSale = @p3


END

else if(@q1<@quantity and @t3>@q1)
BEGIN

 set @t3=@t3-@q1
 SET @ff=(@q1*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId
 
 set @TQuantity=@Tquantity+@q1
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   set @TpriceWholeSale = @p3

END

else if(@q1<@quantity and @t3<=@q1)
BEGIN
SET @ff=(@t3*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

   set @TQuantity=@Tquantity+@t3
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   set @TpriceWholeSale = @p3


 set @t3=null
END

else if(@q1>=@quantity and @t3>0)
BEGIN
SET @ff=(@t3*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

   set @TQuantity=@Tquantity+@t3
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   set @TpriceWholeSale = @p3


 set @t3=null
END

ELSE

BEGIN
      UPDATE Accounting.Stock
SET 
   Quantity =  @q1-@quantity WHERE GoodId=@goodId AND Id=@stockId 
   set @TQuantity=@Tquantity+@quantity
   set @TpriceBuy = (@TpriceBuy + @p1)
   set @TpriceRetail = @p2
   set @TpriceWholeSale = @p3

  set @t3=null
END
end


FETCH NEXT FROM css INTO @q1,@stockId
   end
close css
deallocate css
   
   insert into Accounting.DocumentDetail ([DocumentId],[AccountId],[GoodId],[Percent],DiscountNumber,[Quantity],[PriceRetail],[PriceBuy],[PriceWholeSale] ,[AmountRetail],[AmountBuy],[AmountWholeSale] ,[Payment],[Deficit],[CreateId],[SaleNo])
select 



@documentId
,@accountId
,@goodId
,@percent
,@discountNumber
,@Tquantity
,@TpriceRetail
,@TpriceBuy
,@TpriceWholeSale
,SUM(@TpriceRetail*@Tquantity) [AmountRetail]
,SUM(@TpriceBuy*@Tquantity) [AmountBuy]
,SUM(@TpriceWholeSale*@Tquantity) [AmountWholeSale]
,@payment [Payment]
,@payment-SUM(@TpriceRetail) [Deficit] 
,@userId [CreateId] 
,[Accounting].[SFnNewSaleNo](@userId,@accountCode)
set @documentDetailId=SCOPE_IDENTITY();



insert into Accounting.RetailSale(BarcodeId,DocumentDetailId,AccountId,GoodId,Quantity,PriceRetail,PriceBuy,PriceWholeSale,WareHouseId,CustomerId,CreateId,[Percent],DiscountNumber)
select @barcodeId,@documentDetailId,8,@goodId,@Tquantity,@TpriceRetail,@TpriceBuy,@TpriceWholeSale,@warehouseId,@contractId,@userId,@percent,@discountNumber


FETCH NEXT FROM crs INTO @goodId,@quantity,@fullGoodName,@barcodeId,@barcode,@accountId,@goodName,@priceBuy,@priceRetail,@priceWholeSale

end
close crs
deallocate crs
INSERT INTO Accounting.PaymentRetail (DocumentId,CustomerId,PaymentTypeId,Payment,Deficit,TotalSum,CreateDate,CreateId,[Percent],DiscountNumber) 
VALUES (@documentId,@contractId,isnull(@paymentTypeId,1),@totalsum,@deficit,@payment,GETDATE(),@userId,@percent,@discountNumber
)
end
end

