CREATE TABLE [Accounting].[LogisticDetail]
(
	[Id] int NOT NULL IDENTITY, 
	[LogisticId] int  null, 
	[BarcodeId]  int null,
	
    [GoodId] INT NULL,  
	[Quantity] DECIMAL(26, 6) NULL, 
	[UnitId] INT NULL,
	[Description] nvarchar(500) null,
	[IsActive] bit default 1 not null,
	[SaleNo] int null,
	[CreateId] INT NULL,
	[CreateDate] DATETIME  NULL DEFAULT getdate(), 
	[UpdateId] int null,
	[UpdateDate] DATETIME ,
	[DeleteId] int null,
	[DeleteDate] DATETIME,
	[ReadOnly] DATETIME
	CONSTRAINT PKLogisticDetail PRIMARY KEY (Id)
    
)
