CREATE TABLE [Accounting].[Account]
(
	[Id] INT NOT NULL IDENTITY(1,1),

	[ParentId]  int null,
	[Code] VARCHAR(40) NOT NULL, 
    [Name] NVARCHAR(200) NOT NULL, 
    [Description] NVARCHAR(500) NULL, 
    [IsActive] BIT NULL, 
    [CreateDate] DATETIME NOT NULL DEFAULT getdate(), 
    CONSTRAINT PKAccount PRIMARY KEY (Id),
	CONSTRAINT UIAccountCode UNIQUE (Code)
)
