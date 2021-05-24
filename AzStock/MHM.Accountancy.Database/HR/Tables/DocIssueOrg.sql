﻿CREATE TABLE [HR].[DocIssueOrg]
(
	[Id] INT IDENTITY NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	CONSTRAINT PKRefDocIssueOrg PRIMARY KEY (Id)
)
