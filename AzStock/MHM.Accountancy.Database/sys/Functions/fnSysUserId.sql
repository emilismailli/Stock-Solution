CREATE FUNCTION [dbo].[fnSysUserId]
(
	@name nvarchar(200)
)
RETURNS INT
AS
BEGIN
	RETURN (select Id from dbo.Principial where [Name]=@name and IsMember=1)
END
