CREATE FUNCTION [Accounting].[IFnInventarGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.Inventar where DocumentInventarId=@id
)