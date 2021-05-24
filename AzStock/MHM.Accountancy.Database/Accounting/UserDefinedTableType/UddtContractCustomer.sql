create type [Accounting].[UddtContractCustomer]
AS TABLE
(
    [Id] int NOT NULL ,
    [CustomerId]  int null,
	[ContractDate] datetime null,
	[CurrencyId] int null,
	[OperationTypeId] int null,
	[CompanyId] int null,
    [ContractTypeId] int null,
	[Description] nvarchar(500) null

)