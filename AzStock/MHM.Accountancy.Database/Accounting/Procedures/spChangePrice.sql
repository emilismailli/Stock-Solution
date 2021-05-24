create PROC Accounting.spChangePrice
@userId int,
@description nvarchar(500)='--',

@detail [Accounting].[UddtChangePrice] READONLY
AS
BEGIN
DECLARE  @goodId INT,@priceBuy decimal(25,5),@priceRetail decimal(25,5),@priceWholeSale decimal(25,5),@newpriceBuy DECIMAL(25,5),@newpriceRetail DECIMAL(25,5),@newpriceWholeSale DECIMAL(25,5)

DECLARE crs CURSOR FOR 
(SELECT [GoodId],[PriceBuy],[PriceRetail],[PriceWholeSale],[NewPriceBuy],[NewPriceRetail],[NewPriceWholeSale]
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @goodId,@priceBuy,@priceRetail,@priceWholeSale,@newpriceBuy,@newpriceRetail,@newpriceWholeSale

WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @stockId int,@quantity DECIMAL(25,5)

SELECT @stockId=s.Id,@quantity=s.Quantity FROM Accounting.Stock s 
WHERE s.Id=(SELECT max(s2.Id) FROM Accounting.Stock s2 WHERE s2.GoodId=@goodId)

UPDATE Accounting.Stock 
SET

    Accounting.Stock.PriceBuy = @newpriceBuy, 
    Accounting.Stock.PrcieRetail = @newpriceRetail, 
    Accounting.Stock.PriceWholeSale = @newpriceWholeSale, 
    Accounting.Stock.UpdateDate = getdate(),
    Accounting.Stock.UpdateId = @userId
WHERE Id=(SELECT MAX(s.Id) FROM Accounting.Stock s WHERE s.GoodId=@goodId)
	

	INSERT INTO Accounting.LastPrice (StockId,GoodId      ,LastPriceBuy,LastPriceRetail,LastPriceWholeSale    ,PriceBuy,PriceRetail,PriceWholeSale  ,Description,CreateId,CreateDate) 
	VALUES (@stockId,@goodId,@priceBuy,@priceRetail,@priceWholeSale                                           ,@newpriceBuy,@newpriceRetail,@newpriceWholeSale,@description,@userId,GETDATE())

UPDATE Accounting.DocumentDetail
SET


    Accounting.DocumentDetail.PriceBuy =@newpriceBuy, 
    Accounting.DocumentDetail.PriceRetail =@newpriceRetail, 
    Accounting.DocumentDetail.PriceWholeSale = @newpriceWholeSale,
	Accounting.DocumentDetail.AmountBuy =@quantity*@newpriceBuy, 
	Accounting.DocumentDetail.AmountRetail =@quantity*@newpriceRetail, 
    Accounting.DocumentDetail.AmountWholeSale = @quantity*@newpriceWholeSale,
    Accounting.DocumentDetail.UpdateId = @userId, 
    Accounting.DocumentDetail.UpdateDate = getdate(),
	Accounting.DocumentDetail.Description='Qiymet Deyisme Edilib'

	WHERE Id=(SELECT MAX(s.Id) FROM Accounting.DocumentDetail s WHERE s.GoodId=@goodId AND s.AccountId=3)
    
	FETCH NEXT FROM crs INTO @goodId,@priceBuy,@priceRetail,@priceWholeSale,@newpriceBuy,@newpriceRetail,@newpriceWholeSale


end

close crs
deallocate crs

	END


--create PROC Accounting.spChangePrice
--@userId int,
--@description nvarchar(500)='--',

--@detail [Accounting].[UddtChangePrice] READONLY
--AS
--BEGIN
--DECLARE  @goodId INT,@priceBuy decimal(25,5),@priceRetail decimal(25,5),@priceWholeSale decimal(25,5),@newpriceBuy DECIMAL(25,5),@newpriceRetail DECIMAL(25,5),@newpriceWholeSale DECIMAL(25,5)

--DECLARE crs CURSOR FOR 
--(SELECT [GoodId],[PriceBuy],[PriceRetail],[PriceWholeSale],[NewPriceBuy],[NewPriceRetail],[NewPriceWholeSale]
--FROM @detail)
--OPEN crs
--FETCH NEXT FROM crs INTO @goodId,@priceBuy,@priceRetail,@priceWholeSale,@newpriceBuy,@newpriceRetail,@newpriceWholeSale

--WHILE @@FETCH_STATUS=0
--BEGIN
--DECLARE @stockId int,@quantity DECIMAL(25,5)

--SELECT @stockId=s.Id,@quantity=s.Quantity FROM Accounting.Stock s 
--WHERE s.Id=(SELECT max(s2.Id) FROM Accounting.Stock s2 WHERE s2.GoodId=@goodId)

--UPDATE Accounting.Stock 
--SET

--    Accounting.Stock.PriceBuy = @newpriceBuy, 
--    Accounting.Stock.PrcieRetail = @newpriceRetail, 
--    Accounting.Stock.PriceWholeSale = @newpriceWholeSale, 
--    Accounting.Stock.UpdateDate = getdate(),
--    Accounting.Stock.UpdateId = @userId
--WHERE Id=(SELECT MAX(s.Id) FROM Accounting.Stock s WHERE s.GoodId=@goodId)
	

--	INSERT INTO Accounting.LastPrice (StockId,GoodId      ,LastPriceBuy,LastPriceRetail,LastPriceWholeSale,PriceBuy,PriceRetail,PriceWholeSale  ,Description,CreateId,CreateDate) 
--	VALUES (@stockId,@goodId,@priceBuy,@priceRetail,@priceWholeSale                             ,@newpriceBuy,@newpriceRetail,@newpriceWholeSale,@description,@userId,GETDATE())

--UPDATE Accounting.DocumentDetail
--SET


--    Accounting.DocumentDetail.PriceBuy =@newpriceBuy, 
--    Accounting.DocumentDetail.PriceRetail =@newpriceRetail, 
--    Accounting.DocumentDetail.PriceWholeSale = @newpriceWholeSale,
--	Accounting.DocumentDetail.AmountBuy =@quantity*@newpriceBuy, 
--	Accounting.DocumentDetail.AmountRetail =@quantity*@newpriceRetail, 
--    Accounting.DocumentDetail.AmountWholeSale = @quantity*@newpriceWholeSale,
--    Accounting.DocumentDetail.UpdateId = @userId, 
--    Accounting.DocumentDetail.UpdateDate = getdate(),
--	Accounting.DocumentDetail.Description='Qiymet Deyisme Edilib'

--	WHERE Id=(SELECT MAX(s.Id) FROM Accounting.DocumentDetail s WHERE s.GoodId=@goodId AND s.AccountId=3)
    
--	FETCH NEXT FROM crs INTO @goodId,@priceBuy,@priceRetail,@priceWholeSale,@newpriceBuy,@newpriceRetail,@newpriceWholeSale


--end

--close crs
--deallocate crs

--	END