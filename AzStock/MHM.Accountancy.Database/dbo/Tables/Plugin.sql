CREATE TABLE [dbo].[Plugin]
(
    [Id] [int] IDENTITY NOT NULL,
	[PlugName] [nvarchar](200) NOT NULL,
	[Version] [nvarchar](50) NOT NULL,
	[Plug] [varbinary](max) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[ModifyDate] [datetime] NOT NULL,
	[ModifyUser] [nvarchar](200) NOT NULL,
	CONSTRAINT PKRefPlugin PRIMARY KEY (Id)
)
