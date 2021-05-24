CREATE VIEW [Accounting].[VwRetailReceiptHistory]
	AS select
	ROW_NUMBER() OVER(ORDER BY CreateId) RowNo
	,CreateId
	 
	,CreateDate
	,StatusName
	,InfoJson  
	,CashierName
	  
	from (SELECT distinct 
CreateId
,CreateDate
,StatusName
,InfoJson  
,[Name] CashierName
 
  FROM [Accounting].[VwRetailReceipt] rr 

    join dbo.[Principial]  p on p.Id=rr.CreateId
  

  where rr.CreateDate >=CAST(GETDATE() as date) 
) x
   
 

 