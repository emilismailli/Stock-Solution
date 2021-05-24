CREATE VIEW [HR].[VwEmployeeStatusChoose]
	AS SELECT Id,[Name] FROM [HR].[EmployeeStatus] where nullif(IsActive,1) is null
