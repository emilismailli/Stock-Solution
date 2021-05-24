CREATE PROCEDURE [Accounting].[spDocumentDeletion]
	@userId int ,
	@operationType tinyint = null,
	@id INT = NULL,
	@menuId int,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL, 
	@description nvarchar(500)=NULL,
	@contractId int =null,
	@customerId int=null,
	@reasonId int=null,
	@paymentid int = null,
	@accountId int=null,
    
	@detail [Accounting].[UddtDeleteGood] readonly
	

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
join Accounting.VwGoodStock st on d.GoodId=st.Id
where ISNULL(st.quantity,0) - d.Quantity<0 and st.WarehouseId=@wareHouseId)

BEGIN
raiserror('Stokda qeyd etdiyiniz sayda  mehsul yoxdur',16,1)
rollback
return
end
else 
begin
INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[ContractId],[AccountId],[ReasonId],[CreateId])
values (@includeDate,@companyId,@wareHouseId,@description,@contractId,6,@reasonId,@userId)

set @id=SCOPE_IDENTITY();
DECLARE @barcodeId int,@stogoodId int,@companyName nvarchar(20),@customerName nvarchar(20),@goodId int,@series nvarchar(200),@dateofProduction datetime,@lastExpirationdate datetime,@quantity decimal(25,5),@unitId int,@priceBuy decimal(26,6),@priceRetail decimal(26,6),@priceWholeSale decimal(26,6),@amountBuy decimal(26,6),@amountRetail decimal(26,6),@amountWholeSale decimal(26,6),@payment decimal(26,6),@deficit decimal(26,6)
DECLARE css CURSOR FOR
(SELECT d.BarcodeId,d.StoGoodId,d.CompanyName,d.CustomerName,d.AccountId,d.GoodId,d.Series,d.DateOfProduction,d.LastExpirationDate,d.Quantity,d.UnitId,d.PriceBuy,d.PriceRetail,d.PriceWholeSale,d.AmountBuy,d.AmountRetail,d.AmountWholeSale,d.Payment,d.Deficit FROM @detail d)
OPEN css
FETCH NEXT FROM css INTO @barcodeId,@stogoodId,@companyName,@customerName,@accountId,@goodId,@series,@dateofProduction,@lastExpirationdate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@amountBuy,@amountRetail,@amountWholeSale,@payment,@deficit
WHILE @@FETCH_STATUS=0
begin


declare @g int,@q decimal(25,5),@sId int,@deficitQuantity decimal(25,5)=0

DECLARE crs CURSOR FOR 
(SELECT s.Id,s.GoodId,s.Quantity
FROM Accounting.Stock s WHERE s.Quantity>0 AND s.GoodId=@goodId AND s.WarehouseId=@wareHouseId AND s.UpdateId IS null)
OPEN crs
FETCH NEXT FROM crs INTO @sId,@g,@q

WHILE @@FETCH_STATUS=0
BEGIN
if(@deficitQuantity IS NOT null)
begin
if(@quantity>@q AND @deficitQuantity=0)
begin
SET @deficitQuantity=@quantity-@q
UPDATE Accounting.Stock
SET
    Quantity = 0
	where Id=@sId AND GoodId=@goodId
end

if(@quantity>@q AND @deficitQuantity>@q)
begin
SET @deficitQuantity=@deficitQuantity-@q
UPDATE Accounting.Stock
SET
    Quantity = 0
	where Id=@sId AND GoodId=@goodId
END

if(@quantity>@q AND @deficitQuantity<=@q)
BEGIN
UPDATE Accounting.Stock
SET
    Quantity = @q-@deficitQuantity
	where Id=@sId AND GoodId=@goodId
SET @deficitQuantity=null
END

ELSE
begin
UPDATE Accounting.Stock
SET
    Quantity = @q-@quantity
	where Id=@sId AND GoodId=@goodId
	SET @deficitQuantity=null
END

end
FETCH NEXT FROM crs INTO @sId,@g,@q

end

close crs
deallocate crs










