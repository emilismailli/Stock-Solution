CREATE FUNCTION [Accounting].[IfnCompanyContact]
(
	@companyId int
)
RETURNS TABLE
with encryption
RETURN
(
SELECT cc.[Id],[Contact],[ContactTypeId],ct.[Name]
FROM [Accounting].[CompanyContact] cc
left join [dbo].[ContactType] ct on cc.ContactTypeId=ct.Id
where CompanyId=@companyId and nullif(cc.IsActive,1) is null
)
