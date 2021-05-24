CREATE TABLE [Accounting].[Contract]
(
	[Id] INT IDENTITY NOT NULL,
    [CustomerId] INT NULL,
	[ContractDate] datetime null,
	[CurrencyId]  int null,
	[OperationTypeId] int null,
	[CompanyId] INT NULL,  
    [ContractTypeId] INT NULL, 
	[Description] nvarchar(500) NULL,
	[IsActive] bit NULL, 
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
    CONSTRAINT PKRefContract PRIMARY KEY (id),
	CONSTRAINT UqCustomerContract UNIQUE(CompanyId,CustomerId,ContractTypeId)
)