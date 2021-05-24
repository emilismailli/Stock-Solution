CREATE VIEW [Accounting].[VwContract]
	AS SELECT 
	c.[Id]
	,c.[CustomerId]
	,cus.CustomerName
	,c.[ContractDate]
    ,c.[ContractTypeId]
   ,ct.Name [ContractTypeName]

	,c.[CurrencyId]
   ,cr.Name[CurrencyName]

    ,c.[OperationTypeId]
   ,ot.Name[OperationTypeName]

	
	,c.[CompanyId]
	,cm.CompanyName

	,c.[Description]
	,c.[IsActive]

	FROM [Accounting].[Contract] c
  left join [Accounting].[VwCompany] cm on c.CompanyId=cm.Id
  left join [Accounting].[VwContractType] ct on c.ContractTypeId=ct.Id
  left join [Accounting].[VwCurrency] cr on c.CurrencyId=cr.Id
  left join [dbo].[OperationType] ot on c.OperationTypeId=ot.Id
  left join Accounting.VwCustomer cus  on c.CustomerId=cus.Id
