CREATE PROCEDURE [dbo].[spSysAddUser]
	@name nvarchar(200),
	@password varchar(128),
	@personId int=null
AS

begin

if not exists(select top(1) 0 from sys.sysusers where [name]=@name)
begin

if nullif(@name,'') is null
begin
raiserror('name cant be null',16,1);
return;
end

if nullif(@password,'') is null
begin
raiserror('password cant be null',16,1);
return;
end


declare @sql varchar(900)='CREATE USER '+QUOTENAME(@name)+' WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]';
exec sp_sqlexec @sql;
insert into dbo.[Principial]([Name],[Password],[IsMember],PersonId)
values(@name,@password,1,@personId)
end

RETURN 0;

end
