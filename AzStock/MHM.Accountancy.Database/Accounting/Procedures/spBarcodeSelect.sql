CREATE PROCEDURE [dbo].[spBarcodeSelect]
	@userId int,@wareHouseId int
AS
	SELECT distinct
	 b.[Id]
	,b.[GoodId]
	,g.[FullGoodName]
	,b.[Barcode]
	,g.Quantity
	,g.WarehouseId
	
	
	FROM [Accounting].[Barcode] b
	left join Accounting.VwGoodStock g on b.Id=g.BarcodeId
	where g.Quantity > 0 AND g.WarehouseId=@wareHouseId
RETURN 0
