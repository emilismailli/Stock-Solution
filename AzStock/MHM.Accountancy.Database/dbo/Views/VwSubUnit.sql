CREATE VIEW [dbo].[VwSubUnit]
	AS SELECT 

	 su.Id
	,su.[Name]
	,su.GoodTypeId
	,gt.[Name]  GoodTypeName
	,su.UnitId
	,U.[Name] AS UnitName
	,su.[Description]
	
	
	FROM dbo.SubUnit su

	left join dbo.Unit u on u.Id=su.UnitId
	left join Accounting.GoodType GT ON GT.Id=SU.GoodTypeId
