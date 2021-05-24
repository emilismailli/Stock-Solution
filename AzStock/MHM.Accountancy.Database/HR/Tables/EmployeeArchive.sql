CREATE TABLE [HR].[EmployeeArchive]
(
	[EmployeeId] INT NOT NULL,
	[ParentId] [int] NULL,
	[ParentIdNew] [int] NULL,
	[PersonId] [int] NULL,
	[PersonIdNew] [int] NULL,
	[DepartmentId] [int] NULL,
	[DepartmentIdNew] [int] NULL,
	[PositionId] [int] NULL,
	[PositionIdNew] [int] NULL,
	[Salary] [decimal](26,6) NULL,
	[SalaryNew] [decimal](26,6) NULL,
	[OrderId] [int] NULL,
	[OrderNew] [int] NULL,
	[OrderOutId] [int] NULL,
	[IsStaff] [bit] NULL,
	[IsStaffNew] [bit] NULL,
	[StaffTypeId] [int] NULL,	
	[StaffTypeIdNew] [int] NULL,
	[Description] [nvarchar](500) NULL,
	[WorkEmail] [nvarchar](250) NULL,
	[WorkPhone] [nvarchar](250) NULL,
	[StatusId] [int] NULL,	
	[StatusIdNew] [int] NULL,
	[CreatedDate] [datetime] NOT NULL DEFAULT getdate(),
	[CreatedUser] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedUser] [int] NULL,
	[DeletedDate] [datetime] NULL,
	[DeletedUser] [int] NULL
)

GO

CREATE INDEX [IXEmployeeArchiveId] ON [HR].[EmployeeArchive] ([EmployeeId])
