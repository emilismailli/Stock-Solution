CREATE TABLE [Accounting].[RetailSaleTmp]
(
	[Id] int NOT NULL IDENTITY, 
	[BarcodeId]  int null,
	[DocumentDetailTmpId] int  null,
	[AccountId] int null,
    [GoodId] INT NULL, 
	[Quantity] DECIMAL(26, 6) NULL, 
    [PriceRetail] DECIMAL (26, 6) NULL, 
    [PriceBuy] DECIMAL (26, 6) NULL, 
    [PriceWholeSale] DECIMAL (26, 6) NULL, 

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
	CONSTRAINT PKRetailSaleTmp PRIMARY KEY (Id)
)
