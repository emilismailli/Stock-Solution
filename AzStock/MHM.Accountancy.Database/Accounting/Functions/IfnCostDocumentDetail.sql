CREATE FUNCTION [Accounting].[IfnCostDocumentDetail]
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
,d.[DocumentId]
,d.[DetailDate]
,[GoodTypeId]
,[UnitName]
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
WHERE DocumentId=@documentId and d.DeleteId is null
)


