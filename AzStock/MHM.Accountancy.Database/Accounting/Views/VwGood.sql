CREATE  VIEW [Accounting].[VwGood]
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
                         ,(ISNULL(g.GoodName,'') + '   ' + ISNULL(gt.Name,'')+ '  ' + ISNULL(pt.Name,'')+ ' ' + ISNULL(d.Name,'')  + '  ' +ISNULL(c.CompanyName,'') + ' ' + ISNULL(reg.Name,'') )  AS FullGoodName
                         ,gt.[Name] AS GoodTypeName
						 ,g.ManufacturerCompanyId
						 ,ISNULL(c.CompanyName, '') AS ManufacturerCompanyName
						 ,g.RegionId
						 ,reg.Name as [RegionName]
						 ,g.UnitId
						 ,u.[Name] AS UnitName
						 ,g.DoseId
						 ,d.[Name] AS DoseName
                         ,g.PackingTypeId
						 ,pt.[Name] AS  PackingTypeName
						 ,g.[Description]
						 ,g.[GoodCode]
						 ,g.[Photo]
						 ,g.CreateId
						 ,g.CreateDate
						 ,g.ModifyId
						 ,g.ModifyDate
						 ,g.DocTypeId
						 ,g.DocCertId
						 ,g.DocSeriesId


FROM            Accounting.Good AS g

--LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id = bar.GoodId 
LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id=bar.GoodId 
LEFT OUTER JOIN    dbo.Unit AS u ON g.UnitId = u.Id
LEFT OUTER JOIN    Accounting.GoodType AS gt ON g.GoodTypeId = gt.Id
LEFT OUTER JOIN    Accounting.VwCompany AS c ON g.ManufacturerCompanyId = c.Id
left outer join dbo.region as reg on reg.Id=g.RegionId
LEFT OUTER JOIN    dbo.VwDose AS d ON g.DoseId = d.Id 
LEFT OUTER JOIN    dbo.VwPackingType AS pt ON g.PackingTypeId = pt.Id
LEFT OUTER JOIN    Accounting.DocumentDetail AS dd ON g.Id = dd.GoodId 
                       
						 WHERE        (g.DeleteId IS NULL)   						
						--and Quantity>=0
GROUP BY
g.Id,
--g.BarcodeId,
c.CompanyName,
 bar.Id, 
bar.Barcode, 
g.GoodName,
g.DocumentDetailId,
g.GoodTypeId,
gt.[Name], 
g.ManufacturerCompanyId,
c.CompanyName,
g.RegionId,
reg.Name, 
g.UnitId,
u.[Name],
g.DoseId,
d.[Name], 
 g.PackingTypeId, 
 pt.[Name],
 g.[Description]
 ,g.[GoodCode],
 g.[Photo],
 g.CreateId, 
 g.CreateDate,
 g.ModifyId,
 g.ModifyDate,
 g.DocTypeId, 
 g.DocCertId,
 g.DocSeriesId


--SELECT       
--                         g.Id
--						 ,g.BarcodeId
--                         --,bar.Id AS Id
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

----LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id = bar.GoodId 
--LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.BarcodeId = bar.Id 
--LEFT OUTER JOIN    dbo.Unit AS u ON g.UnitId = u.Id
--LEFT OUTER JOIN    Accounting.GoodType AS gt ON g.GoodTypeId = gt.Id
--LEFT OUTER JOIN    Accounting.VwCompany AS c ON g.ManufacturerCompanyId = c.Id
--LEFT OUTER JOIN    dbo.VwDose AS d ON g.DoseId = d.Id 
--LEFT OUTER JOIN    dbo.VwPackingType AS pt ON g.PackingTypeId = pt.Id
--LEFT OUTER JOIN    Accounting.DocumentDetail AS dd ON g.Id = dd.GoodId 
                        
--						WHERE        (g.DeleteId IS NULL) 
						
--						--and Quantity>=0

--GROUP BY
--g.Id,
--g.BarcodeId,
--c.CompanyName,
----bar.Id, 

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


