﻿CREATE TABLE [HR].[Employee]
(
	[Id] INT IDENTITY NOT NULL,
	[ParentId] [int] NULL,
	[PersonId] [int] NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[PositionId] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[Salary] [decimal](26,6) NULL,
	[OrderInId] [int] NULL,
	[OrderOutId] [int] NULL,
	[IsStaff] [bit] NULL,
	[StaffTypeId] [int] NULL,
	[Description] [nvarchar](500) NULL,
	[WorkEmail] [nvarchar](250) NULL,
	[WorkPhone] [nvarchar](250) NULL,
	[StatusId] [int] NOT NULL,
	[DocType]   tinyint NULL,
	[DocCert]   tinyint NULL,
	[DocSeries] tinyint NULL,
	[CreatedDate] [datetime] NOT NULL DEFAULT getdate(),
	[CreatedUser] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedUser] [int] NULL,
	[DeletedDate] [datetime] NULL,
	[DeletedUser] [int] NULL,
	CONSTRAINT PKRefEmployee PRIMARY KEY (Id)
)