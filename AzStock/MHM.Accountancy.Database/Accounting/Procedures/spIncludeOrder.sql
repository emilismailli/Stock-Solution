CREATE PROCEDURE [Accounting].[spIncludeOrder]
	@userId int 
	 
 as
	SELECT vdd.CustomerName,sum(p.Deficit) Borc FROM Accounting.VwDocumentDetail vdd
	join Accounting.Payment p on vdd.PaymentId=p.Id
JOIN Accounting.VwDocument vd ON vdd.DocumentId=vd.Id
 WHERE vdd.AccountCode=1.1  and  vdd.Deficit<>'0'
  GROUP BY vdd.CustomerName
