create PROCEDURE [Accounting].[spRetailReceipts]
	@details [Accounting].[UddtReceiptsRetail] readonly,
	@userId int=null,
	@date datetime =null,
	@statusId int=null ,
	@infoJson nvarchar(max)=null
AS
begin

if @statusId=2 --novbe

begin
insert into Accounting.RetailReceipt (GoodId,BarcodeId,Quantity,StatusId,CreateId,CreateDate,InfoJson)
select 

GoodId,BarcodeId,Quantity,@statusId,@userId,@date,@infoJson InfoJson
 
from @details
end


else if @statusId=1 --tesdiq
begin
merge [Accounting].[RetailReceipt] target
using (select [Id],GoodId,BarcodeId,Quantity,@statusId StatusId,@userId CreateId,@date CreateDate,@infoJson InfoJson from @details) 
source on target.Id=source.Id 
when MATCHED  THEN update set
StatusId=@statusId,CreateId = @userId,InfoJson = source.InfoJson
when NOT MATCHED BY target then 
INSERT
(GoodId,BarcodeId,Quantity,StatusId,CreateId,CreateDate,InfoJson) 
values(source.GoodId,source.BarcodeId,source.Quantity
,@statusId,@userId,@date,@infoJson);
end

else if @statusId=3 --legv
begin
  update rr set rr.StatusId=3
  from Accounting.RetailReceipt rr
   join @details d on rr.Id=d.Id;
end


end
