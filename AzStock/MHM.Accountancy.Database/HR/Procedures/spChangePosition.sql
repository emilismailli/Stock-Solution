CREATE PROCEDURE [HR].[spChangePosition]
@userId int,
@orderNo varchar(100),
@orderInDate datetime,
@orderInBase nvarchar(500),
@applyDate datetime,
@parentId int=null,
@departmentId int,
@positionId int,
@staffTypeId int,
@isStaff bit,
@salary decimal(26,6)=null,
@id int
with encryption
AS  
  set xact_abort on;
    if @id is null or @id<=0 
	or not exists(select top(1) 0 from [HR].[Employee] where @id is not null and Id=@id and isnull([Salary],0)<>@salary)--maas deyismeyib ve ya id duzgun gonderilmeyibse
    throw 500001,N'Please check input informations.',16;
    

	declare @orderId int=null;
	begin tran
	 if dbo.SfnHasOrder(@orderNo)=1
	  throw 500001,N'The order already exists.',16;
	 else 
	  begin
	  select @orderId=Id from [dbo].[Order] with(rowlock) where [No] = @orderNo
	   if @orderId is null 
	   begin
	     insert into [dbo].[Order]([No],[Description],[Date],[OrderTypeId],[CreateUser],[AppliedUser],[Temp4],[ExecuteDate],[Temp9],[Temp6],[Temp5],[Temp1],[Temp2])
	     select @orderNo,@orderInBase,@orderInDate,3,@userId,@id,@salary,@applyDate,@parentId,@staffTypeId,@isStaff,@departmentId,@positionId;
	     set @orderId=SCOPE_IDENTITY();
	   end
	  end

	  exec [HR].[Auto.spEmployeeOrder] @id;

	if(@@TRANCOUNT>0)
	   commit;

RETURN 0
