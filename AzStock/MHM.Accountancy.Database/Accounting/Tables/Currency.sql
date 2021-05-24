CREATE TABLE [Accounting].[Currency]
(
	[Id] INT IDENTITY NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Buy] decimal(26,6),
	[Sell] decimal(26,6),
	[RefreshDate] datetime,
	[Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	[CreateDate] datetime  null default getdate(),
	[CreateUserId] int  null
	CONSTRAINT PKCurrency PRIMARY KEY (id)
)

GO

CREATE TRIGGER [Accounting].[trgUpdateCurrency]
    ON [Accounting].[Currency]
    FOR UPDATE
    AS
    BEGIN
        SET NoCount ON;
		insert into [Accounting].[CurrencyHistory]([Name],[Sell],[Buy],[CreateUserId],[RefreshDate])
		select [Name],[Sell],[Buy],[CreateUserId],[RefreshDate] from deleted d
    END