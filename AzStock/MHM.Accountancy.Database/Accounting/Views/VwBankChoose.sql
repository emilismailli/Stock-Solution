CREATE VIEW [Accounting].[VwBankChoose]
with encryption
	AS 
	select b.[Id]
      ,b.[Name]
	  ,b.[Voen]
	  ,b.[Swift]
      ,b.[DocTypeId]
      ,b.[DocCertId]
      ,b.[DocSeriesId]
from [Accounting].[Bank] b
where DeleteId is null
