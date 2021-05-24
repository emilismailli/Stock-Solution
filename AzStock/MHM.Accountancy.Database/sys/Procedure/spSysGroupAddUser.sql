CREATE PROCEDURE [dbo].[spSysGroupAddUser]
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

	insert into dbo.MemberGroupPool(GroupId,MemberId)
	select @groupId,@userId
	except select GroupId,MemberId from dbo.MemberGroupPool;

RETURN 0
end
