CREATE TABLE [dbo].[District]
(
	[Id] INT IDENTITY NOT NULL,
	[CityId] INT NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	CONSTRAINT PKRefDistrict PRIMARY KEY (id)
)
