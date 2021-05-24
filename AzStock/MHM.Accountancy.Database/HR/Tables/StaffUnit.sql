CREATE TABLE [HR].[StaffUnit]
(
	[Id] INT IDENTITY NOT NULL,
	[ParentStaffId] [int] NULL,
	[OrgStructId] [decimal](26,6) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[StuffTypeId] [int] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[CreationOrderId] [int] NULL,
	[ArchiveOrderId] [int] NULL,
	[NeededCount] [int] NULL,
	[CurrentCount] [int] NULL,
	[SalaryMin] [decimal](26,6) NOT NULL,
	[SalaryMax] [decimal](26,6) NOT NULL,
	[File] [varbinary](max) NULL,
	[FileType] [nvarchar](50) NULL,
	CONSTRAINT PKRefStaffUnit PRIMARY KEY (Id)
)
