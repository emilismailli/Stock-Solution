create PROCEDURE [Accounting].[spDocumentRetailTmp]
@userId int,
@operationTypeId tinyint=null,
--@payment  decimal(26,6),
@basket Accounting.UddtRetailSaleTmp readonly,
@selectedDelIds [Accounting].[UdttIds]  readonly,
@goodId int=null,
@quantity decimal(18,4)=0,
@barcodeId int=null,
@createDate datetime = null

as

begin

if @operationTypeId =24
begin 

 select
  rr.Id,
  g.Id GoodId
 ,rr.Quantity
 ,prc.PriceRetail Price
 ,prc.PriceBuy
 ,prc.PriceWholeSale
 ,rr.BarcodeId
 ,b.Barcode
 , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
 ,null Account, g.GoodName

from [Accounting].[RetailReceipt] rr 
join Accounting.Good g on g.Id=rr.GoodId
join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
join [dbo].[VwDose] d on g.DoseId=d.Id
cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
join Accounting.Barcode b on b.Id=rr.BarcodeId
where rr.CreateId=@userId and format(rr.CreateDate,'yyyyMMddHHmmss') =  format(@createDate,'yyyyMMddHHmmss')
and rr.CreateId=@userId

return
end
 
 if(@operationTypeId=4) goto spSelect;
 else if(@operationTypeId=3) goto spDelete;
 if exists(select top(1) 0 from [Accounting].[DocumentTmp] where CreateId=@userId and [GoodId]=@goodId)
begin
   update [Accounting].[DocumentTmp] set [Quantity]=@quantity
   
   where CreateId=@userId and [GoodId]=@goodId;
   goto spSelect;
   return;
end 

 insert into [Accounting].[DocumentTmp](CreateId,[GoodId],[Quantity],[BarcodeId]
 )
 values (@userId,@goodId,(case WHEN @quantity=0 THEN 1 else @quantity end), @barcodeId
 );
goto spSelect;
 return;

  spSelect:
 begin
 select
   
 g.Id GoodId
 ,dt.Quantity
 ,prc.PriceRetail Price
 ,prc.PriceBuy
 ,prc.PriceWholeSale
 ,dt.BarcodeId
 ,b.Barcode
 , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
 ,null Account, g.GoodName
 ,dt.Id TempId

from Accounting.DocumentTmp dt 

join Accounting.Good g on g.Id=dt.GoodId
join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
join [dbo].[VwDose] d on g.DoseId=d.Id
cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
join Accounting.Barcode b on b.Id=dt.BarcodeId

where   dt.CreateId=@userId

 RETURN 0
 end

spDelete:

begin
if exists(select top(1) 0 from @selectedDelIds)
begin
    delete t
	from [Accounting].[DocumentTmp] t
	join @selectedDelIds sd on t.Id = sd.Id
	where CreateId=@userId;
	goto spSelect;
end
else
begin
	delete from [Accounting].[DocumentTmp]
	where CreateId=@userId;
end
RETURN 0
end

 
 end


--CREATE PROCEDURE [Accounting].[spDocumentRetailTmp]
--@userId int,
--@operationTypeId tinyint=null,
----@payment  decimal(26,6),
--@basket Accounting.UddtRetailSaleTmp readonly,
--@selectedDelIds [Accounting].[UdttIds]  readonly,
--@goodId int=null,
--@quantity decimal(18,4)=0,
--@barcodeId int=null,
--@createDate datetime = null

--as

--begin

--if @operationTypeId =24
--begin 

-- select
--  rr.Id,
--  g.Id GoodId
-- ,rr.Quantity
-- ,prc.PriceRetail Price
-- ,prc.PriceBuy
-- ,prc.PriceWholeSale
-- ,rr.BarcodeId
-- ,b.Barcode
-- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
-- ,null Account, g.GoodName

--from [Accounting].[RetailReceipt] rr 
--join Accounting.Good g on g.Id=rr.GoodId
--join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
--join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
--join [dbo].[VwDose] d on g.DoseId=d.Id
--cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
--join Accounting.Barcode b on b.Id=rr.BarcodeId
--where rr.CreateId=@userId and format(rr.CreateDate,'yyyyMMddHHmmss') =  format(@createDate,'yyyyMMddHHmmss')
--and rr.CreateId=@userId

