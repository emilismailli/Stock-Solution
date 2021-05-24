CREATE TABLE [dbo].[PackingType]
(
[Id] INT IDENTITY NOT NULL,
	[Name] [nvarchar](40) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[IsActive] [bit] NULL,
	CONSTRAINT PKRefPackingType PRIMARY KEY (Id)
)
