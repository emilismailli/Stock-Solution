CREATE TABLE [Accounting].[Good]
(
    [Id] INT NOT NULL PRIMARY KEY identity(1,1), 
	[BarcodeId] bigint null,
	[DocumentDetailId] int null,
    [GoodName]              nvarchar(200) null,
	[GoodTypeId]             int null,
	[ManufacturerCompanyId]   int null,
	[RegionId] int null,
	[UnitId]                int null,
	[DoseId]               int null,
	[PackingTypeId]            int null,
	[Description]     nvarchar(500) null,
	
	[GoodCode]     nvarchar(500) null,
	
	[Photo] [varbinary](max) NULL,
	--[DocumentId] int null,
	--[ContractId]     int null,
	--[ContractTypeId] int null,
    [CreateId] INT NULL, 
    [CreateDate] DATETIME NULL DEFAULT getdate(), 
    [ModifyId] INT NULL, 
    [ModifyDate] DATETIME NULL,
	[DeleteId] int null,
	[DeleteDate] DATETIME null,
	[DocTypeId] INT NULL,
	[DocCertId] int null,
	[DocSeriesId] int null
)
