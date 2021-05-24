CREATE FUNCTION [dbo].[fnSysGroupId]
(
	@name nvarchar(200)
)
RETURNS INT
AS
BEGIN
	RETURN (select Id from dbo.Principial where [Name]=@name and IsGroup=1)
END
