CREATE TABLE [Accounting].[PaymentRetail]
(
	[Id] [INT] IDENTITY(1,1) NOT NULL,
	[DocumentId] int null,
	[CustomerId] [int] NULL,
	[PaymentTypeId] INT NULL,
	[Payment] [decimal](26, 6) NULL,
	[Deficit] [decimal](26, 6) NULL,
	[TotalSum] [DECIMAL](26, 6) NULL,
	[Description] NVARCHAR(500) NULL,
	[Percent] NVARCHAR(500) NULL,
	[DiscountNumber]NVARCHAR(500) NULL,
	[CreateId] INT NULL,
	[CreateDate] DATETIME  NULL DEFAULT getdate() 
  
    CONSTRAINT PKPaymentRetail PRIMARY KEY (Id)
)
