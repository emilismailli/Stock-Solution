CREATE PROCEDURE [dbo].[spGetGood]
@userId int,
@wareHouseId INT,
@operationType tinyint=4,
@barcodeId int=null,
@barcode varchar(200)=null,
@goodId int=null
AS
if coalesce(@barcodeId,@barcode,@goodId) is null  ---her hansi birine gore axtarish ede bilerik,mutleq 1i qeyd olunmalidi
raiserror('Axtarış parameteri qeyd edilməyib',16,1);
------------son medaxile gore qiymet cixaririq---------------
;with toprecord as (
select 
max(dd.Id) Id
,GoodId
from [Accounting].[DocumentDetail] dd
join [Accounting].[Account] a on dd.AccountId=a.Id 
where a.Code='1.1'
group by GoodId
)
,lastPrices as (
select r.Id,r.GoodId,dd.PriceRetail ,dd.PriceBuy,dd.PriceWholeSale
from [Accounting].[DocumentDetail] dd
join toprecord r on dd.id=r.Id
)
--------------------------------------------------------------
SELECT distinct 
 g.Id GoodId 
,(g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
,gs.Quantity
,b.Id BarcodeId
,b.Barcode
,null Account
,g.GoodName  
,p.PriceRetail Price
,p.PriceBuy 
,p.PriceWholeSale  

FROM Accounting.Good g
join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
join [dbo].[VwDose] d on g.DoseId=d.Id
join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
join Accounting.VwGoodStock gs on  g.Id=gs.Quantity
join [Accounting].[Barcode] b on g.Id=b.GoodId
join [Accounting].[Stock] s on s.GoodId=g.Id
join lastPrices p on p.GoodId=g.Id
where g.DeleteDate is NULL AND gs.WarehouseId=@wareHouseId  and b.DeleteDate is null 
and s.Quantity>0 and (b.Id=@barcodeId or b.Barcode=@barcode or g.id=@goodId)

RETURN 0