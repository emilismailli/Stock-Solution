CREATE VIEW [Accounting].[VwExpense]
	AS SELECT 
	
	
     ex.[Id]  
	, isnull (ParentId,0)ParentId
	,ex.[ExpenseName]  
	
	,ex.[Code]
	,ex.[Description]  
	,ex.[IsActive]  
	,ex.[CreateDate]
	FROM Accounting.Expense ex 
	

	where isnull (IsActive, 1)=1 




 

 
