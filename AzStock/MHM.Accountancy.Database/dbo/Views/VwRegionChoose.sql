CREATE VIEW [dbo].[VwRegionChoose]
	AS select r.[Id]
      ,isnull([ParentId],0)[ParentId]
      ,r.[Name]
      ,[RegionTypeId]
	  ,rt.Name [RegionType]
      ,r.[Description]
      ,r.[IsActive]
	  from [dbo].[Region] r 
      join [dbo].[RegionType] rt on r.RegionTypeId=rt.Id
	  where isnull(r.[IsActive],1)=1 and isnull(rt.[IsActive],1)=1