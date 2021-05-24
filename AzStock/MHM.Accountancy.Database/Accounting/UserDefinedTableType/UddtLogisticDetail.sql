create type [Accounting].[UddtLogisticDetail]
AS TABLE
(
    --[Id] int NOT NULL IDENTITY,
	[LogisticId] int  null, 
	[BarcodeId]  int null,
    [GoodId] INT NULL,  
	[Quantity] DECIMAL(26, 6) NULL, 
	[UnitId] INT NULL,
	[Description] nvarchar(500) null

)