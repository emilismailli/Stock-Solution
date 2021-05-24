CREATE TABLE [dbo].[Principial]
(
	[Id] INT NOT NULL identity(1,1),
	[Name] varchar(200) not null,
	[Password] varchar(128),
	[PersonId] int,
	[GroupId] int,
	[IsGroup] bit,
	[IsMember] bit,
	[IsDisable] bit,
	[Created]  datetime not null default(getdate()),
	CONSTRAINT PkPrincipialId PRIMARY KEY([Id])
)
