create type [Accounting].[UddtBarcodeGood]
AS TABLE
(
    [Id] int  NULL , 
	[GoodId] int null,
	[Barcode] varchar(200)  null
   
)