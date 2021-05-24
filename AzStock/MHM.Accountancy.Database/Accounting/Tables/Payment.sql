CREATE TABLE [Accounting].[Payment](
	[Id] [INT] IDENTITY(1,1) NOT NULL,
	[CashId] int null,
	[CashFromId] int null,
	[ExpenseId] int null,
	[AccountId] [int]  NULL,
	[CustomerId] [int] NULL,
	[CustomerWareHouseId] int null,
	[DocumentId] [int] NULL,
	[PaymentTypeId] INT NULL,
	[Payment] [decimal](26, 6) NULL,
	[Deficit] [decimal](26, 6) NULL,
	[Description] NVARCHAR(500) NULL,

	[Percent] NVARCHAR(500) NULL,
	[PaymentDate] datetime null,
	[CreateDate] DATETIME  NULL DEFAULT getdate() ,
		[DeleteId] int null,
	[DeleteDate] DATETIME  NULL DEFAULT getdate(),

  
    [UpdateId] INT NULL, 
    [UpdateDate] DATETIME NULL, 
    CONSTRAINT PKPayment PRIMARY KEY (Id))