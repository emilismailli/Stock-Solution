CREATE TYPE [Accounting].[UdttImagesGood] 
AS TABLE
(
	[Id]        INT NOT NULL,
	[GoodId]     int,
	[IsMain]    bit,
	[Image]    varbinary
)
