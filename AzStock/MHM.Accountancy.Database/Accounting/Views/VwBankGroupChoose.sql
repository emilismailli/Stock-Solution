CREATE VIEW [Accounting].[VwBankGroupChoose]
with encryption
	AS SELECT Id,[Name] FROM [Accounting].[BankGroup] where nullif(IsActive,1) is null
