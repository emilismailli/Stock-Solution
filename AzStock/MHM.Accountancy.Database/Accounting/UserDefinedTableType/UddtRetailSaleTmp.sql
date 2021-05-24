create type [Accounting].[UddtRetailSaleTmp]
AS TABLE
(
    --[Id] int NOT NULL ,
	[GoodId] INT NOT NULL, 
	[Quantity] decimal(26,6) null,
	[FullGoodName] nvarchar(200) null,
	[BarcodeId] bigint null,
	[Barcode] varchar(200) null,
    [AccountId] int null,
	[GoodName] nvarchar(200) null,
    [PriceRetail] DECIMAL (26, 6) NULL
	--,
	--[PriceBuy] DECIMAL (26, 6) NULL,
	--[PriceWholeSale] DECIMAL (26, 6) NULL
)