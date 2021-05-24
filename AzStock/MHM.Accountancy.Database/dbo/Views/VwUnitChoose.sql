CREATE VIEW [dbo].[VwUnitChoose]
with encryption

	AS SELECT Id,[Name],[Description] FROM [dbo].[Unit]

where nullif (IsActive,1) IS NULL
