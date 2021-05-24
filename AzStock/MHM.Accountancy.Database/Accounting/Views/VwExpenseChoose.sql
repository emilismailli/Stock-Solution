CREATE VIEW [Accounting].[VwExpenseChoose]

	AS SELECT 
	
     [Id]  
	, isnull (ParentId,0)ParentId
	,[ExpenseName]  
	
	,[Code]
	,[Description]   	
	,[IsActive]
	,[CreateDate]
	FROM Accounting.Expense 
	where

	nullif (IsActive,1) is null


