CREATE FUNCTION [Accounting].[SfnDocumentNumberBySeries]
(
	@series nvarchar(40)
)
RETURNS INT
with encryption
AS
BEGIN
    declare @number int=0;

	select @number=max([Number]) from [Accounting].[Document] where [Series]=@series

	RETURN isnull(@number,0)+1;
END
