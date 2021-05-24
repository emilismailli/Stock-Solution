CREATE VIEW [Accounting].[VwCustomer]
	AS SELECT

	c.[Id],
	c.ParentId,
	c.TypeId,
	ct.[Name] TypeName,
    c.[CustomerName]  , 
    c.[CustomerLeader] , 
    c.[WorkTypeId] ,
	wt.Name [WorkTypeName] ,
	c.RegionId,
	r.Name [RegionName],
	c.BankId,
	b.Name [BankName] ,
	c.BankSwift ,
    c.[Voen] , 
    c.[CurrencyId] ,
	cr.name [CurrencyName] ,
    c.[LegalAddress] , 
    c.[ActualAddress] , 
    c.[Email] , 
    c.[Tel] , 
	c.[Date] ,
    c.[Description] 

	FROM [Accounting].[Customer] C

	left join [dbo].[VwWorkType] wt on c.WorkTypeId=wt.Id
	LEFT JOIN dbo.CompanyType ct ON ct.Id=c.TypeId
	left join [Accounting].[VwCurrency] cr on c.CurrencyId=cr.Id
	left join [Accounting].[VwBank] b on c.BankId=b.Id
	left join  [dbo].[VwRegion] r on c.RegionId=r.Id