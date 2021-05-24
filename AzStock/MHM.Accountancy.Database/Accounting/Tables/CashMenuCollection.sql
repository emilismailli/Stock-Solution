CREATE TABLE [dbo].[CashMenuCollection]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[UserId] INT NOT NULL ,
	[CashId] INT NOT NULL,
	[MenuId] INT NOT NULL, 
    [Allow] BIT NOT NULL
)
