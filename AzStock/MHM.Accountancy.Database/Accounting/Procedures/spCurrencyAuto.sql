CREATE PROCEDURE [Accounting].[spCurrencyAuto]
	@userId int,
	@operation tinyint,
	@input [Accounting].[UdttCurrency] readonly
AS
begin

if @operation=1
begin
  SELECT [Id],[Name],[Buy],[Sell]
  FROM [Accounting].[Currency]
  where isnull(IsActive,1) =1
  and (RefreshDate is null or  RefreshDate < cast(getdate() as date))
  and Id<>1
end
else
begin
  update c set Buy=i.Buy,Sell=i.Sell,RefreshDate=GETDATE(),CreateUserId=@userId
  from [Accounting].[Currency] c
  join @input i on i.Id=c.Id
  where c.Sell<>i.Sell or c.Buy<>i.Buy
end

return 0;
end
