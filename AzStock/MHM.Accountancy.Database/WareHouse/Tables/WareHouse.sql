CREATE TABLE [WareHouses].[WareHouse]
(
	[Id] INT IDENTITY NOT NULL,
	[CompanyId] int not null,
	[Name] nvarchar(100) NOT NULL,
	[WareHouseTypeId] int not null,
	[Description] nvarchar(500) NULL,
	[IsActive] bit NULL,
	CONSTRAINT PKRefWareHouse PRIMARY KEY (id)
)
