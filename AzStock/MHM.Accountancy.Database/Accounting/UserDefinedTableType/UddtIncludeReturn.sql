create type [Accounting].[UddtIncludeReturn]
AS TABLE
(
    [Id] int NOT NULL , 
	[StoGoodId] int null,
	[CompanyName] nvarchar(200),
	[CustomerName] nvarchar(200),
	[BarcodeId] bigint null,
	[AccountId] int null,
    [GoodId] INT NULL, 
    [Series] nvarchar(200) NULL, 
    [DateOfProduction] DATETIME NULL, 
    [LastExpirationDate] DATETIME NULL, 
	[Quantity] DECIMAL(26, 6) NULL, 
	[UnitId] int null,
    [PriceBuy] DECIMAL (26, 6) NULL, 
    [PriceRetail] DECIMAL (26, 6) NULL, 
    [PriceWholeSale] DECIMAL (26, 6) NULL, 
    [AmountBuy] DECIMAL (26, 6) NULL, 
    [AmountRetail] DECIMAL (26, 6) NULL, 
    [AmountWholeSale] DECIMAL (26, 6) NULL, 
	[Payment] DECIMAL(26, 6) NULL, 
	[Deficit] DECIMAL(26, 6) NULL
)