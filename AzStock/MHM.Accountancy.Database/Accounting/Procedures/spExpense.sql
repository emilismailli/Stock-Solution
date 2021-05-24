CREATE PROCEDURE [Accounting].[spExpense] 
@userId int,
@operationType tinyint,
@parentId int=null,
@code varchar(40) =null,
@expenseName nvarchar(200)=null,
@description nvarchar(500)=null,
@isActive bit=null,
@id int=null
with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [Accounting].Expense([ParentId],[Code],[ExpenseName],[Description])
values(@parentId,@code,@expenseName,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].Expense
set
[ParentId]=@parentId,
[Code]=case when @code is null then [Code] else @code end,
[ExpenseName]=case when @expenseName is null then [ExpenseName] else @expenseName end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].Expense
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [Accounting].VwExpense
RETURN 0
end