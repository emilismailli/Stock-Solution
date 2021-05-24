CREATE VIEW [Accounting].[VwPaymentRetail]
	AS 
	SELECT 
	pr.DocumentId,
	pr.CreateId
	,pr.CreateDate
	,c.CustomerName
	,pr.Deficit
	,pr.Payment,
	pr.TotalSum,
	pr.[Percent],
	pr.DiscountNumber,
	pt.Name PaymentTypeName
	
	FROM [Accounting].[PaymentRetail] pr
	JOIN Accounting.PaymentType pt ON pt.Id=pr.PaymentTypeId
	LEFT JOIN Accounting.Customer c ON c.Id=pr.CustomerId
    