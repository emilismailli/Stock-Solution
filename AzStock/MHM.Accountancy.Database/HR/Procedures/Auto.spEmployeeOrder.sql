CREATE PROCEDURE [HR].[Auto.spEmployeeOrder]
	@id int=null
	with encryption
AS

set xact_abort on;
set transaction isolation level serializable;
     ---------------------------------SALARY CHANGE----------------------------------

	 --if object_id('tempdb..#numbers') IS NOT NULL
	 --drop table #numbers;
	 --create table #numbers(Id int);

	 --insert into #numbers select Id from [dbo].[VwOrdersSalaryChangePending] where AppliedDate IS NULL 
	 --and nullif(IsActive,1) IS NULL /*Sened aktivdirse*/
	 --and ExecuteDate <= cast(getdate() as date) /*Tetbiq edilme tarixi*/
	 --and (@id IS NULL OR EmployeeId=@id);

	 --update  e set e.Salary=p.Salary
	 --from [HR].[Employee] e
	 --join [dbo].[VwOrdersSalaryChangePending] p on e.Id=p.EmployeeId
	 --join #numbers n on p.Id=n.Id;

	 --update o set AppliedDate=getdate() 
	 --from [dbo].[Order] o
	 --join #numbers n on o.id=n.Id;

	 --truncate table #numbers;

     ----------------------------------------------------------------------------------
	 declare @entityId int,@orderTypeId int;
	 declare crs cursor local for 
	 select Id,OrderTypeId from [dbo].[Order] 
	 where AppliedDate IS NULL 
	 and nullif(IsActive,1) IS NULL /*Sened aktivdirse*/  
	 and ExecuteDate <= cast(getdate() as date) /*Tetbiq edilme tarixi*/
	 and (@id IS NULL OR AppliedUser=@id)
	 order by Id;

	 open crs

	 fetch next from crs into @entityId,@orderTypeId;

	 while @@fetch_status=0
	 begin
	  ---------------------------------SALARY CHANGE----------------------------------
	  if @orderTypeId=2
	  update  e set e.Salary=o.[Temp4] 
	  from [HR].[Employee] e 
	  join [dbo].[Order] o on e.Id=o.AppliedUser where o.Id=@entityId;

	  ---------------------------------Position CHANGE----------------------------------
	  else if @orderTypeId=3
	  update  e set 
	  e.Salary=case when o.[Temp4]  IS NOT NULL then o.[Temp4]  else e.Salary end,
	  e.ParentId=case when o.[Temp9]  IS NOT NULL then o.[Temp9]  else e.ParentId end,
	  e.StaffTypeId=case when o.[Temp6]  IS NOT NULL then o.[Temp6]  else e.StaffTypeId end,
	  e.IsStaff=case when o.[Temp5]  IS NOT NULL then o.[Temp5]  else e.IsStaff end,
	  e.DepartmentId=case when o.[Temp1]  IS NOT NULL then o.[Temp1]  else e.DepartmentId end,
	  e.PositionId=case when o.[Temp2]  IS NOT NULL then o.[Temp2]  else e.PositionId end
	  from [HR].[Employee] e 
	  join [dbo].[Order] o on e.Id=o.AppliedUser where o.Id=@entityId;




	   update [dbo].[Order]  set AppliedDate=getdate()  where Id=@entityId;
	   fetch next from crs into @entityId,@orderTypeId;
	 end

	 close crs
	 deallocate crs

RETURN 0
