CREATE TABLE [dbo].[MartialStatus]
(
	[Id] INT IDENTITY NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	CONSTRAINT PKRefMartialStatus PRIMARY KEY (id)
)
