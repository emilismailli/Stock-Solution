CREATE VIEW [dbo].[VwDepartmentChoose]
with encryption
	AS SELECT Id,[Name] FROM [dbo].[Department] where nullif(IsActive,1) is null
