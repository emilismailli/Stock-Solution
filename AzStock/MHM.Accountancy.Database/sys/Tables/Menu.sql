CREATE TABLE [dbo].[Menu]
(
	[Id] int identity not null,
	[ParentId] int,
	[Code] varchar(6),
	[Caption] nvarchar(200) not null,
	[TypePath] varchar(200),
	[Parameters] varchar(200),
	[AllowNotify] bit,
	[IconId] int,
	[OrderNumber] int,
	constraint PkMenuId Primary Key([Id])
)
