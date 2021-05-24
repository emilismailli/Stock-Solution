CREATE VIEW [dbo].[VwDocSeriesChoose]
with encryption
AS SELECT Id,[Name] FROM [dbo].[DocSeries] where nullif(IsActive,1) is null

