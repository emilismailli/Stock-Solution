CREATE TABLE [Accounting].[BarcodeGenerate]
(
	[Id] int NOT NULL IDENTITY, 
	[BarcodeGen] varchar(200) null,
	[CreateId] int null,
	[CreateDate] DATETIME not null default getdate(),
	[UpdateId] int null,
	[UpdateDate] DATETIME ,
	[DeleteId] int null,
	[DeleteDate] DATETIME,
	CONSTRAINT PKBarcodeGenerate PRIMARY KEY (Id)
)
