CREATE VIEW [dbo].[VwDocTypeChoose]
with encryption
AS SELECT Id,[Name] FROM [dbo].[DocType] where nullif(IsActive,1) is null
