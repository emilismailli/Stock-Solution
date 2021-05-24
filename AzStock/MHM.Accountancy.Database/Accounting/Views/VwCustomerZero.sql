--CREATE VIEW [dbo].[VwCustomerCreditor]
--	AS 
--	SELECT 
--	cb.CustomerId,
--	c.CustomerName,
--	cb.Deficit,
--	cb.UpdateDate
	
--	FROM [Accounting].[CustomerDebt] cb
--	join Accounting.Customer c ON c.Id=cb.CustomerId

--	where Deficit>0
