CREATE TABLE [HR].[Contact]
(
    [Id] [int] IDENTITY NOT NULL,
	[ContactTypeId] [int] NOT NULL,
	[Contact] [nvarchar](200) NOT NULL,
	[Descrption] [nvarchar](500) NULL,
	[IsActive] [bit] NOT NULL,
	[PersonId] [int] NOT NULL,
	CONSTRAINT PKRefContact PRIMARY KEY (Id)
)
