CREATE VIEW [HR].[VwReportPositionChange]
	with encryption
	AS
	select o.[No]
  ,o.[Description]
  ,o.[Date]
  ,o.[OrderTypeId]
  ,o.[CreateUser]
  ,o.[AppliedUser]
  ,o.[Temp4] [Salary]
  ,o.[ExecuteDate]
  --,o.[Temp9] [ParentId]
  --,o.[Temp6] [StuffTypeId]
  ,wg.Name [StaffTypeName]
  --,o.[Temp5] [IsStaff]
  --,o.[Temp1] [DepartmentId]
  ,d.Name as DepartmentName
  --,o.[Temp2] [PositionId]
,p.Name as PositionName
,e.Name as EmployeeName
 ,case when o.[Temp9]<>0 then (select top(1) CONCAT([Surname],' ',[Name],' ',[Patronymic]) from [CRM].[VwPerson] vp where vp.Id=o.[Temp9]) else '' end ParentName
 ,case o.[Temp5] when 1 then N'Ştatdadır' else N'Ştatdan kənar'end as IsStaff

 from [dbo].[order] o  

left join [HR].[VwEmployee] e on o.AppliedUser=e.Id
left join [dbo].[Department] d on o.Temp1=d.Id
left join [dbo].[Position] p on o.Temp2=p.Id
left join [dbo].[WorkGraphic] wg on o.Temp6=wg.Id


where OrderTypeId=3 
