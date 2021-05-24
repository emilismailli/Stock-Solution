CREATE TABLE [Accounting].[TotalReport]
(
	[Id] INT NOT NULL identity(1,1) ,
	[TotalAmount] decimal (26,6 ),
	[TotalCost] decimal (26,6),
	[TotalProfit] decimal (26,6),
	[IsActive] BIT NULL, 
    [CreateDate] DATETIME NOT NULL DEFAULT getdate()
	 
)