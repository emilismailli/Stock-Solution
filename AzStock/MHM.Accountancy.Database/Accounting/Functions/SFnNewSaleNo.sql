CREATE FUNCTION [Accounting].[SFnNewSaleNo]
(
	@userId int,
	@accountCode varchar(40)
)
RETURNS int
AS
BEGIN

  if @accountCode is null 
	return null;

  RETURN 
  isnull((SELECT max(dd.SaleNo) FROM [Accounting].[DocumentDetail] dd
  where CreateId=@userId
  and AccountId=[Accounting].[SFnAccountIdByCode]('2.2')
  and CreateDate>=cast(getdate() as date)),0)+1;

END
GO
