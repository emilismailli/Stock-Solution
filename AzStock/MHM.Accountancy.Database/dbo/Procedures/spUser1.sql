CREATE PROCEDURE [dbo].[spUser1]
	@userId int, 
	@login nvarchar(100)=null,
	@password nvarchar(128)=null,
	@isActive bit=null,	
	@id int=null
WITH ENCRYPTION
AS
BEGIN

 
  begin
 
spSelect:
select * from [dbo].[User]
     where [Login]=@login  and [Password]=@password
END
END