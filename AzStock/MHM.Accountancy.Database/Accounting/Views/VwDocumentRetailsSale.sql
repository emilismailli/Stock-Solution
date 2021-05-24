CREATE VIEW [Accounting].[VwDocumentRetailsSale]
	AS SELECT 
	 d.[Id]     
	,d.[PaymentTypeId]
	,pt.Name PaymentTypeName
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,c.CompanyName
    ,d.[WareHouseId] 
	,wh.Name WareHouseName
	,d.ContractId
	,co.CustomerId
	,co.CustomerName
	,d.Description
	,d.DeleteDate
	,d.DeleteId
	,d.[DocTypeId]
     ,d.[DocCertId]
     ,d.[DocSeriesId]
	 ,d.PaymentDate
	 ,d.PartnerOrderNo
	
	
	
	FROM [Accounting].[Document] d
	left join [Accounting].[VwCompany] c on d.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on d.WareHouseId=wh.Id
	left join Accounting.VwContract co on d.ContractId=co.Id 
	left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id

	where AccountId=8