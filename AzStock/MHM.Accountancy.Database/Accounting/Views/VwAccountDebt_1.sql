CREATE VIEW [dbo].[VwAccountDebt]
	AS SELECT Id,isnull(ParentId,0) ParentId,[Name],[Code],[Description],[IsActive],[CreateDate] 
	FROM [Accounting].[Account]
	where isnull (IsActive, 1)=1 AND Accounting.Account.Id=11 OR Accounting.Account.Id=12

