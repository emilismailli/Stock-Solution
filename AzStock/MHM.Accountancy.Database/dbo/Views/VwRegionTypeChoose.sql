CREATE VIEW [dbo].[VwRegionTypeChoose]
	AS SELECT Id,[Name] FROM [dbo].[RegionType] where isnull([IsActive],1)=1
