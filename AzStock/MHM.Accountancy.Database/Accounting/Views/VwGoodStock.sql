CREATE VIEW [Accounting].[VwGoodStock]
	AS SELECT 
	
	 g.Id
	 ,g.GoodName
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
	 ,g.BarcodeId,
	 g.Barcode
	 --,sto.DocumentId
	 ----------,g.ContractTypeId
	 ----------,g.ContractId
	 -------- --,g.DocumentId as DocumentsId 
	 --,doc.CustomerName
	 --,cont.ContractTypeId



	,sum(isnull(sto.Quantity,0)) Quantity
	
	FROM [Accounting].[VwGoodSelect] g
	left join Accounting.VwStock sto on g.Id=sto.GoodId
	   left join Accounting.VwDocument doc on sto.DocumentId=doc.Id
	   join Accounting.[Contract] cont on cont.Id=doc.ContractId
	WHERE sto.Quantity>=0 
	  and  cont.ContractTypeId in (1)
	
	group by 
	g.Id
	 ,g.GoodName
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
	 ,g.Barcode
	 
	 --,sto.DocumentId
	 --	  ------,g.DocumentId
	 --,doc.CustomerName
	 --,cont.ContractTypeId
 
	 