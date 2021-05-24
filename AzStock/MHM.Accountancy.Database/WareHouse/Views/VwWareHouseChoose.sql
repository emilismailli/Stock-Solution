CREATE VIEW [WareHouses].[VwWareHouseChoose]
with encryption
	AS SELECT Id,[Name] FROM [WareHouses].[WareHouse] where nullif(IsActive,1) is null
