CREATE TABLE [Service].[Employee]
(
	[Id] int NOT NULL IDENTITY,  
	[Name] nvarchar(200) null,
	[Surname] nvarchar(200) null,
	[Patryonmic] nvarchar(200) null,
	[BirthOfDate] date null,
	[BirthPlace] nvarchar(200),
	[PassportPin] nvarchar(200),
	[PassportSeries] nvarchar(200) null,
	[ProjectId] int null,
	[SalaryId] int null,
	[WorkPlaceId] int null,
	[Description] nvarchar(500),
	[Description1] nvarchar(500),
	[Description2] nvarchar(500),
	[Description3] nvarchar(500),
	[Description4] nvarchar(500),
	[Description5] nvarchar(500),
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
	CONSTRAINT PKEmployee PRIMARY KEY (Id)

)
