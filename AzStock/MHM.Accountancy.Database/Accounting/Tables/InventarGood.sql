CREATE TABLE [Accounting].[InventarGood]
(
	[Id] int NOT NULL IDENTITY, 
    [DocumentId] INT NULL, 
    [DifferenceQuantity] DECIMAL(26, 6) NULL, 
    [StockQuantity] DECIMAL(26, 6) NULL, 
    [Quantity] DECIMAL(26, 6) NULL, 
    [IsActive] BIT NULL, 
    [CreateId] INT NULL, 
    [CreateDate] DATETIME NULL, 
    [UpdateId] INT NULL, 
    [UpdateDate] DATETIME NULL, 
    [DeleteId] INT NULL, 
    [DeleteDate] DATETIME NULL, 
    [ReadOnly] DATETIME NULL, 
    [DocTypeId] INT NULL, 
    [DocCertId] INT NULL, 
    [DocSeriesId] INT NULL,
	CONSTRAINT PKInevntarGood PRIMARY KEY (Id)
)
