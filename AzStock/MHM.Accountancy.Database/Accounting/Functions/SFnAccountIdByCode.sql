CREATE FUNCTION [Accounting].[SFnAccountIdByCode]
(
	@code varchar(40)
	)
RETURNS INT
AS
BEGIN
	RETURN (SELECT Id FROM [Accounting].[Account] where code=@code)
END