--return
--end
 
-- if(@operationTypeId=4) goto spSelect;
-- else if(@operationTypeId=3) goto spDelete;
-- if exists(select top(1) 0 from [Accounting].[DocumentTmp] where CreateId=@userId and [GoodId]=@goodId)
--begin
--   update [Accounting].[DocumentTmp] set [Quantity]=@quantity
   
--   where CreateId=@userId and [GoodId]=@goodId;
--   return;
--end 

-- insert into [Accounting].[DocumentTmp](CreateId,[GoodId],[Quantity],[BarcodeId]
-- )
-- values (@userId,@goodId,(case WHEN @quantity=0 THEN 1 else @quantity end), @barcodeId
-- );
-- return;

--  spSelect:
-- begin
-- select
-- g.Id GoodId
-- ,dt.Quantity
-- ,prc.PriceRetail Price
-- ,prc.PriceBuy
-- ,prc.PriceWholeSale
-- ,dt.BarcodeId
-- ,b.Barcode
-- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
-- ,null Account, g.GoodName

--from Accounting.DocumentTmp dt 

--join Accounting.Good g on g.Id=dt.GoodId
--join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
--join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
--join [dbo].[VwDose] d on g.DoseId=d.Id
--cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
--join Accounting.Barcode b on b.Id=dt.BarcodeId

--where   dt.CreateId=@userId

-- RETURN 0
-- end

--spDelete:

--begin

--if exists(select top(1) 0 from @selectedDelIds)
--begin
--    delete t
--	from [Accounting].[DocumentTmp] t
--	join @selectedDelIds sd on t.Id = sd.Id
--	where CreateId=@userId;
--end
--else
--begin
--	delete from [Accounting].[DocumentTmp]
--	where CreateId=@userId;
--end


--RETURN 0
--end
 
-- end



--create PROCEDURE [Accounting].[spDocumentRetailTmp]
--@userId int,
--@operationTypeId tinyint=null,
----@payment  decimal(26,6),
--@basket Accounting.UddtRetailSaleTmp readonly,
--@selectedDelIds [Accounting].[UdttIds]  readonly,
--@goodId int=null,
--@quantity decimal(18,4)=0,
--@barcodeId int=null,
--@createDate datetime = null

--as

--begin

--if @operationTypeId =24
--begin 

-- select
--  rr.Id,
--  g.Id GoodId
-- ,rr.Quantity
-- ,prc.PriceRetail Price
-- ,prc.PriceBuy
-- ,prc.PriceWholeSale
-- ,rr.BarcodeId
-- ,b.Barcode
-- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
-- ,null Account, g.GoodName

--from [Accounting].[RetailReceipt] rr 
--join Accounting.Good g on g.Id=rr.GoodId
--join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
--join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
--join [dbo].[VwDose] d on g.DoseId=d.Id
--cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
--join Accounting.Barcode b on b.Id=rr.BarcodeId
--where rr.CreateId=@userId and format(rr.CreateDate,'yyyyMMddHHmmss') =  format(@createDate,'yyyyMMddHHmmss')
--and rr.CreateId=@userId

--return
--end
 
-- if(@operationTypeId=4) goto spSelect;
-- else if(@operationTypeId=3) goto spDelete;
-- if exists(select top(1) 0 from [Accounting].[DocumentTmp] where CreateId=@userId and [GoodId]=@goodId)
--begin
--   update [Accounting].[DocumentTmp] set [Quantity]=@quantity
   
--   where CreateId=@userId and [GoodId]=@goodId;
--   return;
--end 

-- insert into [Accounting].[DocumentTmp](CreateId,[GoodId],[Quantity],[BarcodeId]
-- )
-- values (@userId,@goodId,(case WHEN @quantity=0 THEN 1 else @quantity end), @barcodeId
-- );
-- return;

