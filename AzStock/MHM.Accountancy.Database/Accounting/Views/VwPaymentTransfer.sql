CREATE VIEW [Accounting].[VwPaymentTransfer]
	AS SELECT 
	p.Id
	,p.ExpenseId
	,ex.ExpenseName
	,p.CashId
	,ca.CashName
	,ca.CompanyName
	,p.CashFromId
	,caFrom.CashName CashFromName
    ,p.AccountId,
	a.Name AccountName,
	p.CustomerId,
    p.CustomerWareHouseId,
	p.DocumentId,
	c.CustomerName,
	p.PaymentTypeId,
	pt.Name PaymentTypeName,
	p.Payment,
	p.Deficit,
	p.PaymentDate,
	p.Description,
	p.[Percent],
	p.CreateDate
	FROM Accounting.Payment p
	JOIN Accounting.Customer c ON p.CustomerId=c.Id
	JOIN Accounting.Account a ON a.Id=p.AccountId
	JOIN Accounting.PaymentType pt ON pt.Id=p.PaymentTypeId
	left join WareHouses.WareHouse w on w.Id=p.CustomerWareHouseId
	left join Accounting.VwExpense ex on p.ExpenseId=ex.Id
	left join Accounting.VwCash ca on p.CashId=ca.Id
	left join Accounting.VwCash caFrom on p.CashFromId=caFrom.Id

	where AccountId  = 17
    