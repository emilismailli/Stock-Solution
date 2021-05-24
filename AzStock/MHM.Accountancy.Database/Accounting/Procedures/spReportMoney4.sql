create PROC [dbo].[spReportMoney4]
    @userId int,
	@beginDate datetime,
	@endDate datetime,     /*filterlemek istediyin parametri  prosedurda yazilmalidi */
	@profit decimal(26,6) =null output,
	@cost decimal(26,6) =null output
   ,@goodId varchar(200)=null
   ,@goodTypeId varchar(200)=null,
	@customerId varchar(200)=null,
	@accountId varchar(200)=null,
	@wareHouseId varchar(200)=null


AS
begin
set @endDate=dateadd(DAY,1,@endDate);
if object_id('tempdb..#monthlyReport') is not null 
	       drop table #monthlyReport
    


	;with src as (
	select dd.DocumentId DocumentId,a.Id AccountId, a.ParentId AccountParentId,a.Code AccountCode,a.[Name] AccountName
	,dd2.CreateDate ReportDay,d.CustomerName _CustomerName,d.WareHouseName _WareHouseName,dd.FullGoodName _FullGoodName,pt.[Name] PaymentTypeName,gt.[Name] GoodTypeName,dd.Quantity _Quantity,dd.PriceBuy _PriceBuy,dd.PriceRetail _PriceRetail,dd.PriceWholeSale _PriceWholeSale,dd.Payment _Payment,dd.Deficit _Deficit
	,sum(dd.AmountBuy) TotalBuy,sum(dd.AmountRetail) TotalRetail,sum(dd.AmountWholeSale) TotalWholeSale,dd.[Percent] Percents
from Accounting.VwDocumentDetail dd 
join Accounting.VwDocument d on dd.DocumentId=d.Id
join Accounting.VwAccount a on dd.AccountId=a.Id
JOIN Accounting.DocumentDetail dd2 ON dd.Id = dd2.Id
left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id
   join [Accounting].[GoodType] gt on gt.Id=dd.GoodId





where(@goodId is null or  dd.GoodId=@goodId) And (@customerId is null or d.CustomerId=@customerId) 
And (@accountId is null or dd.AccountId=@accountId) And (@wareHouseId is null or d.WareHouseId=@wareHouseId) 
And (dd2.CreateDate between @beginDate and @endDate) AND dd2.DeleteId is NULL
	group by dd.DocumentId,dd.Id,a.Id ,a.ParentId,a.Code,dd2.CreateDate,a.[Name],d.CustomerName,d.WareHouseName,dd.FullGoodName,pt.[Name],gt.[Name],dd.Quantity,dd.PriceBuy,dd.PriceRetail,dd.PriceWholeSale,dd.Payment,dd.Deficit,dd.[Percent])
	
    ,summary as(
    select DISTINCT  DocumentId,AccountCode,AccountName,ReportDay,_CustomerName,_WareHouseName,_FullGoodName,PaymentTypeName,GoodTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents,
    isnull((select sum(sTotal.TotalBuy) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalBuy) as TotalAmountBuy,
	isnull((select sum(sTotal.TotalRetail) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalRetail) as TotalAmountRetail,
	isnull((select sum(sTotal.TotalWholeSale) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalWholeSale) as TotalWholeSale
     from src s
    )
    SELECT DocumentId,AccountCode,AccountName,ReportDay Column1,sum(TotalAmountBuy) TotalAmountBuy,sum(TotalAmountRetail) TotalAmountRetail,sum(TotalWholeSale) TotalWholeSale,_WareHouseName,_CustomerName,_FullGoodName,PaymentTypeName,GoodTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents
	into #monthlyReport
	from summary group BY DocumentId,AccountCode,AccountName,ReportDay,_WareHouseName,_CustomerName,_FullGoodName,PaymentTypeName,GoodTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents

	select @profit=sum(case 
	when AccountCode like '2.1' then (TotalWholeSale - TotalAmountBuy)
	--when AccountCode like '2.2' then (TotalAmountRetail - TotalAmountBuy)
	--when AccountCode like '2.3' then TotalAmountBuy 
	else 0 end),

	@cost=sum(case 
	when AccountCode like '1.1' then TotalAmountBuy
	--when AccountCode like '1.2' then TotalAmountBuy
	--when AccountCode like '1.3' then TotalWholeSale
	--when AccountCode like '1.4' then TotalAmountBuy
	 else 0 end)
	 from #monthlyReport;

	--insert into Accounting.TotalReport(TotalCost,TotalProfit) values (@profit,@cost)

	

	select @profit=isnull(@profit,0),@cost=isnull(@cost,0);

	select *,isnull(
	sum(case 
	when AccountCode like '2.1' then (TotalWholeSale - TotalAmountBuy)
	--when AccountCode like '2.2' then (TotalAmountRetail - TotalAmountBuy)
	--when AccountCode like '2.3' then TotalAmountBuy 
	else 0 end),0) Profit,
	isnull(sum(case 
	when AccountCode like '1.1' then TotalAmountBuy
	--when AccountCode like '1.2' then TotalAmountBuy
	--when AccountCode like '1.3' then TotalWholeSale
	--when AccountCode like '1.4' then TotalAmountBuy
	 else 0 end),0) Cost
	from #monthlyReport
	group by DocumentId,AccountCode,AccountName,Column1,TotalWholeSale,TotalAmountBuy,TotalAmountRetail,_FullGoodName,_WareHouseName,_CustomerName,PaymentTypeName,GoodTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents
    order by AccountCode

RETURN 0
end
 

--CREATE PROC [dbo].[spReportMoney4]
--    @userId int,
--	@beginDate datetime,
--	@endDate datetime,     /*filterlemek istediyin parametri  prosedurda yazilmalidi */
--	@profit decimal(26,6) =null output,
--	@cost decimal(26,6) =null output
--   ,@goodId varchar(200)=null,
--	@customerId varchar(200)=null,
--	@accountId varchar(200)=null,
--	@wareHouseId varchar(200)=null


--AS
--begin
--set @endDate=dateadd(DAY,1,@endDate);
--if object_id('tempdb..#monthlyReport') is not null 
--	       drop table #monthlyReport
    


--	;with src as (
--	select dd.DocumentId DocumentId,a.Id AccountId, a.ParentId AccountParentId,a.Code AccountCode,a.[Name] AccountName
--	,dd2.CreateDate ReportDay,d.CustomerName _CustomerName,d.WareHouseName _WareHouseName,dd.FullGoodName _FullGoodName,pt.[Name] PaymentTypeName,dd.Quantity _Quantity,dd.PriceBuy _PriceBuy,dd.PriceRetail _PriceRetail,dd.PriceWholeSale _PriceWholeSale,dd.Payment _Payment,dd.Deficit _Deficit
--	,sum(dd.AmountBuy) TotalBuy,sum(dd.AmountRetail) TotalRetail,sum(dd.AmountWholeSale) TotalWholeSale,dd.[Percent] Percents
--from Accounting.VwDocumentDetail dd 
--join Accounting.VwDocument d on dd.DocumentId=d.Id
--join Accounting.VwAccount a on dd.AccountId=a.Id
--JOIN Accounting.DocumentDetail dd2 ON dd.Id = dd2.Id
--left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id




--where(@goodId is null or  dd.GoodId=@goodId) And (@customerId is null or d.CustomerId=@customerId) 
--And (@accountId is null or dd.AccountId=@accountId) And (@wareHouseId is null or d.WareHouseId=@wareHouseId) 
--And (dd2.CreateDate between @beginDate and @endDate) AND dd2.DeleteId is NULL
--	group by dd.DocumentId,dd.Id,a.Id ,a.ParentId,a.Code,dd2.CreateDate,a.[Name],d.CustomerName,d.WareHouseName,dd.FullGoodName,pt.[Name],dd.Quantity,dd.PriceBuy,dd.PriceRetail,dd.PriceWholeSale,dd.Payment,dd.Deficit,dd.[Percent])
	
--    ,summary as(
--    select DISTINCT  DocumentId,AccountCode,AccountName,ReportDay,_CustomerName,_WareHouseName,_FullGoodName,PaymentTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents,
--    isnull((select sum(sTotal.TotalBuy) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalBuy) as TotalAmountBuy,
--	isnull((select sum(sTotal.TotalRetail) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalRetail) as TotalAmountRetail,
--	isnull((select sum(sTotal.TotalWholeSale) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalWholeSale) as TotalWholeSale
--     from src s
--    )
--    SELECT DocumentId,AccountCode,AccountName,ReportDay Column1,sum(TotalAmountBuy) TotalAmountBuy,sum(TotalAmountRetail) TotalAmountRetail,sum(TotalWholeSale) TotalWholeSale,_WareHouseName,_CustomerName,_FullGoodName,PaymentTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents
--	into #monthlyReport
--	from summary group BY DocumentId,AccountCode,AccountName,ReportDay,_WareHouseName,_CustomerName,_FullGoodName,PaymentTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents

--	select @profit=sum(case 
--	when AccountCode like '2.1' then (TotalWholeSale - TotalAmountBuy)
--	when AccountCode like '2.2' then (TotalAmountRetail - TotalAmountBuy)
--	when AccountCode like '2.3' then TotalAmountBuy 
--	else 0 end),

--	@cost=sum(case 
--	when AccountCode like '1.1' then TotalAmountBuy
--	when AccountCode like '1.2' then TotalAmountBuy
--	when AccountCode like '1.3' then TotalWholeSale
--	when AccountCode like '1.4' then TotalAmountBuy
--	 else 0 end)
--	 from #monthlyReport;

--	--insert into Accounting.TotalReport(TotalCost,TotalProfit) values (@profit,@cost)

	

--	select @profit=isnull(@profit,0),@cost=isnull(@cost,0);

--	select *,isnull(
--	sum(case 
--	when AccountCode like '2.1' then (TotalWholeSale - TotalAmountBuy)
--	when AccountCode like '2.2' then (TotalAmountRetail - TotalAmountBuy)
--	when AccountCode like '2.3' then TotalAmountBuy 
--	else 0 end),0) Profit,
--	isnull(sum(case 
--	when AccountCode like '1.1' then TotalAmountBuy
--	when AccountCode like '1.2' then TotalAmountBuy
--	when AccountCode like '1.3' then TotalWholeSale
--	when AccountCode like '1.4' then TotalAmountBuy
--	 else 0 end),0) Cost
--	from #monthlyReport
--	group by DocumentId,AccountCode,AccountName,Column1,TotalWholeSale,TotalAmountBuy,TotalAmountRetail,_FullGoodName,_WareHouseName,_CustomerName,PaymentTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents
--    order by AccountCode

--RETURN 0
--end
 