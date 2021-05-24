CREATE TABLE [Accounting].[Barcode]
(
	[Id] int NOT NULL IDENTITY, 
	[GoodId] int null,
	[Barcode] varchar(200) null,
	[CreateId] int null,
	[CreateDate] DATETIME not null default getdate(),
	[UpdateId] int null,
	[UpdateDate] DATETIME ,
	[DeleteId] int null,
	[DeleteDate] DATETIME,
	CONSTRAINT PKBarcode PRIMARY KEY (Id)
)
