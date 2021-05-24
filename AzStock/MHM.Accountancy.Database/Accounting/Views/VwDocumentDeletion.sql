CREATE VIEW [Accounting].[VwDocumentDeletion] 
	AS SELECT 
	 d.[Id]   
	,d.[AccountId]
	,ac.Code AccountCode
	,ac.Name AccountName
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,c.CompanyName
    ,d.[WareHouseId] 
	,wh.Name WareHouseName

	,d.PaymentTypeId
	,pt.Name PaymentTypeName
	,d.ContractId
	,co.CustomerId
	,co.CustomerName
	,d.DeleteDate
	,d.DeleteId
	,d.[ReasonId]
	,re.Name ReasonName
		,d.Description
	
	
	
	FROM [Accounting].[Document] d

	left join [Accounting].[VwCompany] c on d.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on d.WareHouseId=wh.Id
	left join Accounting.VwContract co on d.ContractId=co.Id
	left join Accounting.Account ac on d.AccountId=ac.Id
	left join Accounting.PaymentType pt on d.PaymentTypeId=pt.Id
	left join Accounting.Reason re on d.ReasonId=re.Id

	where AccountId=6
 