CREATE VIEW [Accounting].[VwOfflineSale]
	AS SELECT 

	     l.[Id]  
		,l.[Driver]  
		,l.[Fin]  
		,l.[Transportation]  
		,l.[Cart]  
		,l.[Sender]  
		,l.[SenderAddress]  
		,l.[SenderManager]  
		,l.[Received]  
		,l.[ReceivedAddress]  
		,l.[ReceivedManager]  
		,l.[Date] 
		,l.[DeliveryDate] 
		,l.[Description]  
		,l.WareHouseId
		,l.CompanyId
		,wv.[Name] as WareHouseName
		,c.CompanyName
			,l.ContractId
	,co.CustomerId
	,co.CustomerName
	
	,l.[PaymentTypeId]
	,pt.[Name] PaymentTypeName
	
	FROM [Accounting].[OfflineSale] l
	left join WareHouses.WareHouse  wv on wv.Id=l.WareHouseId
	left join Accounting.Company c on c.Id=l.CompanyId
		left join Accounting.VwContract co on l.ContractId=co.Id 
	left join Accounting.VwPaymentType pt on l.PaymentTypeId=pt.Id
