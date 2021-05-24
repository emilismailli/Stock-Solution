CREATE TABLE [Accounting].[CustomerDebt]
(
	[Id] [INT] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[Deficit] [decimal](26, 6) NULL,
	[UpdateDate] DATETIME  NULL DEFAULT getdate(), 
 CONSTRAINT PKCustomerDebt PRIMARY KEY (Id)
 )
