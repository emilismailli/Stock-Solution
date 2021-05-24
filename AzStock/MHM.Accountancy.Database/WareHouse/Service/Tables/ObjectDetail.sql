CREATE TABLE [Service].[ObjectDetail]
(
	[Id] int NOT NULL IDENTITY, 
	[GoodName] nvarchar(200) null,
	[Price] decimal (26,6) null,
	[Quantity] decimal (26,6) null,
 
	[CreateId] int  null,
	[CreateDate] DATETIME  NULL DEFAULT getdate(), 
	[UpdateId] int null,
	[UpdateDate] DATETIME ,
	[DeleteId] int null,
	[DeleteDate] DATETIME,
	[ReadOnly] DATETIME,
	[DocTypeId] INT NULL,
	[DocCertId] int null,
	[DocSeriesId] int null,
	[IsFiltered] bit null
	CONSTRAINT PKObjectDetail PRIMARY KEY (Id)
)