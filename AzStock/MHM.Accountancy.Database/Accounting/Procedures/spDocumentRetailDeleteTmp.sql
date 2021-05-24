CREATE PROCEDURE [dbo].[spDocumentRetailDeleteTmp] 
@userId int,
@id INT = NULL
  
as
 
begin
update [Accounting].[DocumentDetailTmp]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

--if @operationType=13 goto spSelect;
RETURN 0
end


 