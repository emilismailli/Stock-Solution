CREATE TABLE [Accounting].[ImagesGood]
(
	[Id]         INT NOT NULL identity(1,1)  PRIMARY KEY,
	[GoodId]    int ,
	[IsMain]      bit,
	[Image]        varbinary(max),
	[CreateId]  int,
	[CreateDate] datetime,
	[DeleteDate] datetime,
	[DeleteId] int

)
