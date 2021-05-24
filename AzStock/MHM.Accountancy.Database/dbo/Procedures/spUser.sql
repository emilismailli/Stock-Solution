--CREATE PROCEDURE [dbo].[spUser]
--	@userId int,
--	@operationType tinyint,
--	@login nvarchar(100)=null,
--	@password nvarchar(128)=null,
--	@isActive bit=null,	
--	@id int=null
--WITH ENCRYPTION
--AS
--BEGIN

--if @operationType in (1,11)
-- goto spAdd;
----else if @operationType in (2,12)
---- goto spEdit;
----else if @operationType in (3,13)
---- goto spDelete;
----else if @operationType = 4
---- goto spSelect;
--else 
--  return 0;

--  spAdd:
--  begin

--   if exists(select top(1) 0 from sys.sql_logins where [login]=@login)
--      or exists(select top(1) 0 from [dbo].[User]  where [Login]=@login) return -1;

--   declare @defdb nvarchar(128)=db_name();
--   insert into [dbo].[User]([Login],[Password],CreatedUser,IsActive)
--   values(@login,@password,@userId,1);

--   --execute sys.sp_addlogin @login,@password,@defdb;
--   --execute sys.sp_addrolemember 'db_owner',@login;

--   if @operationType=11
--   goto spSelect;
--  return 0;
--  end
--spSelect:
--select * from [dbo].[User]
--END
