CREATE TABLE [Accounting].[Expense]
(
	 
	[Id] INT IDENTITY NOT NULL,
	[ParentId] int NULL,
	[Code] VARCHAR(40) NOT NULL, 
	[ExpenseName] [nvarchar](100)   NULL, 
	[Description] nvarchar(500) NULL, 
	[CreateDate] DATETIME  NULL DEFAULT getdate(),
	
    [IsActive] BIT NULL, 
	CONSTRAINT UIExpenseCode UNIQUE (Code),
    CONSTRAINT PKRefExpense PRIMARY KEY (Id)
)
