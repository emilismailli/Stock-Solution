CREATE TABLE [dbo].[Transport]
(
	[Id] int NOT NULL IDENTITY,
	[GoodId] int NULL,
	[BarcodeId] int null,
    [Quantity] DECIMAL(26, 6) NULL,
	[PriceBuy] DECIMAL(26, 6) NULL,
	[PriceRetail] DECIMAL(26, 6) NULL,
	[PriceWholeSale] DECIMAL(26, 6) NULL,
	[WareHouseId] INT NULL,
    [CreateId] INT NULL, 
    [CreateDate] DATETIME NULL, 
    [UpdateId] INT NULL, 
    [UpdateDate] DATETIME NULL, 
    [DeleteId] INT NULL, 
    [DeleteDate] DATETIME NULL, 
	CONSTRAINT PKTransport PRIMARY KEY (Id)
)
