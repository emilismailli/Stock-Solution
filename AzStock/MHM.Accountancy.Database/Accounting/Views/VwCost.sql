CREATE VIEW [Accounting].[VwCost]
	AS SELECT 
	 c.[Id]  
	,c.[Person]  
	,c.[Place] 
	,c.Amount
	,c.[CostDate]  
	,c.[PaymentTypeId] 
	,pt.[Name] as PaymentTypeName
	,c.[Description]  
	
	
	FROM [Accounting].[Cost] c
	left join Accounting.PaymentType pt on c.PaymentTypeId=pt.Id
