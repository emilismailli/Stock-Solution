CREATE VIEW [Accounting].[VwCustomerGoodReturn]
	AS 
	----declare @goodid int =5
SELECT
	
	d.Id
	,d.ContractId
	,cust.CustomerName
	
	FROM [Accounting].[Document] d

	inner join Accounting.DocumentDetail dd on dd.DocumentId=d.Id
	inner join [Accounting].[Contract] c  on c.Id=d.ContractId
	inner join  [Accounting].[Customer] cust on cust.Id=c.CustomerId

	where GoodId  in  (1,1)






