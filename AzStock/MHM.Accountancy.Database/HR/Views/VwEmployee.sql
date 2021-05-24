CREATE VIEW [HR].[VwEmployee]
with encryption
	AS 
	SELECT  e.[Id]
      ,isnull([ParentId],0) [ParentId]
      ,[PersonId]
	  ,concat(pr.[Name],' ',pr.[Surname],' ',pr.[Patronymic]) [Name]
	  ,[DepartmentId]
	  ,d.[Name] DepartmentName
      ,[PositionId]
	  ,p.[Name] PositionName
      ,[StartDate]
      ,[EndDate]
      ,[Salary]
      ,[OrderInId]
	  ,oIn.[No] [OrderInNo]
	  ,oIn.[Date] [OrderInDate]
	  ,oIn.[Description] [OrderInBase]
      ,[OrderOutId]
      ,[IsStaff]
      ,[StaffTypeId]
      ,e.[Description]
      ,[WorkEmail]
      ,[WorkPhone]
      ,[StatusId]
	  ,[Photo]
	  ,s.[Name] [Status]
      ,isnull(e.[DocType],0) [DocType]
      ,[DocCert]
      ,[DocSeries]
      ,pr.[CreatedDate]
      ,pr.[CreatedUser]
      ,pr.[UpdatedDate]
      ,pr.[UpdatedUser]
      ,pr.[DeletedDate]
      ,pr.[DeletedUser]
  FROM [HR].[Employee] e
  join [CRM].[Person] pr on e.PersonId=pr.Id
  left join [HR].[EmployeeStatus] s on e.StatusId=s.Id
  left join [dbo].[Department] d on e.DepartmentId=d.Id
  left join [dbo].[Position] p on e.PositionId=p.Id
  left join [dbo].[Order] oIn on e.[OrderInId]=oIn.[Id]

  go;

  -- triggers
  create trigger [HR].[trgInsertEmployee]    
	on [HR].[VwEmployee]
	with encryption
	instead of insert
  as
  begin
   --SET implicit_transactions on
    set xact_abort on;

    declare @count int=0,@orderId int=null,@orderNo varchar(100),@userId int;
	select @count=count(0) from inserted;

     if @count>1  or @count=0 
	 throw 500001,N'Only simple row apply in trigger',16;
     
	 select @orderNo=i.OrderInNo,@userId=CreatedUser from inserted i;

	 if dbo.SfnHasOrder(@orderNo)=1
	  throw 500001,N'The order already exists.',16;
	 else 
	  begin
	  select @orderId=Id from [dbo].[Order] with(rowlock) where [No] = @orderNo
	   if @orderId is null 
	   begin
	     insert into [dbo].[Order]([No],[Description],[Date],[OrderTypeId],[CreateUser])
	     select OrderInNo,OrderInBase,OrderInDate,1,CreatedUser from inserted;
	     set @orderId=SCOPE_IDENTITY();
	   end
	  end

    insert into [HR].[Employee]([ParentId],[PersonId],[DepartmentId],[PositionId],[StartDate],[EndDate],[Salary],[OrderInId],[OrderOutId],[IsStaff],[StaffTypeId],[Description],[WorkEmail],[WorkPhone],[StatusId],[DocType],[DocCert],[DocSeries],[CreatedUser])
	select ParentId,[PersonId],DepartmentId,PositionId,StartDate,EndDate,Salary,@orderId,OrderOutId,IsStaff,StaffTypeId,[Description],WorkEmail,WorkPhone,StatusId,DocType,DocCert,DocSeries,CreatedUser from inserted; 
    --values(@parentId,@personId,@departmentId,@positionId,@startDate,@endDate,@salary,@orderInId,@orderOutId,@isStaff,@staffTypeId,@description,@workEmail,@workPhone,@statusId,@docTypeId,@docCertId,@docSeriesId,@userId);
	
	update [dbo].[Order] set AppliedUser=@userId,AppliedDate=getdate() where Id=@orderId;

  end
