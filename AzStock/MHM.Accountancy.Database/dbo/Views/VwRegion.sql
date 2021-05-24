CREATE VIEW [dbo].[VwRegion]
	AS select r.[Id]
      ,isnull([ParentId],0)[ParentId]
      ,r.[Name]
      ,[RegionTypeId]
	  ,rt.Name [RegionType]
      ,r.[Description]
      ,r.[IsActive]
	  from [dbo].[Region] r 
      join [dbo].[RegionType] rt on r.RegionTypeId=rt.Id