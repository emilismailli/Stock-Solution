CREATE TABLE [dbo].[Role]
(
	[Id] INT IDENTITY NOT NULL,
	[ParentId] int NULL,
	[Name] [nvarchar](100) NOT NULL,
	[RoleTypeId] int NULL,
	[Description] nvarchar(500) NULL,
	[IsActive] [bit] NULL, 
    CONSTRAINT PKRole PRIMARY KEY (id)
)
