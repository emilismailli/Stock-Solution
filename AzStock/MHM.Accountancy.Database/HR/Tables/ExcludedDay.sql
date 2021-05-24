CREATE TABLE [HR].[ExcludedDay]
(
    [Id] [int] IDENTITY NOT NULL,
	[HolidayDate] [datetime] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[IsHoliday] [bit] NULL,
	CONSTRAINT PKRefExcludedDay PRIMARY KEY (Id)
)
