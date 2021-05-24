create type [Accounting].[UddtChangePrice]
AS TABLE
(
	[GoodId] int null,
    [PriceBuy] DECIMAL (26, 6) NULL, 
    [PriceRetail] DECIMAL (26, 6) NULL, 
    [PriceWholeSale] DECIMAL (26, 6) NULL,
	
	[NewPriceBuy] DECIMAL (26, 6) NULL, 
	[NewPriceRetail] DECIMAL (26, 6) NULL, 
    [NewPriceWholeSale] DECIMAL (26, 6) NULL
)