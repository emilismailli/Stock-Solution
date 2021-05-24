CREATE VIEW [dbo].[VwUserRegistration]
	AS SELECT 
	 ur.[Id] 
    ,ur.[Name] 
    ,ur.[Surname] 
    ,ur.[Patronymic]
    ,ur.[BirthOfDate]  
    ,ur.[CitizenshipId] 
	,c.Name CitizenshipName
    ,ur.[RegionId] 
	,r.Name RegionName
    ,ur.[Address] 
    ,ur.[Description] 
	FROM dbo.UserRegistration ur 
	left join dbo.Citizenship c on ur.CitizenshipId=c.Id
	left join dbo.Region r on ur.RegionId=r.Id
