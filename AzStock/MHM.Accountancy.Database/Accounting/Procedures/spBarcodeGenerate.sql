CREATE PROCEDURE [Accounting].[spBarcodeGenerate]
	@userId int,
	@barcodeGen bigint output
AS
begin

	SELECT @barcodeGen=convert(bigint,BarcodeGen) from Accounting.BarcodeGenerate where Id = (select max(s.Id) from Accounting.BarcodeGenerate s)

	set @barcodeGen=@barcodeGen+1

	insert into Accounting.BarcodeGenerate (BarcodeGen,CreateId,CreateDate) values (convert(nvarchar(50),@barcodeGen),@userId,GETDATE());	

end