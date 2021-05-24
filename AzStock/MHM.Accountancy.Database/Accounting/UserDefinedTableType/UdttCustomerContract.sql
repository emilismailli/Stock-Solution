CREATE TYPE [Accounting].[CustomerContract] 
AS TABLE
(
	[Id] INT NOT NULL IDENTITY,
    [PrivateNumber] NVARCHAR(200) NULL, 
    [Company] NVARCHAR(200) NULL, 
    [CompanyLeader] NVARCHAR(200) NULL, 
    [WorkTypeId] INT NULL, 
    [Voen] NVARCHAR(50) NULL, 
    [Currency] INT NULL, 
    [OperatorBankName] INT NULL, 
    [BankSwift] NVARCHAR(200) NULL, 
    [LegalAddress] NVARCHAR(200) NULL, 
    [ActualAddress] NVARCHAR(200) NULL, 
    [Email] NVARCHAR(200) NULL, 
    [Tel] NVARCHAR(200) NULL, 
	[Date] datetime NULL,
	[Description] nvarchar(500) NULL,
	[ContractDate] datetime null,
	[ContractNo]  nvarchar(200) null,
	[CurrencyName]  int null,
	[OperationType] int null,
	[CompanyName] INT NULL, 
    [CustomerName] INT NULL, 
    [ContractTypeName] INT NULL
)
