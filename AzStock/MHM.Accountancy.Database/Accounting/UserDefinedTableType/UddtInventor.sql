create type [Accounting].[UddtInventor]
AS TABLE
(

	[Id] int NULL,
	[FullGoodName] NVARCHAR(200)  NULL,
	[Quantity] DECIMAL(26,5) NULL,
	[RealQuantity] DECIMAL(26,5) NULL,
	[DeficitQuanity] DECIMAL(26,5) NULL 

)