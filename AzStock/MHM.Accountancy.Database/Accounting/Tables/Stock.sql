CREATE TABLE [Accounting].[Stock]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
	[GoodId] int null,
	[CreatId] INT NULL,
	[WarehouseId] int null,
	[DocumentId] int null,
	--[ContractTypeId] int null,
	--[ContractId] int null,
	[Series] NVARCHAR(50) NULL,
	[Quantity] decimal(25,5) null, 
    [PriceBuy] DECIMAL(26, 6) NULL, 
    [PrcieRetail] DECIMAL(26, 6) NULL, 
    [PriceWholeSale] DECIMAL(26, 6) NULL , 
    [CreateDate] DATETIME NULL, 
    [UpdateDate] DATETIME NULL, 
    [UpdateId] INT NULL, 
)
