CREATE TABLE [dbo].[Country]
(
	[Id] INT IDENTITY NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Code] int null,
	[Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	CONSTRAINT PKRefCountry PRIMARY KEY (Id)
)
