CREATE TABLE [Accounting].[CashMoney]
( 
	[Id] [INT] IDENTITY(1,1) NOT NULL,
	[CashId] int null,
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
	[CreateDate] DATETIME  NULL DEFAULT getdate() 
  
    CONSTRAINT PKCashMoney PRIMARY KEY (Id)
)

