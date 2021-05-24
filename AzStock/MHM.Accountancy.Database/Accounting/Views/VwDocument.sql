CREATE VIEW [Accounting].[VwDocument]


	AS SELECT 
	 d.[Id]     
	,d.[PaymentTypeId]
	,pt.[Name] PaymentTypeName
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,c.CompanyName
    ,d.[WareHouseId] 
	,wh.[Name] WareHouseName
	,d.[FromWarehouseId]
	

	,whf.[Name] FromWareHouseName
	,d.ContractId
	,co.CustomerId
	,co.CustomerName
	,d.[Description]
	,d.DeleteDate
	,d.DeleteId
	,d.[DocTypeId]
     ,d.[DocCertId]
     ,d.[DocSeriesId]
	,d. [PaymentDate]   
	,d. [PartnerOrderNo]
	,d.[AdditionalCost]
	,d.[MainNumber]
	,d.CashierId
	,cashier.CashierName 
	,d.LockDate
	,d.LockId
	
	FROM [Accounting].[Document] d
	left join [Accounting].[VwCompany] c on d.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on d.WareHouseId=wh.Id
	left join [WareHouses].[VwWareHouse] whf on d.FromWarehouseId=whf.Id
	left join Accounting.VwContract co on d.ContractId=co.Id 
	left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id
	left join Accounting.[Cashier] cashier on cashier.Id=d.CashierId


 