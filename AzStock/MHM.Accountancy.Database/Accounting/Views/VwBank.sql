CREATE VIEW [Accounting].[VwBank]
with encryption
	AS 
	select 
	   b.[Id]
      ,b.[GroupId]
	  ,bg.Name BankGroupName
      ,b.[Name]
      ,b.[Swift]
	  ,b.[Voen]
      ,b.[CurrencyId]
	  ,C.Name CurrencyName
	  ,b.[RegionId]
	  ,r.Name  RegionName
      ,b.[CreateId]
      ,b.[CreateDate]
      ,b.[UpdateId]
      ,b.[UpdateDate]
      ,b.[DeleteId]
      ,b.[DeleteDate]
      ,b.[ReadOnly]
      ,b.[DocTypeId]
      ,b.[DocCertId]
      ,b.[DocSeriesId]
from [Accounting].[Bank] b

left  join [Accounting].[BankGroup] bg on b.GroupId=bg.Id
left join [Accounting].[Currency] c on b.CurrencyId=c.Id
left join [dbo].[Region] r on b.RegionId=r.Id
