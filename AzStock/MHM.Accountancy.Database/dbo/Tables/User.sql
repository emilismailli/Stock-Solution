CREATE TABLE [dbo].[User]
(
	[Id] [bigint] IDENTITY NOT NULL, 
	[UserName] [nvarchar](50) NULL,
	[UserSurname] [nvarchar](50) NULL,
	[UserPatryonmic] [nvarchar](50) NULL,
	[Pin] NVARCHAR(50)  ,
	[RoleId] INT NULL ,
	[Login] nvarchar(100) null,
	[Password] [nvarchar](128) NULL, 
	[BirthOfDate] DATETIME NULL,  
    [RegionId] INT NULL, 
    [Address] NVARCHAR(200) NULL, 
    [Description] NVARCHAR(500) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL DEFAULT getdate(),
	[CreatedUser] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedUser] [int] NULL,
	[DeletedDate] [datetime] NULL,
	[DeletedUser] [int] NULL,
	[LastLogIn] [datetime] NULL,
	[LastLogOut] [datetime] NULL,

	CONSTRAINT PKRefUser PRIMARY KEY (Id)
)
