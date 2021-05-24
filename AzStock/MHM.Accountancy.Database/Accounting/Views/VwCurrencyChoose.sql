CREATE VIEW [Accounting].[VwCurrencyChoose]
with encryption
	AS SELECT Id,[Name] FROM [Accounting].[Currency] where nullif(IsActive,1) is null
