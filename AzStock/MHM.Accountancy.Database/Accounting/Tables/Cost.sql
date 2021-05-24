CREATE TABLE [Accounting].[Cost]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
	[Person] nvarchar(250) null,
	[Place] nvarchar(200) null,
	[Amount]  decimal(26,6) null,
	[CostDate] datetime null,
	[PaymentTypeId] int null,
	[Description] nvarchar(max) null,
	
	[CreateId] int   null,
	[CreateDate] DATETIME   NULL DEFAULT getdate(), 
	[UpdateId] int null,
	[UpdateDate] DATETIME ,
	[DeleteId] int null,
	[DeleteDate] DATETIME,
	CONSTRAINT PKCost PRIMARY KEY (Id)
)
