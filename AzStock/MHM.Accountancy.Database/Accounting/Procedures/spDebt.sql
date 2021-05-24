CREATE PROCEDURE [Accounting].[spDebt]
--Kohne Prosedur
	@operationType TINYINT=NULL,
	@userId INT,
	@customerId int=NULL
AS
BEGIN
DECLARE @deficit decimal(26,6)
	,@deficit2 decimal(26,6)
	SELECT @deficit=sum(case 
	WHEN AccountId  like '7' AND CustomerId=@customerId  THEN Deficit 
	WHEN  AccountId LIKE '8' AND  CustomerId=@customerId THEN Deficit
	WHEN  AccountId LIKE '9' AND CustomerId=@customerId THEN Deficit
	WHEN  AccountId LIKE '10' and CustomerId=@customerId then Deficit
	else 0 end),
    
	@deficit2=SUM(CASE 
	WHEN AccountId LIKE '3' AND CustomerId=@customerId THEN  Deficit
	WHEN AccountId LIKE '4' AND CustomerId=@customerId THEN  Deficit
	WHEN AccountId LIKE '5' AND CustomerId=@customerId THEN  Deficit
	WHEN AccountId LIKE '6' AND CustomerId=@customerId THEN  Deficit
	WHEN AccountId LIKE '11' AND CustomerId=@customerId THEN Deficit
	 else 0 end)
	 
	FROM Accounting.Payment p

	SELECT CustomerName,ISNULL((@deficit-@deficit2),0) Borc FROM Accounting.VwPayment
	

 WHERE CustomerId=@customerId
  GROUP BY CustomerName
end
