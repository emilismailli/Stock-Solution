
create  PROCEDURE [Accounting].[spManagementPaymentDebt]
	@userId int,
	
@id int =null,
@operationType TINYINT,
@accountId int=NULL,
@customerId int=null,
@paymentTypeId int=null,

--@expenseId int null,
	--@cashId int null,
@payment DECIMAL(26,6),
@description VARCHAR(500),
@paymentDate datetime = null

AS

BEGIN
IF @operationType IN (1,11)
GOTO spAdd;
ELSE IF @operationType IN (2,12)
GOTO spEdit;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4   
GOTO spSelect;


spAdd:

INSERT INTO Accounting.Payment(AccountId,CustomerId,PaymentTypeId,Deficit,[Description],[PaymentDate],CreateDate) 
VALUES (@accountId,@customerId,@paymenttypeId,@payment,@description,@paymentDate,getdate())
	

	 --update  Accounting.Payment  set Deficit = isnull  (Deficit,0) +@payment

   
  -- where 
  -- --Id=@cashId 
  -- --and
  --  @accountId=11



  --  update  Accounting.Payment  set Deficit = isnull  (Deficit,0) - @payment

   
  -- where 
  -- --Id=@cashId 
  -- --and 
  -- @accountId=10
   end
  RETURN 0

   spEdit:
BEGIN
 
   
update [Accounting].Payment
set 
AccountId=@accountId,
CustomerId=@customerId,
--ExpenseId=@expenseId,
[Deficit]=@payment,
[PaymentDate]=@paymentDate,
PaymentTypeId=@paymentTypeId,
[Description]=@description,
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;
if @operationType=12 goto spSelect;
RETURN 0
 spDelete:
BEGIN
 
   
update [Accounting].Payment
set 
--AccountId=@accountId,
--CustomerId=@customerId,
--ExpenseId=@expenseId,
--[Deficit]=@payment,
--[PaymentDate]=@paymentDate,
--PaymentTypeId=@paymentTypeId,

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;
if @operationType=13 goto spSelect;
end
RETURN 0


spSelect:
select *
from [Accounting].VwCustomerDebt
 end
 RETURN 0
