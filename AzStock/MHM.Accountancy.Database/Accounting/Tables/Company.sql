﻿CREATE TABLE [Accounting].[Company]
(
	[Id] INT NOT NULL IDENTITY,
	[TypeId] INT NOT NULL,
	[ParentId] INT NULL,
    [PrivateNumber] NVARCHAR(200) NULL,
    [CompanyName] NVARCHAR(200) NULL, 
    [CompanyLeader] NVARCHAR(200) NULL, 
	[RegionId] int null,
    [WorkTypeId] INT NULL, 
    [Voen] NVARCHAR(50) NULL, 
    [CurrencyId] INT NULL, 
    [BankId] INT NULL, 
    [BankSwift] NVARCHAR(200) NULL, 
    [LegalAddress] NVARCHAR(200) NULL, 
    [ActualAddress] NVARCHAR(200) NULL, 
    [Email] NVARCHAR(200) NULL, 
    [Tel] NVARCHAR(200) NULL, 
	[ContractNumber] nvarchar(200),
	[ContractDate]   datetime ,
	 [Date] datetime NULL,
    [Description] NVARCHAR(500) NULL,
	[CreateId] int  null,
	[CreateDate] DATETIME  NULL DEFAULT getdate(), 
	[UpdateId] int null,
	[UpdateDate] DATETIME ,
	[DeleteId] int null,
	[DeleteDate] DATETIME,
	[DocTypeId] INT NULL,
	[DocCertId] int null,
	[DocSeriesId] int null,
	CONSTRAINT PKCompany PRIMARY KEY (Id)
)
