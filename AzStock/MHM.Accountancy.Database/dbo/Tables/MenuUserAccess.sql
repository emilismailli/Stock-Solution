CREATE TABLE [dbo].[MenuUserAccess]
(
	[MenuItemId] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
	[Show] [bit] NULL,
	[Create] [bit] NULL,
	[Update] [bit] NULL,
	[Delete] [bit] NULL,
	[ApplyDocument] [bit] NULL,
	[AllowInContainer] [bit] NULL, 
    [AllowRetail] BIT NULL, 
    [ShowCreate] BIT NULL, 
    [ShowUpdate] BIT NULL, 
    [ShowDelete] BIT NULL,
    [ShowApplyDocument] BIT NULL
)
