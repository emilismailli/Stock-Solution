CREATE VIEW [dbo].[VwPositionChoose]
with encryption
	AS SELECT Id,[Name] FROM [dbo].[Position] where nullif(IsActive,1) is null
