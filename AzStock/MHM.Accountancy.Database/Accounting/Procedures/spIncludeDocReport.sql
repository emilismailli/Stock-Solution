--CREATE PROCEDURE [Accounting].[spIncludeReport]
--	@userId int,
--	@beginDate date,
--	@endDate date,      
--	@contractId int =null,
--	@customerId int=null,
--	@wareHouseId INT=NULL

--	AS
--	begin
	
--	set @endDate =DATEADD(DAY,1,@endDate);
--	if OBJECT_ID ('tempdb..#monthlyReport') is not null 
--	drop table #monthlyReport
--	;with repo as(

--	select 

--coalesce(d.IncludeDate,dd.CreateDate) DocumentDate
--,d.CustomerName
--,d.IncludeDate
--,d.WareHouseId
--,d.WareHouseName
--,DD.GoodName
--,dd.Quantity
--,dd.PriceBuy  
--,dd.AmountBuy
--,dd.DocumentId
	
--	from Accounting.VwDocument d 
--	 join [Accounting].[DocumentDetail]dd on d.id=dd.DocumentId 
--	   where coalesce (d.IncludeDate,dd.CreateDate)>=@beginDate  and coalesce(d.IncludeDate,dd.CreateDate) < @endDate -- d.DocumentDate>=@beginDate  and d.DocumentDate < @endDate
--    and AccountId=3
	

--	--,src as (
	
--	--select c.Id ,d.Id  ,c.CustomerName 
--	--from repo d
--	--join Accounting.Customer c on c.Id=isnull(d.ContractId)
  
--	--)

--	--	,src as (
	
--	--select vw.Id ,d.Id  ,vw.[Name] 
--	--from repo a
--	--join WareHouses.WareHouse vw on c.Id=isnull(d.WareHouseId)
   
--	--)
	 
--END