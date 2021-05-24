CREATE PROCEDURE [Accounting].[spDocumentSaless]
	@userId int ,
	@operationType tinyint = null,
	@id INT = NULL,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
	@contractId int =null,
	@customerId int=null,
    
	@detail [Accounting].[UddtIncludeGood] readonly
	

with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spedit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
begin tran 

if exists(select top(1) 0 from @detail d
join Accounting.Stock st with(rowlock,holdlock) on d.GoodId=st.GoodId
where st.quantity -d.Quantity<0)
begin
raiserror('Stokda kifayet qeder mehsul yoxdur',16,1)
rollback
return
end
else 
begin
update st set st.Quantity=st.Quantity-d.Quantity
from @detail d join Accounting.Stock st with(rowlock,holdlock) on d.GoodId=st.GoodId
end

insert into [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[ContractId])
values (@includeDate,@companyId,@wareHouseId,@contractId)

set @id=SCOPE_IDENTITY();

insert into [Accounting].[DocumentDetail]([DocumentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit])
select @id,[AccountId], [GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[Quantity]*[PriceBuy] [AmountBuy],[Quantity]*[PriceRetail] [AmountRetail],[Quantity]*[PriceWholeSale] [AmountWholeSale],[Payment],[AmountBuy] - [Payment][Deficit]
from @detail


--insert into [Accounting].[Stock] (GoodId,Quantity)
--select [GoodId],[Quantity]
--from @detail




if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].[Document]
set

[IncludeDate]=@includeDate,
[CompanyId]=@companyId,
[WareHouseId]=@wareHouseId,
[ContractId]=@contractId

where Id=@id;


--------------  Stock -------------

;with chck as (
select d.GoodId,sum(d.Quantity-isnull(dd.Quantity,0)) Quantity from @detail d 
left join [Accounting].[DocumentDetail] dd on d.Id=dd.Id
group by d.GoodId
)


merge [Accounting].[Stock] target
using (select [GoodId] ,Quantity  from chck)source  on target.GoodId=source.GoodId
when Matched then
update set [Quantity]=target.Quantity-source.[Quantity] 
when not matched by target then insert ([GoodId],[Quantity]) values(source.GoodId,source.Quantity);


merge [Accounting].[DocumentDetail] target
using (select [Id],[GoodId],@id [DocumentId],[AccountId],[BarCodeId],[Series],[DateOfProduction]
,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
,[Quantity]*[PriceBuy] [AmountBuy],[Quantity]*[PriceRetail] [AmountRetail]
,[Quantity]*[PriceWholeSale] [AmountWholeSale],[Payment],[AmountBuy] - [Payment] [Deficit]
from @detail) source on target.Id=source.Id
when MATCHED and target.DocumentId=@id THEN 


update set [AccountId]=source.[AccountId],[BarCodeId]=source.[BarCodeId],[Series]=source.[Series]
,[DateOfProduction]=source.[DateOfProduction],[LastExpirationDate]=source.[LastExpirationDate]
,[Quantity]=source.[Quantity],[UnitId]=source.[UnitId],[PriceBuy]=source.[PriceBuy]
,[PriceRetail]=source.[PriceRetail],[PriceWholeSale]=source.[PriceWholeSale]
,[AmountBuy]=source.[AmountBuy],[AmountRetail]=source.[AmountRetail]
,[AmountWholeSale]=source.[AmountWholeSale],[Payment]=source.[Payment]
,[Deficit]=source.[AmountBuy]-(isnull(target.[Payment],0)+source.[Payment])


when NOT MATCHED BY target then 
insert  ( [DocumentId] ,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction]
,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy]
,[AmountRetail],[AmountWholeSale],[Payment],[Deficit])
values (@id,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate]
,[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[Quantity]*[PriceBuy]
, [Quantity] * [PriceRetail] ,[Quantity]*[PriceWholeSale] ,[Payment],[AmountBuy]-[Payment] )

when NOT MATCHED BY source and target.DocumentId=@Id then update set [DeleteId]=@userId
,[DeleteDate]=getdate();

if @@TRANCOUNT>0
   commit;
if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[Document]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
select  d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
     
         ,max(dd.AmountBuy) AmountBuy
         ,max(dd.AmountRetail) AmountRetail
         ,max(dd.AmountWholeSale) AmountWholeSale
		 ,max(dd.PriceWholeSale) PriceWholeSale
	     ,max(dd.Payment) Payment
	     ,max(dd.Deficit) Deficit
from [Accounting].[VwDocument] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
 left join [Accounting].[VwContract] c on c.id=d.ContractId
 where c.ContractTypeId=2--satiw ucun
 group by 
     d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName];
 RETURN 0
end