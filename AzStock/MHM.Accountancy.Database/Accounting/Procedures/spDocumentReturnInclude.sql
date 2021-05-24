CREATE PROCEDURE [Accounting].[spDocumentReturnInclude]
	@userId int ,
	@operationType tinyint = null,
	@id INT = NULL,
	@menuId INT,
	@paymentid INT=NULL,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
	@description nvarchar(500)=null,
	@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
	@accountId int=null,
	@paymentDate datetime =null, 
		@partnerOrderNo nvarchar(200)=null,
		@mainNumber   int=null,
    
	@detail [Accounting].[UddtIncludeReturn] READONLY
	


AS

BEGIN
IF @operationType IN (1,11)
GOTO spAdd;
--ELSE IF @operationType IN (2,12)
--GOTO spedit;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4
GOTO spSelect;


spAdd:
BEGIN
BEGIN TRAN 

IF EXISTS(SELECT * FROM @detail d
JOIN Accounting.VwGoodStock st WITH(ROWLOCK,HOLDLOCK) ON d.GoodId=st.Id
WHERE ISNULL(st.quantity,0) - d.Quantity<0 AND st.WarehouseId=@wareHouseId)
BEGIN
RAISERROR('Stokda kifayet qeder mehsul yoxdur',16,1)
ROLLBACK
RETURN
END 
ELSE 
BEGIN
INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],[ContractId],[AccountId],[PaymentDate],[PartnerOrderNo],[MainNumber],CreateId,CreateDate)
VALUES (@includeDate,@companyId,@wareHouseId,@description,@paymentTypeId,@contractId,@accountId,@paymentDate,@partnerOrderNo,@mainNumber,@userId,GETDATE())

SET @id=SCOPE_IDENTITY();

DECLARE @totalAmount DECIMAL(26,6)=0,@payment DECIMAL(26,6),@amountBuy DECIMAL(26,6),@goodId INT,@barcodeId INT,@series nvarchar(200),@dateOfProduction datetime,@lastExpirationDate DATETIME
,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6)
--declare sss cursor for
--(select GoodId,Quantity from Accounting.Stock)
--open sss
--fetch next from sss into @stockgoodId,@stockquantity
--while @@FETCH_STATUS=0
--begin
DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount=@totalAmount+@amountBuy
 

INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[CreateId],[CreateDate])
values(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy,@quantity*@priceRetail,@quantity*@priceWholeSale,@payment, @amountBuy,@userId,GETDATE())
 

UPDATE Accounting.Stock
SET
Quantity=Quantity-@quantity
WHERE GoodId=@goodId AND Quantity>0 and WarehouseId=@wareHouseId AND UpdateId IS null


FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale


end

close crs
deallocate crs
END
INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
VALUES(@id,@accountId,@customerId,ISNULL(@paymentTypeId,1),@payment,@totalAmount)
SET @paymentid=SCOPE_IDENTITY();

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
--[PaymentTypeId]=@paymentTypeId,
--[ContractId]=@contractId,
--[AccountId]=@accountId

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
--,[Quantity]*[PriceWholeSale] [AmountWholeSale],ISNULL([Payment],0) [Payment],[AmountBuy] [Deficit]
--FROM @detail) source on target.Id=source.Id
--when MATCHED and target.DocumentId=@id THEN 


--update set [AccountId]=source.[AccountId],[BarCodeId]=source.[BarCodeId],[Series]=source.[Series]
--,[DateOfProduction]=source.[DateOfProduction],[LastExpirationDate]=source.[LastExpirationDate]
--,[Quantity]=source.[Quantity],[UnitId]=source.[UnitId],[PriceBuy]=source.[PriceBuy]
--,[PriceRetail]=source.[PriceRetail],[PriceWholeSale]=source.[PriceWholeSale]
--,[AmountBuy]=source.[AmountBuy],[AmountRetail]=source.[AmountRetail]
--,[AmountWholeSale]=source.[AmountWholeSale],[Payment]=isnull(target.[Payment],0)
--,[Deficit]=source.[AmountBuy]


--when NOT MATCHED BY target then 
--insert  ( [DocumentId] ,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction]
--,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy]
--,[AmountRetail],[AmountWholeSale],[Payment],[Deficit])
--values (@id,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate]
--,[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[Quantity]*[PriceBuy]
--, [Quantity] * [PriceRetail] ,[Quantity]*[PriceWholeSale] ,isnull([Payment],0),[AmountBuy] )

--when NOT MATCHED BY source and target.DocumentId=@Id then update set [DeleteId]=@userId
--,[DeleteDate]=getdate();

--if @@TRANCOUNT>0
--   commit;
--if @operationType=12 goto spSelect;
--RETURN 0
--end
------------------------------------------------
spDelete:
BEGIN
DECLARE @totalAmount1 DECIMAL(26,6)=0,@payment1 DECIMAL(26,6),@amountBuy1 DECIMAL(26,6),@goodId1 INT,@barcodeId1 INT,@series1 nvarchar(200),@dateOfProduction1 datetime,@lastExpirationDate1 DATETIME
,@quantity1 DECIMAL(26,6),@unitId1 INT,@priceBuy1 DECIMAL(26,6),@priceRetail1 DECIMAL(26,6),@priceWholeSale1 DECIMAL(26,6)
DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1 
,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1
WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount1=@totalAmount1+@amountBuy1
INSERT INTO Accounting.Stock (GoodId,CreatId,CreateDate,WarehouseId,DocumentId,Quantity,PriceBuy,PrcieRetail,PriceWholeSale) VALUES (@goodId1,@userId,GETDATE(),@wareHouseId,@id,@quantity1,@priceBuy1,@priceRetail1,@priceWholeSale1)
FETCH NEXT FROM crs INTO @accountId ,@payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1
end
CLOSE crs
deallocate crs
update [Accounting].[Document]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;
DELETE FROM Accounting.Payment 
WHERE DocumentId=@id
UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id
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
WHERE AccountId=9 and d.DeleteId is null
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