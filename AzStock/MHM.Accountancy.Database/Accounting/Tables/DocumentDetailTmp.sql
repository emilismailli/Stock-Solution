CREATE TABLE [Accounting].[DocumentDetailTmp]
(
	[Id] int NOT NULL IDENTITY, 
	[BarcodeId]  int null,
	[DocumentTmpId] int  null,
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
	 --[Payment] DECIMAL(26, 6) NULL, 
	 --[Deficit] DECIMAL(26, 6) NULL, 
	[IsActive] bit default 1 not null,
	[CreateId] int  null,
	[CreateDate] DATETIME  NULL DEFAULT getdate(), 
	[UpdateId] int null,
	[UpdateDate] DATETIME ,
	[DeleteId] int null,
	[DeleteDate] DATETIME,
	[ReadOnly] DATETIME,
	[DocTypeId] INT NULL,
	[DocCertId] int null,
	[DocSeriesId] int null
	CONSTRAINT PKDocumentDetailTmp PRIMARY KEY (Id)
)
