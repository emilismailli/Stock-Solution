CREATE VIEW [dbo].[VwRoleTypeChoose]
	AS SELECT Id,[Name] FROM [dbo].[RoleType] where isnull([IsActive],1)=1
