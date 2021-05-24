CREATE TABLE [Accounting].[LastPrice]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
    [StockId] INT NULL, 
    [GoodId] INT NULL, 
	[CreateId] INT NULL,
	[CreateDate] DATETIME,
    [PriceBuy] DECIMAL(25, 5) NULL, 
    [PriceRetail] DECIMAL(25, 5) NULL, 
    [PriceWholeSale] DECIMAL(25, 5) NULL,
    [LastPriceBuy] DECIMAL(25, 5) NULL, 
    [LastPriceRetail] DECIMAL(25, 5) NULL, 
    [LastPriceWholeSale] DECIMAL(25, 5) NULL, 
    [Description] NVARCHAR(500) NULL, 
    
)
