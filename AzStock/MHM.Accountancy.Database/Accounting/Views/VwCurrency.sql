CREATE VIEW [Accounting].[VwCurrency]
with encryption
	AS SELECT [Id],[Name],isnull([Buy],1) [Buy],isnull([Sell],1) [Sell],isnull([RefreshDate],'20000101') [RefreshDate],[Description],[IsActive]
	FROM [Accounting].[Currency]
go;
