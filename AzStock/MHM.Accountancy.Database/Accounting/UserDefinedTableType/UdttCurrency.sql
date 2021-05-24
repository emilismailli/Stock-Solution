CREATE TYPE [Accounting].[UdttCurrency] 
AS TABLE
(
	[Id] INT NOT NULL,
	[Buy] decimal(26,6),
	[Sell] decimal(26,6)
)
