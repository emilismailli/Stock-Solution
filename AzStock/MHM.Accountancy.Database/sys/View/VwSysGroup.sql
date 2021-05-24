CREATE VIEW [dbo].[VwSysGroup]
AS 
SELECT 20000+Id Id,[Name],[Password],[PersonId],[IsDisable] 
FROM dbo.Principial where IsGroup=1
