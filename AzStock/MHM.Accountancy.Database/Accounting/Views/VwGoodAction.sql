CREATE view  Accounting.VwGoodAction as select 
 dd.Id
, dd.FullGoodName
, dd.AccountName
, dd.DocumentId
, dd.Quantity
, SUM(case when dd.AccountParentId in (2) then -1 else 1 end * dd.Quantity) OVER (PARTITION BY dd.GoodId ORDER BY dd.Id) AS SumNow
, dd.PriceBuy
, dd.PriceRetail
, dd.PriceWholeSale
, dd.AmountBuy
, dd.AmountRetail
, dd.AmountWholeSale
, dd.Payment
, dd.Deficit
, ISNULL(dd.CostDeficit, 0)  AS CostDeficit					 
, ISNULL(dd.DiscountPrice, 0) AS DiscountPrice
, ddt.CreateDate
, ddt.CreateId
 , SUM(s.Quantity) AS StockQuantity
  ,pr.Name as UserName



FROM      Accounting.VwDocumentDetail AS dd LEFT OUTER JOIN
          Accounting.Stock AS s ON dd.GoodId = s.GoodId LEFT OUTER JOIN
          Accounting.DocumentDetail AS ddt ON ddt.DocumentId = dd.Id LEFT OUTER JOIN
          dbo.Principial AS pr ON pr.Id = ddt.CreateId

		  

GROUP BY dd.Id
,dd.GoodId
,dd.AccountParentId
, dd.FullGoodName
, dd.AccountName
, dd.DocumentId
, dd.Quantity
, dd.PriceBuy
, dd.PriceRetail
, dd.PriceWholeSale
, dd.AmountBuy
, dd.AmountRetail
, dd.AmountWholeSale
, dd.Payment
, dd.Deficit
, ISNULL(dd.CostDeficit, 0)
,  ISNULL(dd.DiscountPrice, 0)
, ddt.CreateDate
, ddt.CreateId
 ,pr.Name