CREATE TABLE [dbo].[CompanyType]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Name] NVARCHAR(200) NOT NULL, 
    [Description] NVARCHAR(500) NULL, 
    [IsActive] BIT NULL, 
    [CreateDate] DATETIME NOT NULL DEFAULT getdate(), 
    CONSTRAINT PKCompanyType PRIMARY KEY (Id)
)
