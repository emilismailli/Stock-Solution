CREATE VIEW [Accounting].[VwManagementPayment]
	AS SELECT 
	p.Id
    ,p.AccountId,
	a.Name AccountName,
	sum(p.CustomerId) CustomerId, 
	p.DocumentId,
	c.CustomerName,
	p.PaymentTypeId,
	pt.Name PaymentTypeName,
	p.Payment,
	 sum(p.Deficit) Deficit,
	p.Paymentdate,

	p.Description, 
	p.CreateDate
	FROM Accounting.Payment p
	JOIN Accounting.Customer c ON p.CustomerId=c.Id
	JOIN Accounting.Account a ON a.Id=p.AccountId
	JOIN Accounting.PaymentType pt ON pt.Id=p.PaymentTypeId 

	group by
	p.Id
    ,p.AccountId,
	a.Name  ,
	 p.CustomerId, 
	p.DocumentId,
	c.CustomerName,
	p.PaymentTypeId,
	pt.Name    ,
	p.Payment, 
	p.Paymentdate,
	p.Description, 
	p.CreateDate