CREATE  VIEW [Accounting].[VwGoodSelect]
AS
SELECT       
                         g.Id
						 --,g.BarcodeId
                          ,bar.Id AS BarcodeId
                         ,bar.Barcode
                         ,g.GoodName
                         ,g.DocumentDetailId 
                         ,SUM(dd.Quantity) AS Quantity
						 ,g.GoodTypeId
                         ,(g.GoodName + ' ' + gt.Name+ ' ' + pt.Name+ ' ' + d.Name  + '  ' + c.CompanyName + ' ' + c.RegionName )  AS FullGoodName
                         ,gt.Name AS GoodTypeName
						 ,g.ManufacturerCompanyId
						 ,ISNULL(c.CompanyName, '') AS ManufacturerCompanyName
						 ,c.RegionId
						 ,ISNULL(c.RegionName, '') AS RegionName
						 ,g.UnitId
						 ,u.[Name] AS UnitName
						 ,g.DoseId
						 ,d.Name AS DoseName
                         ,g.PackingTypeId
						 ,pt.Name AS  PackingTypeName
						 ,g.Description
						 ,g.CreateId
						 ,g.CreateDate
						 ,g.ModifyId
						 ,g.ModifyDate
						 ,g.DocTypeId
						 ,g.DocCertId
						 ,g.DocSeriesId
						 --,g.[DocumentId]
						 --,doc.CustomerName  
						 --,cont.ContractTypeId
						 --,g.[ContractId]    
						 --,g.[ContractTypeId]

FROM            Accounting.Good AS g

--LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id = bar.GoodId 
LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id=bar.GoodId 
LEFT OUTER JOIN    dbo.Unit AS u ON g.UnitId = u.Id
LEFT OUTER JOIN    Accounting.GoodType AS gt ON g.GoodTypeId = gt.Id
LEFT OUTER JOIN    Accounting.VwCompany AS c ON g.ManufacturerCompanyId = c.Id
LEFT OUTER JOIN    dbo.VwDose AS d ON g.DoseId = d.Id 
LEFT OUTER JOIN    dbo.VwPackingType AS pt ON g.PackingTypeId = pt.Id
LEFT OUTER JOIN    Accounting.DocumentDetail AS dd ON g.Id = dd.GoodId 
--LEFT OUTER JOIN    Accounting.VwDocument  doc on g.DocumentId=doc.Id 
  --JOIN    Accounting.[Contract] cont on cont.Id=doc.ContractId
						 WHERE        (g.DeleteId IS NULL)  and Quantity>0 
						--and ContractTypeId in (1)
						--and Quantity>=0

GROUP BY
g.Id
 --,g.BarcodeId
,c.CompanyName
, bar.Id
 
,bar.Barcode 
,g.GoodName
,g.DocumentDetailId
,g.GoodTypeId
,gt.Name
,g.ManufacturerCompanyId
,ISNULL(c.CompanyName, '')
,c.RegionId
,c.RegionName 
,g.UnitId
,u.Name
,g.DoseId
,d.Name 
, g.PackingTypeId
, pt.Name
, g.Description
, g.CreateId 
, g.CreateDate
, g.ModifyId
, g.ModifyDate
, g.DocTypeId 
, g.DocCertId
, g.DocSeriesId
 --,g.[DocumentId]
-- ,doc.CustomerName 
-- ,cont.ContractTypeId
----,g.[ContractId]    
--,g.[ContractTypeId]



--SELECT       
--                         g.Id
--						 ,g.BarcodeId
--                         ,bar.Id AS Id
--                         ,bar.Barcode
--                         ,g.GoodName
--                         ,g.DocumentDetailId 
--                         ,SUM(dd.Quantity) AS Quantity
--						 ,g.GoodTypeId
--                         ,(g.GoodName + ' ' + pt.Name+ ' ' + d.Name  + '  ' + c.CompanyName + ' ' + c.RegionName )  AS FullGoodName
--                         ,gt.Name AS GoodTypeName
--						 ,g.ManufacturerCompanyId
--						 ,ISNULL(c.CompanyName, '') AS ManufacturerCompanyName
--						 ,c.RegionId
--						 ,c.RegionName
--						 ,g.UnitId
--						 ,u.Name AS UnitName
--						 ,g.DoseId
--						 ,d.Name AS DoseName
--                         ,g.PackingTypeId
--						 ,pt.Name AS  PackingTypeName
--						 ,g.Description
--						 ,g.CreateId
--						 ,g.CreateDate
--						 ,g.ModifyId
--						 ,g.ModifyDate
--						 ,g.DocTypeId
--						 ,g.DocCertId
--						 ,g.DocSeriesId


--FROM            Accounting.Good AS g

--LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id = bar.GoodId 
--LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.BarcodeId = bar.Id 
--LEFT OUTER JOIN    dbo.Unit AS u ON g.UnitId = u.Id
--LEFT OUTER JOIN    Accounting.GoodType AS gt ON g.GoodTypeId = gt.Id
--LEFT OUTER JOIN    Accounting.VwCompany AS c ON g.ManufacturerCompanyId = c.Id
--LEFT OUTER JOIN    dbo.VwDose AS d ON g.DoseId = d.Id 
--LEFT OUTER JOIN    dbo.VwPackingType AS pt ON g.PackingTypeId = pt.Id
--LEFT OUTER JOIN    Accounting.DocumentDetail AS dd ON g.Id = dd.GoodId 
                        
--						WHERE        (g.DeleteId IS NULL)  and Quantity>0
						
--						and Quantity>=0

--GROUP BY
--g.Id,
--g.BarcodeId,
--c.CompanyName,
--bar.Id, 

--bar.Barcode, 
--g.GoodName,
--g.DocumentDetailId,
--g.GoodTypeId,
--gt.Name, 
--g.ManufacturerCompanyId,
--ISNULL(c.CompanyName, ''),
--c.RegionId,
--c.RegionName, 
--g.UnitId,
--u.Name,
--g.DoseId,
--d.Name, 
-- g.PackingTypeId, 
-- pt.Name,
-- g.Description,
-- g.CreateId, 
-- g.CreateDate,
-- g.ModifyId,
-- g.ModifyDate,
-- g.DocTypeId, 
-- g.DocCertId,
-- g.DocSeriesId


