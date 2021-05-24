CREATE VIEW [Accounting].[VwCashMoney]
	AS SELECT 
    ca.CashName
	,ca.CompanyName 
	,sum (p.Deficit) Deficit
	
	FROM Accounting.Payment p 
	JOIN Accounting.Account a ON a.Id=p.AccountId 
	left join Accounting.VwCash ca on p.CashId=ca.Id
	left join Accounting.VwCash caFrom on p.CashId=caFrom.Id

where AccountId  not in (3,5,7,9)

group by
	ca.CashName
	,ca.CompanyName 

 
