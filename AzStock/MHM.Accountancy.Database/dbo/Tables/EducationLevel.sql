CREATE TABLE [dbo].[EducationLevel]
(
	[Id] INT IDENTITY NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	CONSTRAINT PKRefEducationLevel PRIMARY KEY (id)
)
