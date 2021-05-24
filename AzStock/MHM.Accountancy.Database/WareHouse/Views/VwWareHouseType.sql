CREATE VIEW [WareHouses].[VwWareHouseType]
with encryption
	AS SELECT * FROM [WareHouses].[WareHouseType]
	WHERE isnull (IsActive,1)= 1;
