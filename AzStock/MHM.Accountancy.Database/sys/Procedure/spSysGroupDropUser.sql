CREATE PROCEDURE [dbo].[spSysGroupDropUser]
	@groupName nvarchar(200),
	@userName nvarchar(200)
AS
begin
 declare
    @groupId int = dbo.fnSysGroupId(@groupName),
    @userId int = null;

	if @groupId is null
	begin
       raiserror('group could"t found',16,1);
       return -1;
    end
	
	set @userId=dbo.fnSysUserId(@userName);
	if @userId is null
	begin
       raiserror('user could"t found',16,1);
       return -1;
    end

	delete from dbo.MemberGroupPool where GroupId=@groupId and MemberId=@userId;

RETURN 0
end
