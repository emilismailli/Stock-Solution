CREATE VIEW [Accounting].[VwTotalReport]
	AS SELECT 
	 tr.[Id]
	,tr.[TotalAmount]  
	,tr.[TotalCost]  
	,tr.[TotalProfit]  
	,tr.[IsActive]  
	
	
	
	
	
	FROM [Accounting].[TotalReport] tr

