CREATE TABLE [Service].[ObjectDocument]
(
	[Id] int NOT NULL IDENTITY, 
	[Name] nvarchar(200) null,
	[ContractNo] nvarchar(200) null,
	[WorkType] nvarchar(200) null,
	[Description] nvarchar(500) null,
	[Description1] nvarchar(500) null,
	[Description2] nvarchar(500) null,
	[Description3] nvarchar(500) null,
	[Description4] nvarchar(500) null,
	[Description5] nvarchar(500) null,
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
	CONSTRAINT PKObjectDocument PRIMARY KEY (Id)
)
