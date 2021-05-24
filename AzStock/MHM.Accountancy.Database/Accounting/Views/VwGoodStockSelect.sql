 

create VIEW [Accounting].[VwGoodStockSelect]
	AS
	select top 100 percent 
	 g.Id
	 ,
	 
	 g.GoodName
	 ,g.GoodTypeName
	 ,g.FullGoodName,
	k.WarehouseId,
	k.Warehouse
	 ,g.[UnitId]
	 ,g.UnitName
	,g.PackingTypeId
	 ,g.PackingTypeName
	 ,g.DoseId
	 ,g.DoseName
	 ,g.[Description]
	 ,g.BarcodeId,
	 g.Barcode
	 ,k.Quantity
		

	FROM [Accounting].[VwGoodSelect] g  	
	   inner join
	
	(select
	g.Id,
	 sto.WarehouseId WarehouseId
	 ,sto.Warehouse Warehouse,
	sum(isnull(sto.Quantity,0)) Quantity
	
	FROM [Accounting].[VwGoodSelect] g  
	left join Accounting.VwStock sto on g.Id=sto.GoodId
	   left join Accounting.VwDocument doc on sto.DocumentId=doc.Id
	   join Accounting.[Contract] cont on cont.Id=doc.ContractId
	WHERE  sto.Quantity>0   
	  and  cont.ContractTypeId in (1)  --burda order by elemek isteyirem Id ucun  kv sql ach
	
	group by 
	g.Id
	 ,
	 g.GoodName
	 
	 ,g.GoodTypeName
	 ,g.FullGoodName
	 ,sto.WarehouseId
	 ,sto.Warehouse
	 ,g.[UnitId]
	 ,g.UnitName
	,g.PackingTypeId
	 ,g.PackingTypeName
	 ,g.DoseId
	 ,g.DoseName
	 ,g.[Description]
	 ,g.BarcodeId
	 ,g.Barcode) k on k.Id=g.Id
	
	 order by g.Id 


GO




--CREATE VIEW [Accounting].[VwGoodStockSelect]
--	AS select 
--	TOP 100 PERCENT
--	 g.Id
--	 ,g.GoodName
--	 ,g.GoodTypeName
--	 ,g.FullGoodName
--	 ,sto.WarehouseId

--	 ,sto.Warehouse
--	 ,g.[UnitId]
--	 ,g.UnitName
--	,g.PackingTypeId
--	 ,g.PackingTypeName
--	 ,g.DoseId
--	 ,g.DoseName
--	 ,g.[Description]
--	 ,g.BarcodeId,
--	 g.Barcode
--	 --,sto.DocumentId
--	 ----------,g.ContractTypeId
--	 ----------,g.ContractId
--	 -------- --,g.DocumentId as DocumentsId 
--	 --,doc.CustomerName
--	 --,cont.ContractTypeId

--	 --  top 100 percent  ne demekdi 100 setir melumat ? yox 100 faiz melumat hamisin getirecey sen birdene create ele harda baxmalisansa bax gor nolur onnan evvel diyan
--	,sum(isnull(sto.Quantity,0)) Quantity
	
--	FROM [Accounting].[VwGoodSelect] g  
--	left join Accounting.VwStock sto on g.Id=sto.GoodId
--	   left join Accounting.VwDocument doc on sto.DocumentId=doc.Id
--	   join Accounting.[Contract] cont on cont.Id=doc.ContractId
--	WHERE sto.Quantity>0   
--	  and  cont.ContractTypeId in (1)  --burda order by elemek isteyirem Id ucun  kv sql ach
	
--	group by 
--	g.Id
--	 ,g.GoodName
	 
--	 ,g.GoodTypeName
--	 ,g.FullGoodName
--	 ,sto.WarehouseId
--	 ,sto.Warehouse
--	 ,g.[UnitId]
--	 ,g.UnitName
--	,g.PackingTypeId
--	 ,g.PackingTypeName
--	 ,g.DoseId
--	 ,g.DoseName
--	 ,g.[Description]
--	 ,g.BarcodeId
--	 ,g.Barcode
--	 order by g.Id 



