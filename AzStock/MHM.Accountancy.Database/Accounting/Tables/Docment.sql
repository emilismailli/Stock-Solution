
CREATE TABLE [Accounting].[Document]
(
	[Id] int NOT NULL IDENTITY,  
	[AccountId] int null,
    [IncludeDate] DATETIME NULL DEFAULT getdate(), 
    [CompanyId] INT NULL, 
	[SaleNo] int null,
	[ContractId] int null,
    [WareHouseId] INT NULL, 
	[FromWarehouseId] int null,
	[PaymentTypeId] int null,
	[Description] nvarchar(500) null,
	[ReasonId] int null,
	[PaymentDate]    datetime null,
	[PartnerOrderNo] nvarchar(200) null,
	[AdditionalCost] decimal(26,6) null,
	[MainNumber] int null,
	[CashierId] int null,
	[CreateId] int  null,
	[CreateDate] DATETIME  NULL DEFAULT getdate(), 
	[UpdateId] int null,
	[UpdateDate] DATETIME ,
	[DeleteId] int null,
	[DeleteDate] DATETIME,
		[LockId] int null,
	[LockDate] DATETIME ,
	[ReadOnly] DATETIME,
	[DocTypeId] INT NULL,
	[DocCertId] int null,
	[DocSeriesId] int null,
	[IsFiltered] bit null
	CONSTRAINT PKDocument PRIMARY KEY (Id)
)