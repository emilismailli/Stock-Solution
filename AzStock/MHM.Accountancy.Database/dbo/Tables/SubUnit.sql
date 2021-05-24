CREATE TABLE [dbo].[SubUnit]
(
		[Id] INT IDENTITY NOT NULL,
	[Name] nvarchar(200),
	[GoodTypeId] int ,
	[UnitId] int,
	[Description] nvarchar(500),
	[IsActive] [bit] NULL,
	CONSTRAINT PKSubUnit PRIMARY KEY (Id)

)
