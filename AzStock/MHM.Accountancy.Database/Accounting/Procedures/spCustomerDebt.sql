CREATE PROCEDURE [Accounting].[spCustomerDebt]
@userId int
AS
	BEGIN

DECLARE @accountId int,@accountname varchar(200),@customerId int,@customername varchar(200),@payment decimal(26,6),@createdate datetime
DECLARE crs CURSOR FOR(SELECT vp.AccountId,vp.AccountName,vp.CustomerId,vp.CustomerName,vp.Deficit,vp.CreateDate FROM Accounting.VwPayment vp

  join Accounting.[Contract]  c on c.CustomerId=vp.CustomerId


WHERE  ContractTypeId <>3
)
OPEN crs
FETCH NEXT FROM crs INTO @accountId,@accountname,@customerId,@customername,@payment,@createdate
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @deficit decimal(26,6)=0
	,@deficit2 decimal(26,6)=0
	SELECT @deficit=SUM(CASE 
	WHEN  vp.AccountId  LIKE '7' AND vp.CustomerId=@customerId  THEN Deficit 
	WHEN  vp.AccountId LIKE '8' AND  vp.CustomerId=@customerId THEN Deficit
	WHEN  vp.AccountId LIKE '9' AND vp.CustomerId=@customerId THEN Deficit
	WHEN  vp.AccountId LIKE '10' AND vp.CustomerId=@customerId THEN Deficit
	ELSE 0 END),
    
	@deficit2=SUM(CASE 
	WHEN vp.AccountId LIKE '3' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '4' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '5' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '6' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '11' AND vp.CustomerId=@customerId THEN Deficit
	 ELSE 0 END)
     
	FROM Accounting.VwPayment vp 

	DECLARE @cust int=0
	SELECT @cust=ISNULL(p.CustomerId,0) FROM [Accounting].CustomerDebt p WHERE p.CustomerId=@customerId 
	IF @cust=@customerId and @customerId<>0
UPDATE [Accounting].CustomerDebt
SET
Deficit=@deficit-@deficit2
WHERE CustomerId=@customerId;

else 
insert into [Accounting].CustomerDebt (CustomerId,Deficit)
values(@customerId,@deficit-@deficit2)

	FETCH NEXT FROM crs INTO @accountId,@accountname,@customerId,@customername,@payment,@createdate
	end
 
close crs
deallocate crs
	SELECT * FROM [Accounting].VwCustomerDebt 
	--SELECT CustomerName,ISNULL((@deficit-@deficit2),0) Borc FROM Accounting.VwPayment WHERE CustomerId=@customerId GROUP BY CustomerName
	where Deficit<0
	end
 