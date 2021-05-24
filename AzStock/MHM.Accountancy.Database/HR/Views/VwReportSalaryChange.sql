CREATE VIEW [HR].[VwReportSalaryChange]
	with encryption
	AS
	select
     [No]
 ,o.[Description]
 ,o.[Date]
 ,o.[OrderTypeId]
 ,o.[CreateUser]
 ,o.[AppliedUser]
 ,o.[ExecuteDate] 
 ,p.DepartmentName ExecutorDepartmentName
 ,p.PositionName ExecutorPositionName
 ,p.Name ExecutorName
 ,o.temp4 Salary
 ,e.Name as EmployeeName
 ,e.DepartmentName 
 ,e.PositionName
 ,e.Status
 ,case when e.[ParentId]<>0 then (select top(1) CONCAT([Surname],' ',[Name],' ',[Patronymic]) from [CRM].[VwPerson] vp where vp.Id=e.ParentId) else '' end ParentName
 ,case e.IsStaff when 1 then N'Ştatdadır' else N'Ştatdan Kənardır'end as IsStaff

from 
[DBO].[Order] o  

left join [HR].[VwEmployee] e on o.AppliedUser=e.Id
left join [HR].[VwEmployee] ee on o.Temp4=ee.Id
left join [HR].[VwEmployee] p on o.Temp8=p.Id


where OrderTypeId=3
