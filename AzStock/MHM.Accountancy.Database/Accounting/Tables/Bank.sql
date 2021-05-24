CREATE TABLE [Accounting].[Bank]
(
	[Id] int NOT NULL IDENTITY,
	[GroupId] int,
	[Name] nvarchar(200) not null,
	[Swift] nvarchar(200),
	[Voen] varchar(70),
	[CurrencyId] int,
	[RegionId] int,
	[CreateId] int  null,
	[CreateDate] DATETIME NOT NULL DEFAULT getdate(), 
	[UpdateId] int null,
	[UpdateDate] DATETIME ,
	[DeleteId] int null,
	[DeleteDate] DATETIME,
	[ReadOnly] DATETIME,
	[DocTypeId] INT NULL,
	[DocCertId] int null,
	[DocSeriesId] int null
	CONSTRAINT PKBank PRIMARY KEY (Id)
	--CONSTRAINT UQCode UNIQUE (Code)
)
