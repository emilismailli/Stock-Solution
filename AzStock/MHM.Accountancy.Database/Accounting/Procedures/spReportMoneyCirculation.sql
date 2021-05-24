CREATE PROCEDURE [Accounting].[spReportMoneyCirculation]
	@userId int,
	@beginDate date,
	@endDate date,
	@accountCode varchar(40)=null,
	@isFiltered bit=1,
	@profit decimal(26,6) =null output,
	@cost decimal(26,6) =null output
	
with encryption
AS
begin

if object_id ('tempd..monthlyReport')  is not null

drop table #monthlyReport
;with repo as (select d.Id,1 DocSpecial,dd.Payment Amount,d.AccountId,dd.AccountId [DetailAccountId],d.DocumentDate 
     from Accounting.document d
     join [Accounting].[DocumentDetail]dd on d.id=dd.DocumentId 
     where d.DocumentDate>=@beginDate  and d.DocumentDate < dateadd(DAY,1,@endDate)
     and ((isnull(@isFiltered,0)<>1 and isnull(d.[DocTypeId],0)=1) or (isnull(@isFiltered,0)=1 and isnull(d.[DocTypeId],0) <>1))
	   union
     select id,2 DocSpecial,OperationAmount,AccountId, null [DetailAccountId],DocumentDate 
     from [Accounting].[PaymentOrder] d
     where d.DocumentDate>=@beginDate  and d.DocumentDate < dateadd(DAY,1,@endDate) and ((isnull(@isFiltered,0)<>1 and isnull(d.[DocTypeId],0)=1) or (isnull(@isFiltered,0)=1 and isnull(d.[DocTypeId],0) <>1))
	)
	
	,src as (
	select d.Id ,a.Id AccountId,a.ParentId AccountParentId,a.Code AccountCode,a.[Name] AccountName,FORMAT(DocumentDate,'yyyy-MM') ReportMonth,sum(d.Amount) Total
	from repo d
	join Accounting.Account a on a.Id=isnull(d.AccountId,DetailAccountId)
	where (a.Code like (@accountCode+'%') or @accountCode is null)
	group by d.Id ,a.Id ,a.ParentId,a.Code,FORMAT(DocumentDate,'yyyy-MM'),a.[Name]
	)
    ,summary as(
    select distinct AccountCode,AccountName,ReportMonth,
    isnull((select sum(sTotal.Total) from src sTotal where sTotal.AccountParentId=s.AccountId),s.Total) as Total
     from src s
    )
    select AccountCode,AccountName,ReportMonth Column1,sum(Total) Total 
	into #monthlyReport
	from summary group by AccountCode,AccountName,ReportMonth

	select @profit=sum(case when AccountCode like '6%' then Total else 0 end),
	@cost=sum(case when AccountCode like '7%' then Total else 0 end)
	from #monthlyReport;

	select @profit=isnull(@profit,0),@cost=isnull(@cost,0);

	select AccountCode,AccountName,Column1, Total 
	from #monthlyReport
    order by AccountCode

RETURN 0
end
