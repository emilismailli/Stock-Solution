CREATE TABLE [Accounting].[Inventar]
(
	[Id]                                 int NOT NULL IDENTITY,
	[DocumentInventarId]            int NULL,
	[GoodId]                        int NULL,
	[FullGoodName]              NVARCHAR(50) NULL,
    [DifferenceQuantity]       DECIMAL(26, 6) NULL, 
    [StockQuantity]              DECIMAL(26, 6) NULL, 
    [Quantity]                   DECIMAL(26, 6) NULL,
	[WareHouseId]                     INT NULL,
    [CreateId]                    INT NULL, 
    [CreateDate]                   DATETIME NULL, 
    [UpdateId]                     INT NULL, 
    [UpdateDate]            DATETIME NULL, 
    [DeleteId]                  INT NULL, 
    [DeleteDate]                                DATETIME NULL, 
	CONSTRAINT PKInevntar                   PRIMARY KEY (Id)
)