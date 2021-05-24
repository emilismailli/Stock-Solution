CREATE VIEW [Accounting].[VwDocumentTmp]
	AS SELECT 
	 dTmp.[Id]    
    ,dTmp.[CompanyId]   
	,c.[CompanyName]
    ,dTmp.[WareHouseId] 
	,wh.Name WareHouseName
	,dTmp.ContractId
	,co.CustomerId
	,co.CustomerName
	,dTmp.DeleteDate
	,dTmp.DeleteId
	
	
	
	FROM [Accounting].[DocumentTmp] dTmp

	left join [Accounting].[VwCompany]    c on dTmp.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on dTmp.WareHouseId=wh.Id
	left join Accounting.VwContract co on dTmp.ContractId=co.Id

