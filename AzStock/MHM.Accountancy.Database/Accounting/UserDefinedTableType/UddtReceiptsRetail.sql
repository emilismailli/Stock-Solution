create type [Accounting].[UddtReceiptsRetail]
AS TABLE
(
        Id     int NOT NULL   
      ,GoodId     int 
	 ,BarcodeId int 
	 ,Quantity  decimal (26,6)
)