CREATE FUNCTION [Accounting].[SfnCustomerContractNumberBySeries]
(
	@id int not null 
)
RETURNS INT
with encryption
AS
BEGIN
    declare @number int=0;

	select @number=max([Number]) from [Accounting].[Customer] where [Id]=@id

	RETURN isnull(@number,0)+1;
END