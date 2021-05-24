CREATE TABLE [dbo].[MemberGroupPool]
(
	[GroupId] int,
	[MemberId] int,
	constraint PkMemberGroupPoolId unique([GroupId],[MemberId])
)
