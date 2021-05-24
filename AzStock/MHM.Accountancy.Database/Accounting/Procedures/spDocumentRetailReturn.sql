CREATE PROCEDURE [Accounting].[spDocumentRetailReturn]


@userId int ,
@menuId INT,
	@operationType tinyint = null,
	@id INT = NULL,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
	@description nvarchar(500)=NULL,
	@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
	@accountId int=null,
	@paymentid INT=NULL,
	@paymentDate datetime =null, 
    @partnerOrderNo nvarchar(200)=null,
    @mainNumber int =null,
    
	@detail [Accounting].[UddtRetailSaleGoodReturn] readonly
	

with encryption
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
WHERE ISNULL(st.Quantity,0) + d.Quantity<0 AND st.WarehouseId=@wareHouseId)
begin
raiserror('Say duzgun deyil',16,1)
rollback
return
end
else 
BEGIN

INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],[ContractId],[AccountId],[PaymentDate],[PartnerOrderNo],[MainNumber])
VALUES (@includeDate,@companyId,@wareHouseId,@description,@paymentTypeId,@contractId,@accountId,@paymentDate,@partnerOrderNo,@mainNumber)

SET @id=SCOPE_IDENTITY();

DECLARE @totalAmount DECIMAL(26,6)=0,@payment DECIMAL(26,6),@amountretail DECIMAL(26,6),@goodId INT,@barcodeId INT,@series nvarchar(200),@dateOfProduction datetime,@lastExpirationDate DATETIME
,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6)

DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountRetail],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountretail ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale

WHILE @@FETCH_STATUS=0
BEGIN

SET @totalAmount=@totalAmount+@amountretail
DECLARE @element INT=0
SELECT @element=Id FROM DocumentDetail WHERE GoodId=@goodId AND (SELECT SUM(Quantity) FROM DocumentDetail WHERE GoodId=@goodId AND AccountId=8)>=@quantity 
IF(@element>0)
BEGIN

--INSERT INTO Accounting.Payment (AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
--VALUES(@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@amountretail)


INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[CreateId],[CreateDate])
values(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy,@quantity*@priceRetail,@quantity*@priceWholeSale,@payment, @amountretail,@userId,GETDATE())


--INSERT INTO [Accounting].[Stock]( [GoodId],[Quantity],[PriceBuy],[PrcieRetail],[PriceWholeSale],[CreateDate]) 
--values (@goodId,@quantity,@priceBuy,@priceRetail,@priceWholeSale,getdate())

UPDATE Accounting.Stock
SET
Quantity=Quantity+@quantity
WHERE Id=(select max(s.Id) from Accounting.Stock s where s.GoodId=@goodId and s.WarehouseId=@wareHouseId AND s.UpdateId IS null)

end
else
begin
raiserror('Say duzgun deyil',16,1)
rollback
return
end
--update st set st.Quantity=st.Quantity+d.Quantity
--from @detail d 
--join Accounting.Stock st with(rowlock,holdlock) on d.GoodId=st.GoodId WHERE d.GoodId=@goodId AND st.Id=(select max(Id)  from Accounting.Stock where GoodId=@goodId );

FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountretail ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale


end

close crs
deallocate crs
INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
VALUES(@id,@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@totalAmount)
SET @paymentid=SCOPE_IDENTITY();
END

if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end

 
spDelete:
BEGIN

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


declare @g int,@q decimal(25,5),@sId int,@deficitQuantity decimal(25,5)=0

DECLARE css CURSOR FOR 
(SELECT s.Id,s.GoodId,s.Quantity
FROM Accounting.Stock s WHERE s.Quantity>0 AND s.GoodId=@goodId1 AND s.WarehouseId=@wareHouseId AND s.UpdateId IS null)
OPEN css
FETCH NEXT FROM css INTO @sId,@g,@q

WHILE @@FETCH_STATUS=0
BEGIN
if(@deficitQuantity IS NOT null)
begin
if(@quantity1>@q AND @deficitQuantity=0)
begin
SET @deficitQuantity=@quantity1-@q
UPDATE Accounting.Stock
SET
    Quantity = 0
	where Id=@sId AND GoodId=@goodId1 
end

if(@quantity1>@q AND @deficitQuantity>@q)
begin
SET @deficitQuantity=@deficitQuantity-@q
UPDATE Accounting.Stock
SET
    Quantity = 0
	where Id=@sId AND GoodId=@goodId1
END

if(@quantity1>@q AND @deficitQuantity<=@q)
BEGIN
UPDATE Accounting.Stock
SET
    Quantity = @q-@deficitQuantity
	where Id=@sId AND GoodId=@goodId1
SET @deficitQuantity=null
END

ELSE
begin
UPDATE Accounting.Stock
SET
    Quantity = @q-@quantity1
	where Id=@sId AND GoodId=@goodId1
	SET @deficitQuantity=null
END

end
FETCH NEXT FROM css INTO @sId,@g,@q

end

close css
deallocate css


FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1


END

CLOSE crs
DEALLOCATE crs


DELETE FROM Accounting.Payment 
WHERE DocumentId=@id

UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id

update [Accounting].[Document]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
select  
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
    ,d.[PartnerOrderNo]
    ,d.[MainNumber]

         ,max(dd.AmountBuy) AmountBuy
         ,max(dd.AmountRetail) AmountRetail
         ,max(dd.AmountWholeSale) AmountWholeSale
		 ,max(dd.PriceWholeSale) PriceWholeSale
	     ,max(dd.Payment) Payment
	     ,max(dd.Deficit) Deficit
from [Accounting].[VwDocument] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
 left join [Accounting].[VwContract] c on c.id=d.ContractId
 JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
 where d.DeleteId is NULL AND AccountId=4
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
    ,d.[PartnerOrderNo]
    ,d.[MainNumber]

	;
 RETURN 0
end
