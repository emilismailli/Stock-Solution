CREATE PROCEDURE [Accounting].[spDocumentRetailSale]
	@userId int ,
	@operationType tinyint = null,
	@detail [Accounting].[UddtRetailSale] readonly
	

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

--insert into [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[ContractId])
--values (@includeDate,@companyId,@wareHouseId,@contractId)

--set @id=SCOPE_IDENTITY();

insert into [Accounting].[DocumentDetail]([BarCodeId],[AccountId],[GoodId],[Quantity],[PriceRetail], [AmountRetail])
select [BarCodeId],[AccountId], [GoodId],[Quantity],[PriceRetail], [Quantity]*[PriceRetail] [AmountRetail]
from @detail




if @operationType=11 goto spSelect;
RETURN 0
end