--  spSelect:
-- begin
-- select
--   dt.Id TempId,
-- g.Id GoodId
-- ,dt.Quantity
-- ,prc.PriceRetail Price
-- ,prc.PriceBuy
-- ,prc.PriceWholeSale
-- ,dt.BarcodeId
-- ,b.Barcode
-- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
-- ,null Account, g.GoodName

--from Accounting.DocumentTmp dt 

--join Accounting.Good g on g.Id=dt.GoodId
--join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
--join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
--join [dbo].[VwDose] d on g.DoseId=d.Id
--cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
--join Accounting.Barcode b on b.Id=dt.BarcodeId

--where   dt.CreateId=@userId

-- RETURN 0
-- end

--spDelete:

--begin
--if exists(select top(1) 0 from @selectedDelIds)
--begin
--    delete t
--	from [Accounting].[DocumentTmp] t
--	join @selectedDelIds sd on t.Id = sd.Id
--	where CreateId=@userId;
--	goto spSelect;
--end
--else
--begin
--	delete from [Accounting].[DocumentTmp]
--	where CreateId=@userId;
--end
--RETURN 0
--end

 
-- end


----CREATE PROCEDURE [Accounting].[spDocumentRetailTmp]
----@userId int,
----@operationTypeId tinyint=null,
------@payment  decimal(26,6),
----@basket Accounting.UddtRetailSaleTmp readonly,
----@selectedDelIds [Accounting].[UdttIds]  readonly,
----@goodId int=null,
----@quantity decimal(18,4)=0,
----@barcodeId int=null,
----@createDate datetime = null

----as

----begin

----if @operationTypeId =24
----begin 

---- select
----  rr.Id,
----  g.Id GoodId
---- ,rr.Quantity
---- ,prc.PriceRetail Price
---- ,prc.PriceBuy
---- ,prc.PriceWholeSale
---- ,rr.BarcodeId
---- ,b.Barcode
---- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
---- ,null Account, g.GoodName

----from [Accounting].[RetailReceipt] rr 
----join Accounting.Good g on g.Id=rr.GoodId
----join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
----join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
----join [dbo].[VwDose] d on g.DoseId=d.Id
----cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
----join Accounting.Barcode b on b.Id=rr.BarcodeId
----where rr.CreateId=@userId and format(rr.CreateDate,'yyyyMMddHHmmss') =  format(@createDate,'yyyyMMddHHmmss')
----and rr.CreateId=@userId

----return
----end
 
---- if(@operationTypeId=4) goto spSelect;
---- else if(@operationTypeId=3) goto spDelete;
---- if exists(select top(1) 0 from [Accounting].[DocumentTmp] where CreateId=@userId and [GoodId]=@goodId)
----begin
----   update [Accounting].[DocumentTmp] set [Quantity]=@quantity
   
----   where CreateId=@userId and [GoodId]=@goodId;
----   return;
----end 

---- insert into [Accounting].[DocumentTmp](CreateId,[GoodId],[Quantity],[BarcodeId]
---- )
---- values (@userId,@goodId,(case WHEN @quantity=0 THEN 1 else @quantity end), @barcodeId
---- );
---- return;

----  spSelect:
---- begin
---- select
---- g.Id GoodId
---- ,dt.Quantity
---- ,prc.PriceRetail Price
---- ,prc.PriceBuy
---- ,prc.PriceWholeSale
---- ,dt.BarcodeId
---- ,b.Barcode
---- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
---- ,null Account, g.GoodName

----from Accounting.DocumentTmp dt 

----join Accounting.Good g on g.Id=dt.GoodId
----join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
----join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
----join [dbo].[VwDose] d on g.DoseId=d.Id
----cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
----join Accounting.Barcode b on b.Id=dt.BarcodeId

----where   dt.CreateId=@userId

---- RETURN 0
---- end

----spDelete:

----begin

----if exists(select top(1) 0 from @selectedDelIds)
----begin
----    delete t
----	from [Accounting].[DocumentTmp] t
----	join @selectedDelIds sd on t.Id = sd.Id
----	where CreateId=@userId;
----end
----else
----begin
----	delete from [Accounting].[DocumentTmp]
----	where CreateId=@userId;
----end


----RETURN 0
----end
 
---- end