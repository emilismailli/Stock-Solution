CREATE VIEW [dbo].[VwUser]
	AS SELECT
	
	 u.[Id] 
	,u.[UserName]
	,u.[UserSurname] 
	,u.[UserPatryonmic] 
	,u.[Pin] 
	,u.[RoleId]
	,rt.Name RoleTypeName
	,u.[Login]
	,u.[Password]  
	,u.[LastLogIn]   
	,u.[LastLogOut]  
	,u.[BirthOfDate] 
	,u.[RegionId] 
	,r.Name RegionName
	,u.[Address]
	,u.[Description]
	
	FROM [dbo].[User]  u
	 
 	left join dbo.Region      r      on       u.RegionId=r.Id
	left join dbo.RoleType    rt     on       u.RoleId=rt.Id