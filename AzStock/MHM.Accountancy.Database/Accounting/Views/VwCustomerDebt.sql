CREATE VIEW [Accounting].[VwCustomerDebt]
	AS 
	SELECT 
	cb.CustomerId,
	c.CustomerName,
	cb.Deficit,
	cb.UpdateDate
	
	FROM [Accounting].[CustomerDebt] cb
	join Accounting.Customer c ON c.Id=cb.CustomerId
