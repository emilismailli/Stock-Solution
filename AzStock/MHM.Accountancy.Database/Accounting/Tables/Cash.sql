CREATE TABLE [Accounting].[Cash]
(
	[Id] INT IDENTITY NOT NULL,
	[CompanyId] int not null,
	[CashName] nvarchar(100) NOT NULL,
	[Balance] decimal(26,6) null,
	--[AccountId] int null,
	--[WareHouseId] int not null,
	[Description] nvarchar(500) NULL,
	[CreateId] int  null,
	[CreateDate] DATETIME  NULL DEFAULT getdate(),
	[IsActive] [bit] NULL, 
	CONSTRAINT PKCash PRIMARY KEY (id)
)
