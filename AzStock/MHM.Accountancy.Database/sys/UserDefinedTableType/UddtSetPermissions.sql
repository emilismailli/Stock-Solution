create type [dbo].[UddtSetPermissions]
AS TABLE
(
    Id int 
	,AllowShow bit
	,AllowCreate bit
	,AllowUpdate bit
	,AllowDelete bit
	,AllowInContainer bit
	,AllowRetail bit
	,AllowApplyDocument bit
	,ShowCreate bit
	,ShowUpdate bit
	,ShowDelete bit
	,ShowApplyDocument bit
	

   
)