CREATE VIEW [HR].[VwReportEmployee]
with encryption
	AS SELECT e.[Id]
	  ,case when e.[ParentId]<>0 then (select top(1) CONCAT([Surname],' ',[Name],' ',[Patronymic]) from [CRM].[VwPerson] vp where vp.Id=e.ParentId) else '' end ParentName
      ,e.[Name]
	  ,p.BirthPlace
	  ,p.Pin
	  ,p.SocCardNumber
	  ,p.MilitaryStatus
	  ,p.EducationLevel
	  ,p.IdentyDocId
	  ,p.GenderName
	  ,p.Photo
      ,e.[DepartmentName]
      ,e.[PositionName]
      ,e.[StartDate]
      ,e.[EndDate]
      ,e.[Salary]
      ,e.[OrderInNo]
      ,e.[OrderInDate]
      ,e.[OrderInBase]
      ,e.[OrderOutId]
      ,case e.[IsStaff] when 1 then N'Ştatdadır' else N'Ştatdan kənar' end IsStaff
	  ,wg.[Name] [StaffTypeName] 
      ,e.[Description]
      ,e.[WorkEmail]
      ,e.[WorkPhone]
      ,e.[Status]
      ,e.[DocType]
      ,e.[DocCert]
      ,e.[DocSeries]
  FROM [HR].[VwEmployee] e
left join [CRM].[VwPersonFullInfo] P on e.PersonId=p.Id
left join [dbo].[WorkGraphic] wg on e.StaffTypeId=wg.Id
