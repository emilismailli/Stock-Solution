CREATE TABLE [Accounting].[CurrencyHistory]
(
	[Id] INT IDENTITY NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Buy] decimal(26,6),
	[Sell] decimal(26,6),
	[RefreshDate] datetime,
	[CreateDate] datetime not null default getdate(),
	[CreateUserId] int not null,
	CONSTRAINT PKCurrencyHistory PRIMARY KEY (id)
)