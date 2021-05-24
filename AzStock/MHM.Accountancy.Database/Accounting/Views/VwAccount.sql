CREATE VIEW [Accounting].[VwAccount]
	AS SELECT 
	Id
	
	,isnull(ParentId,0) ParentId
	,[Name]
	,[Code]
	,[Description]
	,[IsActive]
	,[CreateDate] 



	FROM [Accounting].[Account]



	where isnull (IsActive, 1)=1 
