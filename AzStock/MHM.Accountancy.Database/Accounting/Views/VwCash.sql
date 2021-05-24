CREATE VIEW [Accounting].[VwCash]
	AS SELECT
	
	
	 c.[Id]  
	,c.[CompanyId]  
	,com.CompanyName
	,c.[CashName]  
	,c.Balance
	--,c.[WareHouseId] 
	--,wh.[Name] WareHouseName
	,c.[Description]  
	,c.[CreateId]  
	,c.[CreateDate]  

	
      ,c.[IsActive]

	 FROM [Accounting].[Cash] c
	 left join Accounting.VwCompany com on c.CompanyId=com.Id
	 --left join WareHouses.VwWareHouse wh on c.WareHouseId=wh.Id

 
