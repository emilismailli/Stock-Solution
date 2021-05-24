CREATE VIEW [dbo].[VwSysMember]
AS 
SELECT 20100+Id Id,Id UserId,[Name],[Password],[PersonId],[IsDisable] ,GroupId
FROM dbo.Principial where IsMember=1
