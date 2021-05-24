CREATE PROCEDURE [Accounting].[spCashTrasnport]
	@userId int,
	
@operationType TINYINT,
@accountId int=NULL,
@customerId int=null,
@paymentTypeId int=null,

@expenseId int null,
@cashId int null,
@cashFromId int null,
@payment DECIMAL(26,6), 
@description VARCHAR(500),
@paymentDate datetime null




AS
BEGIN

declare @fromCashBalance  DECIMAL(26,6)=0;

select  @fromCashBalance=Balance from Accounting.Cash where Id=@cashFromId;

if @fromCashBalance>=0 and @fromCashBalance>=@payment
begin

   update  Accounting.Cash  set [Balance] = isnull  (Balance,0) - @payment

   
   where Id=@cashFromId


   update  Accounting.Cash  set [Balance] = isnull  (Balance,0) + @payment

   
   where Id=@cashId




INSERT INTO Accounting.Payment(AccountId,CustomerId,PaymentTypeId,ExpenseId,CashId,[CashFromId],Deficit,Description,PaymentDate,CreateDate) 
VALUES (17,@customerId,@paymenttypeId,@expenseId,@cashId,@cashFromId,@payment,@description,@paymentDate,getdate())

end
else
raiserror('Balans kifayet deyil',11,16)
	
end