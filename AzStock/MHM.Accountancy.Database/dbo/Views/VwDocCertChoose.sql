CREATE VIEW [dbo].[VwDocCertChoose]
with encryption
AS SELECT Id,[Name] FROM [dbo].[DocCert] where nullif(IsActive,1) is null

