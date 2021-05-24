create  PROCEDURE [Accounting].[spPaymentDebt]
	@userId int,
	
@id int =null,
@operationType TINYINT,
@accountId int=NULL,
@customerId int=null,
@paymentTypeId int=null,

@expenseId int null,
	@cashId int null,
@payment DECIMAL(26,6),
@description VARCHAR(500),
@paymentDate datetime = null

AS

BEGIN
IF @operationType IN (1,11)
GOTO spAdd;
--ELSE IF @operationType IN (2,12)
--GOTO spedit;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4   
GOTO spSelect;


spAdd:

INSERT INTO Accounting.Payment(AccountId,CustomerId,PaymentTypeId,ExpenseId,CashId,Deficit,[Description],[PaymentDate],CreateDate) 
VALUES (@accountId,@customerId,@paymenttypeId,@expenseId,@cashId,@payment,@description,@paymentDate,getdate())
	

	 update  Accounting.Cash  set [Balance] = isnull  (Balance,0) +@payment

   
   where Id=@cashId 
   and @accountId=11



    update  Accounting.Cash  set [Balance] = isnull  (Balance,0) - @payment

   
   where Id=@cashId 
   and @accountId=10
   end

  RETURN 0
 spDelete:
BEGIN
 
   
update [Accounting].Payment
set [DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;
if @operationType=13 goto spSelect;
RETURN 0


spSelect:
select *
from [Accounting].VwPaymentIncludeOrder  
 
 RETURN 0

end
 