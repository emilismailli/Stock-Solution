CREATE FUNCTION [Accounting].[IfnDocumentDetail]
(
	@documentId int
)
RETURNS TABLE
with encryption
RETURN
(
SELECT 

   d.[Id]
,d.[AccountId]
,a.[Code] [AccountCode]
,a.[Name] [AccountName]
,d.[DocumentId]
,d.[DetailDate]
,[GoodTypeId]
,gt.[Name] [KindIName]
,[GoodId]
,isnull(d.[GoodCode],'')[GoodCode]
,isnull(g.[Name],'')[GoodName]
,d.[GoodSort]
,[ProjectId]
,[ResponsibilityCenterId]
,d.[NumberOfPackages]
,d.[QuantityWeight]
,d.[NetWeight]
,d.[Quantity]
,d.[UnitId]
,u.[Name] [UnitName]
,[HandingDate]
,d.[CurrentPrice]
,d.[Amount]
,d.[Payment]
,d.[Deficit]
,d.[CurrencyId] 
,d.[Description]
,d.[UpdateId]
,d.[UpdateDate]
,d.[DeleteId]
,d.[DeleteDate]

FROM [Accounting].[DocumentDetail] d 
LEFT JOIN [Accounting].[Goods] g ON d.GoodId=g.Id
LEFT JOIN [Accounting].[GoodType] gt ON d.GoodTypeId=gt.Id
LEFT JOIN [dbo].[Unit] u ON d.UnitId=u.Id
left join [Accounting].[Account] a on d.AccountId=A.Id
WHERE DocumentId=@documentId and d.DeleteId is null
)


