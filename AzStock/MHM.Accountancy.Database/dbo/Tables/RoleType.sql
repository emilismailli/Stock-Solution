CREATE TABLE [dbo].[RoleType]
(
	[Id] INT IDENTITY NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL, 
    CONSTRAINT PKRefRoleType PRIMARY KEY (id)
)