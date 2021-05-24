CREATE TABLE [Accounting].[DocumentTmp]
(
	[Id] int NOT NULL IDENTITY, 
    [CompanyId] INT NULL, 
	[ContractId] int null,
    [WareHouseId] INT NULL,  

	 [BarcodeId] int,
	[GoodId] int not null,
	[Quantity] decimal(18,4) not null,

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
	CONSTRAINT PKDocumentTmp PRIMARY KEY (Id)
)
