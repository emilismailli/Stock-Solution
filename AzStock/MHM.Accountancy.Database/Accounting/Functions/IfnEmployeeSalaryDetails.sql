CREATE FUNCTION [Accounting].[IfnEmployeeSalaryDetails]
(
	@employeeId int
)
RETURNS TABLE
with encryption
RETURN
(
SELECT [EntityId] [№],case when a.Code is not null then a.[Name] + '('+s.[AccountCode]+')' else s.[AccountCode] end [Hesab kodu],[Balance] [Balans],[Current] [Cari maaş],[Kt] [Cəm],[DailyValue] [Gün dəyəri],[DayCount] [Gün sayı],case when AccountCode='7.0.3' then null  else [Current]-[Kt]-[Dt] end  [Qalıq maaş],COALESCE(s.[SalaryDate],s.UpdateDate,s.CreateDate) Tarix
FROM [Accounting].[AccountSummary] s
left join [Accounting].[Account] a on s.AccountCode=a.Code
where EntityTypeId=1 and AccountCode in ('7.0.2','7.0.3') and EntityId=@employeeId
union
SELECT [EntityId] [№],case when a.Code is not null then a.[Name] + '('+s.[AccountCode]+')' else s.[AccountCode] end [Hesab kodu],[Balance] [Balans],[Current] [Cari maaş],[Kt] [Məbləğ],[DailyValue],[DayCount],case when AccountCode='7.0.3' then null else [Current]-[Kt]-[Dt] end,COALESCE(s.[SalaryDate],s.UpdateDate,s.CreateDate) Tarix
FROM [Accounting].[AccountSummaryHistory] s
left join [Accounting].[Account] a on s.AccountCode=a.Code
where EntityTypeId=1 and AccountCode in ('7.0.2','7.0.3') and EntityId=@employeeId
)
