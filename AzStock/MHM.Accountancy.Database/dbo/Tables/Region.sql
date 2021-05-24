CREATE TABLE [dbo].[Region]
(
	[Id] INT IDENTITY NOT NULL,
	[ParentId] int NULL,
	[Name] [nvarchar](100) NOT NULL,
	[RegionTypeId] int NULL,
	[Description] nvarchar(500) NULL,
	[IsActive] [bit] NULL, 
    CONSTRAINT PKRefRegion PRIMARY KEY (id)
)
