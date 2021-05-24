CREATE PROCEDURE [Accounting].[spRetailAddTmps]
	@userId int
AS
begin

	select SaleNo,sum(PriceRetail*Quantity) [Total],CreateDate from Accounting.DocumentDetail
where CreateId=@userId
and SaleNo is not null and CreateDate>cast(getdate() as date)
group by SaleNo,CreateDate


RETURN 0
end

