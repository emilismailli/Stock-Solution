CREATE VIEW [dbo].[VwWorkGraphicChoose]
with encryption
AS SELECT Id,[Name] FROM [dbo].[WorkGraphic] where nullif(IsActive,1) is null
