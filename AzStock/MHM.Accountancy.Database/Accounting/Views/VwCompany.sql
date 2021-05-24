CREATE VIEW [Accounting].[VwCompany]
	AS 
	SELECT 
	 c.[Id] 
,c.ParentId
	 ,c.TypeId,
     ct.[Name] TypeName
    ,c.[PrivateNumber]
    ,c.[CompanyName]
    ,c.[CompanyLeader]
	,c.RegionId
	,r.Name RegionName
    ,c.[WorkTypeId] 
	,wt.Name [WorkTypeName]
    ,c.[Voen] 
    ,c.[CurrencyId] 
	,cr.Name [CurrencyName]
    ,c.[BankId] 
	,b.Name [BankName]
    ,c.[BankSwift] 
    ,c.[Date] 
    ,c.[LegalAddress] 
    ,c.[ActualAddress]
    ,c.[Email]
    ,c.[Tel] 
	,c.[ContractNumber]
	,c.[ContractDate] 
	
    ,c.[Description]
	,c.[CreateId]
	,c.[CreateDate]
	,c.[UpdateId]
	,c.[UpdateDate]
	,c.[DeleteId]
	,c.[DeleteDate]
	,c.[DocTypeId]
	,c.[DocCertId]
	,c.[DocSeriesId]
	
	FROM [Accounting].[Company] C
	left join Accounting.VwCurrency CR ON c.CurrencyId=cr.Id
	left join dbo.CompanyType ct on ct.Id=c.TypeId
	left join Accounting.VwBank b on c.BankId=b.Id
	left JOIN dbo.WorkType WT ON c.WorkTypeId=wt.Id
	left join dbo.Region r on c.RegionId=r.Id