CREATE VIEW [Accounting].[VwDocumentReturnSale]
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
		,d.Description
	,d.[PaymentDate]   
		,d.[PartnerOrderNo]
		,d.[MainNumber]
		,d.CashierId
		,cashier.CashierName
	
	
	FROM [Accounting].[Document] d

	left join [Accounting].[VwCompany]    c on d.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on d.WareHouseId=wh.Id
	left join Accounting.VwContract co on d.ContractId=co.Id
	left join Accounting.Account ac on d.AccountId=ac.Id
	left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id
	left join Accounting.Cashier cashier on d.CashierId=cashier.Id

	where AccountId=5