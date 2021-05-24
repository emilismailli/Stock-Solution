CREATE VIEW [dbo].[VwRole] 
	AS select r.[Id]
      ,isnull([ParentId],0)[ParentId]
      ,r.[Name]
      ,[RoleTypeId]
	  ,rt.Name [RoleType]
      ,r.[Description]
      ,r.[IsActive]
	  from [dbo].[Role] r 
      join [dbo].[RoleType] rt on r.RoleTypeId=rt.Id