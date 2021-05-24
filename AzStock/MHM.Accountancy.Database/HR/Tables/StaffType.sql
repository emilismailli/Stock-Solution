CREATE TABLE [HR].[StaffType]
(
	[Id] INT IDENTITY NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Coefficient] [decimal](26,6) NOT NULL,
	CONSTRAINT PKRefStaffType PRIMARY KEY (Id)
)
