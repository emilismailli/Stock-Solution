CREATE FUNCTION [Accounting].[SfnCompanyContactValue]
(
	@contactId int
)
RETURNS [nvarchar](200)
with encryption
AS
BEGIN
	RETURN (select [Contact] from [Accounting].[CompanyContact] where Id=@contactId);
END
