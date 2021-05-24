CREATE PROCEDURE [Accounting].[spRetailPrint]
	@id int =null,
	@userId int
	as
	begin
	SELECT
	pr.DocumentId
	,dd.FullGoodName
	,dd.Quantity
	,dd.PriceRetail
	,dd.AmountRetail
	,pr.Payment
	,pr.Deficit
	,pr.TotalSum
	,pt.[Name] PaymentTypeName
	,pr.[Percent]
	,pr.CreateDate
	,pr.CreateId
	,u.[Name]
	,pr.DiscountNumber
	


	FROM Accounting.PaymentRetail pr
join  Accounting.VwDocumentDetail dd ON dd.DocumentId = pr.DocumentId
JOIN Accounting.RetailSale rs ON rs.DocumentDetailId=dd.Id
JOIN Accounting.PaymentType pt ON pt.Id=pr.PaymentTypeId
JOIN dbo.[Principial] u ON u.Id=pr.CreateId
WHERE dd.DocumentId= case when @id is null then (SELECT max(dd2.Id) FROM Accounting.Document dd2 WHERE dd2.AccountId=8 and dd2.CreateId=@userId) else @id end;
end
