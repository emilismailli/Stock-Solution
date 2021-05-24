CREATE VIEW [dbo].[VwContactTypeChoose]
	AS SELECT Id,[Name] FROM [dbo].[ContactType]
	where nullif(IsActive,1) is null