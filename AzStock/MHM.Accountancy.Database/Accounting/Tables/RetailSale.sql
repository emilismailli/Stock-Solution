CREATE TABLE [Accounting].[RetailSale]
(
	[Id] int NOT NULL IDENTITY, 
	[BarcodeId]  int null,
	[DocumentDetailId] int  null,
	[AccountId] int null,
    [GoodId] INT NULL, 
	[Quantity] DECIMAL(26, 6) NULL, 
    [PriceRetail] DECIMAL (26, 6) NULL, 
	[PriceBuy] DECIMAL (26, 6) NULL, 
	[PriceWholeSale] DECIMAL (26, 6) NULL,
	[Percent] nvarchar(50) null,
	[DiscountNumber]  nvarchar(50) null,
	[WareHouseId] int null,
	[CustomerId] int null,
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
	CONSTRAINT PKRetailSale PRIMARY KEY (Id)
)
