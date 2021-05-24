Create PROCEDURE [Accounting].[spInventar]
	@userId int ,
	@operationType tinyint = null,
	@menuId int,
	@wareHouseId INT =NULL,
@documentInventarId INT= null,
	
	
	@detail [Accounting].UddtInventor READONLY

	

AS

BEGIN
IF @operationType IN (1,11)
GOTO spAdd;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4   
GOTO spSelect;


spAdd:
BEGIN






DECLARE @fullgoodname nvarchar(50),@differencequantity decimal(26,5),@id INT,@quantity decimal(26,5),@realquantity decimal(26,5)

INSERT INTO dbo.DocumentInventar(WareHouseId,CreateId,CreateDate) VALUES (@wareHouseId,@userId,GETDATE())
SET @documentInventarId=SCOPE_IDENTITY();

DECLARE crs CURSOR FOR 
(SELECT [Id],[FullGoodName],[DeficitQuanity],[RealQuantity],[Quantity]
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @id,@fullgoodname,@differencequantity,@realquantity,@quantity

WHILE @@FETCH_STATUS=0
BEGIN

INSERT INTO Accounting.Inventar
(
DocumentInventarId,
GoodId,
    FullGoodName,
    DifferenceQuantity,
    StockQuantity,
	WareHouseId,
    Quantity,
    CreateId,
    CreateDate

)
VALUES
(
@documentInventarId,
@id,
    @fullgoodname, 
    @differencequantity, 
    @quantity, 
	@wareHouseId,
    @realquantity,
    @userId,
    getdate()

)

FETCH NEXT FROM crs INTO @id,@fullgoodname,@differencequantity,@realquantity,@quantity


end

close crs
deallocate crs


if @@TRANCOUNT>0 
commit;



if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
BEGIN


select 

-- i.FullGoodName
--,i.DocumentInventarId
--,i.Quantity
--,i.DifferenceQuantity
--,i.StockQuantity
--,i.CreateId
--,i.CreateDate
----,i.DeleteId
--,wh.[Name] WareHouseName
--FROM Accounting.VwInventar i

--JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = i.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
--JOIN WareHouses.WareHouse wh ON i.WareHouseId = wh.Id

--where i.DocumentInventarId=@documentInventarId 
----AND DeleteId IS NULL
* from [Accounting].[Inventar]

 end
 
 spDelete:
BEGIN

UPDATE Accounting.Inventar
SET
DeleteDate=GETDATE(),
DeleteId=@userId

WHERE Id=@Id

UPDATE Accounting.Inventar
SET
DeleteDate=GETDATE(),
DeleteId=@userId

WHERE Id=@id


end

end