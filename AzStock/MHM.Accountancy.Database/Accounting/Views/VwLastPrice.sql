CREATE VIEW [Accounting].[VwLastPrice]
	AS 
	SELECT 
	distinct
	d.FullGoodName,
	s.CreateId,
	s.CreateDate,
    s.PriceBuy, 
    s.PriceRetail, 
    s.PriceWholeSale,
	s.LastPriceBuy,
    s.LastPriceRetail, 
    s.LastPriceWholeSale,
	s.Description
	
	FROM [Accounting].[LastPrice] s
	JOIN Accounting.VwDocumentDetail d ON d.GoodId=s.GoodId