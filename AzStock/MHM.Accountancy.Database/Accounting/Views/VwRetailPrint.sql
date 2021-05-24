CREATE VIEW [Accounting].[VwRetailPrint]
	AS SELECT
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
	,pr.[DiscountNumber]
	,pr.CreateDate
	,pr.CreateId
	,u.[Name]
	


	FROM Accounting.PaymentRetail pr
join  Accounting.VwDocumentDetail dd ON dd.DocumentId = pr.DocumentId
JOIN Accounting.RetailSale rs ON rs.DocumentDetailId=dd.Id
JOIN Accounting.PaymentType pt ON pt.Id=pr.PaymentTypeId
JOIN dbo.[Principial] u ON u.Id=pr.CreateId
WHERE dd.DocumentId=(SELECT max(dd2.Id) FROM Accounting.Document dd2 WHERE dd2.AccountId=8)