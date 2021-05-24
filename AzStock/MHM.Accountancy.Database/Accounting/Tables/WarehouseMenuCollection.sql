CREATE TABLE [dbo].[WarehouseMenuCollection]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[UserId] INT NOT NULL ,
	[WareHouseId] INT NOT NULL,
	[MenuId] INT NOT NULL, 
    [Allow] BIT NOT NULL
)
