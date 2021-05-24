CREATE TABLE [Accounting].[Cashier]
(
	[Id] INT IDENTITY NOT NULL,
	[CashierName] [nvarchar](100)    NULL,
	[Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	CONSTRAINT PKCashier PRIMARY KEY (id)
)

