CREATE TABLE [Accounting].[AccountSummary]
(
	[Id] int NOT NULL identity,
	[EntityId] int,
	[EntityTypeId] int,
	[AccountCode] varchar(40),
	[Balance] decimal(26,6),
	[Current] decimal(26,6),
	[DayCount] int null,
	[DailyValue]decimal (26,6) null,
	[Dt] decimal(26,6) null,
	[Kt] decimal(26,6) null,
	[SalaryDate] date null,
	[CreateId] int not null,
	[CreateDate] DATETIME NULL DEFAULT getdate(), 
	[UpdateId] int null,
	[UpdateDate] DATETIME ,
	[DeleteId] int null,
	[DeleteDate] DATETIME,
	[LockId] int null,
	[LockDate] DATETIME ,
	[ReadOnly] DATETIME,
	[DocTypeId] INT NULL,
	[DocCertId] int null,
	[DocSeriesId] int null,
	CONSTRAINT PkAccountSummaryId primary key(Id)
)

GO

CREATE TRIGGER [Accounting].[TrAccountSummaryOnDelete]
    ON [Accounting].[AccountSummary]
    FOR DELETE, UPDATE
    AS
    BEGIN
        SET NoCount ON

		insert into [Accounting].[AccountSummaryHistory]([EntityId]
      ,[EntityTypeId]
      ,[AccountCode]
      ,[Balance]
      ,[Current]
	  ,[DailyValue]
	  ,[DayCount]
      ,[Dt]
      ,[Kt]
	  ,[SalaryDate]
      ,[CreateId]
      ,[CreateDate]
      ,[UpdateId]
      ,[UpdateDate]
      ,[DeleteId]
      ,[DeleteDate]
      ,[LockId]
      ,[LockDate]
      ,[ReadOnly]
      ,[DocTypeId]
      ,[DocCertId]
      ,[DocSeriesId])
	  select  [EntityId]
      ,[EntityTypeId]
      ,[AccountCode]
      ,[Balance]
      ,[Current]
	  ,[DailyValue]
	  ,[DayCount]
      ,[Dt]
      ,[Kt]
	  ,[SalaryDate]
      ,[CreateId]
      ,[CreateDate]
      ,[UpdateId]
      ,[UpdateDate]
      ,[DeleteId]
      ,[DeleteDate]
      ,[LockId]
      ,[LockDate]
      ,[ReadOnly]
      ,[DocTypeId]
      ,[DocCertId]
      ,[DocSeriesId] from deleted;
    END