insert into [Accounting].[DocumentDetail]([DocumentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[Description],[CreateId],[CreateDate])
values (@id,@accountId, @goodId,@barcodeId,@series,@dateofProduction,@lastExpirationdate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy ,@quantity*@priceRetail,@quantity*@priceWholeSale,@payment,(@quantity*@priceBuy) - @payment,@description,@userId,GETDATE())


FETCH NEXT FROM css INTO @barcodeId,@stogoodId,@companyName,@customerName,@accountId,@goodId,@series,@dateofProduction,@lastExpirationdate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@amountBuy,@amountRetail,@amountWholeSale,@payment,@deficit
end

close css
deallocate css

END
if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end

--spEdit:
--begin
--update [Accounting].[Document]
--set

--[IncludeDate]=@includeDate,
--[CompanyId]=@companyId,
--[WareHouseId]=@wareHouseId, 
--[Description]=@description,
--[ContractId]=@contractId,
--[AccountId]=@accountId,
--[ReasonId]=@reasonId,
--[UpdateId]=@userId,
--[UpdateDate]=getdate()

--where Id=@id;


----------------  Stock -------------

--;with chck as (
--select d.GoodId,sum(d.Quantity-isnull(dd.Quantity,0)) Quantity from @detail d 
--left join [Accounting].[DocumentDetail] dd on d.Id=dd.Id
--group by d.GoodId
--)


--merge [Accounting].[Stock] target
--using (select [GoodId] ,Quantity  from chck)source  on target.GoodId=source.GoodId
--when Matched then
--update set [Quantity]=target.Quantity-source.[Quantity]
--when not matched by target then insert ([GoodId],[Quantity]) values(source.GoodId,source.Quantity);


--merge [Accounting].[DocumentDetail] target
--using (select [Id],[GoodId],@id [DocumentId],[AccountId],[BarCodeId],[Series],[DateOfProduction]
--,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
--,[Quantity]*[PriceBuy] [AmountBuy],[Quantity]*[PriceRetail] [AmountRetail]
--,[Quantity]*[PriceWholeSale] [AmountWholeSale],[Payment],[AmountBuy] - [Payment] [Deficit],[Description]
--from @detail) source on target.Id=source.Id
--when MATCHED and target.DocumentId=@id THEN 


--update set [AccountId]=source.[AccountId]
--,[BarCodeId]=source.[BarCodeId]
--,[Series]=source.[Series]
--,[DateOfProduction]=source.[DateOfProduction]
--,[LastExpirationDate]=source.[LastExpirationDate]
--,[Quantity]=source.[Quantity]
--,[UnitId]=source.[UnitId]
--,[PriceBuy]=source.[PriceBuy]
--,[PriceRetail]=source.[PriceRetail]
--,[PriceWholeSale]=source.[PriceWholeSale]
--,[AmountBuy]=source.[AmountBuy]
--,[AmountRetail]=source.[AmountRetail]
--,[AmountWholeSale]=source.[AmountWholeSale]
--,[Payment]=source.[Payment]
--,[Deficit]=source.[AmountBuy]-(isnull(target.[Payment],0)+source.[Payment])
--,[Description]=source.[Description] 
--,[UpdateDate]=getdate()
--,[UpdateId]=@userid


--when NOT MATCHED BY target then 
--insert  ( [DocumentId] ,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction]
--,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy]
--,[AmountRetail],[AmountWholeSale],[Payment],[Deficit],[Description])
--values (@id,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate]
--,[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[Quantity]*[PriceBuy]
--, [Quantity] * [PriceRetail] ,[Quantity]*[PriceWholeSale] ,[Payment],[AmountBuy]-[Payment],[Description] )

--when NOT MATCHED BY source and target.DocumentId=@Id then update set [DeleteId]=@userId
--,[DeleteDate]=getdate();

--if @@TRANCOUNT>0
--   commit;
--if @operationType=12 goto spSelect;
--RETURN 0
--end

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



INSERT INTO Accounting.Stock (GoodId,CreatId,CreateDate,WarehouseId,DocumentId,Quantity,PriceBuy,PrcieRetail,PriceWholeSale) VALUES (@goodId1,@userId,GETDATE(),@wareHouseId,@id,@quantity1,@priceBuy1,@priceRetail1,@priceWholeSale1)



FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1


END

CLOSE crs
DEALLOCATE crs



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
select  d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName] 
	,d.[Description]
	,d.ContractId
	,d.CustomerId
	,d.CustomerName
	,r.Id ReasonId
	,r.Name ReasonName
	,dd.Series
	

         ,max(dd.AmountBuy) AmountBuy
         ,max(dd.AmountRetail) AmountRetail
         ,max(dd.AmountWholeSale) AmountWholeSale
		 ,max(dd.PriceWholeSale) PriceWholeSale
	     ,max(dd.Payment) Payment
	     ,max(dd.Deficit) Deficit
from [Accounting].[VwDocument] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId 
 LEFT JOIN Accounting.Document dw ON dw.Id=d.Id
 LEFT JOIN [Accounting].[Reason] r ON r.Id=dw.ReasonId
 JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
 where dw.AccountId=6 AND d.DeleteId IS NULL
 
 --c.ContractTypeId=2--satiw ucun
 group by 
     d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName] 	
	,d.[Description]
	,d.ContractId
	,d.CustomerId
	,d.CustomerName
	,r.Id 
	,r.Name 
	,dd.Series;
end

