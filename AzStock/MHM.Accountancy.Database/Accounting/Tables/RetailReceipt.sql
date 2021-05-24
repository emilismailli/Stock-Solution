CREATE TABLE [Accounting].[RetailReceipt]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	[GoodId] int ,
	[BarcodeId] int ,
	[Quantity] decimal (26,6),
	[CreateId] int,
	[CreateDate] datetime,
	[StatusId]  int, 
    [InfoJson] NVARCHAR(MAX) NULL  

)
