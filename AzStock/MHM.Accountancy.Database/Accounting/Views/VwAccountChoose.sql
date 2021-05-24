CREATE VIEW [Accounting].[VwAccountChoose]
	AS SELECT 


	Id

	,isnull(ParentId,0) ParentId
	,[Name]
	,[Code]
	,[Description]
	,[IsActive]
	,[CreateDate] 


	FROM [Accounting].[Account] where 
	nullif(IsActive,1) is null
