﻿CREATE VIEW [Accounting].[VwRetailSaleContractChoose]
	AS SELECT
	c.Id ContractId
	,c. CustomerId
	,cu.CustomerName
	,c. ContractTypeId
	


	FROM [Accounting].[Contract] c
	inner join[Accounting].[ContractType] ct on c.ContractTypeId=ct.Id 
	inner join[Accounting].[Customer] cu on c.CustomerId=cu.Id

	where ContractTypeId in (3)
