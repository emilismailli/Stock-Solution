CREATE TABLE [dbo].[UserRegistration]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(200) NULL, 
    [Surname] NVARCHAR(200) NULL, 
    [Patronymic] NVARCHAR(200) NULL, 
    [BirthOfDate] DATE NULL, 
    [CitizenshipId] INT NULL, 
    [RegionId] INT NULL, 
    [Address] NVARCHAR(200) NULL, 
    [Description] NVARCHAR(500) NULL
)
