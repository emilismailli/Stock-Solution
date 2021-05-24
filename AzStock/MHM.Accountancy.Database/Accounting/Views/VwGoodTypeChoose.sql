CREATE VIEW [Accounting].[VwGoodTypeChoose]
with encryption
	AS SELECT Id,[Name] FROM [Accounting].[GoodType] where nullif(IsActive,1) is null

