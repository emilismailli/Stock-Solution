CREATE TABLE [dbo].[DocumentInventar]
(
	[Id] int NOT NULL IDENTITY,
	[WareHouseId] INT NULL,
    [CreateId] INT NULL,
    [CreateDate] DATETIME NULL, 
    [UpdateId] INT NULL, 
    [UpdateDate] DATETIME NULL, 
    [DeleteId] INT NULL, 
    [DeleteDate] DATETIME NULL, 
	CONSTRAINT PKDocumentInevntar PRIMARY KEY (Id)
)
