CREATE FUNCTION [Accounting].[IFnContractCustomer]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  [Accounting].[Contract]  where CustomerId=@id
)
