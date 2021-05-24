create type [Accounting].[UddtOfflineSaleDetail]
AS TABLE
(
    --[Id] int NOT NULL IDENTITY,
	[LogisticId] int  null, 
	[BarcodeId]  int null,
    [GoodId] INT NULL,  
	[Quantity] DECIMAL(26, 6) NULL, 
	[PriceWholeSale]  DECIMAL(26, 6) NULL, 
	[AmountWholeSale] DECIMAL(26, 6) NULL, 
	[Percent] nvarchar(50) NULL,
	[UnitId] INT NULL,
	[Description] nvarchar(500) null

)