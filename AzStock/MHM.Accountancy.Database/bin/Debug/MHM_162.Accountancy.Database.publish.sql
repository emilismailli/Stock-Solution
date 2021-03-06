
IF (DB_ID(N'{0}') IS NOT NULL) 
BEGIN
    ALTER DATABASE [{0}]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [{0}];
END

GO
PRINT N'Creating {0}...'
GO
CREATE DATABASE [{0}]
    ON 
    PRIMARY(NAME = [{0}], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [{0}_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'{0}')
    BEGIN
        ALTER DATABASE [{0}]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [{0}];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'{0}')
    BEGIN
        ALTER DATABASE [{0}]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'{0}')
    BEGIN
        ALTER DATABASE [{0}]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'{0}')
    BEGIN
        ALTER DATABASE [{0}]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'{0}')
    BEGIN
        ALTER DATABASE [{0}]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'{0}')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [{0}]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'{0}')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [{0}]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [{0}]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'{0}')
    BEGIN
        ALTER DATABASE [{0}]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'{0}')
    BEGIN
        ALTER DATABASE [{0}]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'{0}')
    BEGIN
        ALTER DATABASE [{0}]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'{0}')
    BEGIN
        ALTER DATABASE [{0}]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'{0}')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [Accounting]...';


GO
CREATE SCHEMA [Accounting]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [CRM]...';


GO
CREATE SCHEMA [CRM]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [HR]...';


GO
CREATE SCHEMA [HR]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [Service]...';


GO
CREATE SCHEMA [Service]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [WareHouses]...';


GO
CREATE SCHEMA [WareHouses]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [Accounting].[UdttCurrency]...';


GO
CREATE TYPE [Accounting].[UdttCurrency] AS TABLE (
    [Id]   INT             NOT NULL,
    [Buy]  DECIMAL (26, 6) NULL,
    [Sell] DECIMAL (26, 6) NULL);


GO
PRINT N'Creating [Accounting].[UddtBarcodeGood]...';


GO
CREATE TYPE [Accounting].[UddtBarcodeGood] AS TABLE (
    [Id]      INT           NULL,
    [GoodId]  INT           NULL,
    [Barcode] VARCHAR (200) NULL);


GO
PRINT N'Creating [Accounting].[UddtIncludeGood]...';


GO
CREATE TYPE [Accounting].[UddtIncludeGood] AS TABLE (
    [Id]                 INT             NOT NULL,
    [StoGoodId]          INT             NULL,
    [CompanyName]        NVARCHAR (200)  NULL,
    [CustomerName]       NVARCHAR (200)  NULL,
    [BarcodeId]          INT             NULL,
    [AccountId]          INT             NULL,
    [GoodId]             INT             NULL,
    [Series]             NVARCHAR (200)  NULL,
    [DateOfProduction]   DATETIME        NULL,
    [LastExpirationDate] DATETIME        NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [UnitId]             INT             NULL,
    [PriceBuy]           DECIMAL (26, 6) NULL,
    [PriceRetail]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]     DECIMAL (26, 6) NULL,
    [AmountBuy]          DECIMAL (26, 6) NULL,
    [AmountRetail]       DECIMAL (26, 6) NULL,
    [AmountWholeSale]    DECIMAL (26, 6) NULL,
    [Payment]            DECIMAL (26, 6) NULL,
    [Deficit]            DECIMAL (26, 6) NULL,
    [Percent]            NVARCHAR (50)   NULL,
    [CostInclude]        DECIMAL (26, 6) NULL,
    [CostDeficit]        DECIMAL (26, 6) NULL,
    [DiscountPrice]      DECIMAL (26, 6) NULL);


GO
PRINT N'Creating [Accounting].[UddtRetailSaleTmp]...';


GO
CREATE TYPE [Accounting].[UddtRetailSaleTmp] AS TABLE (
    [GoodId]       INT             NOT NULL,
    [Quantity]     DECIMAL (26, 6) NULL,
    [FullGoodName] NVARCHAR (200)  NULL,
    [BarcodeId]    BIGINT          NULL,
    [Barcode]      VARCHAR (200)   NULL,
    [AccountId]    INT             NULL,
    [GoodName]     NVARCHAR (200)  NULL,
    [PriceRetail]  DECIMAL (26, 6) NULL);


GO
PRINT N'Creating [Accounting].[UddtIncludeReturn]...';


GO
CREATE TYPE [Accounting].[UddtIncludeReturn] AS TABLE (
    [Id]                 INT             NOT NULL,
    [StoGoodId]          INT             NULL,
    [CompanyName]        NVARCHAR (200)  NULL,
    [CustomerName]       NVARCHAR (200)  NULL,
    [BarcodeId]          BIGINT          NULL,
    [AccountId]          INT             NULL,
    [GoodId]             INT             NULL,
    [Series]             NVARCHAR (200)  NULL,
    [DateOfProduction]   DATETIME        NULL,
    [LastExpirationDate] DATETIME        NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [UnitId]             INT             NULL,
    [PriceBuy]           DECIMAL (26, 6) NULL,
    [PriceRetail]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]     DECIMAL (26, 6) NULL,
    [AmountBuy]          DECIMAL (26, 6) NULL,
    [AmountRetail]       DECIMAL (26, 6) NULL,
    [AmountWholeSale]    DECIMAL (26, 6) NULL,
    [Payment]            DECIMAL (26, 6) NULL,
    [Deficit]            DECIMAL (26, 6) NULL);


GO
PRINT N'Creating [Accounting].[UddtRetailSale]...';


GO
CREATE TYPE [Accounting].[UddtRetailSale] AS TABLE (
    [GoodId]         INT             NOT NULL,
    [Quantity]       DECIMAL (26, 6) NULL,
    [FullGoodName]   NVARCHAR (200)  NULL,
    [BarcodeId]      BIGINT          NULL,
    [Barcode]        VARCHAR (200)   NULL,
    [AccountId]      INT             NULL,
    [GoodName]       NVARCHAR (200)  NULL,
    [PriceRetail]    DECIMAL (26, 6) NULL,
    [PriceBuy]       DECIMAL (26, 6) NULL,
    [PriceWholeSale] DECIMAL (26, 6) NULL);


GO
PRINT N'Creating [Accounting].[UddtRetailSaleGoodReturn]...';


GO
CREATE TYPE [Accounting].[UddtRetailSaleGoodReturn] AS TABLE (
    [Id]                 INT             NOT NULL,
    [StoGoodId]          INT             NULL,
    [CompanyName]        NVARCHAR (200)  NULL,
    [CustomerName]       NVARCHAR (200)  NULL,
    [BarcodeId]          INT             NULL,
    [AccountId]          INT             NULL,
    [GoodId]             INT             NULL,
    [Series]             NVARCHAR (200)  NULL,
    [DateOfProduction]   DATETIME        NULL,
    [LastExpirationDate] DATETIME        NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [UnitId]             INT             NULL,
    [PriceBuy]           DECIMAL (26, 6) NULL,
    [PriceRetail]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]     DECIMAL (26, 6) NULL,
    [AmountBuy]          DECIMAL (26, 6) NULL,
    [AmountRetail]       DECIMAL (26, 6) NULL,
    [AmountWholeSale]    DECIMAL (26, 6) NULL,
    [Payment]            DECIMAL (26, 6) NULL,
    [Deficit]            DECIMAL (26, 6) NULL);


GO
PRINT N'Creating [Accounting].[CustomerContract]...';


GO
CREATE TYPE [Accounting].[CustomerContract] AS TABLE (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [PrivateNumber]    NVARCHAR (200) NULL,
    [Company]          NVARCHAR (200) NULL,
    [CompanyLeader]    NVARCHAR (200) NULL,
    [WorkTypeId]       INT            NULL,
    [Voen]             NVARCHAR (50)  NULL,
    [Currency]         INT            NULL,
    [OperatorBankName] INT            NULL,
    [BankSwift]        NVARCHAR (200) NULL,
    [LegalAddress]     NVARCHAR (200) NULL,
    [ActualAddress]    NVARCHAR (200) NULL,
    [Email]            NVARCHAR (200) NULL,
    [Tel]              NVARCHAR (200) NULL,
    [Date]             DATETIME       NULL,
    [Description]      NVARCHAR (500) NULL,
    [ContractDate]     DATETIME       NULL,
    [ContractNo]       NVARCHAR (200) NULL,
    [CurrencyName]     INT            NULL,
    [OperationType]    INT            NULL,
    [CompanyName]      INT            NULL,
    [CustomerName]     INT            NULL,
    [ContractTypeName] INT            NULL);


GO
PRINT N'Creating [Accounting].[UddtSaleGoodReturn]...';


GO
CREATE TYPE [Accounting].[UddtSaleGoodReturn] AS TABLE (
    [Id]                 INT             NOT NULL,
    [StoGoodId]          INT             NULL,
    [CompanyName]        NVARCHAR (200)  NULL,
    [CustomerName]       NVARCHAR (200)  NULL,
    [BarcodeId]          INT             NULL,
    [AccountId]          INT             NULL,
    [GoodId]             INT             NULL,
    [Series]             NVARCHAR (200)  NULL,
    [DateOfProduction]   DATETIME        NULL,
    [LastExpirationDate] DATETIME        NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [UnitId]             INT             NULL,
    [PriceBuy]           DECIMAL (26, 6) NULL,
    [PriceRetail]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]     DECIMAL (26, 6) NULL,
    [AmountBuy]          DECIMAL (26, 6) NULL,
    [AmountRetail]       DECIMAL (26, 6) NULL,
    [AmountWholeSale]    DECIMAL (26, 6) NULL,
    [Payment]            DECIMAL (26, 6) NULL,
    [Deficit]            DECIMAL (26, 6) NULL,
    [DiscountPrice]      DECIMAL (26, 6) NULL);


GO
PRINT N'Creating [Accounting].[UddtSaleGood]...';


GO
CREATE TYPE [Accounting].[UddtSaleGood] AS TABLE (
    [Id]                 INT             NOT NULL,
    [StoGoodId]          INT             NULL,
    [CompanyName]        NVARCHAR (200)  NULL,
    [CustomerName]       NVARCHAR (200)  NULL,
    [BarcodeId]          INT             NULL,
    [AccountId]          INT             NULL,
    [GoodId]             INT             NULL,
    [Series]             NVARCHAR (200)  NULL,
    [DateOfProduction]   DATETIME        NULL,
    [LastExpirationDate] DATETIME        NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [UnitId]             INT             NULL,
    [PriceBuy]           DECIMAL (26, 6) NULL,
    [PriceRetail]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]     DECIMAL (26, 6) NULL,
    [AmountBuy]          DECIMAL (26, 6) NULL,
    [AmountRetail]       DECIMAL (26, 6) NULL,
    [AmountWholeSale]    DECIMAL (26, 6) NULL,
    [Payment]            DECIMAL (26, 6) NULL,
    [Deficit]            DECIMAL (26, 6) NULL,
    [Percent]            NVARCHAR (50)   NULL,
    [CostInclude]        DECIMAL (26, 6) NULL,
    [CostDeficit]        DECIMAL (26, 6) NULL,
    [DiscountPrice]      DECIMAL (26, 6) NULL);


GO
PRINT N'Creating [Accounting].[UddtDeleteGood]...';


GO
CREATE TYPE [Accounting].[UddtDeleteGood] AS TABLE (
    [Id]                 INT             NOT NULL,
    [StoGoodId]          INT             NULL,
    [CompanyName]        NVARCHAR (200)  NULL,
    [CustomerName]       NVARCHAR (200)  NULL,
    [BarcodeId]          INT             NULL,
    [AccountId]          INT             NULL,
    [GoodId]             INT             NULL,
    [Series]             NVARCHAR (200)  NULL,
    [DateOfProduction]   DATETIME        NULL,
    [LastExpirationDate] DATETIME        NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [UnitId]             INT             NULL,
    [PriceBuy]           DECIMAL (26, 6) NULL,
    [PriceRetail]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]     DECIMAL (26, 6) NULL,
    [AmountBuy]          DECIMAL (26, 6) NULL,
    [AmountRetail]       DECIMAL (26, 6) NULL,
    [AmountWholeSale]    DECIMAL (26, 6) NULL,
    [Payment]            DECIMAL (26, 6) NULL,
    [Deficit]            DECIMAL (26, 6) NULL,
    [Description]        NVARCHAR (500)  NULL);


GO
PRINT N'Creating [Accounting].[UddtRetailsSaleGood]...';


GO
CREATE TYPE [Accounting].[UddtRetailsSaleGood] AS TABLE (
    [Id]                 INT             NOT NULL,
    [StoGoodId]          INT             NULL,
    [CompanyName]        NVARCHAR (200)  NULL,
    [CustomerName]       NVARCHAR (200)  NULL,
    [BarcodeId]          INT             NULL,
    [AccountId]          INT             NULL,
    [GoodId]             INT             NULL,
    [Series]             NVARCHAR (200)  NULL,
    [DateOfProduction]   DATETIME        NULL,
    [LastExpirationDate] DATETIME        NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [UnitId]             INT             NULL,
    [PriceBuy]           DECIMAL (26, 6) NULL,
    [PriceRetail]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]     DECIMAL (26, 6) NULL,
    [AmountBuy]          DECIMAL (26, 6) NULL,
    [AmountRetail]       DECIMAL (26, 6) NULL,
    [AmountWholeSale]    DECIMAL (26, 6) NULL,
    [Payment]            DECIMAL (26, 6) NULL,
    [Deficit]            DECIMAL (26, 6) NULL,
    [Percent]            NVARCHAR (50)   NULL);


GO
PRINT N'Creating [Accounting].[UddtChangePrice]...';


GO
CREATE TYPE [Accounting].[UddtChangePrice] AS TABLE (
    [GoodId]            INT             NULL,
    [PriceBuy]          DECIMAL (26, 6) NULL,
    [PriceRetail]       DECIMAL (26, 6) NULL,
    [PriceWholeSale]    DECIMAL (26, 6) NULL,
    [NewPriceBuy]       DECIMAL (26, 6) NULL,
    [NewPriceRetail]    DECIMAL (26, 6) NULL,
    [NewPriceWholeSale] DECIMAL (26, 6) NULL);


GO
PRINT N'Creating [Accounting].[UddtInventor]...';


GO
CREATE TYPE [Accounting].[UddtInventor] AS TABLE (
    [Id]             INT             NULL,
    [FullGoodName]   NVARCHAR (200)  NULL,
    [Quantity]       DECIMAL (26, 5) NULL,
    [RealQuantity]   DECIMAL (26, 5) NULL,
    [DeficitQuanity] DECIMAL (26, 5) NULL);


GO
PRINT N'Creating [Accounting].[UdttImagesGood]...';


GO
CREATE TYPE [Accounting].[UdttImagesGood] AS TABLE (
    [Id]     INT           NOT NULL,
    [GoodId] INT           NULL,
    [IsMain] BIT           NULL,
    [Image]  VARBINARY (1) NULL);


GO
PRINT N'Creating [Accounting].[UdttIds]...';


GO
CREATE TYPE [Accounting].[UdttIds] AS TABLE (
    [Id] INT NOT NULL);


GO
PRINT N'Creating [Accounting].[UddtReceiptsRetail]...';


GO
CREATE TYPE [Accounting].[UddtReceiptsRetail] AS TABLE (
    [Id]        INT             NOT NULL,
    [GoodId]    INT             NULL,
    [BarcodeId] INT             NULL,
    [Quantity]  DECIMAL (26, 6) NULL);


GO
PRINT N'Creating [Accounting].[UddtLogisticDetail]...';


GO
CREATE TYPE [Accounting].[UddtLogisticDetail] AS TABLE (
    [LogisticId]  INT             NULL,
    [BarcodeId]   INT             NULL,
    [GoodId]      INT             NULL,
    [Quantity]    DECIMAL (26, 6) NULL,
    [UnitId]      INT             NULL,
    [Description] NVARCHAR (500)  NULL);


GO
PRINT N'Creating [Accounting].[UddtOfflineSaleDetail]...';


GO
CREATE TYPE [Accounting].[UddtOfflineSaleDetail] AS TABLE (
    [LogisticId]      INT             NULL,
    [BarcodeId]       INT             NULL,
    [GoodId]          INT             NULL,
    [Quantity]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]  DECIMAL (26, 6) NULL,
    [AmountWholeSale] DECIMAL (26, 6) NULL,
    [Percent]         NVARCHAR (50)   NULL,
    [UnitId]          INT             NULL,
    [Description]     NVARCHAR (500)  NULL);


GO
PRINT N'Creating [Accounting].[UddtTransport]...';


GO
CREATE TYPE [Accounting].[UddtTransport] AS TABLE (
    [Id]                 INT             NOT NULL,
    [StoGoodId]          INT             NULL,
    [CompanyName]        NVARCHAR (200)  NULL,
    [CustomerName]       NVARCHAR (200)  NULL,
    [BarcodeId]          INT             NULL,
    [AccountId]          INT             NULL,
    [GoodId]             INT             NULL,
    [Series]             NVARCHAR (200)  NULL,
    [DateOfProduction]   DATETIME        NULL,
    [LastExpirationDate] DATETIME        NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [UnitId]             INT             NULL,
    [PriceBuy]           DECIMAL (26, 6) NULL,
    [PriceRetail]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]     DECIMAL (26, 6) NULL,
    [AmountBuy]          DECIMAL (26, 6) NULL,
    [AmountRetail]       DECIMAL (26, 6) NULL,
    [AmountWholeSale]    DECIMAL (26, 6) NULL,
    [Payment]            DECIMAL (26, 6) NULL,
    [Deficit]            DECIMAL (26, 6) NULL,
    [Percent]            NVARCHAR (50)   NULL);


GO
PRINT N'Creating [Accounting].[UddtContractCustomer]...';


GO
CREATE TYPE [Accounting].[UddtContractCustomer] AS TABLE (
    [Id]              INT            NOT NULL,
    [CustomerId]      INT            NULL,
    [ContractDate]    DATETIME       NULL,
    [CurrencyId]      INT            NULL,
    [OperationTypeId] INT            NULL,
    [CompanyId]       INT            NULL,
    [ContractTypeId]  INT            NULL,
    [Description]     NVARCHAR (500) NULL);


GO
PRINT N'Creating [dbo].[UddtCashPermission]...';


GO
CREATE TYPE [dbo].[UddtCashPermission] AS TABLE (
    [Allow]         BIT NULL,
    [CashId]        INT NULL,
    [ReserveMenuId] INT NULL);


GO
PRINT N'Creating [dbo].[UddtSetPermissions]...';


GO
CREATE TYPE [dbo].[UddtSetPermissions] AS TABLE (
    [Id]                 INT NULL,
    [AllowShow]          BIT NULL,
    [AllowCreate]        BIT NULL,
    [AllowUpdate]        BIT NULL,
    [AllowDelete]        BIT NULL,
    [AllowInContainer]   BIT NULL,
    [AllowRetail]        BIT NULL,
    [AllowApplyDocument] BIT NULL,
    [ShowCreate]         BIT NULL,
    [ShowUpdate]         BIT NULL,
    [ShowDelete]         BIT NULL,
    [ShowApplyDocument]  BIT NULL);


GO
PRINT N'Creating [dbo].[UddtWareHousePermission]...';


GO
CREATE TYPE [dbo].[UddtWareHousePermission] AS TABLE (
    [Allow]         BIT NULL,
    [WareHouseId]   INT NULL,
    [ReserveMenuId] INT NULL);


GO
PRINT N'Creating [Accounting].[Account]...';


GO
CREATE TABLE [Accounting].[Account] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ParentId]    INT            NULL,
    [Code]        VARCHAR (40)   NOT NULL,
    [Name]        NVARCHAR (200) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    [CreateDate]  DATETIME       NOT NULL,
    CONSTRAINT [PKAccount] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UIAccountCode] UNIQUE NONCLUSTERED ([Code] ASC)
);


GO
PRINT N'Creating [Accounting].[GoodType]...';


GO
CREATE TABLE [Accounting].[GoodType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefGoodType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Good]...';


GO
CREATE TABLE [Accounting].[Good] (
    [Id]                    INT             IDENTITY (1, 1) NOT NULL,
    [BarcodeId]             BIGINT          NULL,
    [DocumentDetailId]      INT             NULL,
    [GoodName]              NVARCHAR (200)  NULL,
    [GoodTypeId]            INT             NULL,
    [ManufacturerCompanyId] INT             NULL,
    [RegionId]              INT             NULL,
    [UnitId]                INT             NULL,
    [DoseId]                INT             NULL,
    [PackingTypeId]         INT             NULL,
    [Description]           NVARCHAR (500)  NULL,
    [GoodCode]              NVARCHAR (500)  NULL,
    [Photo]                 VARBINARY (MAX) NULL,
    [CreateId]              INT             NULL,
    [CreateDate]            DATETIME        NULL,
    [ModifyId]              INT             NULL,
    [ModifyDate]            DATETIME        NULL,
    [DeleteId]              INT             NULL,
    [DeleteDate]            DATETIME        NULL,
    [DocTypeId]             INT             NULL,
    [DocCertId]             INT             NULL,
    [DocSeriesId]           INT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[CurrencyHistory]...';


GO
CREATE TABLE [Accounting].[CurrencyHistory] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (100)  NOT NULL,
    [Description]  NVARCHAR (500)  NULL,
    [Buy]          DECIMAL (26, 6) NULL,
    [Sell]         DECIMAL (26, 6) NULL,
    [RefreshDate]  DATETIME        NULL,
    [CreateDate]   DATETIME        NOT NULL,
    [CreateUserId] INT             NOT NULL,
    CONSTRAINT [PKCurrencyHistory] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Currency]...';


GO
CREATE TABLE [Accounting].[Currency] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (100)  NOT NULL,
    [Buy]          DECIMAL (26, 6) NULL,
    [Sell]         DECIMAL (26, 6) NULL,
    [RefreshDate]  DATETIME        NULL,
    [Description]  NVARCHAR (500)  NULL,
    [IsActive]     BIT             NULL,
    [CreateDate]   DATETIME        NULL,
    [CreateUserId] INT             NULL,
    CONSTRAINT [PKCurrency] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Company]...';


GO
CREATE TABLE [Accounting].[Company] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [TypeId]         INT            NOT NULL,
    [ParentId]       INT            NULL,
    [PrivateNumber]  NVARCHAR (200) NULL,
    [CompanyName]    NVARCHAR (200) NULL,
    [CompanyLeader]  NVARCHAR (200) NULL,
    [RegionId]       INT            NULL,
    [WorkTypeId]     INT            NULL,
    [Voen]           NVARCHAR (50)  NULL,
    [CurrencyId]     INT            NULL,
    [BankId]         INT            NULL,
    [BankSwift]      NVARCHAR (200) NULL,
    [LegalAddress]   NVARCHAR (200) NULL,
    [ActualAddress]  NVARCHAR (200) NULL,
    [Email]          NVARCHAR (200) NULL,
    [Tel]            NVARCHAR (200) NULL,
    [ContractNumber] NVARCHAR (200) NULL,
    [ContractDate]   DATETIME       NULL,
    [Date]           DATETIME       NULL,
    [Description]    NVARCHAR (500) NULL,
    [CreateId]       INT            NULL,
    [CreateDate]     DATETIME       NULL,
    [UpdateId]       INT            NULL,
    [UpdateDate]     DATETIME       NULL,
    [DeleteId]       INT            NULL,
    [DeleteDate]     DATETIME       NULL,
    [DocTypeId]      INT            NULL,
    [DocCertId]      INT            NULL,
    [DocSeriesId]    INT            NULL,
    CONSTRAINT [PKCompany] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[BankGroup]...';


GO
CREATE TABLE [Accounting].[BankGroup] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKBankGroup] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Bank]...';


GO
CREATE TABLE [Accounting].[Bank] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [GroupId]     INT            NULL,
    [Name]        NVARCHAR (200) NOT NULL,
    [Swift]       NVARCHAR (200) NULL,
    [Voen]        VARCHAR (70)   NULL,
    [CurrencyId]  INT            NULL,
    [RegionId]    INT            NULL,
    [CreateId]    INT            NULL,
    [CreateDate]  DATETIME       NOT NULL,
    [UpdateId]    INT            NULL,
    [UpdateDate]  DATETIME       NULL,
    [DeleteId]    INT            NULL,
    [DeleteDate]  DATETIME       NULL,
    [ReadOnly]    DATETIME       NULL,
    [DocTypeId]   INT            NULL,
    [DocCertId]   INT            NULL,
    [DocSeriesId] INT            NULL,
    CONSTRAINT [PKBank] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[DocumentDetail]...';


GO
CREATE TABLE [Accounting].[DocumentDetail] (
    [Id]                    INT             IDENTITY (1, 1) NOT NULL,
    [TotalId]               INT             NULL,
    [PaymentId]             INT             NULL,
    [BarcodeId]             INT             NULL,
    [DocumentId]            INT             NULL,
    [AccountId]             INT             NULL,
    [GoodId]                INT             NULL,
    [Series]                NVARCHAR (200)  NULL,
    [DateOfProduction]      DATETIME        NULL,
    [LastExpirationDate]    DATETIME        NULL,
    [Quantity]              DECIMAL (26, 6) NULL,
    [StoQuantity]           DECIMAL (26, 6) NULL,
    [UnitId]                INT             NULL,
    [PriceBuy]              DECIMAL (26, 6) NULL,
    [PriceRetail]           DECIMAL (26, 6) NULL,
    [PriceWholeSale]        DECIMAL (26, 6) NULL,
    [AmountBuy]             DECIMAL (26, 6) NULL,
    [AmountRetail]          DECIMAL (26, 6) NULL,
    [AmountWholeSale]       DECIMAL (26, 6) NULL,
    [Payment]               DECIMAL (26, 6) NULL,
    [Deficit]               DECIMAL (26, 6) NULL,
    [Description]           NVARCHAR (500)  NULL,
    [Percent]               NVARCHAR (50)   NULL,
    [DiscountNumber]        NVARCHAR (500)  NULL,
    [DiscountNumberDeficit] DECIMAL (26, 6) NULL,
    [CostInclude]           DECIMAL (26, 6) NULL,
    [CostDeficit]           DECIMAL (26, 6) NULL,
    [DiscountPrice]         DECIMAL (26, 6) NULL,
    [IsActive]              BIT             NOT NULL,
    [SaleNo]                INT             NULL,
    [CreateId]              INT             NULL,
    [CreateDate]            DATETIME        NULL,
    [UpdateId]              INT             NULL,
    [UpdateDate]            DATETIME        NULL,
    [DeleteId]              INT             NULL,
    [DeleteDate]            DATETIME        NULL,
    [ReadOnly]              DATETIME        NULL,
    CONSTRAINT [PKDocumentDetail] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Document]...';


GO
CREATE TABLE [Accounting].[Document] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [AccountId]       INT             NULL,
    [IncludeDate]     DATETIME        NULL,
    [CompanyId]       INT             NULL,
    [SaleNo]          INT             NULL,
    [ContractId]      INT             NULL,
    [WareHouseId]     INT             NULL,
    [FromWarehouseId] INT             NULL,
    [PaymentTypeId]   INT             NULL,
    [Description]     NVARCHAR (500)  NULL,
    [ReasonId]        INT             NULL,
    [PaymentDate]     DATETIME        NULL,
    [PartnerOrderNo]  NVARCHAR (200)  NULL,
    [AdditionalCost]  DECIMAL (26, 6) NULL,
    [MainNumber]      INT             NULL,
    [CashierId]       INT             NULL,
    [CreateId]        INT             NULL,
    [CreateDate]      DATETIME        NULL,
    [UpdateId]        INT             NULL,
    [UpdateDate]      DATETIME        NULL,
    [DeleteId]        INT             NULL,
    [DeleteDate]      DATETIME        NULL,
    [LockId]          INT             NULL,
    [LockDate]        DATETIME        NULL,
    [ReadOnly]        DATETIME        NULL,
    [DocTypeId]       INT             NULL,
    [DocCertId]       INT             NULL,
    [DocSeriesId]     INT             NULL,
    [IsFiltered]      BIT             NULL,
    CONSTRAINT [PKDocument] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Contract]...';


GO
CREATE TABLE [Accounting].[Contract] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [CustomerId]      INT            NULL,
    [ContractDate]    DATETIME       NULL,
    [CurrencyId]      INT            NULL,
    [OperationTypeId] INT            NULL,
    [CompanyId]       INT            NULL,
    [ContractTypeId]  INT            NULL,
    [Description]     NVARCHAR (500) NULL,
    [IsActive]        BIT            NULL,
    [CreateId]        INT            NULL,
    [CreateDate]      DATETIME       NULL,
    [UpdateId]        INT            NULL,
    [UpdateDate]      DATETIME       NULL,
    [DeleteId]        INT            NULL,
    [DeleteDate]      DATETIME       NULL,
    [ReadOnly]        DATETIME       NULL,
    [DocTypeId]       INT            NULL,
    [DocCertId]       INT            NULL,
    [DocSeriesId]     INT            NULL,
    CONSTRAINT [PKRefContract] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UqCustomerContract] UNIQUE NONCLUSTERED ([CompanyId] ASC, [CustomerId] ASC, [ContractTypeId] ASC)
);


GO
PRINT N'Creating [Accounting].[Customer]...';


GO
CREATE TABLE [Accounting].[Customer] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [TypeId]         INT            NOT NULL,
    [ParentId]       INT            NULL,
    [CustomerName]   NVARCHAR (200) NULL,
    [CustomerLeader] NVARCHAR (200) NULL,
    [WorkTypeId]     INT            NULL,
    [Voen]           NVARCHAR (50)  NULL,
    [CurrencyId]     INT            NULL,
    [BankId]         INT            NULL,
    [BankSwift]      NVARCHAR (200) NULL,
    [RegionId]       INT            NULL,
    [LegalAddress]   NVARCHAR (200) NULL,
    [ActualAddress]  NVARCHAR (200) NULL,
    [Email]          NVARCHAR (200) NULL,
    [Tel]            NVARCHAR (200) NULL,
    [Date]           DATETIME       NULL,
    [Description]    NVARCHAR (500) NULL,
    [CreateId]       INT            NULL,
    [CreateDate]     DATETIME       NULL,
    [UpdateId]       INT            NULL,
    [UpdateDate]     DATETIME       NULL,
    [DeleteId]       INT            NULL,
    [DeleteDate]     DATETIME       NULL,
    [ReadOnly]       DATETIME       NULL,
    [DocTypeId]      INT            NULL,
    [DocCertId]      INT            NULL,
    [DocSeriesId]    INT            NULL,
    CONSTRAINT [PKCustomer] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[ContractType]...';


GO
CREATE TABLE [Accounting].[ContractType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefContractType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Stock]...';


GO
CREATE TABLE [Accounting].[Stock] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [GoodId]         INT             NULL,
    [CreatId]        INT             NULL,
    [WarehouseId]    INT             NULL,
    [DocumentId]     INT             NULL,
    [Series]         NVARCHAR (50)   NULL,
    [Quantity]       DECIMAL (25, 5) NULL,
    [PriceBuy]       DECIMAL (26, 6) NULL,
    [PrcieRetail]    DECIMAL (26, 6) NULL,
    [PriceWholeSale] DECIMAL (26, 6) NULL,
    [CreateDate]     DATETIME        NULL,
    [UpdateDate]     DATETIME        NULL,
    [UpdateId]       INT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Barcode]...';


GO
CREATE TABLE [Accounting].[Barcode] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [GoodId]     INT           NULL,
    [Barcode]    VARCHAR (200) NULL,
    [CreateId]   INT           NULL,
    [CreateDate] DATETIME      NOT NULL,
    [UpdateId]   INT           NULL,
    [UpdateDate] DATETIME      NULL,
    [DeleteId]   INT           NULL,
    [DeleteDate] DATETIME      NULL,
    CONSTRAINT [PKBarcode] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[PaymentType]...';


GO
CREATE TABLE [Accounting].[PaymentType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefPaymentType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[DocumentTmp]...';


GO
CREATE TABLE [Accounting].[DocumentTmp] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [CompanyId]   INT             NULL,
    [ContractId]  INT             NULL,
    [WareHouseId] INT             NULL,
    [BarcodeId]   INT             NULL,
    [GoodId]      INT             NOT NULL,
    [Quantity]    DECIMAL (18, 4) NOT NULL,
    [CreateId]    INT             NULL,
    [CreateDate]  DATETIME        NULL,
    [UpdateId]    INT             NULL,
    [UpdateDate]  DATETIME        NULL,
    [DeleteId]    INT             NULL,
    [DeleteDate]  DATETIME        NULL,
    [ReadOnly]    DATETIME        NULL,
    [DocTypeId]   INT             NULL,
    [DocCertId]   INT             NULL,
    [DocSeriesId] INT             NULL,
    CONSTRAINT [PKDocumentTmp] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[RetailSaleTmp]...';


GO
CREATE TABLE [Accounting].[RetailSaleTmp] (
    [Id]                  INT             IDENTITY (1, 1) NOT NULL,
    [BarcodeId]           INT             NULL,
    [DocumentDetailTmpId] INT             NULL,
    [AccountId]           INT             NULL,
    [GoodId]              INT             NULL,
    [Quantity]            DECIMAL (26, 6) NULL,
    [PriceRetail]         DECIMAL (26, 6) NULL,
    [PriceBuy]            DECIMAL (26, 6) NULL,
    [PriceWholeSale]      DECIMAL (26, 6) NULL,
    [CreateId]            INT             NULL,
    [CreateDate]          DATETIME        NULL,
    [UpdateId]            INT             NULL,
    [UpdateDate]          DATETIME        NULL,
    [DeleteId]            INT             NULL,
    [DeleteDate]          DATETIME        NULL,
    [ReadOnly]            DATETIME        NULL,
    [DocTypeId]           INT             NULL,
    [DocCertId]           INT             NULL,
    [DocSeriesId]         INT             NULL,
    CONSTRAINT [PKRetailSaleTmp] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[DocumentDetailTmp]...';


GO
CREATE TABLE [Accounting].[DocumentDetailTmp] (
    [Id]                 INT             IDENTITY (1, 1) NOT NULL,
    [BarcodeId]          INT             NULL,
    [DocumentTmpId]      INT             NULL,
    [AccountId]          INT             NULL,
    [GoodId]             INT             NULL,
    [Series]             NVARCHAR (200)  NULL,
    [DateOfProduction]   DATETIME        NULL,
    [LastExpirationDate] DATETIME        NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [UnitId]             INT             NULL,
    [PriceBuy]           DECIMAL (26, 6) NULL,
    [PriceRetail]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]     DECIMAL (26, 6) NULL,
    [AmountBuy]          DECIMAL (26, 6) NULL,
    [AmountRetail]       DECIMAL (26, 6) NULL,
    [AmountWholeSale]    DECIMAL (26, 6) NULL,
    [IsActive]           BIT             NOT NULL,
    [CreateId]           INT             NULL,
    [CreateDate]         DATETIME        NULL,
    [UpdateId]           INT             NULL,
    [UpdateDate]         DATETIME        NULL,
    [DeleteId]           INT             NULL,
    [DeleteDate]         DATETIME        NULL,
    [ReadOnly]           DATETIME        NULL,
    [DocTypeId]          INT             NULL,
    [DocCertId]          INT             NULL,
    [DocSeriesId]        INT             NULL,
    CONSTRAINT [PKDocumentDetailTmp] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[AccountSummaryHistory]...';


GO
CREATE TABLE [Accounting].[AccountSummaryHistory] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [EntityId]     INT             NULL,
    [EntityTypeId] INT             NULL,
    [AccountCode]  VARCHAR (40)    NULL,
    [Balance]      DECIMAL (26, 6) NULL,
    [Current]      DECIMAL (26, 6) NULL,
    [DayCount]     INT             NULL,
    [DailyValue]   DECIMAL (26, 6) NULL,
    [Dt]           DECIMAL (26, 6) NULL,
    [Kt]           DECIMAL (26, 6) NULL,
    [SalaryDate]   DATE            NULL,
    [CreateId]     INT             NOT NULL,
    [CreateDate]   DATETIME        NULL,
    [UpdateId]     INT             NULL,
    [UpdateDate]   DATETIME        NULL,
    [DeleteId]     INT             NULL,
    [DeleteDate]   DATETIME        NULL,
    [LockId]       INT             NULL,
    [LockDate]     DATETIME        NULL,
    [ReadOnly]     DATETIME        NULL,
    [DocTypeId]    INT             NULL,
    [DocCertId]    INT             NULL,
    [DocSeriesId]  INT             NULL,
    [RowCreated]   DATETIME        NOT NULL,
    CONSTRAINT [PkAccountSummaryHistoryId] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[AccountSummary]...';


GO
CREATE TABLE [Accounting].[AccountSummary] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [EntityId]     INT             NULL,
    [EntityTypeId] INT             NULL,
    [AccountCode]  VARCHAR (40)    NULL,
    [Balance]      DECIMAL (26, 6) NULL,
    [Current]      DECIMAL (26, 6) NULL,
    [DayCount]     INT             NULL,
    [DailyValue]   DECIMAL (26, 6) NULL,
    [Dt]           DECIMAL (26, 6) NULL,
    [Kt]           DECIMAL (26, 6) NULL,
    [SalaryDate]   DATE            NULL,
    [CreateId]     INT             NOT NULL,
    [CreateDate]   DATETIME        NULL,
    [UpdateId]     INT             NULL,
    [UpdateDate]   DATETIME        NULL,
    [DeleteId]     INT             NULL,
    [DeleteDate]   DATETIME        NULL,
    [LockId]       INT             NULL,
    [LockDate]     DATETIME        NULL,
    [ReadOnly]     DATETIME        NULL,
    [DocTypeId]    INT             NULL,
    [DocCertId]    INT             NULL,
    [DocSeriesId]  INT             NULL,
    CONSTRAINT [PkAccountSummaryId] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[PaymentOrder]...';


GO
CREATE TABLE [Accounting].[PaymentOrder] (
    [Id]                  INT             IDENTITY (1, 1) NOT NULL,
    [Number]              INT             NOT NULL,
    [DocumentDate]        DATETIME        NOT NULL,
    [EmitentId]           INT             NOT NULL,
    [BenefisiarId]        INT             NOT NULL,
    [PayerId]             INT             NOT NULL,
    [PayeeId]             INT             NOT NULL,
    [OperationCurrencyId] INT             NULL,
    [OperationAmount]     DECIMAL (26, 6) NOT NULL,
    [AmountAZN]           DECIMAL (26, 6) NOT NULL,
    [Classification]      NVARCHAR (300)  NULL,
    [Description]         NVARCHAR (500)  NULL,
    [BudgetCode]          NVARCHAR (60)   NULL,
    [BudgetLevelCode]     NVARCHAR (60)   NULL,
    [AccountId]           INT             NULL,
    [CreateId]            INT             NOT NULL,
    [CreateDate]          DATETIME        NOT NULL,
    [UpdateId]            INT             NULL,
    [UpdateDate]          DATETIME        NULL,
    [DeleteId]            INT             NULL,
    [DeleteDate]          DATETIME        NULL,
    [LockId]              INT             NULL,
    [LockDate]            DATETIME        NULL,
    [ReadOnly]            DATETIME        NULL,
    [DocTypeId]           INT             NULL,
    [DocCertId]           INT             NULL,
    [DocSeriesId]         INT             NULL,
    CONSTRAINT [PKPaymentOrder] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[RetailSale]...';


GO
CREATE TABLE [Accounting].[RetailSale] (
    [Id]               INT             IDENTITY (1, 1) NOT NULL,
    [BarcodeId]        INT             NULL,
    [DocumentDetailId] INT             NULL,
    [AccountId]        INT             NULL,
    [GoodId]           INT             NULL,
    [Quantity]         DECIMAL (26, 6) NULL,
    [PriceRetail]      DECIMAL (26, 6) NULL,
    [PriceBuy]         DECIMAL (26, 6) NULL,
    [PriceWholeSale]   DECIMAL (26, 6) NULL,
    [Percent]          NVARCHAR (50)   NULL,
    [DiscountNumber]   NVARCHAR (50)   NULL,
    [WareHouseId]      INT             NULL,
    [CustomerId]       INT             NULL,
    [CreateId]         INT             NULL,
    [CreateDate]       DATETIME        NULL,
    [UpdateId]         INT             NULL,
    [UpdateDate]       DATETIME        NULL,
    [DeleteId]         INT             NULL,
    [DeleteDate]       DATETIME        NULL,
    [ReadOnly]         DATETIME        NULL,
    [DocTypeId]        INT             NULL,
    [DocCertId]        INT             NULL,
    [DocSeriesId]      INT             NULL,
    CONSTRAINT [PKRetailSale] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[CustomerDebt]...';


GO
CREATE TABLE [Accounting].[CustomerDebt] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [CustomerId] INT             NULL,
    [Deficit]    DECIMAL (26, 6) NULL,
    [UpdateDate] DATETIME        NULL,
    CONSTRAINT [PKCustomerDebt] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Payment]...';


GO
CREATE TABLE [Accounting].[Payment] (
    [Id]                  INT             IDENTITY (1, 1) NOT NULL,
    [CashId]              INT             NULL,
    [CashFromId]          INT             NULL,
    [ExpenseId]           INT             NULL,
    [AccountId]           INT             NULL,
    [CustomerId]          INT             NULL,
    [CustomerWareHouseId] INT             NULL,
    [DocumentId]          INT             NULL,
    [PaymentTypeId]       INT             NULL,
    [Payment]             DECIMAL (26, 6) NULL,
    [Deficit]             DECIMAL (26, 6) NULL,
    [Description]         NVARCHAR (500)  NULL,
    [Percent]             NVARCHAR (500)  NULL,
    [PaymentDate]         DATETIME        NULL,
    [CreateDate]          DATETIME        NULL,
    [DeleteId]            INT             NULL,
    [DeleteDate]          DATETIME        NULL,
    [UpdateId]            INT             NULL,
    [UpdateDate]          DATETIME        NULL,
    CONSTRAINT [PKPayment] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Reason]...';


GO
CREATE TABLE [Accounting].[Reason] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKReason] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[TotalReport]...';


GO
CREATE TABLE [Accounting].[TotalReport] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [TotalAmount] DECIMAL (26, 6) NULL,
    [TotalCost]   DECIMAL (26, 6) NULL,
    [TotalProfit] DECIMAL (26, 6) NULL,
    [IsActive]    BIT             NULL,
    [CreateDate]  DATETIME        NOT NULL
);


GO
PRINT N'Creating [Accounting].[InventarGood]...';


GO
CREATE TABLE [Accounting].[InventarGood] (
    [Id]                 INT             IDENTITY (1, 1) NOT NULL,
    [DocumentId]         INT             NULL,
    [DifferenceQuantity] DECIMAL (26, 6) NULL,
    [StockQuantity]      DECIMAL (26, 6) NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [IsActive]           BIT             NULL,
    [CreateId]           INT             NULL,
    [CreateDate]         DATETIME        NULL,
    [UpdateId]           INT             NULL,
    [UpdateDate]         DATETIME        NULL,
    [DeleteId]           INT             NULL,
    [DeleteDate]         DATETIME        NULL,
    [ReadOnly]           DATETIME        NULL,
    [DocTypeId]          INT             NULL,
    [DocCertId]          INT             NULL,
    [DocSeriesId]        INT             NULL,
    CONSTRAINT [PKInevntarGood] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[LastPrice]...';


GO
CREATE TABLE [Accounting].[LastPrice] (
    [Id]                 INT             IDENTITY (1, 1) NOT NULL,
    [StockId]            INT             NULL,
    [GoodId]             INT             NULL,
    [CreateId]           INT             NULL,
    [CreateDate]         DATETIME        NULL,
    [PriceBuy]           DECIMAL (25, 5) NULL,
    [PriceRetail]        DECIMAL (25, 5) NULL,
    [PriceWholeSale]     DECIMAL (25, 5) NULL,
    [LastPriceBuy]       DECIMAL (25, 5) NULL,
    [LastPriceRetail]    DECIMAL (25, 5) NULL,
    [LastPriceWholeSale] DECIMAL (25, 5) NULL,
    [Description]        NVARCHAR (500)  NULL
);


GO
PRINT N'Creating [Accounting].[PaymentRetail]...';


GO
CREATE TABLE [Accounting].[PaymentRetail] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [DocumentId]     INT             NULL,
    [CustomerId]     INT             NULL,
    [PaymentTypeId]  INT             NULL,
    [Payment]        DECIMAL (26, 6) NULL,
    [Deficit]        DECIMAL (26, 6) NULL,
    [TotalSum]       DECIMAL (26, 6) NULL,
    [Description]    NVARCHAR (500)  NULL,
    [Percent]        NVARCHAR (500)  NULL,
    [DiscountNumber] NVARCHAR (500)  NULL,
    [CreateId]       INT             NULL,
    [CreateDate]     DATETIME        NULL,
    CONSTRAINT [PKPaymentRetail] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Cost]...';


GO
CREATE TABLE [Accounting].[Cost] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [Person]        NVARCHAR (250)  NULL,
    [Place]         NVARCHAR (200)  NULL,
    [Amount]        DECIMAL (26, 6) NULL,
    [CostDate]      DATETIME        NULL,
    [PaymentTypeId] INT             NULL,
    [Description]   NVARCHAR (MAX)  NULL,
    [CreateId]      INT             NULL,
    [CreateDate]    DATETIME        NULL,
    [UpdateId]      INT             NULL,
    [UpdateDate]    DATETIME        NULL,
    [DeleteId]      INT             NULL,
    [DeleteDate]    DATETIME        NULL,
    CONSTRAINT [PKCost] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Inventar]...';


GO
CREATE TABLE [Accounting].[Inventar] (
    [Id]                 INT             IDENTITY (1, 1) NOT NULL,
    [DocumentInventarId] INT             NULL,
    [GoodId]             INT             NULL,
    [FullGoodName]       NVARCHAR (50)   NULL,
    [DifferenceQuantity] DECIMAL (26, 6) NULL,
    [StockQuantity]      DECIMAL (26, 6) NULL,
    [Quantity]           DECIMAL (26, 6) NULL,
    [WareHouseId]        INT             NULL,
    [CreateId]           INT             NULL,
    [CreateDate]         DATETIME        NULL,
    [UpdateId]           INT             NULL,
    [UpdateDate]         DATETIME        NULL,
    [DeleteId]           INT             NULL,
    [DeleteDate]         DATETIME        NULL,
    CONSTRAINT [PKInevntar] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[BarcodeGenerate]...';


GO
CREATE TABLE [Accounting].[BarcodeGenerate] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [BarcodeGen] VARCHAR (200) NULL,
    [CreateId]   INT           NULL,
    [CreateDate] DATETIME      NOT NULL,
    [UpdateId]   INT           NULL,
    [UpdateDate] DATETIME      NULL,
    [DeleteId]   INT           NULL,
    [DeleteDate] DATETIME      NULL,
    CONSTRAINT [PKBarcodeGenerate] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[ImagesGood]...';


GO
CREATE TABLE [Accounting].[ImagesGood] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [GoodId]     INT             NULL,
    [IsMain]     BIT             NULL,
    [Image]      VARBINARY (MAX) NULL,
    [CreateId]   INT             NULL,
    [CreateDate] DATETIME        NULL,
    [DeleteDate] DATETIME        NULL,
    [DeleteId]   INT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[ReceiptsStatus]...';


GO
CREATE TABLE [Accounting].[ReceiptsStatus] (
    [Id]          INT            NOT NULL,
    [StatusName]  NVARCHAR (200) NULL,
    [Description] NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[RetailReceipt]...';


GO
CREATE TABLE [Accounting].[RetailReceipt] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [GoodId]     INT             NULL,
    [BarcodeId]  INT             NULL,
    [Quantity]   DECIMAL (26, 6) NULL,
    [CreateId]   INT             NULL,
    [CreateDate] DATETIME        NULL,
    [StatusId]   INT             NULL,
    [InfoJson]   NVARCHAR (MAX)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Expense]...';


GO
CREATE TABLE [Accounting].[Expense] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ParentId]    INT            NULL,
    [Code]        VARCHAR (40)   NOT NULL,
    [ExpenseName] NVARCHAR (100) NULL,
    [Description] NVARCHAR (500) NULL,
    [CreateDate]  DATETIME       NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefExpense] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UIExpenseCode] UNIQUE NONCLUSTERED ([Code] ASC)
);


GO
PRINT N'Creating [Accounting].[Cash]...';


GO
CREATE TABLE [Accounting].[Cash] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [CompanyId]   INT             NOT NULL,
    [CashName]    NVARCHAR (100)  NOT NULL,
    [Balance]     DECIMAL (26, 6) NULL,
    [Description] NVARCHAR (500)  NULL,
    [CreateId]    INT             NULL,
    [CreateDate]  DATETIME        NULL,
    [IsActive]    BIT             NULL,
    CONSTRAINT [PKCash] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[OfflineSaleDetail]...';


GO
CREATE TABLE [Accounting].[OfflineSaleDetail] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [LogisticId]      INT             NULL,
    [BarcodeId]       INT             NULL,
    [GoodId]          INT             NULL,
    [Quantity]        DECIMAL (26, 6) NULL,
    [PriceWholeSale]  DECIMAL (26, 6) NULL,
    [AmountWholeSale] DECIMAL (26, 6) NULL,
    [Percent]         NVARCHAR (500)  NULL,
    [UnitId]          INT             NULL,
    [Description]     NVARCHAR (500)  NULL,
    [IsActive]        BIT             NOT NULL,
    [SaleNo]          INT             NULL,
    [CreateId]        INT             NULL,
    [CreateDate]      DATETIME        NULL,
    [UpdateId]        INT             NULL,
    [UpdateDate]      DATETIME        NULL,
    [DeleteId]        INT             NULL,
    [DeleteDate]      DATETIME        NULL,
    [ReadOnly]        DATETIME        NULL,
    CONSTRAINT [PKOfflineSaleDetail] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[OfflineSale]...';


GO
CREATE TABLE [Accounting].[OfflineSale] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Driver]          NVARCHAR (200) NULL,
    [Fin]             NVARCHAR (200) NULL,
    [CompanyId]       INT            NULL,
    [WareHouseId]     INT            NULL,
    [ContractId]      INT            NULL,
    [PaymentTypeId]   INT            NULL,
    [Transportation]  NVARCHAR (200) NULL,
    [Cart]            NVARCHAR (200) NULL,
    [Sender]          NVARCHAR (200) NULL,
    [SenderAddress]   NVARCHAR (200) NULL,
    [SenderManager]   NVARCHAR (200) NULL,
    [Received]        NVARCHAR (200) NULL,
    [ReceivedAddress] NVARCHAR (200) NULL,
    [ReceivedManager] NVARCHAR (200) NULL,
    [Date]            DATETIME       NULL,
    [DeliveryDate]    DATETIME       NULL,
    [Description]     NVARCHAR (500) NULL,
    [CreateId]        INT            NULL,
    [CreateDate]      DATETIME       NULL,
    [UpdateId]        INT            NULL,
    [UpdateDate]      DATETIME       NULL,
    [DeleteId]        INT            NULL,
    [DeleteDate]      DATETIME       NULL,
    [ReadOnly]        DATETIME       NULL,
    [DocTypeId]       INT            NULL,
    [DocCertId]       INT            NULL,
    [DocSeriesId]     INT            NULL,
    CONSTRAINT [PKOfflineSale] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[LogisticDetail]...';


GO
CREATE TABLE [Accounting].[LogisticDetail] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [LogisticId]  INT             NULL,
    [BarcodeId]   INT             NULL,
    [GoodId]      INT             NULL,
    [Quantity]    DECIMAL (26, 6) NULL,
    [UnitId]      INT             NULL,
    [Description] NVARCHAR (500)  NULL,
    [IsActive]    BIT             NOT NULL,
    [SaleNo]      INT             NULL,
    [CreateId]    INT             NULL,
    [CreateDate]  DATETIME        NULL,
    [UpdateId]    INT             NULL,
    [UpdateDate]  DATETIME        NULL,
    [DeleteId]    INT             NULL,
    [DeleteDate]  DATETIME        NULL,
    [ReadOnly]    DATETIME        NULL,
    CONSTRAINT [PKLogisticDetail] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Logistic]...';


GO
CREATE TABLE [Accounting].[Logistic] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Driver]          NVARCHAR (200) NULL,
    [Fin]             NVARCHAR (200) NULL,
    [CompanyId]       INT            NULL,
    [WareHouseId]     INT            NULL,
    [ContractId]      INT            NULL,
    [PaymentTypeId]   INT            NULL,
    [Transportation]  NVARCHAR (200) NULL,
    [Cart]            NVARCHAR (200) NULL,
    [Sender]          NVARCHAR (200) NULL,
    [SenderAddress]   NVARCHAR (200) NULL,
    [SenderManager]   NVARCHAR (200) NULL,
    [Received]        NVARCHAR (200) NULL,
    [ReceivedAddress] NVARCHAR (200) NULL,
    [ReceivedManager] NVARCHAR (200) NULL,
    [Date]            DATETIME       NULL,
    [DeliveryDate]    DATETIME       NULL,
    [Description]     NVARCHAR (500) NULL,
    [CreateId]        INT            NULL,
    [CreateDate]      DATETIME       NULL,
    [UpdateId]        INT            NULL,
    [UpdateDate]      DATETIME       NULL,
    [DeleteId]        INT            NULL,
    [DeleteDate]      DATETIME       NULL,
    [ReadOnly]        DATETIME       NULL,
    [DocTypeId]       INT            NULL,
    [DocCertId]       INT            NULL,
    [DocSeriesId]     INT            NULL,
    CONSTRAINT [PKLogistic] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[Cashier]...';


GO
CREATE TABLE [Accounting].[Cashier] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [CashierName] NVARCHAR (100) NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKCashier] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Accounting].[CashMoney]...';


GO
CREATE TABLE [Accounting].[CashMoney] (
    [Id]                  INT             IDENTITY (1, 1) NOT NULL,
    [CashId]              INT             NULL,
    [ExpenseId]           INT             NULL,
    [AccountId]           INT             NULL,
    [CustomerId]          INT             NULL,
    [CustomerWareHouseId] INT             NULL,
    [DocumentId]          INT             NULL,
    [PaymentTypeId]       INT             NULL,
    [Payment]             DECIMAL (26, 6) NULL,
    [Deficit]             DECIMAL (26, 6) NULL,
    [Description]         NVARCHAR (500)  NULL,
    [Percent]             NVARCHAR (500)  NULL,
    [CreateDate]          DATETIME        NULL,
    CONSTRAINT [PKCashMoney] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [Service].[ObjectDetail]...';


GO
CREATE TABLE [Service].[ObjectDetail] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [GoodName]    NVARCHAR (200)  NULL,
    [Price]       DECIMAL (26, 6) NULL,
    [Quantity]    DECIMAL (26, 6) NULL,
    [CreateId]    INT             NULL,
    [CreateDate]  DATETIME        NULL,
    [UpdateId]    INT             NULL,
    [UpdateDate]  DATETIME        NULL,
    [DeleteId]    INT             NULL,
    [DeleteDate]  DATETIME        NULL,
    [ReadOnly]    DATETIME        NULL,
    [DocTypeId]   INT             NULL,
    [DocCertId]   INT             NULL,
    [DocSeriesId] INT             NULL,
    [IsFiltered]  BIT             NULL,
    CONSTRAINT [PKObjectDetail] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [WareHouses].[WareHouse]...';


GO
CREATE TABLE [WareHouses].[WareHouse] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [CompanyId]       INT            NOT NULL,
    [Name]            NVARCHAR (100) NOT NULL,
    [WareHouseTypeId] INT            NOT NULL,
    [Description]     NVARCHAR (500) NULL,
    [IsActive]        BIT            NULL,
    CONSTRAINT [PKRefWareHouse] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [WareHouses].[WareHouseType]...';


GO
CREATE TABLE [WareHouses].[WareHouseType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefWareHouseType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[CashMenuCollection]...';


GO
CREATE TABLE [dbo].[CashMenuCollection] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [UserId] INT NOT NULL,
    [CashId] INT NOT NULL,
    [MenuId] INT NOT NULL,
    [Allow]  BIT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Citizenship]...';


GO
CREATE TABLE [dbo].[Citizenship] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefCitizenship] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[City]...';


GO
CREATE TABLE [dbo].[City] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefCity] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Company]...';


GO
CREATE TABLE [dbo].[Company] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefCompany] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[CompanyType]...';


GO
CREATE TABLE [dbo].[CompanyType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (200) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    [CreateDate]  DATETIME       NOT NULL,
    CONSTRAINT [PKCompanyType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[ContactType]...';


GO
CREATE TABLE [dbo].[ContactType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefContactType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[ContractStatus]...';


GO
CREATE TABLE [dbo].[ContractStatus] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefContractStatus] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Country]...';


GO
CREATE TABLE [dbo].[Country] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Code]        INT            NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefCountry] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Department]...';


GO
CREATE TABLE [dbo].[Department] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefDepartment] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[District]...';


GO
CREATE TABLE [dbo].[District] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [CityId]      INT            NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefDistrict] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[DocCert]...';


GO
CREATE TABLE [dbo].[DocCert] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefDocCert] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[DocSeries]...';


GO
CREATE TABLE [dbo].[DocSeries] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefDocSeries] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[DocType]...';


GO
CREATE TABLE [dbo].[DocType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefDocType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[DocumentInventar]...';


GO
CREATE TABLE [dbo].[DocumentInventar] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [WareHouseId] INT      NULL,
    [CreateId]    INT      NULL,
    [CreateDate]  DATETIME NULL,
    [UpdateId]    INT      NULL,
    [UpdateDate]  DATETIME NULL,
    [DeleteId]    INT      NULL,
    [DeleteDate]  DATETIME NULL,
    CONSTRAINT [PKDocumentInevntar] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Dose]...';


GO
CREATE TABLE [dbo].[Dose] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (40)  NOT NULL,
    [Description] NVARCHAR (200) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefDose] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[EducationInstitute]...';


GO
CREATE TABLE [dbo].[EducationInstitute] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefEducationInstitute] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[EducationLevel]...';


GO
CREATE TABLE [dbo].[EducationLevel] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefEducationLevel] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[EducationType]...';


GO
CREATE TABLE [dbo].[EducationType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefEducationType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Gender]...';


GO
CREATE TABLE [dbo].[Gender] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (20) NULL,
    CONSTRAINT [PKRefGender] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[KnowledgeLevel]...';


GO
CREATE TABLE [dbo].[KnowledgeLevel] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefKnowledgeLevel] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Language]...';


GO
CREATE TABLE [dbo].[Language] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefLanguage] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[MartialStatus]...';


GO
CREATE TABLE [dbo].[MartialStatus] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefMartialStatus] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[MemberGroupPool]...';


GO
CREATE TABLE [dbo].[MemberGroupPool] (
    [GroupId]  INT NULL,
    [MemberId] INT NULL,
    CONSTRAINT [PkMemberGroupPoolId] UNIQUE NONCLUSTERED ([GroupId] ASC, [MemberId] ASC)
);


GO
PRINT N'Creating [dbo].[Menu]...';


GO
CREATE TABLE [dbo].[Menu] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ParentId]    INT            NULL,
    [Code]        VARCHAR (6)    NULL,
    [Caption]     NVARCHAR (200) NOT NULL,
    [TypePath]    VARCHAR (200)  NULL,
    [Parameters]  VARCHAR (200)  NULL,
    [AllowNotify] BIT            NULL,
    [IconId]      INT            NULL,
    [OrderNumber] INT            NULL,
    CONSTRAINT [PkMenuId] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[MenuUserAccess]...';


GO
CREATE TABLE [dbo].[MenuUserAccess] (
    [MenuItemId]        BIGINT NOT NULL,
    [UserId]            BIGINT NOT NULL,
    [Show]              BIT    NULL,
    [Create]            BIT    NULL,
    [Update]            BIT    NULL,
    [Delete]            BIT    NULL,
    [ApplyDocument]     BIT    NULL,
    [AllowInContainer]  BIT    NULL,
    [AllowRetail]       BIT    NULL,
    [ShowCreate]        BIT    NULL,
    [ShowUpdate]        BIT    NULL,
    [ShowDelete]        BIT    NULL,
    [ShowApplyDocument] BIT    NULL
);


GO
PRINT N'Creating [dbo].[MilitaryStatus]...';


GO
CREATE TABLE [dbo].[MilitaryStatus] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefMilitaryStatus] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[OperationType]...';


GO
CREATE TABLE [dbo].[OperationType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (40)  NOT NULL,
    [Description] NVARCHAR (200) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefOperationType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[PackingType]...';


GO
CREATE TABLE [dbo].[PackingType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (40)  NOT NULL,
    [Description] NVARCHAR (200) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefPackingType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Plugin]...';


GO
CREATE TABLE [dbo].[Plugin] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [PlugName]    NVARCHAR (200)  NOT NULL,
    [Version]     NVARCHAR (50)   NOT NULL,
    [Plug]        VARBINARY (MAX) NOT NULL,
    [Description] NVARCHAR (200)  NOT NULL,
    [ModifyDate]  DATETIME        NOT NULL,
    [ModifyUser]  NVARCHAR (200)  NOT NULL,
    CONSTRAINT [PKRefPlugin] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Position]...';


GO
CREATE TABLE [dbo].[Position] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefPosition] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Principial]...';


GO
CREATE TABLE [dbo].[Principial] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (200) NOT NULL,
    [Password]  VARCHAR (128) NULL,
    [PersonId]  INT           NULL,
    [GroupId]   INT           NULL,
    [IsGroup]   BIT           NULL,
    [IsMember]  BIT           NULL,
    [IsDisable] BIT           NULL,
    [Created]   DATETIME      NOT NULL,
    CONSTRAINT [PkPrincipialId] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Region]...';


GO
CREATE TABLE [dbo].[Region] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [ParentId]     INT            NULL,
    [Name]         NVARCHAR (100) NOT NULL,
    [RegionTypeId] INT            NULL,
    [Description]  NVARCHAR (500) NULL,
    [IsActive]     BIT            NULL,
    CONSTRAINT [PKRefRegion] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[RegionType]...';


GO
CREATE TABLE [dbo].[RegionType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefRegionType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Role]...';


GO
CREATE TABLE [dbo].[Role] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ParentId]    INT            NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [RoleTypeId]  INT            NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRole] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[RoleType]...';


GO
CREATE TABLE [dbo].[RoleType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefRoleType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[SubUnit]...';


GO
CREATE TABLE [dbo].[SubUnit] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (200) NULL,
    [GoodTypeId]  INT            NULL,
    [UnitId]      INT            NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKSubUnit] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Transport]...';


GO
CREATE TABLE [dbo].[Transport] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [GoodId]         INT             NULL,
    [BarcodeId]      INT             NULL,
    [Quantity]       DECIMAL (26, 6) NULL,
    [PriceBuy]       DECIMAL (26, 6) NULL,
    [PriceRetail]    DECIMAL (26, 6) NULL,
    [PriceWholeSale] DECIMAL (26, 6) NULL,
    [WareHouseId]    INT             NULL,
    [CreateId]       INT             NULL,
    [CreateDate]     DATETIME        NULL,
    [UpdateId]       INT             NULL,
    [UpdateDate]     DATETIME        NULL,
    [DeleteId]       INT             NULL,
    [DeleteDate]     DATETIME        NULL,
    CONSTRAINT [PKTransport] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Unit]...';


GO
CREATE TABLE [dbo].[Unit] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (40)  NOT NULL,
    [Description] NVARCHAR (200) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefUnit] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[User]...';


GO
CREATE TABLE [dbo].[User] (
    [Id]             BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserName]       NVARCHAR (50)  NULL,
    [UserSurname]    NVARCHAR (50)  NULL,
    [UserPatryonmic] NVARCHAR (50)  NULL,
    [Pin]            NVARCHAR (50)  NULL,
    [RoleId]         INT            NULL,
    [Login]          NVARCHAR (100) NULL,
    [Password]       NVARCHAR (128) NULL,
    [BirthOfDate]    DATETIME       NULL,
    [RegionId]       INT            NULL,
    [Address]        NVARCHAR (200) NULL,
    [Description]    NVARCHAR (500) NULL,
    [IsActive]       BIT            NULL,
    [CreatedDate]    DATETIME       NOT NULL,
    [CreatedUser]    INT            NULL,
    [UpdatedDate]    DATETIME       NULL,
    [UpdatedUser]    INT            NULL,
    [DeletedDate]    DATETIME       NULL,
    [DeletedUser]    INT            NULL,
    [LastLogIn]      DATETIME       NULL,
    [LastLogOut]     DATETIME       NULL,
    CONSTRAINT [PKRefUser] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[UserRegistration]...';


GO
CREATE TABLE [dbo].[UserRegistration] (
    [Id]            INT            NOT NULL,
    [Name]          NVARCHAR (200) NULL,
    [Surname]       NVARCHAR (200) NULL,
    [Patronymic]    NVARCHAR (200) NULL,
    [BirthOfDate]   DATE           NULL,
    [CitizenshipId] INT            NULL,
    [RegionId]      INT            NULL,
    [Address]       NVARCHAR (200) NULL,
    [Description]   NVARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[WarehouseMenuCollection]...';


GO
CREATE TABLE [dbo].[WarehouseMenuCollection] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [UserId]      INT NOT NULL,
    [WareHouseId] INT NOT NULL,
    [MenuId]      INT NOT NULL,
    [Allow]       BIT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[WorkGraphic]...';


GO
CREATE TABLE [dbo].[WorkGraphic] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefWorkGraphic] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[WorkPlace]...';


GO
CREATE TABLE [dbo].[WorkPlace] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefWorkPlace] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[WorkType]...';


GO
CREATE TABLE [dbo].[WorkType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (500) NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PKRefWorkType] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [Accounting].[Account]...';


GO
ALTER TABLE [Accounting].[Account]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Good]...';


GO
ALTER TABLE [Accounting].[Good]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[CurrencyHistory]...';


GO
ALTER TABLE [Accounting].[CurrencyHistory]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Currency]...';


GO
ALTER TABLE [Accounting].[Currency]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Company]...';


GO
ALTER TABLE [Accounting].[Company]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Bank]...';


GO
ALTER TABLE [Accounting].[Bank]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[DocumentDetail]...';


GO
ALTER TABLE [Accounting].[DocumentDetail]
    ADD DEFAULT 1 FOR [IsActive];


GO
PRINT N'Creating unnamed constraint on [Accounting].[DocumentDetail]...';


GO
ALTER TABLE [Accounting].[DocumentDetail]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Document]...';


GO
ALTER TABLE [Accounting].[Document]
    ADD DEFAULT getdate() FOR [IncludeDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Document]...';


GO
ALTER TABLE [Accounting].[Document]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Contract]...';


GO
ALTER TABLE [Accounting].[Contract]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Customer]...';


GO
ALTER TABLE [Accounting].[Customer]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Barcode]...';


GO
ALTER TABLE [Accounting].[Barcode]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[DocumentTmp]...';


GO
ALTER TABLE [Accounting].[DocumentTmp]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[RetailSaleTmp]...';


GO
ALTER TABLE [Accounting].[RetailSaleTmp]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[DocumentDetailTmp]...';


GO
ALTER TABLE [Accounting].[DocumentDetailTmp]
    ADD DEFAULT 1 FOR [IsActive];


GO
PRINT N'Creating unnamed constraint on [Accounting].[DocumentDetailTmp]...';


GO
ALTER TABLE [Accounting].[DocumentDetailTmp]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[AccountSummaryHistory]...';


GO
ALTER TABLE [Accounting].[AccountSummaryHistory]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[AccountSummaryHistory]...';


GO
ALTER TABLE [Accounting].[AccountSummaryHistory]
    ADD DEFAULT getdate() FOR [RowCreated];


GO
PRINT N'Creating unnamed constraint on [Accounting].[AccountSummary]...';


GO
ALTER TABLE [Accounting].[AccountSummary]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[PaymentOrder]...';


GO
ALTER TABLE [Accounting].[PaymentOrder]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[RetailSale]...';


GO
ALTER TABLE [Accounting].[RetailSale]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[CustomerDebt]...';


GO
ALTER TABLE [Accounting].[CustomerDebt]
    ADD DEFAULT getdate() FOR [UpdateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Payment]...';


GO
ALTER TABLE [Accounting].[Payment]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Payment]...';


GO
ALTER TABLE [Accounting].[Payment]
    ADD DEFAULT getdate() FOR [DeleteDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[TotalReport]...';


GO
ALTER TABLE [Accounting].[TotalReport]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[PaymentRetail]...';


GO
ALTER TABLE [Accounting].[PaymentRetail]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Cost]...';


GO
ALTER TABLE [Accounting].[Cost]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[BarcodeGenerate]...';


GO
ALTER TABLE [Accounting].[BarcodeGenerate]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Expense]...';


GO
ALTER TABLE [Accounting].[Expense]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Cash]...';


GO
ALTER TABLE [Accounting].[Cash]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[OfflineSaleDetail]...';


GO
ALTER TABLE [Accounting].[OfflineSaleDetail]
    ADD DEFAULT 1 FOR [IsActive];


GO
PRINT N'Creating unnamed constraint on [Accounting].[OfflineSaleDetail]...';


GO
ALTER TABLE [Accounting].[OfflineSaleDetail]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[OfflineSale]...';


GO
ALTER TABLE [Accounting].[OfflineSale]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[LogisticDetail]...';


GO
ALTER TABLE [Accounting].[LogisticDetail]
    ADD DEFAULT 1 FOR [IsActive];


GO
PRINT N'Creating unnamed constraint on [Accounting].[LogisticDetail]...';


GO
ALTER TABLE [Accounting].[LogisticDetail]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[Logistic]...';


GO
ALTER TABLE [Accounting].[Logistic]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Accounting].[CashMoney]...';


GO
ALTER TABLE [Accounting].[CashMoney]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [Service].[ObjectDetail]...';


GO
ALTER TABLE [Service].[ObjectDetail]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [dbo].[CompanyType]...';


GO
ALTER TABLE [dbo].[CompanyType]
    ADD DEFAULT getdate() FOR [CreateDate];


GO
PRINT N'Creating unnamed constraint on [dbo].[Principial]...';


GO
ALTER TABLE [dbo].[Principial]
    ADD DEFAULT (getdate()) FOR [Created];


GO
PRINT N'Creating unnamed constraint on [dbo].[User]...';


GO
ALTER TABLE [dbo].[User]
    ADD DEFAULT getdate() FOR [CreatedDate];


GO
PRINT N'Creating [Accounting].[trgUpdateCurrency]...';


GO

CREATE TRIGGER [Accounting].[trgUpdateCurrency]
    ON [Accounting].[Currency]
    FOR UPDATE
    AS
    BEGIN
        SET NoCount ON;
		insert into [Accounting].[CurrencyHistory]([Name],[Sell],[Buy],[CreateUserId],[RefreshDate])
		select [Name],[Sell],[Buy],[CreateUserId],[RefreshDate] from deleted d
    END
GO
PRINT N'Creating [Accounting].[TrAccountSummaryOnDelete]...';


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
GO
PRINT N'Creating [Accounting].[VwGoodTypeChoose]...';


GO
CREATE VIEW [Accounting].[VwGoodTypeChoose]
with encryption
	AS SELECT Id,[Name] FROM [Accounting].[GoodType] where nullif(IsActive,1) is null
GO
PRINT N'Creating [Accounting].[VwGoodType]...';


GO
CREATE VIEW [Accounting].[VwGoodType]
with encryption
	AS SELECT * FROM [Accounting].[GoodType]
GO
PRINT N'Creating [Accounting].[VwCurrencyChoose]...';


GO
CREATE VIEW [Accounting].[VwCurrencyChoose]
with encryption
	AS SELECT Id,[Name] FROM [Accounting].[Currency] where nullif(IsActive,1) is null
GO
PRINT N'Creating [Accounting].[VwCurrency]...';


GO
CREATE VIEW [Accounting].[VwCurrency]
with encryption
	AS SELECT [Id],[Name],isnull([Buy],1) [Buy],isnull([Sell],1) [Sell],isnull([RefreshDate],'20000101') [RefreshDate],[Description],[IsActive]
	FROM [Accounting].[Currency]
GO
PRINT N'Creating [Accounting].[VwBankGroupChoose]...';


GO
CREATE VIEW [Accounting].[VwBankGroupChoose]
with encryption
	AS SELECT Id,[Name] FROM [Accounting].[BankGroup] where nullif(IsActive,1) is null
GO
PRINT N'Creating [Accounting].[VwBankGroup]...';


GO
CREATE VIEW [Accounting].[VwBankGroup]
with encryption
	AS SELECT * FROM [Accounting].[BankGroup]
GO
PRINT N'Creating [Accounting].[VwBankChoose]...';


GO
CREATE VIEW [Accounting].[VwBankChoose]
with encryption
	AS 
	select b.[Id]
      ,b.[Name]
	  ,b.[Voen]
	  ,b.[Swift]
      ,b.[DocTypeId]
      ,b.[DocCertId]
      ,b.[DocSeriesId]
from [Accounting].[Bank] b
where DeleteId is null
GO
PRINT N'Creating [Accounting].[VwBank]...';


GO
CREATE VIEW [Accounting].[VwBank]
with encryption
	AS 
	select 
	   b.[Id]
      ,b.[GroupId]
	  ,bg.Name BankGroupName
      ,b.[Name]
      ,b.[Swift]
	  ,b.[Voen]
      ,b.[CurrencyId]
	  ,C.Name CurrencyName
	  ,b.[RegionId]
	  ,r.Name  RegionName
      ,b.[CreateId]
      ,b.[CreateDate]
      ,b.[UpdateId]
      ,b.[UpdateDate]
      ,b.[DeleteId]
      ,b.[DeleteDate]
      ,b.[ReadOnly]
      ,b.[DocTypeId]
      ,b.[DocCertId]
      ,b.[DocSeriesId]
from [Accounting].[Bank] b

left  join [Accounting].[BankGroup] bg on b.GroupId=bg.Id
left join [Accounting].[Currency] c on b.CurrencyId=c.Id
left join [dbo].[Region] r on b.RegionId=r.Id
GO
PRINT N'Creating [Accounting].[VwAccountChoose]...';


GO
CREATE VIEW [Accounting].[VwAccountChoose]
	AS SELECT 


	Id

	,isnull(ParentId,0) ParentId
	,[Name]
	,[Code]
	,[Description]
	,[IsActive]
	,[CreateDate] 


	FROM [Accounting].[Account] where 
	nullif(IsActive,1) is null
GO
PRINT N'Creating [Accounting].[VwAccount]...';


GO
CREATE VIEW [Accounting].[VwAccount]
	AS SELECT 
	Id
	
	,isnull(ParentId,0) ParentId
	,[Name]
	,[Code]
	,[Description]
	,[IsActive]
	,[CreateDate] 



	FROM [Accounting].[Account]



	where isnull (IsActive, 1)=1
GO
PRINT N'Creating [Accounting].[VwIncludeContractChoose]...';


GO
CREATE VIEW [Accounting].[VwIncludeContractChoose]
	AS SELECT
	c.Id  ContractId
	,c. CustomerId
	,cu.CustomerName
	,c. ContractTypeId
	


	FROM [Accounting].[Contract] c
	inner join[Accounting].[ContractType] ct on c.ContractTypeId=ct.Id 
	inner join[Accounting].[Customer] cu on c.CustomerId=cu.Id

	where ContractTypeId in (1)
GO
PRINT N'Creating [Accounting].[VwContractType]...';


GO
CREATE VIEW [Accounting].[VwContractType]
	AS SELECT * FROM [Accounting].[ContractType]
GO
PRINT N'Creating [Accounting].[VwStock]...';


GO
CREATE VIEW [Accounting].[VwStock]
	AS SELECT 
	s.DocumentId
	,s.GoodId
	,s.WarehouseId
	,w.[Name] Warehouse
	,g.GoodName
	,CreateId
	,s.Series
	,sum(s.Quantity) Quantity
	,s.PriceBuy
	,s.PrcieRetail
	,s.PriceWholeSale
	,s.CreateDate
	,UpdateDate
	,UpdateId 
	--,s.ContractId
	--,s.ContractTypeId
	
	

	FROM [Accounting].[Stock] s

left  join Accounting.Good g on s.GoodId=g.Id
LEFT JOIN WareHouses.WareHouse w ON w.Id=s.WarehouseId
   --join Accounting.[Contract] c on c.Id=d.ContractId

GROUP BY 
s.DocumentId
,s.GoodId
,s.WarehouseId
,w.[Name]
,g.GoodName
,CreateId
,s.Series
,s.PriceBuy
,s.PrcieRetail
,s.PriceWholeSale
,s.CreateDate
,UpdateDate
,UpdateId

	--,s.ContractId
	--,s.ContractTypeId
GO
PRINT N'Creating [Accounting].[VwPaymentType]...';


GO
CREATE VIEW [Accounting].[VwPaymentType]
	AS SELECT * FROM [Accounting].[PaymentType]
GO
PRINT N'Creating [Accounting].[VwSaleContractChoose]...';


GO
CREATE VIEW [Accounting].[VwSaleContractChoose]
	AS SELECT
	c.Id ContractId
	,c. CustomerId
	,cu.CustomerName
	,c. ContractTypeId
	


	FROM [Accounting].[Contract] c
	inner join[Accounting].[ContractType] ct on c.ContractTypeId=ct.Id 
	inner join[Accounting].[Customer] cu on c.CustomerId=cu.Id

	where ContractTypeId in (2)
GO
PRINT N'Creating [Accounting].[VwCustomerGoodReturn]...';


GO
CREATE VIEW [Accounting].[VwCustomerGoodReturn]
	AS 
	----declare @goodid int =5
SELECT
	
	d.Id
	,d.ContractId
	,cust.CustomerName
	
	FROM [Accounting].[Document] d

	inner join Accounting.DocumentDetail dd on dd.DocumentId=d.Id
	inner join [Accounting].[Contract] c  on c.Id=d.ContractId
	inner join  [Accounting].[Customer] cust on cust.Id=c.CustomerId

	where GoodId  in  (1,1)
GO
PRINT N'Creating [Accounting].[VwCompanyMain]...';


GO
CREATE VIEW [Accounting].[VwCompanyMain]
	AS SELECT 
	 c.[Id] 
,c.ParentId
	 ,c.TypeId,
     ct.[Name] TypeName
    ,c.[PrivateNumber]
    ,c.[CompanyName]
    ,c.[CompanyLeader]
	,c.RegionId
	,r.Name RegionName
    ,c.[WorkTypeId] 
	,wt.Name [WorkTypeName]
    ,c.[Voen] 
    ,c.[CurrencyId] 
	,cr.Name [CurrencyName]
    ,c.[BankId] 
	,b.Name [BankName]
    ,c.[BankSwift] 
    ,c.[Date] 
    ,c.[LegalAddress] 
    ,c.[ActualAddress]
    ,c.[Email]
    ,c.[Tel] 
	,c.[ContractNumber]
	,c.[ContractDate] 
	
    ,c.[Description]
	,c.[CreateId]
	,c.[CreateDate]
	,c.[UpdateId]
	,c.[UpdateDate]
	,c.[DeleteId]
	,c.[DeleteDate]
	,c.[DocTypeId]
	,c.[DocCertId]
	,c.[DocSeriesId]
	
	FROM [Accounting].[Company] C
	left join Accounting.VwCurrency CR ON c.CurrencyId=cr.Id
	left join dbo.CompanyType ct on ct.Id=c.TypeId
	left join Accounting.VwBank b on c.BankId=b.Id
	left JOIN dbo.WorkType WT ON c.WorkTypeId=wt.Id
	left join dbo.Region r on c.RegionId=r.Id
GO
PRINT N'Creating [Accounting].[VwCustomerDebt]...';


GO
CREATE VIEW [Accounting].[VwCustomerDebt]
	AS 
	SELECT 
	cb.CustomerId,
	c.CustomerName,
	cb.Deficit,
	cb.UpdateDate
	
	FROM [Accounting].[CustomerDebt] cb
	join Accounting.Customer c ON c.Id=cb.CustomerId
GO
PRINT N'Creating [Accounting].[VwReason]...';


GO
CREATE VIEW [Accounting].[VwReason]
with encryption
	AS SELECT * FROM [Accounting].Reason
GO
PRINT N'Creating [Accounting].[VwRetailContractChoose]...';


GO
CREATE VIEW [Accounting].[VwRetailContractChoose]
	AS SELECT
	c.Id  ContractId
	,c. CustomerId
	,cu.CustomerName
	,c. ContractTypeId
	


	FROM [Accounting].[Contract] c
	inner join[Accounting].[ContractType] ct on c.ContractTypeId=ct.Id 
	inner join[Accounting].[Customer] cu on c.CustomerId=cu.Id

	where ContractTypeId in (3)
GO
PRINT N'Creating [Accounting].[VwTotalReport]...';


GO
CREATE VIEW [Accounting].[VwTotalReport]
	AS SELECT 
	 tr.[Id]
	,tr.[TotalAmount]  
	,tr.[TotalCost]  
	,tr.[TotalProfit]  
	,tr.[IsActive]  
	
	
	
	
	
	FROM [Accounting].[TotalReport] tr
GO
PRINT N'Creating [Accounting].[VwRetailSaleContractChoose]...';


GO
CREATE VIEW [Accounting].[VwRetailSaleContractChoose]
	AS SELECT
	c.Id ContractId
	,c. CustomerId
	,cu.CustomerName
	,c. ContractTypeId
	


	FROM [Accounting].[Contract] c
	inner join[Accounting].[ContractType] ct on c.ContractTypeId=ct.Id 
	inner join[Accounting].[Customer] cu on c.CustomerId=cu.Id

	where ContractTypeId in (3)
GO
PRINT N'Creating [Accounting].[VwPaymentRetail]...';


GO
CREATE VIEW [Accounting].[VwPaymentRetail]
	AS 
	SELECT 
	pr.DocumentId,
	pr.CreateId
	,pr.CreateDate
	,c.CustomerName
	,pr.Deficit
	,pr.Payment,
	pr.TotalSum,
	pr.[Percent],
	pr.DiscountNumber,
	pt.Name PaymentTypeName
	
	FROM [Accounting].[PaymentRetail] pr
	JOIN Accounting.PaymentType pt ON pt.Id=pr.PaymentTypeId
	LEFT JOIN Accounting.Customer c ON c.Id=pr.CustomerId
GO
PRINT N'Creating [Accounting].[VwCustomerCreditor]...';


GO
CREATE VIEW [Accounting].[VwCustomerCreditor]
	AS 
	SELECT 
	cb.CustomerId,
	c.CustomerName,
	cb.Deficit,
	cb.UpdateDate 
	FROM [Accounting].[CustomerDebt] cb
	join Accounting.Customer c ON c.Id=cb.CustomerId 
	where Deficit>0
GO
PRINT N'Creating [Accounting].[VwCost]...';


GO
CREATE VIEW [Accounting].[VwCost]
	AS SELECT 
	 c.[Id]  
	,c.[Person]  
	,c.[Place] 
	,c.Amount
	,c.[CostDate]  
	,c.[PaymentTypeId] 
	,pt.[Name] as PaymentTypeName
	,c.[Description]  
	
	
	FROM [Accounting].[Cost] c
	left join Accounting.PaymentType pt on c.PaymentTypeId=pt.Id
GO
PRINT N'Creating [Accounting].[VwExpenseChoose]...';


GO
CREATE VIEW [Accounting].[VwExpenseChoose]

	AS SELECT 
	
     [Id]  
	, isnull (ParentId,0)ParentId
	,[ExpenseName]  
	
	,[Code]
	,[Description]   	
	,[IsActive]
	,[CreateDate]
	FROM Accounting.Expense 
	where

	nullif (IsActive,1) is null
GO
PRINT N'Creating [Accounting].[VwExpense]...';


GO
CREATE VIEW [Accounting].[VwExpense]
	AS SELECT 
	
	
     ex.[Id]  
	, isnull (ParentId,0)ParentId
	,ex.[ExpenseName]  
	
	,ex.[Code]
	,ex.[Description]  
	,ex.[IsActive]  
	,ex.[CreateDate]
	FROM Accounting.Expense ex 
	

	where isnull (IsActive, 1)=1
GO
PRINT N'Creating [Accounting].[VwManagementPayment]...';


GO
CREATE VIEW [Accounting].[VwManagementPayment]
	AS SELECT 
	p.Id
    ,p.AccountId,
	a.Name AccountName,
	sum(p.CustomerId) CustomerId, 
	p.DocumentId,
	c.CustomerName,
	p.PaymentTypeId,
	pt.Name PaymentTypeName,
	p.Payment,
	 sum(p.Deficit) Deficit,
	p.Paymentdate,

	p.Description, 
	p.CreateDate
	FROM Accounting.Payment p
	JOIN Accounting.Customer c ON p.CustomerId=c.Id
	JOIN Accounting.Account a ON a.Id=p.AccountId
	JOIN Accounting.PaymentType pt ON pt.Id=p.PaymentTypeId 

	group by
	p.Id
    ,p.AccountId,
	a.Name  ,
	 p.CustomerId, 
	p.DocumentId,
	c.CustomerName,
	p.PaymentTypeId,
	pt.Name    ,
	p.Payment, 
	p.Paymentdate,
	p.Description, 
	p.CreateDate
GO
PRINT N'Creating [WareHouses].[VwWareHouse]...';


GO
CREATE VIEW [WareHouses].[VwWareHouse]
with encryption
	AS SELECT 
	
	 wh.[Id],
	 wh.CompanyId,
	 c.CompanyName
	,wh.[Name]
	,wh.[WareHouseTypeId]
	,wh.[Description]
	,wh.[IsActive]
	,wht.Name WareHouseTypeName
	FROM [WareHouses].[WareHouse] wh

	left join WareHouses.WareHouseType  wht on wh.WareHouseTypeId= wht.Id
	LEFT JOIN Accounting.Company c ON  c.Id=wh.CompanyId
	--where wh.Id=1;
GO
PRINT N'Creating [WareHouses].[VwWareHouseType]...';


GO
CREATE VIEW [WareHouses].[VwWareHouseType]
with encryption
	AS SELECT * FROM [WareHouses].[WareHouseType]
	WHERE isnull (IsActive,1)= 1;
GO
PRINT N'Creating [WareHouses].[VwWareHouseChoose]...';


GO
CREATE VIEW [WareHouses].[VwWareHouseChoose]
with encryption
	AS SELECT Id,[Name] FROM [WareHouses].[WareHouse] where nullif(IsActive,1) is null
GO
PRINT N'Creating [dbo].[VwAccountDebt]...';


GO
CREATE VIEW [dbo].[VwAccountDebt]
	AS SELECT Id,isnull(ParentId,0) ParentId,[Name],[Code],[Description],[IsActive],[CreateDate] 
	FROM [Accounting].[Account]
	where isnull (IsActive, 1)=1 AND Accounting.Account.Id=10 OR Accounting.Account.Id=11
GO
PRINT N'Creating [dbo].[VwCitizenShip]...';


GO
CREATE VIEW [dbo].[VwCitizenShip]
	AS SELECT * FROM [dbo].[Citizenship]
GO
PRINT N'Creating [dbo].[VwContactType]...';


GO
CREATE VIEW [dbo].[VwContactType]
	AS SELECT * FROM [dbo].[ContactType]
GO
PRINT N'Creating [dbo].[VwContactTypeChoose]...';


GO
CREATE VIEW [dbo].[VwContactTypeChoose]
	AS SELECT Id,[Name] FROM [dbo].[ContactType]
	where nullif(IsActive,1) is null
GO
PRINT N'Creating [dbo].[VwDepartment]...';


GO
CREATE VIEW [dbo].[VwDepartment]
with encryption
	AS SELECT * FROM [dbo].[Department]
GO
PRINT N'Creating [dbo].[VwDepartmentChoose]...';


GO
CREATE VIEW [dbo].[VwDepartmentChoose]
with encryption
	AS SELECT Id,[Name] FROM [dbo].[Department] where nullif(IsActive,1) is null
GO
PRINT N'Creating [dbo].[VwDocCert]...';


GO
CREATE VIEW [dbo].[VwDocCert]
with encryption
AS SELECT * FROM [dbo].[DocCert]
GO
PRINT N'Creating [dbo].[VwDocCertChoose]...';


GO
CREATE VIEW [dbo].[VwDocCertChoose]
with encryption
AS SELECT Id,[Name] FROM [dbo].[DocCert] where nullif(IsActive,1) is null
GO
PRINT N'Creating [dbo].[VwDocSeries]...';


GO
CREATE VIEW [dbo].[VwDocSeries]
with encryption
AS SELECT * FROM [dbo].[DocSeries]
GO
PRINT N'Creating [dbo].[VwDocSeriesChoose]...';


GO
CREATE VIEW [dbo].[VwDocSeriesChoose]
with encryption
AS SELECT Id,[Name] FROM [dbo].[DocSeries] where nullif(IsActive,1) is null
GO
PRINT N'Creating [dbo].[VwDocType]...';


GO
CREATE VIEW [dbo].[VwDocType]
with encryption
AS SELECT * FROM [dbo].[DocType]
GO
PRINT N'Creating [dbo].[VwDocTypeChoose]...';


GO
CREATE VIEW [dbo].[VwDocTypeChoose]
with encryption
AS SELECT Id,[Name] FROM [dbo].[DocType] where nullif(IsActive,1) is null
GO
PRINT N'Creating [dbo].[VwDose]...';


GO
CREATE VIEW [dbo].[VwDose]
	AS SELECT * FROM  [dbo].[Dose]
GO
PRINT N'Creating [dbo].[VwEducationLevel]...';


GO
CREATE VIEW [dbo].[VwEducationLevel]
	AS SELECT Id,[Name] FROM  [dbo].[EducationLevel]
GO
PRINT N'Creating [dbo].[VwGender]...';


GO
CREATE VIEW [dbo].[VwGender]
	AS SELECT Id,[Description] FROM [dbo].[Gender]
GO
PRINT N'Creating [dbo].[VwMartialStatus]...';


GO
CREATE VIEW [dbo].[VwMartialStatus]
	AS SELECT Id,[Name] FROM [dbo].[MartialStatus]
GO
PRINT N'Creating [dbo].[VwMilitaryStatus]...';


GO
CREATE VIEW [dbo].[VwMilitaryStatus]
	AS SELECT Id,[Name] FROM [dbo].[MilitaryStatus]
GO
PRINT N'Creating [dbo].[VwPackingType]...';


GO
CREATE VIEW [dbo].[VwPackingType]
	AS SELECT * FROM [dbo].[PackingType]
GO
PRINT N'Creating [dbo].[VwPosition]...';


GO
CREATE VIEW [dbo].[VwPosition]
with encryption
	AS SELECT * FROM [dbo].[Position]
GO
PRINT N'Creating [dbo].[VwPositionChoose]...';


GO
CREATE VIEW [dbo].[VwPositionChoose]
with encryption
	AS SELECT Id,[Name] FROM [dbo].[Position] where nullif(IsActive,1) is null
GO
PRINT N'Creating [dbo].[VwRegion]...';


GO
CREATE VIEW [dbo].[VwRegion]
	AS select r.[Id]
      ,isnull([ParentId],0)[ParentId]
      ,r.[Name]
      ,[RegionTypeId]
	  ,rt.Name [RegionType]
      ,r.[Description]
      ,r.[IsActive]
	  from [dbo].[Region] r 
      join [dbo].[RegionType] rt on r.RegionTypeId=rt.Id
GO
PRINT N'Creating [dbo].[VwRegionChoose]...';


GO
CREATE VIEW [dbo].[VwRegionChoose]
	AS select r.[Id]
      ,isnull([ParentId],0)[ParentId]
      ,r.[Name]
      ,[RegionTypeId]
	  ,rt.Name [RegionType]
      ,r.[Description]
      ,r.[IsActive]
	  from [dbo].[Region] r 
      join [dbo].[RegionType] rt on r.RegionTypeId=rt.Id
	  where isnull(r.[IsActive],1)=1 and isnull(rt.[IsActive],1)=1
GO
PRINT N'Creating [dbo].[VwRegionType]...';


GO
CREATE VIEW [dbo].[VwRegionType]
	AS SELECT * FROM [dbo].[RegionType]
GO
PRINT N'Creating [dbo].[VwRegionTypeChoose]...';


GO
CREATE VIEW [dbo].[VwRegionTypeChoose]
	AS SELECT Id,[Name] FROM [dbo].[RegionType] where isnull([IsActive],1)=1
GO
PRINT N'Creating [dbo].[VwRole]...';


GO
CREATE VIEW [dbo].[VwRole] 
	AS select r.[Id]
      ,isnull([ParentId],0)[ParentId]
      ,r.[Name]
      ,[RoleTypeId]
	  ,rt.Name [RoleType]
      ,r.[Description]
      ,r.[IsActive]
	  from [dbo].[Role] r 
      join [dbo].[RoleType] rt on r.RoleTypeId=rt.Id
GO
PRINT N'Creating [dbo].[VwRoleType]...';


GO
CREATE VIEW [dbo].[VwRoleType]
 
	AS SELECT * FROM [dbo].[RoleType]
GO
PRINT N'Creating [dbo].[VwRoleTypeChoose]...';


GO
CREATE VIEW [dbo].[VwRoleTypeChoose]
	AS SELECT Id,[Name] FROM [dbo].[RoleType] where isnull([IsActive],1)=1
GO
PRINT N'Creating [dbo].[VwSubUnit]...';


GO
CREATE VIEW [dbo].[VwSubUnit]
	AS SELECT 

	 su.Id
	,su.[Name]
	,su.GoodTypeId
	,gt.[Name]  GoodTypeName
	,su.UnitId
	,U.[Name] AS UnitName
	,su.[Description]
	
	
	FROM dbo.SubUnit su

	left join dbo.Unit u on u.Id=su.UnitId
	left join Accounting.GoodType GT ON GT.Id=SU.GoodTypeId
GO
PRINT N'Creating [dbo].[VwSysGroup]...';


GO
CREATE VIEW [dbo].[VwSysGroup]
AS 
SELECT 20000+Id Id,[Name],[Password],[PersonId],[IsDisable] 
FROM dbo.Principial where IsGroup=1
GO
PRINT N'Creating [dbo].[VwSysMember]...';


GO
CREATE VIEW [dbo].[VwSysMember]
AS 
SELECT 20100+Id Id,Id UserId,[Name],[Password],[PersonId],[IsDisable] ,GroupId
FROM dbo.Principial where IsMember=1
GO
PRINT N'Creating [dbo].[VwUnit]...';


GO
CREATE VIEW [dbo].[VwUnit]
	AS SELECT * FROM [dbo].[Unit]
GO
PRINT N'Creating [dbo].[VwUnitChoose]...';


GO
CREATE VIEW [dbo].[VwUnitChoose]
with encryption

	AS SELECT Id,[Name],[Description] FROM [dbo].[Unit]

where nullif (IsActive,1) IS NULL
GO
PRINT N'Creating [dbo].[VwUser]...';


GO
CREATE VIEW [dbo].[VwUser]
	AS SELECT
	
	 u.[Id] 
	,u.[UserName]
	,u.[UserSurname] 
	,u.[UserPatryonmic] 
	,u.[Pin] 
	,u.[RoleId]
	,rt.Name RoleTypeName
	,u.[Login]
	,u.[Password]  
	,u.[LastLogIn]   
	,u.[LastLogOut]  
	,u.[BirthOfDate] 
	,u.[RegionId] 
	,r.Name RegionName
	,u.[Address]
	,u.[Description]
	
	FROM [dbo].[User]  u
	 
 	left join dbo.Region      r      on       u.RegionId=r.Id
	left join dbo.RoleType    rt     on       u.RoleId=rt.Id
GO
PRINT N'Creating [dbo].[VwUserRegistration]...';


GO
CREATE VIEW [dbo].[VwUserRegistration]
	AS SELECT 
	 ur.[Id] 
    ,ur.[Name] 
    ,ur.[Surname] 
    ,ur.[Patronymic]
    ,ur.[BirthOfDate]  
    ,ur.[CitizenshipId] 
	,c.Name CitizenshipName
    ,ur.[RegionId] 
	,r.Name RegionName
    ,ur.[Address] 
    ,ur.[Description] 
	FROM dbo.UserRegistration ur 
	left join dbo.Citizenship c on ur.CitizenshipId=c.Id
	left join dbo.Region r on ur.RegionId=r.Id
GO
PRINT N'Creating [dbo].[VwWorkGraphic]...';


GO
CREATE VIEW [dbo].[VwWorkGraphic]
with encryption
AS SELECT * FROM [dbo].[WorkGraphic]
GO
PRINT N'Creating [dbo].[VwWorkGraphicChoose]...';


GO
CREATE VIEW [dbo].[VwWorkGraphicChoose]
with encryption
AS SELECT Id,[Name] FROM [dbo].[WorkGraphic] where nullif(IsActive,1) is null
GO
PRINT N'Creating [dbo].[VwWorkPlace]...';


GO
CREATE VIEW [dbo].[VwWorkPlace]
AS SELECT * FROM [dbo].[WorkPlace]
GO
PRINT N'Creating [dbo].[VwWorkType]...';


GO
CREATE VIEW [dbo].[VwWorkType]
AS SELECT * FROM [dbo].[WorkType]
GO
PRINT N'Creating [Accounting].[VwCompany]...';


GO
CREATE VIEW [Accounting].[VwCompany]
	AS 
	SELECT 
	 c.[Id] 
,c.ParentId
	 ,c.TypeId,
     ct.[Name] TypeName
    ,c.[PrivateNumber]
    ,c.[CompanyName]
    ,c.[CompanyLeader]
	,c.RegionId
	,r.Name RegionName
    ,c.[WorkTypeId] 
	,wt.Name [WorkTypeName]
    ,c.[Voen] 
    ,c.[CurrencyId] 
	,cr.Name [CurrencyName]
    ,c.[BankId] 
	,b.Name [BankName]
    ,c.[BankSwift] 
    ,c.[Date] 
    ,c.[LegalAddress] 
    ,c.[ActualAddress]
    ,c.[Email]
    ,c.[Tel] 
	,c.[ContractNumber]
	,c.[ContractDate] 
	
    ,c.[Description]
	,c.[CreateId]
	,c.[CreateDate]
	,c.[UpdateId]
	,c.[UpdateDate]
	,c.[DeleteId]
	,c.[DeleteDate]
	,c.[DocTypeId]
	,c.[DocCertId]
	,c.[DocSeriesId]
	
	FROM [Accounting].[Company] C
	left join Accounting.VwCurrency CR ON c.CurrencyId=cr.Id
	left join dbo.CompanyType ct on ct.Id=c.TypeId
	left join Accounting.VwBank b on c.BankId=b.Id
	left JOIN dbo.WorkType WT ON c.WorkTypeId=wt.Id
	left join dbo.Region r on c.RegionId=r.Id
GO
PRINT N'Creating [Accounting].[VwCustomer]...';


GO
CREATE VIEW [Accounting].[VwCustomer]
	AS SELECT

	c.[Id],
	c.ParentId,
	c.TypeId,
	ct.[Name] TypeName,
    c.[CustomerName]  , 
    c.[CustomerLeader] , 
    c.[WorkTypeId] ,
	wt.Name [WorkTypeName] ,
	c.RegionId,
	r.Name [RegionName],
	c.BankId,
	b.Name [BankName] ,
	c.BankSwift ,
    c.[Voen] , 
    c.[CurrencyId] ,
	cr.name [CurrencyName] ,
    c.[LegalAddress] , 
    c.[ActualAddress] , 
    c.[Email] , 
    c.[Tel] , 
	c.[Date] ,
    c.[Description] 

	FROM [Accounting].[Customer] C

	left join [dbo].[VwWorkType] wt on c.WorkTypeId=wt.Id
	LEFT JOIN dbo.CompanyType ct ON ct.Id=c.TypeId
	left join [Accounting].[VwCurrency] cr on c.CurrencyId=cr.Id
	left join [Accounting].[VwBank] b on c.BankId=b.Id
	left join  [dbo].[VwRegion] r on c.RegionId=r.Id
GO
PRINT N'Creating [Accounting].[VwContract]...';


GO
CREATE VIEW [Accounting].[VwContract]
	AS SELECT 
	c.[Id]
	,c.[CustomerId]
	,cus.CustomerName
	,c.[ContractDate]
    ,c.[ContractTypeId]
   ,ct.Name [ContractTypeName]

	,c.[CurrencyId]
   ,cr.Name[CurrencyName]

    ,c.[OperationTypeId]
   ,ot.Name[OperationTypeName]

	
	,c.[CompanyId]
	,cm.CompanyName

	,c.[Description]
	,c.[IsActive]

	FROM [Accounting].[Contract] c
  left join [Accounting].[VwCompany] cm on c.CompanyId=cm.Id
  left join [Accounting].[VwContractType] ct on c.ContractTypeId=ct.Id
  left join [Accounting].[VwCurrency] cr on c.CurrencyId=cr.Id
  left join [dbo].[OperationType] ot on c.OperationTypeId=ot.Id
  left join Accounting.VwCustomer cus  on c.CustomerId=cus.Id
GO
PRINT N'Creating [Accounting].[VwDocumentReturnRetail]...';


GO
CREATE VIEW [Accounting].[VwDocumentReturnRetail]
		AS SELECT 
	 d.[Id]   
	,d.[AccountId]
	,ac.Code AccountCode
	,ac.Name AccountName
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,c.CompanyName
    ,d.[WareHouseId] 
	,wh.Name WareHouseName

	,d.PaymentTypeId
	,pt.Name PaymentTypeName
	,d.ContractId
	,co.CustomerId
	,co.CustomerName
	,d.DeleteDate
	,d.DeleteId
		,d.Description
		,d.[PaymentDate]   
		,d.[PartnerOrderNo]
		,d.[MainNumber]
	
	
	
	FROM [Accounting].[Document] d

	left join [Accounting].[VwCompany] c on d.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on d.WareHouseId=wh.Id
	left join Accounting.VwContract co on d.ContractId=co.Id
	left join Accounting.Account ac on d.AccountId=ac.Id
	left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id

	where AccountId=4
GO
PRINT N'Creating [Accounting].[VwDocumentReturnSale]...';


GO
CREATE VIEW [Accounting].[VwDocumentReturnSale]
	AS SELECT 
	 d.[Id]   
	,d.[AccountId]
	,ac.Code AccountCode
	,ac.Name AccountName
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,c.CompanyName
    ,d.[WareHouseId] 
	,wh.Name WareHouseName

	,d.PaymentTypeId
	,pt.Name PaymentTypeName
	,d.ContractId
	,co.CustomerId
	,co.CustomerName
	,d.DeleteDate
	,d.DeleteId
		,d.Description
	,d.[PaymentDate]   
		,d.[PartnerOrderNo]
		,d.[MainNumber]
		,d.CashierId
		,cashier.CashierName
	
	
	FROM [Accounting].[Document] d

	left join [Accounting].[VwCompany]    c on d.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on d.WareHouseId=wh.Id
	left join Accounting.VwContract co on d.ContractId=co.Id
	left join Accounting.Account ac on d.AccountId=ac.Id
	left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id
	left join Accounting.Cashier cashier on d.CashierId=cashier.Id

	where AccountId=5
GO
PRINT N'Creating [Accounting].[VwDocumentReturnInclude]...';


GO
CREATE VIEW [Accounting].[VwDocumentReturnInclude]
	AS SELECT 
	 d.[Id]   
	 ,d.[AccountId]
	 ,ac.Code AccountCode
	 ,ac.Name AccountName
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,c.CompanyName
    ,d.[WareHouseId] 
	,wh.Name WareHouseName
	,d.PaymentTypeId
	,pt.Name PaymentTypeName
	,d.ContractId
	,co.CustomerId
	,co.CustomerName
	,d.DeleteDate
	,d.DeleteId
		,d.Description
		,d.[PaymentDate]   
		,d.[PartnerOrderNo]
		,d.[MainNumber]

	
	
	
	FROM [Accounting].[Document] d

	left join [Accounting].[VwCompany] c on d.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on d.WareHouseId=wh.Id
	left join Accounting.VwContract co on d.ContractId=co.Id
	left join Accounting.Account ac on d.AccountId=ac.Id
	left join Accounting.PaymentType pt on d.PaymentTypeId=pt.Id
	 
	where [AccountId]=9
GO
PRINT N'Creating [Accounting].[VwDocumentTmp]...';


GO
CREATE VIEW [Accounting].[VwDocumentTmp]
	AS SELECT 
	 dTmp.[Id]    
    ,dTmp.[CompanyId]   
	,c.[CompanyName]
    ,dTmp.[WareHouseId] 
	,wh.Name WareHouseName
	,dTmp.ContractId
	,co.CustomerId
	,co.CustomerName
	,dTmp.DeleteDate
	,dTmp.DeleteId
	
	
	
	FROM [Accounting].[DocumentTmp] dTmp

	left join [Accounting].[VwCompany]    c on dTmp.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on dTmp.WareHouseId=wh.Id
	left join Accounting.VwContract co on dTmp.ContractId=co.Id
GO
PRINT N'Creating [Accounting].[VwDocumentDeletion]...';


GO
CREATE VIEW [Accounting].[VwDocumentDeletion] 
	AS SELECT 
	 d.[Id]   
	,d.[AccountId]
	,ac.Code AccountCode
	,ac.Name AccountName
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,c.CompanyName
    ,d.[WareHouseId] 
	,wh.Name WareHouseName

	,d.PaymentTypeId
	,pt.Name PaymentTypeName
	,d.ContractId
	,co.CustomerId
	,co.CustomerName
	,d.DeleteDate
	,d.DeleteId
	,d.[ReasonId]
	,re.Name ReasonName
		,d.Description
	
	
	
	FROM [Accounting].[Document] d

	left join [Accounting].[VwCompany] c on d.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on d.WareHouseId=wh.Id
	left join Accounting.VwContract co on d.ContractId=co.Id
	left join Accounting.Account ac on d.AccountId=ac.Id
	left join Accounting.PaymentType pt on d.PaymentTypeId=pt.Id
	left join Accounting.Reason re on d.ReasonId=re.Id

	where AccountId=6
GO
PRINT N'Creating [Accounting].[VwInventar]...';


GO
CREATE VIEW [Accounting].[VwInventar]
	AS 
	SELECT 
	i.FullGoodName,
	i.DocumentInventarId,
	i.Quantity,
	i.DifferenceQuantity,
	i.StockQuantity,
	i.WareHouseId,
	w.[Name] WarehouseName,
	u.[Name] UserName,
	i.CreateDate
	,i.CreateId
	,i.[DeleteId]   

	FROM [Accounting].[Inventar] i
	JOIN WareHouses.VwWareHouse w ON w.Id=i.WareHouseId
	JOIN dbo.[Principial] u ON u.Id=i.CreateId
GO
PRINT N'Creating [Accounting].[VwGoodSelect]...';


GO
CREATE  VIEW [Accounting].[VwGoodSelect]
AS
SELECT       
                         g.Id
						 --,g.BarcodeId
                          ,bar.Id AS BarcodeId
                         ,bar.Barcode
                         ,g.GoodName
                         ,g.DocumentDetailId 
                         ,SUM(dd.Quantity) AS Quantity
						 ,g.GoodTypeId
                         ,(g.GoodName + ' ' + gt.Name+ ' ' + pt.Name+ ' ' + d.Name  + '  ' + c.CompanyName + ' ' + c.RegionName )  AS FullGoodName
                         ,gt.Name AS GoodTypeName
						 ,g.ManufacturerCompanyId
						 ,ISNULL(c.CompanyName, '') AS ManufacturerCompanyName
						 ,c.RegionId
						 ,ISNULL(c.RegionName, '') AS RegionName
						 ,g.UnitId
						 ,u.[Name] AS UnitName
						 ,g.DoseId
						 ,d.Name AS DoseName
                         ,g.PackingTypeId
						 ,pt.Name AS  PackingTypeName
						 ,g.Description
						 ,g.CreateId
						 ,g.CreateDate
						 ,g.ModifyId
						 ,g.ModifyDate
						 ,g.DocTypeId
						 ,g.DocCertId
						 ,g.DocSeriesId
						 --,g.[DocumentId]
						 --,doc.CustomerName  
						 --,cont.ContractTypeId
						 --,g.[ContractId]    
						 --,g.[ContractTypeId]

FROM            Accounting.Good AS g

--LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id = bar.GoodId 
LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id=bar.GoodId 
LEFT OUTER JOIN    dbo.Unit AS u ON g.UnitId = u.Id
LEFT OUTER JOIN    Accounting.GoodType AS gt ON g.GoodTypeId = gt.Id
LEFT OUTER JOIN    Accounting.VwCompany AS c ON g.ManufacturerCompanyId = c.Id
LEFT OUTER JOIN    dbo.VwDose AS d ON g.DoseId = d.Id 
LEFT OUTER JOIN    dbo.VwPackingType AS pt ON g.PackingTypeId = pt.Id
LEFT OUTER JOIN    Accounting.DocumentDetail AS dd ON g.Id = dd.GoodId 
--LEFT OUTER JOIN    Accounting.VwDocument  doc on g.DocumentId=doc.Id 
  --JOIN    Accounting.[Contract] cont on cont.Id=doc.ContractId
						 WHERE        (g.DeleteId IS NULL)  and Quantity>0 
						--and ContractTypeId in (1)
						--and Quantity>=0

GROUP BY
g.Id
 --,g.BarcodeId
,c.CompanyName
, bar.Id
 
,bar.Barcode 
,g.GoodName
,g.DocumentDetailId
,g.GoodTypeId
,gt.Name
,g.ManufacturerCompanyId
,ISNULL(c.CompanyName, '')
,c.RegionId
,c.RegionName 
,g.UnitId
,u.Name
,g.DoseId
,d.Name 
, g.PackingTypeId
, pt.Name
, g.Description
, g.CreateId 
, g.CreateDate
, g.ModifyId
, g.ModifyDate
, g.DocTypeId 
, g.DocCertId
, g.DocSeriesId
 --,g.[DocumentId]
-- ,doc.CustomerName 
-- ,cont.ContractTypeId
----,g.[ContractId]    
--,g.[ContractTypeId]



--SELECT       
--                         g.Id
--						 ,g.BarcodeId
--                         ,bar.Id AS Id
--                         ,bar.Barcode
--                         ,g.GoodName
--                         ,g.DocumentDetailId 
--                         ,SUM(dd.Quantity) AS Quantity
--						 ,g.GoodTypeId
--                         ,(g.GoodName + ' ' + pt.Name+ ' ' + d.Name  + '  ' + c.CompanyName + ' ' + c.RegionName )  AS FullGoodName
--                         ,gt.Name AS GoodTypeName
--						 ,g.ManufacturerCompanyId
--						 ,ISNULL(c.CompanyName, '') AS ManufacturerCompanyName
--						 ,c.RegionId
--						 ,c.RegionName
--						 ,g.UnitId
--						 ,u.Name AS UnitName
--						 ,g.DoseId
--						 ,d.Name AS DoseName
--                         ,g.PackingTypeId
--						 ,pt.Name AS  PackingTypeName
--						 ,g.Description
--						 ,g.CreateId
--						 ,g.CreateDate
--						 ,g.ModifyId
--						 ,g.ModifyDate
--						 ,g.DocTypeId
--						 ,g.DocCertId
--						 ,g.DocSeriesId


--FROM            Accounting.Good AS g

--LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id = bar.GoodId 
--LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.BarcodeId = bar.Id 
--LEFT OUTER JOIN    dbo.Unit AS u ON g.UnitId = u.Id
--LEFT OUTER JOIN    Accounting.GoodType AS gt ON g.GoodTypeId = gt.Id
--LEFT OUTER JOIN    Accounting.VwCompany AS c ON g.ManufacturerCompanyId = c.Id
--LEFT OUTER JOIN    dbo.VwDose AS d ON g.DoseId = d.Id 
--LEFT OUTER JOIN    dbo.VwPackingType AS pt ON g.PackingTypeId = pt.Id
--LEFT OUTER JOIN    Accounting.DocumentDetail AS dd ON g.Id = dd.GoodId 
                        
--						WHERE        (g.DeleteId IS NULL)  and Quantity>0
						
--						and Quantity>=0

--GROUP BY
--g.Id,
--g.BarcodeId,
--c.CompanyName,
--bar.Id, 

--bar.Barcode, 
--g.GoodName,
--g.DocumentDetailId,
--g.GoodTypeId,
--gt.Name, 
--g.ManufacturerCompanyId,
--ISNULL(c.CompanyName, ''),
--c.RegionId,
--c.RegionName, 
--g.UnitId,
--u.Name,
--g.DoseId,
--d.Name, 
-- g.PackingTypeId, 
-- pt.Name,
-- g.Description,
-- g.CreateId, 
-- g.CreateDate,
-- g.ModifyId,
-- g.ModifyDate,
-- g.DocTypeId, 
-- g.DocCertId,
-- g.DocSeriesId
GO
PRINT N'Creating [Accounting].[VwDocumentRetailsSale]...';


GO
CREATE VIEW [Accounting].[VwDocumentRetailsSale]
	AS SELECT 
	 d.[Id]     
	,d.[PaymentTypeId]
	,pt.Name PaymentTypeName
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,c.CompanyName
    ,d.[WareHouseId] 
	,wh.Name WareHouseName
	,d.ContractId
	,co.CustomerId
	,co.CustomerName
	,d.Description
	,d.DeleteDate
	,d.DeleteId
	,d.[DocTypeId]
     ,d.[DocCertId]
     ,d.[DocSeriesId]
	 ,d.PaymentDate
	 ,d.PartnerOrderNo
	
	
	
	FROM [Accounting].[Document] d
	left join [Accounting].[VwCompany] c on d.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on d.WareHouseId=wh.Id
	left join Accounting.VwContract co on d.ContractId=co.Id 
	left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id

	where AccountId=8
GO
PRINT N'Creating [Accounting].[VwCash]...';


GO
CREATE VIEW [Accounting].[VwCash]
	AS SELECT
	
	
	 c.[Id]  
	,c.[CompanyId]  
	,com.CompanyName
	,c.[CashName]  
	,c.Balance
	--,c.[WareHouseId] 
	--,wh.[Name] WareHouseName
	,c.[Description]  
	,c.[CreateId]  
	,c.[CreateDate]  

	
      ,c.[IsActive]

	 FROM [Accounting].[Cash] c
	 left join Accounting.VwCompany com on c.CompanyId=com.Id
	 --left join WareHouses.VwWareHouse wh on c.WareHouseId=wh.Id
GO
PRINT N'Creating [Accounting].[VwOfflineSale]...';


GO
CREATE VIEW [Accounting].[VwOfflineSale]
	AS SELECT 

	     l.[Id]  
		,l.[Driver]  
		,l.[Fin]  
		,l.[Transportation]  
		,l.[Cart]  
		,l.[Sender]  
		,l.[SenderAddress]  
		,l.[SenderManager]  
		,l.[Received]  
		,l.[ReceivedAddress]  
		,l.[ReceivedManager]  
		,l.[Date] 
		,l.[DeliveryDate] 
		,l.[Description]  
		,l.WareHouseId
		,l.CompanyId
		,wv.[Name] as WareHouseName
		,c.CompanyName
			,l.ContractId
	,co.CustomerId
	,co.CustomerName
	
	,l.[PaymentTypeId]
	,pt.[Name] PaymentTypeName
	
	FROM [Accounting].[OfflineSale] l
	left join WareHouses.WareHouse  wv on wv.Id=l.WareHouseId
	left join Accounting.Company c on c.Id=l.CompanyId
		left join Accounting.VwContract co on l.ContractId=co.Id 
	left join Accounting.VwPaymentType pt on l.PaymentTypeId=pt.Id
GO
PRINT N'Creating [Accounting].[VwLogistic]...';


GO
CREATE VIEW [Accounting].[VwLogistic]
	AS SELECT 

	     l.[Id]  
		,l.[Driver]  
		,l.[Fin]  
		,l.[Transportation]  
		,l.[Cart]  
		,l.[Sender]  
		,l.[SenderAddress]  
		,l.[SenderManager]  
		,l.[Received]  
		,l.[ReceivedAddress]  
		,l.[ReceivedManager]  
		,l.[Date] 
		,l.[DeliveryDate] 
		,l.[Description]  
		,l.WareHouseId
		,l.CompanyId
		,wv.[Name] as WareHouseName
		,c.CompanyName
			,l.ContractId
	,co.CustomerId
	,co.CustomerName
	
	,l.[PaymentTypeId]
	,pt.[Name] PaymentTypeName
	
	FROM [Accounting].[Logistic] l
	left join WareHouses.WareHouse  wv on wv.Id=l.WareHouseId
	left join Accounting.Company c on c.Id=l.CompanyId
		left join Accounting.VwContract co on l.ContractId=co.Id 
	left join Accounting.VwPaymentType pt on l.PaymentTypeId=pt.Id
GO
PRINT N'Creating [Accounting].[VwPaymentIncludeOrder]...';


GO
CREATE VIEW [Accounting].[VwPaymentIncludeOrder]
	AS SELECT 
	p.Id
	,p.ExpenseId
	,ex.ExpenseName
	,p.CashId
	,ca.CashName
	,ca.CompanyName
	,p.CashFromId
	,caFrom.CashName CashFromName
    ,p.AccountId,
	a.Name AccountName,
	p.CustomerId,
    p.CustomerWareHouseId,
	p.DocumentId,
	c.CustomerName,
	p.PaymentTypeId,
	pt.Name PaymentTypeName,
	p.Payment,
	p.Deficit,
	p.Description,

	p.PaymentDate,
	p.[Percent],
	p.CreateDate
	FROM Accounting.Payment p
	JOIN Accounting.Customer c ON p.CustomerId=c.Id
	JOIN Accounting.Account a ON a.Id=p.AccountId
	JOIN Accounting.PaymentType pt ON pt.Id=p.PaymentTypeId
	left join WareHouses.WareHouse w on w.Id=p.CustomerWareHouseId
	left join Accounting.VwExpense ex on p.ExpenseId=ex.Id
	left join Accounting.VwCash ca on p.CashId=ca.Id
	left join Accounting.VwCash caFrom on p.CashFromId=caFrom.Id

	where AccountId in  (10,11)
GO
PRINT N'Creating [Accounting].[VwPaymentTransfer]...';


GO
CREATE VIEW [Accounting].[VwPaymentTransfer]
	AS SELECT 
	p.Id
	,p.ExpenseId
	,ex.ExpenseName
	,p.CashId
	,ca.CashName
	,ca.CompanyName
	,p.CashFromId
	,caFrom.CashName CashFromName
    ,p.AccountId,
	a.Name AccountName,
	p.CustomerId,
    p.CustomerWareHouseId,
	p.DocumentId,
	c.CustomerName,
	p.PaymentTypeId,
	pt.Name PaymentTypeName,
	p.Payment,
	p.Deficit,
	p.PaymentDate,
	p.Description,
	p.[Percent],
	p.CreateDate
	FROM Accounting.Payment p
	JOIN Accounting.Customer c ON p.CustomerId=c.Id
	JOIN Accounting.Account a ON a.Id=p.AccountId
	JOIN Accounting.PaymentType pt ON pt.Id=p.PaymentTypeId
	left join WareHouses.WareHouse w on w.Id=p.CustomerWareHouseId
	left join Accounting.VwExpense ex on p.ExpenseId=ex.Id
	left join Accounting.VwCash ca on p.CashId=ca.Id
	left join Accounting.VwCash caFrom on p.CashFromId=caFrom.Id

	where AccountId  = 17
GO
PRINT N'Creating [Accounting].[VwCashMoney]...';


GO
CREATE VIEW [Accounting].[VwCashMoney]
	AS SELECT 
    ca.CashName
	,ca.CompanyName 
	,sum (p.Deficit) Deficit
	
	FROM Accounting.Payment p 
	JOIN Accounting.Account a ON a.Id=p.AccountId 
	left join Accounting.VwCash ca on p.CashId=ca.Id
	left join Accounting.VwCash caFrom on p.CashId=caFrom.Id

where AccountId  not in (3,5,7,9)

group by
	ca.CashName
	,ca.CompanyName
GO
PRINT N'Creating [Accounting].[VwGood]...';


GO
CREATE  VIEW [Accounting].[VwGood]
AS
SELECT       
                         g.Id
						 --,g.BarcodeId
                          ,bar.Id AS BarcodeId
                         ,bar.Barcode
                         ,g.GoodName
                         ,g.DocumentDetailId 
                         ,SUM(dd.Quantity) AS Quantity
						 ,g.GoodTypeId 
                         ,(ISNULL(g.GoodName,'') + '   ' + ISNULL(gt.Name,'')+ '  ' + ISNULL(pt.Name,'')+ ' ' + ISNULL(d.Name,'')  + '  ' +ISNULL(c.CompanyName,'') + ' ' + ISNULL(reg.Name,'') )  AS FullGoodName
                         ,gt.[Name] AS GoodTypeName
						 ,g.ManufacturerCompanyId
						 ,ISNULL(c.CompanyName, '') AS ManufacturerCompanyName
						 ,g.RegionId
						 ,reg.Name as [RegionName]
						 ,g.UnitId
						 ,u.[Name] AS UnitName
						 ,g.DoseId
						 ,d.[Name] AS DoseName
                         ,g.PackingTypeId
						 ,pt.[Name] AS  PackingTypeName
						 ,g.[Description]
						 ,g.[GoodCode]
						 ,g.[Photo]
						 ,g.CreateId
						 ,g.CreateDate
						 ,g.ModifyId
						 ,g.ModifyDate
						 ,g.DocTypeId
						 ,g.DocCertId
						 ,g.DocSeriesId


FROM            Accounting.Good AS g

--LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id = bar.GoodId 
LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id=bar.GoodId 
LEFT OUTER JOIN    dbo.Unit AS u ON g.UnitId = u.Id
LEFT OUTER JOIN    Accounting.GoodType AS gt ON g.GoodTypeId = gt.Id
LEFT OUTER JOIN    Accounting.VwCompany AS c ON g.ManufacturerCompanyId = c.Id
left outer join dbo.region as reg on reg.Id=g.RegionId
LEFT OUTER JOIN    dbo.VwDose AS d ON g.DoseId = d.Id 
LEFT OUTER JOIN    dbo.VwPackingType AS pt ON g.PackingTypeId = pt.Id
LEFT OUTER JOIN    Accounting.DocumentDetail AS dd ON g.Id = dd.GoodId 
                       
						 WHERE        (g.DeleteId IS NULL)   						
						--and Quantity>=0
GROUP BY
g.Id,
--g.BarcodeId,
c.CompanyName,
 bar.Id, 
bar.Barcode, 
g.GoodName,
g.DocumentDetailId,
g.GoodTypeId,
gt.[Name], 
g.ManufacturerCompanyId,
c.CompanyName,
g.RegionId,
reg.Name, 
g.UnitId,
u.[Name],
g.DoseId,
d.[Name], 
 g.PackingTypeId, 
 pt.[Name],
 g.[Description]
 ,g.[GoodCode],
 g.[Photo],
 g.CreateId, 
 g.CreateDate,
 g.ModifyId,
 g.ModifyDate,
 g.DocTypeId, 
 g.DocCertId,
 g.DocSeriesId


--SELECT       
--                         g.Id
--						 ,g.BarcodeId
--                         --,bar.Id AS Id
--                         ,bar.Barcode
--                         ,g.GoodName
--                         ,g.DocumentDetailId 
--                         ,SUM(dd.Quantity) AS Quantity
--						 ,g.GoodTypeId
--                         ,(g.GoodName + ' ' + pt.Name+ ' ' + d.Name  + '  ' + c.CompanyName + ' ' + c.RegionName )  AS FullGoodName
--                         ,gt.Name AS GoodTypeName
--						 ,g.ManufacturerCompanyId
--						 ,ISNULL(c.CompanyName, '') AS ManufacturerCompanyName
--						 ,c.RegionId
--						 ,c.RegionName
--						 ,g.UnitId
--						 ,u.Name AS UnitName
--						 ,g.DoseId
--						 ,d.Name AS DoseName
--                         ,g.PackingTypeId
--						 ,pt.Name AS  PackingTypeName
--						 ,g.Description
--						 ,g.CreateId
--						 ,g.CreateDate
--						 ,g.ModifyId
--						 ,g.ModifyDate
--						 ,g.DocTypeId
--						 ,g.DocCertId
--						 ,g.DocSeriesId


--FROM            Accounting.Good AS g

----LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.Id = bar.GoodId 
--LEFT OUTER JOIN    Accounting.Barcode AS bar ON g.BarcodeId = bar.Id 
--LEFT OUTER JOIN    dbo.Unit AS u ON g.UnitId = u.Id
--LEFT OUTER JOIN    Accounting.GoodType AS gt ON g.GoodTypeId = gt.Id
--LEFT OUTER JOIN    Accounting.VwCompany AS c ON g.ManufacturerCompanyId = c.Id
--LEFT OUTER JOIN    dbo.VwDose AS d ON g.DoseId = d.Id 
--LEFT OUTER JOIN    dbo.VwPackingType AS pt ON g.PackingTypeId = pt.Id
--LEFT OUTER JOIN    Accounting.DocumentDetail AS dd ON g.Id = dd.GoodId 
                        
--						WHERE        (g.DeleteId IS NULL) 
						
--						--and Quantity>=0

--GROUP BY
--g.Id,
--g.BarcodeId,
--c.CompanyName,
----bar.Id, 

--bar.Barcode, 
--g.GoodName,
--g.DocumentDetailId,
--g.GoodTypeId,
--gt.Name, 
--g.ManufacturerCompanyId,
--ISNULL(c.CompanyName, ''),
--c.RegionId,
--c.RegionName, 
--g.UnitId,
--u.Name,
--g.DoseId,
--d.Name, 
-- g.PackingTypeId, 
-- pt.Name,
-- g.Description,
-- g.CreateId, 
-- g.CreateDate,
-- g.ModifyId,
-- g.ModifyDate,
-- g.DocTypeId, 
-- g.DocCertId,
-- g.DocSeriesId
GO
PRINT N'Creating [Accounting].[VwDocumentDetail]...';


GO
CREATE VIEW [Accounting].[VwDocumentDetail]
	AS SELECT distinct
	 dd.[Id] 
	 ,dd.GoodId StoGoodId
	 ,dd.[DocumentId]
	 ,dd.[TotalId]
	 ,dd.PaymentId
	 ,r.[TotalAmount]
	 ,r.[TotalCost]
	 ,r.[TotalProfit]
	 ,d.ContractId
	 ,c.ContractTypeId
	 ,c.CompanyId
	 ,comp.CompanyName
	 ,c.CustomerId
	 ,cust.CustomerName
	 

	 ,d.PaymentTypeId
	 ,pt.Name PaymentTypeName

	 ,dd.AccountId
	 ,a.ParentId AccountParentId
	 ,a.Code AccountCode
	 ,a.Name AccountName
     ,dd.[GoodId] 
	 ,g. [GoodName] 
	 ,dd.BarCodeId
	 ,b.Barcode
	 
	 ,g.[FullGoodName]
     ,dd.[Series] 
     ,dd.[DateOfProduction] 
     ,dd.[LastExpirationDate] 
     ,dd.[Quantity] 
     ,dd.[StoQuantity] 
	 ,dd.[UnitId]
	 ,u.Name UnitName
     ,dd.[PriceBuy] 
     ,dd.[PriceRetail]
     ,dd.[PriceWholeSale] 
     ,dd.[AmountBuy]
     ,dd.[AmountRetail]
     ,dd.[AmountWholeSale]
	 ,dd.[Payment]
	 ,dd.[Deficit] 
	 ,dd.[Description] 
	 --,dd.[DiscountPercent]
	,dd.[Percent] 
	,dd.[DiscountNumber]
	 ,dd.[CostInclude]
	 ,dd.[CostDeficit]
	 ,dd.[DiscountPrice]
	
	
	
	FROM [Accounting].[DocumentDetail] dd
	
	left join Accounting.Document d on dd.DocumentId=d.Id
	LEFT join Accounting.Payment p on dd.PaymentId=p.Id
	left join Accounting.[Contract] c on c.Id=d.ContractId
	left join [Accounting].[VwGood] g on dd.GoodId=g.Id
	left join [Accounting].[Account] a on dd.AccountId=a.Id
	left join [dbo].[Unit] u on dd.UnitId=u.Id
	left join [Accounting].[Barcode] b on dd.BarcodeId=b.Id
	left join Accounting.Stock sto on dd.GoodId=sto.GoodId
	left join Accounting.Company comp on d.CompanyId=comp.Id
	left join Accounting.Customer cust on c.CustomerId=cust.Id
	left join Accounting.PaymentType pt on d.PaymentTypeId=pt.Id
	left join Accounting.TotalReport r on dd.TotalId=r.Id
GO
PRINT N'Creating [Accounting].[VwBarcode]...';


GO
CREATE VIEW [Accounting].[VwBarcode]
	AS 
	SELECT 
	 b.[Id]
	,b.[GoodId]
	,g.[FullGoodName]
	,b.[Barcode]
	,g.Quantity
	
	
	
	FROM [Accounting].[Barcode] b
	left join Accounting.VwGood g on b.Id=g.BarcodeId
	--where g.Quantity >0
GO
PRINT N'Creating [Accounting].[VwDocument]...';


GO
CREATE VIEW [Accounting].[VwDocument]


	AS SELECT 
	 d.[Id]     
	,d.[PaymentTypeId]
	,pt.[Name] PaymentTypeName
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,c.CompanyName
    ,d.[WareHouseId] 
	,wh.[Name] WareHouseName
	,d.[FromWarehouseId]
	

	,whf.[Name] FromWareHouseName
	,d.ContractId
	,co.CustomerId
	,co.CustomerName
	,d.[Description]
	,d.DeleteDate
	,d.DeleteId
	,d.[DocTypeId]
     ,d.[DocCertId]
     ,d.[DocSeriesId]
	,d. [PaymentDate]   
	,d. [PartnerOrderNo]
	,d.[AdditionalCost]
	,d.[MainNumber]
	,d.CashierId
	,cashier.CashierName 
	,d.LockDate
	,d.LockId
	
	FROM [Accounting].[Document] d
	left join [Accounting].[VwCompany] c on d.CompanyId=c.Id
	left join [WareHouses].[VwWareHouse] wh on d.WareHouseId=wh.Id
	left join [WareHouses].[VwWareHouse] whf on d.FromWarehouseId=whf.Id
	left join Accounting.VwContract co on d.ContractId=co.Id 
	left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id
	left join Accounting.[Cashier] cashier on cashier.Id=d.CashierId
GO
PRINT N'Creating [Accounting].[VwDocumentDetailTmp]...';


GO
CREATE VIEW [Accounting].[VwDocumentDetailTmp]
	AS SELECT 
	  ddTemp.[Id] 
	 ,ddTemp.GoodId StoGoodId
	 ,ddTemp.[DocumentTmpId]
	 ,d.ContractId
	 ,c.ContractTypeId
	 ,c.CompanyId
	 ,comp.CompanyName
	 ,c.CustomerId
	 ,cust.CustomerName
	 ,ddTemp.AccountId
	 ,a.ParentId AccountParentId
	 ,a.Code AccountCode
	 ,a.Name AccountName
     ,ddTemp.[GoodId] 
	 ,g. [GoodName]
	 ,ddTemp.BarCodeId
	 ,g.[FullGoodName]
     ,ddTemp.[Series] 
     ,ddTemp.[DateOfProduction] 
     ,ddTemp.[LastExpirationDate] 
     ,ddTemp.[Quantity] 
	 ,ddTemp.[UnitId]
	 ,u.Name UnitName
     ,ddTemp.[PriceBuy] 
     ,ddTemp.[PriceRetail]
     ,ddTemp.[PriceWholeSale] 
     ,ddTemp.[AmountBuy]
     ,ddTemp.[AmountRetail]
     ,ddTemp.[AmountWholeSale]
	 --,ddTemp.[Payment]
	 --,ddTemp.[Deficit]

	
	FROM [Accounting].[DocumentDetailTmp] ddTemp
	left join Accounting.DocumentTmp d on ddTemp.DocumentTmpId=d.Id
	left join Accounting.[Contract] c on c.Id=d.ContractId
	left join [Accounting].[VwGood] g on ddTemp.GoodId=g.Id
	left join [Accounting].[Account] a on ddTemp.AccountId=a.Id
	left join [dbo].[Unit] u on ddTemp.UnitId=u.Id
	left join [Accounting].[Barcode] b on ddTemp.BarcodeId=b.Id
	left join Accounting.Stock sto on ddTemp.Id=sto.GoodId
	left join Accounting.Company comp on d.CompanyId=comp.Id
	left join Accounting.Customer cust on c.CustomerId=cust.Id
GO
PRINT N'Creating [Accounting].[VwRetailSale]...';


GO
CREATE VIEW [Accounting].[VwRetailSale]
	AS SELECT 
	 rs.BarcodeId
	 ,b.Barcode
	 ,dd.[DocumentId]
	 ,dd.AccountId
	 ,a.Name AccountName
     ,dd.[GoodId] 
	 ,dd.[FullGoodName]
     ,dd.[Quantity] 
     ,dd.[PriceRetail]
	 ,dd.[PriceBuy]
	 ,dd.[PriceWholeSale]
	 ,rs.[Percent]
	 ,rs.[DiscountNumber]
	FROM [Accounting].[VwDocumentDetail] dd
	left join Accounting.RetailSale rs on rs.DocumentDetailId=dd.Id
	left join [Accounting].[VwGood] g on dd.GoodId=g.Id
	left join [Accounting].[Account] a on dd.AccountId=a.Id
	left join [dbo].[Unit] u on dd.UnitId=u.Id
	left join [Accounting].[Barcode] b on rs.BarcodeId=b.Id
	left join Accounting.Stock sto on dd.GoodId=sto.GoodId
	where dd.AccountId=8
GO
PRINT N'Creating [Accounting].[VwPayment]...';


GO
CREATE VIEW [Accounting].[VwPayment]
	AS SELECT 
	p.Id
	,p.ExpenseId
	,ex.ExpenseName
	,p.CashId
	,ca.CashName
	,ca.CompanyName
	,p.CashFromId
	,caFrom.CashName CashFromName
    ,p.AccountId,
	a.Name AccountName,
	p.CustomerId,
    p.CustomerWareHouseId,
	p.DocumentId,
	c.CustomerName,
	p.PaymentTypeId,
	pt.Name PaymentTypeName,
	p.Payment,
	p.Deficit,
	p.Paymentdate,

	p.Description,
	p.[Percent],
	p.CreateDate
	FROM Accounting.Payment p
	JOIN Accounting.Customer c ON p.CustomerId=c.Id
	JOIN Accounting.Account a ON a.Id=p.AccountId
	JOIN Accounting.PaymentType pt ON pt.Id=p.PaymentTypeId
	left join WareHouses.WareHouse w on w.Id=p.CustomerWareHouseId
	left join Accounting.VwExpense ex on p.ExpenseId=ex.Id
	left join Accounting.VwCash ca on p.CashId=ca.Id
	left join Accounting.VwCash caFrom on p.CashFromId=caFrom.Id
GO
PRINT N'Creating [Accounting].[VwDeficitGoodStock]...';


GO
CREATE VIEW [Accounting].[VwDeficitGoodStock]
	AS  


	SELECT g.FullGoodName
	,g.GoodName,
SUM(s2.Quantity) Quantity,
s2.Series
,s2.PriceBuy
,s2.PriceWholeSale
,s2.PrcieRetail
 ,s2.WarehouseId
 ,s2.Warehouse
,g.GoodTypeName
,g.Barcode
,g.ManufacturerCompanyName
,g.RegionName
,g.[Description]
,s2.DocumentId 
,d.CustomerName 
,c.ContractTypeId 

FROM Accounting.VwStock s2



join Accounting.VwGood g on s2.GoodId=g.Id
left join Accounting.VwDocument d on s2.DocumentId=d.Id
   
   join Accounting.[Contract] c on c.Id=d.ContractId

where s2.Quantity>0  and ContractTypeId in (1)

 GROUP BY g.FullGoodName,
 g.GoodName,
s2.Series
,s2.PriceBuy
,s2.PriceWholeSale
,s2.PrcieRetail
  ,s2.WarehouseId
 ,s2.Warehouse
,g.GoodTypeName
,g.Barcode
,g.ManufacturerCompanyName
,g.RegionName
,g.[Description]
,s2.DocumentId 
,d.CustomerName  
,c.ContractTypeId
GO
PRINT N'Creating [Accounting].[VwRetailPrint]...';


GO
CREATE VIEW [Accounting].[VwRetailPrint]
	AS SELECT
	pr.DocumentId
	,dd.FullGoodName
	,dd.Quantity
	,dd.PriceRetail
	,dd.AmountRetail
	,pr.Payment
	,pr.Deficit
	,pr.TotalSum
	,pt.[Name] PaymentTypeName
	,pr.[Percent]
	,pr.[DiscountNumber]
	,pr.CreateDate
	,pr.CreateId
	,u.[Name]
	


	FROM Accounting.PaymentRetail pr
join  Accounting.VwDocumentDetail dd ON dd.DocumentId = pr.DocumentId
JOIN Accounting.RetailSale rs ON rs.DocumentDetailId=dd.Id
JOIN Accounting.PaymentType pt ON pt.Id=pr.PaymentTypeId
JOIN dbo.[Principial] u ON u.Id=pr.CreateId
WHERE dd.DocumentId=(SELECT max(dd2.Id) FROM Accounting.Document dd2 WHERE dd2.AccountId=8)
GO
PRINT N'Creating [Accounting].[VwLastPrice]...';


GO
CREATE VIEW [Accounting].[VwLastPrice]
	AS 
	SELECT 
	distinct
	d.FullGoodName,
	s.CreateId,
	s.CreateDate,
    s.PriceBuy, 
    s.PriceRetail, 
    s.PriceWholeSale,
	s.LastPriceBuy,
    s.LastPriceRetail, 
    s.LastPriceWholeSale,
	s.Description
	
	FROM [Accounting].[LastPrice] s
	JOIN Accounting.VwDocumentDetail d ON d.GoodId=s.GoodId
GO
PRINT N'Creating [Accounting].[VwBarcodeSelect]...';


GO
CREATE VIEW [Accounting].[VwBarcodeSelect]
	AS 
	SELECT 
	 b.[Id]
	,b.[GoodId]
	,g.[FullGoodName]
	,b.[Barcode]
	,g.Quantity 
	
	
	
	FROM [Accounting].[Barcode] b
	left join Accounting.VwGood g on b.Id=g.BarcodeId
	where g.Quantity >0
GO
PRINT N'Creating [Accounting].[VwRetailReceipt]...';


GO
CREATE VIEW [Accounting].[VwRetailReceipt]
	AS SELECT
	 rr.Id
	 ,rr.GoodId
	 ,g.FullGoodName
	 ,g.Barcode
	 ,rr.BarcodeId
	 ,rr.Quantity
	 ,rr.StatusId
	 ,s.StatusName
	 ,rr.CreateId
	 ,rr.CreateDate,
	 rr.InfoJson 
	 
	
	
	 FROM [Accounting].[RetailReceipt] rr
	 join Accounting.VwGood g on g.Id=rr.GoodId
	 join Accounting.[ReceiptsStatus] s ON s.Id=rr.StatusId
GO
PRINT N'Creating [Accounting].[VwGoodStockSelectReturn]...';


GO
 

create VIEW [Accounting].[VwGoodStockSelectReturn]
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
	WHERE  sto.Quantity>=0   
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
PRINT N'Creating [Accounting].[VwGoodStockSelect]...';


GO
 

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
PRINT N'Creating [Accounting].[VwOfflineSaleDetail]...';


GO
CREATE VIEW [Accounting].[VwOfflineSaleDetail]
	AS SELECT
	
	 ld.[Id]  
	,ld.[BarcodeId]   
	,ld.[LogisticId]  
    ,ld.[GoodId]  
	,ld.[PriceWholeSale] 
	,ld.[AmountWholeSale]
	,g.Id LogGoodId
	,g.FullGoodName
	,ld.[Quantity]  
	,ld.[UnitId]  
	,u.Name 
	,ld.[Description]  
	,ld.[Percent] 
	FROM [Accounting].[OfflineSaleDetail] ld


	left join [Accounting].[VwGood] g on ld.GoodId=g.Id 
	left join [dbo].[Unit] u on ld.UnitId=u.Id
GO
PRINT N'Creating [Accounting].[VwLogisticDetail]...';


GO
CREATE VIEW [Accounting].[VwLogisticDetail]
	AS SELECT
	
	 ld.[Id]  
	,ld.[BarcodeId]   
	,ld.[LogisticId]  
    ,ld.[GoodId]  
	,g.Id LogGoodId
	,g.FullGoodName
	,ld.[Quantity]  
	,ld.[UnitId]  
	,u.Name
	,ld.[Description]  
	FROM [Accounting].[LogisticDetail] ld


	left join [Accounting].[VwGood] g on ld.GoodId=g.Id 
	left join [dbo].[Unit] u on ld.UnitId=u.Id
GO
PRINT N'Creating [Accounting].[VwGoodAction]...';


GO
CREATE view  Accounting.VwGoodAction as select 
 dd.Id
, dd.FullGoodName
, dd.AccountName
, dd.DocumentId
, dd.Quantity
, SUM(case when dd.AccountParentId in (2) then -1 else 1 end * dd.Quantity) OVER (PARTITION BY dd.GoodId ORDER BY dd.Id) AS SumNow
, dd.PriceBuy
, dd.PriceRetail
, dd.PriceWholeSale
, dd.AmountBuy
, dd.AmountRetail
, dd.AmountWholeSale
, dd.Payment
, dd.Deficit
, ISNULL(dd.CostDeficit, 0)  AS CostDeficit					 
, ISNULL(dd.DiscountPrice, 0) AS DiscountPrice
, ddt.CreateDate
, ddt.CreateId
 , SUM(s.Quantity) AS StockQuantity
  ,pr.Name as UserName



FROM      Accounting.VwDocumentDetail AS dd LEFT OUTER JOIN
          Accounting.Stock AS s ON dd.GoodId = s.GoodId LEFT OUTER JOIN
          Accounting.DocumentDetail AS ddt ON ddt.DocumentId = dd.Id LEFT OUTER JOIN
          dbo.Principial AS pr ON pr.Id = ddt.CreateId

		  

GROUP BY dd.Id
,dd.GoodId
,dd.AccountParentId
, dd.FullGoodName
, dd.AccountName
, dd.DocumentId
, dd.Quantity
, dd.PriceBuy
, dd.PriceRetail
, dd.PriceWholeSale
, dd.AmountBuy
, dd.AmountRetail
, dd.AmountWholeSale
, dd.Payment
, dd.Deficit
, ISNULL(dd.CostDeficit, 0)
,  ISNULL(dd.DiscountPrice, 0)
, ddt.CreateDate
, ddt.CreateId
 ,pr.Name
GO
PRINT N'Creating [Accounting].[VwWholeSaleReport]...';


GO
create VIEW [Accounting].[VwWholeSaleReport]
	AS select
DD.GoodName
,dd.Quantity 
,dd.PriceWholeSale
,dd.AmountWholeSale
,dd.DocumentId
,d.CustomerName
,d.IncludeDate


 from Accounting.VwDocumentDetail dd

 left join Accounting.ContractType ct on ct.Id=dd.ContractTypeId 
 left join Accounting.VwDocument d on dd.DocumentId=d.Id

 where ContractTypeId=2
GO
PRINT N'Creating [Accounting].[VwIncludeReport]...';


GO
CREATE VIEW [Accounting].[VwIncludeReport]
	AS select
DD.GoodName
,dd.Quantity
,dd.PriceBuy  
,dd.AmountBuy
,dd.DocumentId

,d.CustomerName
,d.IncludeDate
,d.WareHouseId
,d.WareHouseName


 from Accounting.VwDocumentDetail dd

 left join Accounting.ContractType ct on ct.Id=dd.ContractTypeId 
 left join Accounting.VwDocument d on dd.DocumentId=d.Id

 where ContractTypeId=1
GO
PRINT N'Creating [Accounting].[VwGoodStock]...';


GO
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
GO
PRINT N'Creating [Accounting].[VwRetailReceiptHistory]...';


GO
CREATE VIEW [Accounting].[VwRetailReceiptHistory]
	AS select
	ROW_NUMBER() OVER(ORDER BY CreateId) RowNo
	,CreateId
	 
	,CreateDate
	,StatusName
	,InfoJson  
	,CashierName
	  
	from (SELECT distinct 
CreateId
,CreateDate
,StatusName
,InfoJson  
,[Name] CashierName
 
  FROM [Accounting].[VwRetailReceipt] rr 

    join dbo.[Principial]  p on p.Id=rr.CreateId
  

  where rr.CreateDate >=CAST(GETDATE() as date) 
) x
GO
PRINT N'Creating [Accounting].[SFnGetGoodPriceWholeSale]...';


GO
CREATE FUNCTION [Accounting].[SFnGetGoodPriceWholeSale]
(
	@id int
)
RETURNS decimal(26,6)
AS
BEGIN
	RETURN 
	(
		select top (1) PriceWholeSale from Accounting.DocumentDetail d where GoodId=@id AND AccountId=3 and DeleteId is NULL
		order by d.CreateDate desc
	)
END
GO
PRINT N'Creating [Accounting].[SFnAccountIdByCode]...';


GO
CREATE FUNCTION [Accounting].[SFnAccountIdByCode]
(
	@code varchar(40)
	)
RETURNS INT
AS
BEGIN
	RETURN (SELECT Id FROM [Accounting].[Account] where code=@code)
END
GO
PRINT N'Creating [Accounting].[SFnGetGoodPriceRetailSale]...';


GO
CREATE FUNCTION [Accounting].[SFnGetGoodPriceRetailSale]
(
	@id int
)
RETURNS decimal(26,6)
AS
BEGIN
	RETURN 
	(
		select top (1) PriceRetail from Accounting.DocumentDetail d where GoodId=@id AND AccountId=3 and DeleteId is null
		order by d.CreateDate desc
	)
END
GO
PRINT N'Creating [Accounting].[SFnNewSaleNo]...';


GO
CREATE FUNCTION [Accounting].[SFnNewSaleNo]
(
	@userId int,
	@accountCode varchar(40)
)
RETURNS int
AS
BEGIN

  if @accountCode is null 
	return null;

  RETURN 
  isnull((SELECT max(dd.SaleNo) FROM [Accounting].[DocumentDetail] dd
  where CreateId=@userId
  and AccountId=[Accounting].[SFnAccountIdByCode]('2.2')
  and CreateDate>=cast(getdate() as date)),0)+1;

END
GO
PRINT N'Creating [dbo].[fnSysGroupId]...';


GO
CREATE FUNCTION [dbo].[fnSysGroupId]
(
	@name nvarchar(200)
)
RETURNS INT
AS
BEGIN
	RETURN (select Id from dbo.Principial where [Name]=@name and IsGroup=1)
END
GO
PRINT N'Creating [dbo].[fnSysUserId]...';


GO
CREATE FUNCTION [dbo].[fnSysUserId]
(
	@name nvarchar(200)
)
RETURNS INT
AS
BEGIN
	RETURN (select Id from dbo.Principial where [Name]=@name and IsMember=1)
END
GO
PRINT N'Creating [dbo].[SFnCurrencyBuyAzn]...';


GO
CREATE FUNCTION [dbo].[SFnCurrencyBuyAzn]
(
	@currencyId int,
	@value decimal(26,6)
)
RETURNS decimal(26,6)
AS
BEGIN
	RETURN (select @value*Buy from [Accounting].[Currency] where id=@currencyId)
END
GO
PRINT N'Creating [dbo].[SFnCurrencySellAzn]...';


GO
CREATE FUNCTION [dbo].[SFnCurrencySellAzn]
(
	@currencyId int,
	@value decimal(26,6)
)
RETURNS decimal(26,6)
AS
BEGIN
	RETURN (select @value*Sell from [Accounting].[Currency] where id=@currencyId)
END
GO
PRINT N'Creating [Accounting].[IFnIncludeGood]...';


GO
CREATE FUNCTION [Accounting].[IFnIncludeGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.VwDocumentDetail where DocumentId=@id
)
GO
PRINT N'Creating [Accounting].[IFnPricesByGoodId]...';


GO
CREATE FUNCTION [Accounting].[IFnPricesByGoodId]
(
	@id int
)
RETURNS TABLE
AS
return (
select 


--isnull  (PriceBuy,0)
PriceBuy


,PriceRetail,PriceWholeSale,AmountBuy,AmountRetail,AmountWholeSale ,Payment,Deficit
	from Accounting.DocumentDetail  where id=(select max(Id)  from Accounting.DocumentDetail where GoodId=@id AND AccountId=3 and DeleteId is null)
)
GO
PRINT N'Creating [Accounting].[IFnBarcodeGood]...';


GO
CREATE FUNCTION [Accounting].[IFnBarcodeGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.Barcode where Id=@id
)
GO
PRINT N'Creating [Accounting].[IFnContractCustomer]...';


GO
CREATE FUNCTION [Accounting].[IFnContractCustomer]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  [Accounting].[Contract]  where CustomerId=@id
)
GO
PRINT N'Creating [Accounting].[IFnReturnRetailSaleGood]...';


GO
CREATE FUNCTION [Accounting].[IFnReturnRetailSaleGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.VwDocumentDetail where DocumentId=@id
)
GO
PRINT N'Creating [Accounting].[IFnReturnSaleGood]...';


GO
CREATE FUNCTION [Accounting].[IFnReturnSaleGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.VwDocumentDetail where DocumentId=@id
)
GO
PRINT N'Creating [Accounting].[IFnSaleGood]...';


GO
CREATE FUNCTION [Accounting].[IFnSaleGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.VwDocumentDetail where DocumentId=@id
)
GO
PRINT N'Creating [Accounting].[IFnDocumentDetailReport]...';


GO
CREATE FUNCTION [Accounting].[IFnDocumentDetailReport]
(
	@documentId int
	
)
RETURNS TABLE AS RETURN
(
	
	
	SELECT  dd.[Id]  
	 ,dd.[DocumentId] 
	 ,d.ContractId
	 ,c.ContractTypeId
	 ,c.CompanyId
	 ,comp.CompanyName
	 ,c.CustomerId
	 ,cust.CustomerName
	 

	 ,d.PaymentTypeId
	 ,pt.Name PaymentTypeName

	 ,dd.AccountId
	 ,a.ParentId AccountParentId
	 ,a.Code AccountCode
	 ,a.Name AccountName
     ,dd.[GoodId] 
	 ,g. [GoodName] 
	 ,dd.BarCodeId
	 
	 ,g.[FullGoodName]
     ,dd.[Series] 
     ,dd.[DateOfProduction] 
     ,dd.[LastExpirationDate] 
     ,dd.[Quantity] 
	 ,dd.[UnitId]
	 ,u.Name UnitName
     ,dd.[PriceBuy] 
     ,dd.[PriceRetail]
     ,dd.[PriceWholeSale] 
     ,dd.[AmountBuy]
     ,dd.[AmountRetail]
     ,dd.[AmountWholeSale]
	 ,dd.[Percent]
	 ,dd.[CostInclude]
	 ,dd.[CostDeficit]
	 ,dd.DiscountPrice
	
	FROM [Accounting].[DocumentDetail] dd
	left join Accounting.Document d on dd.DocumentId=d.Id
	left join Accounting.[Contract] c on c.Id=d.ContractId
	left join [Accounting].[VwGood] g on dd.GoodId=g.Id
	left join [Accounting].[Account] a on dd.AccountId=a.Id
	left join [dbo].[Unit] u on dd.UnitId=u.Id
	left join [Accounting].[Barcode] b on dd.BarcodeId=b.Id
	left join Accounting.Company comp on d.CompanyId=comp.Id
	left join Accounting.Customer cust on c.CustomerId=cust.Id
	left join Accounting.PaymentType pt on d.PaymentTypeId=pt.Id 
	
	WHERE DocumentId=@documentId and d.DeleteId is null
)
GO
PRINT N'Creating [Accounting].[IFnBuyPricesByGoodId]...';


GO
 --CREATE FUNCTION [Accounting].[SFnGetGoodPriceInclude]
--(
--	@id int
--)
--RETURNS decimal(26,6)
--AS
--BEGIN
--	RETURN 
--	(
--		select top (1) PriceBuy from Accounting.DocumentDetail d where GoodId=@id
--		order by d.CreateDate desc
--	)
--END



CREATE FUNCTION [Accounting].[IFnBuyPricesByGoodId]
(
	@id int
)
RETURNS TABLE
AS
return (
select PriceBuy,PriceRetail,PriceWholeSale,AmountBuy,AmountRetail,AmountWholeSale ,Payment,Deficit
	from Accounting.DocumentDetail  WHERE id=(select max(Id)  from Accounting.DocumentDetail where GoodId=@id AND AccountId=3 and DeleteId is null)
)
GO
PRINT N'Creating [Accounting].[IFnDeleteGood]...';


GO
CREATE FUNCTION [Accounting].[IFnDeleteGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.VwDocumentDetail where DocumentId=@id
)
GO
PRINT N'Creating [Accounting].[IFnRetailsSaleGood]...';


GO
CREATE FUNCTION [Accounting].[IFnRetailsSaleGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  Accounting.VwDocumentDetail where DocumentId=@id
)
GO
PRINT N'Creating [Accounting].[IFnImageGood]...';


GO
CREATE FUNCTION [Accounting].[IFnImageGood]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  [Accounting].[ImagesGood]  where GoodId=@id
)
GO
PRINT N'Creating [Accounting].[IFnLogisticDetailReport]...';


GO
CREATE FUNCTION [Accounting].[IFnLogisticDetailReport]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT
	
	ld.[BarcodeId]   
	,ld.[LogisticId]  
    ,ld.[GoodId]  
	,g.FullGoodName
	,ld.[Quantity]  
	,ld.[UnitId]  
	,u.Name
	,ld.[Description]  
	FROM [Accounting].[LogisticDetail] ld


	left join [Accounting].[VwGood] g on ld.GoodId=g.Id 
	left join [dbo].[Unit] u on ld.UnitId=u.Id 
 where LogisticId=@id
)
GO
PRINT N'Creating [Accounting].[IFnLogisticDetail]...';


GO
CREATE FUNCTION [Accounting].[IFnLogisticDetail]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  [Accounting].[LogisticDetail]  where LogisticId=@id
)
GO
PRINT N'Creating [Accounting].[IFnOfflineSaleDetail]...';


GO
CREATE FUNCTION [Accounting].[IFnOfflineSaleDetail]
(
	@id int 
	
)
RETURNS TABLE AS RETURN
(
	SELECT * from  [Accounting].[OfflineSaleDetail]  where LogisticId=@id
)
GO
PRINT N'Creating [dbo].[fnGetAccess]...';


GO
CREATE FUNCTION [dbo].[fnGetAccess](@userId int,@managerId int)
RETURNS TABLE 
AS
RETURN 
(
  select cast(case when  ma.Show is null then 0 else ma.Show end as bit)  AllowShow
	  ,cast(case when  ma.[Create] is null then 0 else ma.[Create] end as bit)  AllowCreate
	  ,cast(case when  ma.[Update] is null then 0 else ma.[Update] end as bit)  AllowUpdate
	  ,cast(case when  ma.[Delete] is null then 0 else ma.[Delete] end as bit)  AllowDelete
	  ,cast(case when  ma.[ApplyDocument] is null then 0 else ma.[ApplyDocument] end as bit)  AllowApplyDocument
	  ,cast(case when  ma.[ShowCreate] is null then 0 else ma.[ShowCreate] end as bit)  [ShowCreate]
	  ,cast(case when  ma.[ShowUpdate] is null then 0 else ma.[ShowUpdate] end as bit)  [ShowUpdate]
	  ,cast(case when  ma.[ShowDelete] is null then 0 else ma.[ShowDelete] end as bit)  [ShowDelete]
	  ,cast(case when  ma.[ShowApplyDocument] is null then 0 else ma.[ShowApplyDocument] end as bit)  [ShowApplyDocument]
      from [dbo].[MenuUserAccess] ma where UserId=@userId and MenuItemId=@managerId
)
GO
PRINT N'Creating [Accounting].[spGoodType]...';


GO
CREATE PROCEDURE [Accounting].[spGoodType]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [Accounting].[GoodType]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].[GoodType]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[GoodType]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [Accounting].[VwGoodType]
RETURN 0
end
GO
PRINT N'Creating [Accounting].[spCurrencyAuto]...';


GO
CREATE PROCEDURE [Accounting].[spCurrencyAuto]
	@userId int,
	@operation tinyint,
	@input [Accounting].[UdttCurrency] readonly
AS
begin

if @operation=1
begin
  SELECT [Id],[Name],[Buy],[Sell]
  FROM [Accounting].[Currency]
  where isnull(IsActive,1) =1
  and (RefreshDate is null or  RefreshDate < cast(getdate() as date))
  and Id<>1
end
else
begin
  update c set Buy=i.Buy,Sell=i.Sell,RefreshDate=GETDATE(),CreateUserId=@userId
  from [Accounting].[Currency] c
  join @input i on i.Id=c.Id
  where c.Sell<>i.Sell or c.Buy<>i.Buy
end

return 0;
end
GO
PRINT N'Creating [Accounting].[spReason]...';


GO
CREATE PROCEDURE [Accounting].[spReason]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [Accounting].[Reason]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].[Reason]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[Reason]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [Accounting].[VwReason]
RETURN 0
end
GO
PRINT N'Creating [Accounting].[spAccount]...';


GO
CREATE PROCEDURE [Accounting].[spAccount]
@userId int,
@operationType tinyint,
@parentId int=null,
@code varchar(40) =null,
@name nvarchar(200)=null,
@description nvarchar(500)=null,
@isActive bit=null,
@id int=null
with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [Accounting].[Account]([ParentId],[Code],[Name],[Description])
values(@parentId,@code,@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].[Account]
set
[ParentId]=@parentId,
[Code]=case when @code is null then [Code] else @code end,
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[Account]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [Accounting].[VwAccount]
RETURN 0
end
GO
PRINT N'Creating [Accounting].[spContractType]...';


GO
CREATE PROCEDURE [Accounting].[spContractType]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [Accounting].[ContractType]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].[ContractType]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[ContractType]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [Accounting].[VwContractType]
RETURN 0
end
GO
PRINT N'Creating [Accounting].[spDocumentSale]...';


GO

create proCEDURE [Accounting].[spDocumentSale]
	@userId int ,
	@operationType tinyint = null,
	@id INT = NULL,
	@menuId INT,
	@paymentid int =null,
	@includeDate DATETIME=NULL,
	@paymentDate datetime=null,
    @partnerOrderNo nvarchar(200)=null,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
    @description nvarchar(500)=null,
	@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
	@cashierId int=null,
	@accountCode varchar(40)=null, 
    
	@detail [Accounting].[UddtSaleGood] readonly
	

--with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spedit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;
else if @operationType  in (5,15)
goto spLock;


spAdd:
begin
begin tran 

if exists(select * from @detail d
join Accounting.VwGoodStock st with(rowlock,holdlock) on d.GoodId=st.Id
where ISNULL(st.quantity,0) - d.Quantity<0 AND st.WarehouseId=@wareHouseId)
begin
raiserror('Stokda kifayet qeder mehsul yoxdur',16,1)
rollback
return
end
else 
begin



INSERT INTO [Accounting].[Document]( [IncludeDate],[PaymentDate],[PartnerOrderNo],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],[ContractId],[CashierId],[SaleNo],Accounting.Document.CreateId,AccountId)
VALUES (@includeDate,@paymentDate,@partnerOrderNo,@companyId,@wareHouseId,@description,@paymentTypeId,@contractId,@cashierId,[Accounting].[SFnNewSaleNo](@userId,@accountCode),@userId,7)

SET @id=SCOPE_IDENTITY();

DECLARE @totalAmount DECIMAL(26,6)=0,@accountId  INT,@payment DECIMAL(26,6),@amountWholeSale DECIMAL(26,6),@goodId INT,@barcodeId INT,@series nvarchar(200),@dateOfProduction datetime,@lastExpirationDate DATETIME
,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6),@totalPayment DECIMAL(26,6)=0, @percent nvarchar(50) , 
@costInclude decimal (26,6),@costDeficit decimal (26,6),@discountPrice decimal(26,6)
DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountWholeSale],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale], ISNULL([Percent]+' % Endirim','0')
 ,ISNULL([CostInclude] ,'0' ) ,ISNULL([CostDeficit] ,'0' ), ISNULL([DiscountPrice] ,'0' )
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent
 ,@costInclude,@costDeficit,@discountPrice
WHILE @@FETCH_STATUS=0
BEGIN

--INSERT INTO Accounting.Payment (AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
--VALUES(@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@amountWholeSale)

--SELECT AccountId,@customerId,ISNULL(Payment,0) [Payment],[AmountBuy][Deficit] FROM @detail


--INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit])
--values(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy,@quantity*@priceRetail,@quantity*@priceWholeSale,@payment, @amountWholeSale)


DECLARE @q1 decimal(25,5),@stockId INT,@t3 DECIMAL(25,5)=0,@Tquantity DECIMAL(25,5)=0,@TpriceBuy DECIMAL(26,6)=0,@TpriceRetail DECIMAL(26,6)=0,@TpriceWholeSale DECIMAL(26,6)=0
 ,@count int=0
DECLARE css CURSOR FOR (SELECT s.Quantity,s.Id FROM Accounting.Stock s WHERE s.GoodId=@goodId and s.Quantity>0 AND s.WarehouseId=@wareHouseId AND UpdateId IS null)
OPEN css
FETCH NEXT FROM css INTO @q1,@stockId
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @p1 decimal(25,5),@p2 decimal(25,5),@p3 decimal(25,5),@ff Decimal (25,2)


SET @p1=(
    SELECT s.PriceBuy FROM Accounting.Stock s 
WHERE s.Id=@stockId AND WarehouseId=@wareHouseId)

SET @p2=(
    SELECT s.PrcieRetail FROM Accounting.Stock s 
WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId AND WarehouseId=@wareHouseId) )

SET @p3=(
    SELECT s.PriceWholeSale FROM Accounting.Stock s 
WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId AND WarehouseId=@wareHouseId) )

IF(@t3 IS NOT NULL)
BEGIN
set @count=@count + 1
IF(@q1<@quantity AND @t3=0)

BEGIN

 set @t3=@quantity-@q1
 SET @ff=(@q1*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId

   set @TQuantity=@Tquantity+@q1
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3


END

ELSE IF(@q1<@quantity AND @t3>@q1)
BEGIN

 set @t3=@t3-@q1
 SET @ff=(@q1*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId
 
 set @TQuantity=@Tquantity+@q1
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3

END

ELSE IF(@q1<@quantity AND @t3<=@q1)
BEGIN
SET @ff=(@t3*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

   SET @TQuantity=@Tquantity+@t3
   SET @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   SET @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3


 SET @t3=NULL
END

ELSE IF(@q1>=@quantity AND @t3>0)
BEGIN
SET @ff=(@t3*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

   SET @TQuantity=@Tquantity+@t3
   SET @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   SET @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3


 SET @t3=NULL
END

ELSE

BEGIN
      UPDATE Accounting.Stock
SET 
   Quantity =  @q1-@quantity WHERE GoodId=@goodId AND Id=@stockId 
   SET @TQuantity=@Tquantity+@quantity
   SET @TpriceBuy = (@TpriceBuy + @p1)
   SET @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3

  SET @t3=NULL



  
END
END



FETCH NEXT FROM css INTO @q1,@stockId
SET @totalAmount=@totalAmount+(@TQuantity*(@TpriceWholeSale-@discountPrice))
   END
CLOSE css
DEALLOCATE css


   INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId]
   
   
   
   
   
   
   
 ,[PriceBuy]
 ,[PriceRetail]
 ,[PriceWholeSale]
 ,[AmountBuy]
 ,[AmountRetail]
 ,[AmountWholeSale]
 ,[Payment]
 ,[Deficit]
 ,[Percent]
 ,[CostInclude]
 ,[CostDeficit]
 ,[DiscountPrice]
 ,[CreateId]
 ,[CreateDate])


VALUES(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@TQuantity,@unitId




,@TpriceBuy
,@TpriceRetail
,@TpriceWholeSale -@discountPrice
,@TQuantity*@TpriceBuy
,@TQuantity*@TpriceRetail
, @TQuantity*(@TpriceWholeSale -@discountPrice)
,@payment
, @TQuantity*(@TpriceWholeSale -@discountPrice)
,@percent 
,@costInclude
,@costDeficit
,@discountPrice   
,@userId,getdate())







FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent
 ,@costInclude,@costDeficit,@discountPrice
end

close crs
deallocate crs
END
INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
VALUES(@id,@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@totalAmount)
SET @paymentid=SCOPE_IDENTITY();
 

if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end
spEdit:
begin
update [Accounting].[Document]
set 





[IncludeDate]=@includeDate,
[CompanyId]=@companyId,
[WareHouseId]=@wareHouseId,
[Description]=@description,
[PaymentTypeId]=@paymentTypeId,
[ContractId]=@contractId,
[PartnerOrderNo]=@partnerOrderNo,
[PaymentDate]=@paymentDate,
[CashierId]=@cashierId,
[UpdateId]=@userId,
[UpdateDate]=getdate()

where Id=@id;
--------------------------
UPDATE Accounting.CustomerDebt 
SET 

 --AccountId=@accountId
--,
CustomerId=@customerId
--,PaymentTypeId=@paymentTypeId
--,Payment=@payment
,Deficit=@totalPayment
--,UpdateId=@userId
,UpdateDate=getdate()
 WHERE Id=@id
 ----------------------
--------------  Stock -------------

;with chck as (
select d.GoodId,sum(d.Quantity-isnull(dd.Quantity,0)) Quantity from @detail d 
left join [Accounting].[DocumentDetail] dd on d.Id=dd.Id
group by d.GoodId
)


merge [Accounting].[Stock] target
using (select [GoodId] ,Quantity  from chck)source  on target.GoodId=source.GoodId
when Matched then
update set [Quantity]=target.Quantity-source.[Quantity]
when not matched by target then insert ([GoodId],[Quantity]) values(source.GoodId,source.Quantity);
----------------------

--merge Accounting.Payment target 
--using (select CustomerId)


--------
merge [Accounting].[DocumentDetail] target
using (select [Id],[GoodId],@id [DocumentId],[AccountId],[BarCodeId],[Series],[DateOfProduction]
,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
,[Quantity]*[PriceBuy] [AmountBuy],[Quantity]*[PriceRetail] [AmountRetail]
,[Quantity]*[PriceWholeSale] [AmountWholeSale],ISNULL([Payment],0) [Payment],[AmountWholeSale] [Deficit]
from @detail) source on target.Id=source.Id
when MATCHED and target.DocumentId=@id THEN 


update set [AccountId]=source.[AccountId]
,[BarCodeId]=source.[BarCodeId]
,[Series]=source.[Series]
,[DateOfProduction]=source.[DateOfProduction]
,[LastExpirationDate]=source.[LastExpirationDate]
,[Quantity]=source.[Quantity]
,[UnitId]=source.[UnitId]
,[PriceBuy]=source.[PriceBuy]
,[PriceRetail]=source.[PriceRetail]
,[PriceWholeSale]=source.[PriceWholeSale]
,[AmountBuy]=source.[AmountBuy]
,[AmountRetail]=source.[AmountRetail]
,[AmountWholeSale]=source.[AmountWholeSale]
,[Payment]=isnull(target.[Payment],0)
,[Deficit]=source.[AmountWholeSale]
,[UpdateDate]=getdate()
,[UpdateId]=@userid


when NOT MATCHED BY target then 
insert  ( [DocumentId] ,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction]
,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy]
,[AmountRetail],[AmountWholeSale],[Payment],[Deficit])
values (@id,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate]
,[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[Quantity]*[PriceBuy]
, [Quantity] * [PriceRetail] ,[Quantity]*[PriceWholeSale] ,isnull([Payment],0),[AmountWholeSale])

when NOT MATCHED BY source and target.DocumentId=@Id then update set [DeleteId]=@userId
,[DeleteDate]=getdate();

if @@TRANCOUNT>0
   commit;
if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
DECLARE @totalAmount1 DECIMAL(26,6)=0,@payment1 DECIMAL(26,6),@amountBuy1 DECIMAL(26,6),@goodId1 INT,@barcodeId1 INT,@series1 NVARCHAR(200),@dateOfProduction1 DATETIME,@lastExpirationDate1 DATETIME
,@quantity1 DECIMAL(26,6),@unitId1 INT,@priceBuy1 DECIMAL(26,6),@priceRetail1 DECIMAL(26,6),@priceWholeSale1 DECIMAL(26,6)
DECLARE crs CURSOR FOR 
(SELECT ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)
OPEN crs
FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1 
,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1
WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount1=@totalAmount1+@amountBuy1
INSERT INTO Accounting.Stock (GoodId,CreatId,CreateDate,WarehouseId,DocumentId,Quantity,PriceBuy,PrcieRetail,PriceWholeSale) VALUES (@goodId1,@userId,GETDATE(),@wareHouseId,@id,@quantity1,@priceBuy1,@priceRetail1,@priceWholeSale1)
FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1
END
CLOSE crs
DEALLOCATE crs
DELETE FROM Accounting.Payment WHERE DocumentId=@id
UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id
update [Accounting].[Document]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where Id=@id;
if @operationType=13 goto spSelect;
RETURN 0
end

spLock:
begin
update [Accounting].[Document]
set
[LockId]=@userId,
[LockDate]=getdate()
where [DeleteId] IS NULL AND [LockId] IS NULL AND Id=@id;

if @operationType=15 goto spSelect;
RETURN 0
end

spSelect:
select  d.[Id]  
    ,d.[IncludeDate]  
	,d.[PaymentDate]
	,d.[PartnerOrderNo]
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[AdditionalCost]
	,d.CashierId
	,d.CashierName 
	,D.[DeleteId]  
	,D.[DeleteDate]  
	,D.[LockId]  
	,D.[LockDate]   
	,D.[DocTypeId]  
	,D.[DocCertId]  
	,D.[DocSeriesId]   
         ,sum(dd.AmountBuy) AmountBuy
         ,sum(dd.AmountRetail) AmountRetail
         ,sum(dd.AmountWholeSale) AmountWholeSale
		 ,sum(dd.PriceBuy) PriceBuy
		 ,sum(dd.PriceRetail) PriceRetail
		 ,sum(dd.PriceWholeSale) PriceWholeSale 
	     ,sum(dd.Payment) Payment
	     ,sum(dd.Deficit) Deficit
		 ,sum(dd.DiscountPrice) DiscountPrice

from [Accounting].[VwDocument] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
 left join [Accounting].[VwContract] c on c.id=d.ContractId
 JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
 where AccountId=7 and d.DeleteId is null
 group by 
     d.[Id]  
    ,d.[IncludeDate]  
	,d.[PaymentDate]
	,d.[PartnerOrderNo]
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[AdditionalCost]
	,d.CashierId
	,d.CashierName
	
	,D.[DeleteId]  
	,D.[DeleteDate]  
	,D.[LockId]  
	,D.[LockDate] 
    ,d.[DocTypeId]
    ,d.[DocCertId]
    ,d.[DocSeriesId];
 RETURN 0
end
--create proCEDURE [Accounting].[spDocumentSale]
--	@userId int ,
--	@operationType tinyint = null,
--	@id INT = NULL,
--	@menuId INT,
--	@paymentid int =null,
--	@includeDate DATETIME=NULL,
--	@paymentDate datetime=null,
--    @partnerOrderNo nvarchar(200)=null,
--	@companyId INT=NULL,
--	@wareHouseId INT=NULL,
--    @description nvarchar(500)=null,
--	@paymentTypeId int=null,
--	@contractId int =null,
--	@customerId int=null,
--	@cashierId int=null,
--	@accountCode varchar(40)=null, 
    
--	@detail [Accounting].[UddtSaleGood] readonly
	

----with encryption
--AS

--begin
--if @operationType in (1,11)
--goto spAdd;
----else if @operationType in (2,12)
----goto spedit;
--else if @operationType in (3,13)
--goto spDelete;
--else if @operationType =4
--goto spSelect;


--spAdd:
--begin
--begin tran 

--if exists(select * from @detail d
--join Accounting.VwGoodStock st with(rowlock,holdlock) on d.GoodId=st.Id
--where ISNULL(st.quantity,0) - d.Quantity<0 AND st.WarehouseId=@wareHouseId)
--begin
--raiserror('Stokda kifayet qeder mehsul yoxdur',16,1)
--rollback
--return
--end
--else 
--begin



--INSERT INTO [Accounting].[Document]( [IncludeDate],[PaymentDate],[PartnerOrderNo],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],[ContractId],[CashierId],[SaleNo],Accounting.Document.CreateId,AccountId)
--VALUES (@includeDate,@paymentDate,@partnerOrderNo,@companyId,@wareHouseId,@description,@paymentTypeId,@contractId,@cashierId,[Accounting].[SFnNewSaleNo](@userId,@accountCode),@userId,7)

--SET @id=SCOPE_IDENTITY();

--DECLARE @totalAmount DECIMAL(26,6)=0,@accountId  INT,@payment DECIMAL(26,6),@amountWholeSale DECIMAL(26,6),@goodId INT,@barcodeId INT,@series nvarchar(200),@dateOfProduction datetime,@lastExpirationDate DATETIME
--,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6),@totalPayment DECIMAL(26,6)=0, @percent nvarchar(50) , 
--@costInclude decimal (26,6),@costDeficit decimal (26,6),@discountPrice decimal(26,6)
--DECLARE crs CURSOR FOR 
--(SELECT AccountId,ISNULL(Payment,0),[AmountWholeSale],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
--[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale], ISNULL([Percent]+' % Endirim','0')
-- ,ISNULL([CostInclude] ,'0' ) ,ISNULL([CostDeficit] ,'0' ), ISNULL([DiscountPrice] ,'0' )
--FROM @detail)
--OPEN crs
--FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
--,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent
-- ,@costInclude,@costDeficit,@discountPrice
--WHILE @@FETCH_STATUS=0
--BEGIN

----INSERT INTO Accounting.Payment (AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
----VALUES(@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@amountWholeSale)

----SELECT AccountId,@customerId,ISNULL(Payment,0) [Payment],[AmountBuy][Deficit] FROM @detail


----INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit])
----values(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy,@quantity*@priceRetail,@quantity*@priceWholeSale,@payment, @amountWholeSale)


--DECLARE @q1 decimal(25,5),@stockId INT,@t3 DECIMAL(25,5)=0,@Tquantity DECIMAL(25,5)=0,@TpriceBuy DECIMAL(26,6)=0,@TpriceRetail DECIMAL(26,6)=0,@TpriceWholeSale DECIMAL(26,6)=0
-- ,@count int=0
--DECLARE css CURSOR FOR (SELECT s.Quantity,s.Id FROM Accounting.Stock s WHERE s.GoodId=@goodId and s.Quantity>0 AND s.WarehouseId=@wareHouseId AND UpdateId IS null)
--OPEN css
--FETCH NEXT FROM css INTO @q1,@stockId
--WHILE @@FETCH_STATUS=0
--BEGIN
--DECLARE @p1 decimal(25,5),@p2 decimal(25,5),@p3 decimal(25,5),@ff Decimal (25,2)


--SET @p1=(
--    SELECT s.PriceBuy FROM Accounting.Stock s 
--WHERE s.Id=@stockId AND WarehouseId=@wareHouseId)

--SET @p2=(
--    SELECT s.PrcieRetail FROM Accounting.Stock s 
--WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId AND WarehouseId=@wareHouseId) )

--SET @p3=(
--    SELECT s.PriceWholeSale FROM Accounting.Stock s 
--WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId AND WarehouseId=@wareHouseId) )

--IF(@t3 IS NOT NULL)
--BEGIN
--set @count=@count + 1
--IF(@q1<@quantity AND @t3=0)

--BEGIN

-- set @t3=@quantity-@q1
-- SET @ff=(@q1*100)/@quantity
--UPDATE Accounting.Stock
--SET
--   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId

--   set @TQuantity=@Tquantity+@q1
--   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
--   set @TpriceRetail = @p2
--   SET @TpriceWholeSale = @p3


--END

--ELSE IF(@q1<@quantity AND @t3>@q1)
--BEGIN

-- set @t3=@t3-@q1
-- SET @ff=(@q1*100)/@quantity
--UPDATE Accounting.Stock
--SET
--   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId
 
-- set @TQuantity=@Tquantity+@q1
--   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
--   set @TpriceRetail = @p2
--   SET @TpriceWholeSale = @p3

--END

--ELSE IF(@q1<@quantity AND @t3<=@q1)
--BEGIN
--SET @ff=(@t3*100)/@quantity
--UPDATE Accounting.Stock
--SET
--   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

--   SET @TQuantity=@Tquantity+@t3
--   SET @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
--   SET @TpriceRetail = @p2
--   SET @TpriceWholeSale = @p3


-- SET @t3=NULL
--END

--ELSE IF(@q1>=@quantity AND @t3>0)
--BEGIN
--SET @ff=(@t3*100)/@quantity
--UPDATE Accounting.Stock
--SET
--   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

--   SET @TQuantity=@Tquantity+@t3
--   SET @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
--   SET @TpriceRetail = @p2
--   SET @TpriceWholeSale = @p3


-- SET @t3=NULL
--END

--ELSE

--BEGIN
--      UPDATE Accounting.Stock
--SET 
--   Quantity =  @q1-@quantity WHERE GoodId=@goodId AND Id=@stockId 
--   SET @TQuantity=@Tquantity+@quantity
--   SET @TpriceBuy = (@TpriceBuy + @p1)
--   SET @TpriceRetail = @p2
--   SET @TpriceWholeSale = @p3

--  SET @t3=NULL



  
--END
--END



--FETCH NEXT FROM css INTO @q1,@stockId
--SET @totalAmount=@totalAmount+(@TQuantity*(@TpriceWholeSale-@discountPrice))
--   END
--CLOSE css
--DEALLOCATE css


--   INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId]
   
   
   
   
   
   
   
-- ,[PriceBuy]
-- ,[PriceRetail]
-- ,[PriceWholeSale]
-- ,[AmountBuy]
-- ,[AmountRetail]
-- ,[AmountWholeSale]
-- ,[Payment]
-- ,[Deficit]
-- ,[Percent]
-- ,[CostInclude]
-- ,[CostDeficit]
-- ,[DiscountPrice]
-- ,[CreateId]
-- ,[CreateDate])


--VALUES(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@TQuantity,@unitId




--,@TpriceBuy
--,@TpriceRetail
--,@TpriceWholeSale -@discountPrice
--,@TQuantity*@TpriceBuy
--,@TQuantity*@TpriceRetail
--, @TQuantity*(@TpriceWholeSale -@discountPrice)
--,@payment
--, @TQuantity*(@TpriceWholeSale -@discountPrice)
--,@percent 
--,@costInclude
--,@costDeficit
--,@discountPrice   
--,@userId,getdate())







--FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent
-- ,@costInclude,@costDeficit,@discountPrice
--end

--close crs
--deallocate crs
--END
--INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
--VALUES(@id,@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@totalAmount)
--SET @paymentid=SCOPE_IDENTITY();
 

--if @@TRANCOUNT>0 
--commit;


--if @operationType=11 goto spSelect;
--RETURN 0
--end
----spEdit:
----begin
----update [Accounting].[Document]
----set

----[IncludeDate]=@includeDate,
----[CompanyId]=@companyId,
----[WareHouseId]=@wareHouseId,
----[Description]=@description,
----[PaymentTypeId]=@paymentTypeId,
----[ContractId]=@contractId,
----[UpdateId]=@userId,
----[UpdateDate]=getdate()

----where Id=@id;


------------------  Stock -------------

----;with chck as (
----select d.GoodId,sum(d.Quantity-isnull(dd.Quantity,0)) Quantity from @detail d 
----left join [Accounting].[DocumentDetail] dd on d.Id=dd.Id
----group by d.GoodId
----)


----merge [Accounting].[Stock] target
----using (select [GoodId] ,Quantity  from chck)source  on target.GoodId=source.GoodId
----when Matched then
----update set [Quantity]=target.Quantity-source.[Quantity]
----when not matched by target then insert ([GoodId],[Quantity]) values(source.GoodId,source.Quantity);
--------------

----merge [Accounting].[DocumentDetail] target
----using (select [Id],[GoodId],@id [DocumentId],[AccountId],[BarCodeId],[Series],[DateOfProduction]
----,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
----,[Quantity]*[PriceBuy] [AmountBuy],[Quantity]*[PriceRetail] [AmountRetail]
----,[Quantity]*[PriceWholeSale] [AmountWholeSale],ISNULL([Payment],0) [Payment],[AmountWholeSale] [Deficit]
----from @detail) source on target.Id=source.Id
----when MATCHED and target.DocumentId=@id THEN 


----update set [AccountId]=source.[AccountId]
----,[BarCodeId]=source.[BarCodeId]
----,[Series]=source.[Series]
----,[DateOfProduction]=source.[DateOfProduction]
----,[LastExpirationDate]=source.[LastExpirationDate]
----,[Quantity]=source.[Quantity]
----,[UnitId]=source.[UnitId]
----,[PriceBuy]=source.[PriceBuy]
----,[PriceRetail]=source.[PriceRetail]
----,[PriceWholeSale]=source.[PriceWholeSale]
----,[AmountBuy]=source.[AmountBuy]
----,[AmountRetail]=source.[AmountRetail]
----,[AmountWholeSale]=source.[AmountWholeSale]
----,[Payment]=isnull(target.[Payment],0)
----,[Deficit]=source.[AmountWholeSale]
----,[UpdateDate]=getdate()
----,[UpdateId]=@userid


----when NOT MATCHED BY target then 
----insert  ( [DocumentId] ,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction]
----,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy]
----,[AmountRetail],[AmountWholeSale],[Payment],[Deficit])
----values (@id,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate]
----,[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[Quantity]*[PriceBuy]
----, [Quantity] * [PriceRetail] ,[Quantity]*[PriceWholeSale] ,isnull([Payment],0),[AmountWholeSale])

----when NOT MATCHED BY source and target.DocumentId=@Id then update set [DeleteId]=@userId
----,[DeleteDate]=getdate();

----if @@TRANCOUNT>0
----   commit;
----if @operationType=12 goto spSelect;
----RETURN 0
----end

--spDelete:
--begin
--DECLARE @totalAmount1 DECIMAL(26,6)=0,@payment1 DECIMAL(26,6),@amountBuy1 DECIMAL(26,6),@goodId1 INT,@barcodeId1 INT,@series1 NVARCHAR(200),@dateOfProduction1 DATETIME,@lastExpirationDate1 DATETIME
--,@quantity1 DECIMAL(26,6),@unitId1 INT,@priceBuy1 DECIMAL(26,6),@priceRetail1 DECIMAL(26,6),@priceWholeSale1 DECIMAL(26,6)
--DECLARE crs CURSOR FOR 
--(SELECT ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
--[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
--FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)
--OPEN crs
--FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1 
--,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1
--WHILE @@FETCH_STATUS=0
--BEGIN
--SET @totalAmount1=@totalAmount1+@amountBuy1
--INSERT INTO Accounting.Stock (GoodId,CreatId,CreateDate,WarehouseId,DocumentId,Quantity,PriceBuy,PrcieRetail,PriceWholeSale) VALUES (@goodId1,@userId,GETDATE(),@wareHouseId,@id,@quantity1,@priceBuy1,@priceRetail1,@priceWholeSale1)
--FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1
--END
--CLOSE crs
--DEALLOCATE crs
--DELETE FROM Accounting.Payment WHERE DocumentId=@id
--UPDATE Accounting.DocumentDetail
--SET
--DeleteDate=GETDATE(),
--DeleteId=@userId
--WHERE DocumentId=@id
--update [Accounting].[Document]
--set
--[DeleteId]=@userId,
--[DeleteDate]=GETDATE()
--where Id=@id;
--if @operationType=13 goto spSelect;
--RETURN 0
--end



--spSelect:
--select  d.[Id]  
--    ,d.[IncludeDate]  
--	,d.[PaymentDate]
--	,d.[PartnerOrderNo]
--    ,d.[CompanyId]   
--	,d.[CompanyName]  
--    ,d.[WareHouseId] 
--	,d.[WareHouseName]
--	,d.[Description]
--	,d.[PaymentTypeId]
--	,d.[PaymentTypeName]
--	,d.[ContractId]
--	,d.[CustomerId]
--	,d.[CustomerName]
--	,d.[AdditionalCost]
--	,d.CashierId
--	,d.CashierName
     
--         ,sum(dd.AmountBuy) AmountBuy
--         ,sum(dd.AmountRetail) AmountRetail
--         ,sum(dd.AmountWholeSale) AmountWholeSale
--		 ,sum(dd.PriceBuy) PriceBuy
--		 ,sum(dd.PriceRetail) PriceRetail
--		 ,sum(dd.PriceWholeSale) PriceWholeSale 
--	     ,sum(dd.Payment) Payment
--	     ,sum(dd.Deficit) Deficit
--		 ,sum(dd.DiscountPrice) DiscountPrice

--from [Accounting].[VwDocument] d
-- left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
-- left join [Accounting].[VwContract] c on c.id=d.ContractId
-- JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
-- where AccountId=7 and d.DeleteId is null
-- group by 
--     d.[Id]  
--    ,d.[IncludeDate]  
--	,d.[PaymentDate]
--	,d.[PartnerOrderNo]
--    ,d.[CompanyId]   
--	,d.[CompanyName]  
--    ,d.[WareHouseId] 
--	,d.[WareHouseName]
--	,d.[Description]
--	,d.[PaymentTypeId]
--	,d.[PaymentTypeName]
--	,d.[ContractId]
--	,d.[CustomerId]
--	,d.[CustomerName]
--	,d.[AdditionalCost]
--	,d.CashierId
--	,d.CashierName
--    ,d.[DocTypeId]
--    ,d.[DocCertId]
--    ,d.[DocSeriesId];
-- RETURN 0
--end
GO
PRINT N'Creating [Accounting].[spGood]...';


GO
create procedure [Accounting].[spGood]
@operationType tinyint=null,
@userId int,
@id int =null,
@barcodeId bigint=null,
@documentDetailId int=null,
@goodName nvarchar(200)= null,
@goodTypeId int = null,
@regionId int =null,
@manufacturerCompanyId int =null,
@unitId int=null,
@doseId int=null,
@packingTypeId int=null,
@description nvarchar(500)=null,
@goodCode nvarchar(200)=null,

  @photo varbinary(max)=null,
@docTypeId int =null,
@docCertId int =null,
@docSeriesId int=null,
@isFiltered bit=1,
@detail [Accounting].[UddtBarcodeGood] readonly,
@images [Accounting].[UdttImagesGood] readonly
with encryption
as
begin 
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in(3,13)
goto spDelete;
else if @operationType=4
goto spSelect;

spAdd:
begin 
begin transaction
insert into  [Accounting].[Good]([BarcodeId],[GoodName],[DocumentDetailId],[GoodTypeId],[ManufacturerCompanyId],[RegionId],[UnitId],[DoseId],[PackingTypeId],[Description],[GoodCode],[Photo],[CreateId],[DocTypeId],[DocCertId],[DocSeriesId])
VALUES (@barcodeId,@goodName,@documentDetailId,@goodTypeId,@manufacturerCompanyId,@regionId,@unitId,@doseId,@packingTypeId,@description,@goodCode,@Photo,@userId,@docTypeId,@docCertId,@docSeriesId);

set @id=SCOPE_IDENTITY();

DECLARE @barcode NVARCHAR(20),@barId int

SELECT @barcode=Barcode FROM @detail

INSERT into [Accounting].[Barcode]([GoodId],[Barcode])
SELECT @id,Barcode
from @detail
 
SELECT @barId= Id FROM Barcode WHERE GoodId=@id AND Barcode=@barcode
UPDATE  Accounting.Good
SET 
BarcodeId=@barId
WHERE Id=@id

insert into [Accounting].[ImagesGood]([GoodId],[IsMain],[Image])
select @id,[IsMain],[Image]  
from @images


if @@TRANCOUNT>0
commit;

if @operationType=11 goto spSelect;
return 0
end
spEdit:
begin
begin transaction

update [Accounting].[Good]
set
[GoodName]=@goodName
,[DocumentDetailId]=@documentDetailId
,[GoodTypeId]=@goodTypeId
,[RegionId]=@regionId
,[ManufacturerCompanyId]=@manufacturerCompanyId
,[UnitId]=@unitId
,[DoseId]=@doseId
,[PackingTypeId]=@packingTypeId
,[Description]=@description
,[GoodCode]=@goodCode
 , [Photo]=@photo
,[DocTypeId]=@docTypeId
,[DocCertId]=@docCertId
,[DocSeriesId]=@docSeriesId
,[ModifyId]=@userId
,[ModifyDate]=GETDATE()

WHERE id=@id

merge [Accounting].[Barcode] target
using (select [Id],[Barcode],@id [GoodId] 
from @detail ) source on target.Id=source.Id
when MATCHED and target.GoodId=@id THEN UPDATE SET  [GoodId]=source.[GoodId],[Barcode]=source.[Barcode]
when NOT MATCHED BY target then insert (GoodId,Barcode)
values (@id,[Barcode])
when not matched  by source and  target.GoodId=@Id then update set  [DeleteId]=@userId,[DeleteDate]=getdate();

if @@TRANCOUNT>0
commit;

if @operationType=12 goto spSelect;
return 0
end

spDelete:
begin 
update Accounting.Barcode
set [DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

update Accounting.ImagesGood
set [DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;


update [Accounting].[Good]
set [DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect
return 0
end
spSelect:

select  
g.[Id]
,B.[Id] BarcodeId
,b.Barcode
,g.[GoodName]
,g.[FullGoodName]
,g.[DocumentDetailId]
,g.[GoodTypeId]
,g.[GoodTypeName]
,g.[RegionId]
,g.[RegionName]
,g.[ManufacturerCompanyId]
,g.[ManufacturerCompanyName]
,g.[UnitId]
,g.[UnitName]
,g.[DoseId]
,g.[DoseName]
,g.[PackingTypeId]
,g.[PackingTypeName]
,g.[Description]
,g.[GoodCode]
,g.[Photo]
      ,g.[CreateId]
      ,g.[CreateDate]
      ,g.[DocTypeId]
      ,g.[DocCertId]
      ,g.[DocSeriesId]

from [Accounting].[VwGood] g

left join [Accounting].[Barcode] B ON G.Id=b.GoodId
left join [Accounting].[ImagesGood]  ig on g.Id=ig.GoodId
group by 
g.[Id]

,b.[Id] 
,b.Barcode
,g.[GoodName]
,g.[FullGoodName]
,g.[DocumentDetailId]
,g.[GoodTypeId]
,g.[GoodTypeName]
,g.[RegionId]
,g.[RegionName]
,g.[ManufacturerCompanyId]
,g.[ManufacturerCompanyName]
,g.[UnitId]
,g.[UnitName]
,g.[DoseId]
,g.[DoseName]
,g.[PackingTypeId]
,g.[PackingTypeName]
,g.[Description]
,g.[GoodCode]
,g.[Photo]
      ,g.[CreateId]
      ,g.[CreateDate]
      ,g.[DocTypeId]
      ,g.[DocCertId]
      ,g.[DocSeriesId]
return 0 
end
GO
PRINT N'Creating [Accounting].[spCustomerContract]...';


GO
CREATE PROCEDURE [Accounting].[spCustomerContract]
@userId int,
@operationType tinyint,
@id int=null,
@customerName NVARCHAR(200) =NULL, 
@customerLeader NVARCHAR(200) =NULL, 
@workTypeId INT =NULL, 
@voen NVARCHAR(50) =NULL, 
@currencyId INT =NULL, 
@bankId INT =NULL, 
@bankSwift NVARCHAR(200) =NULL, 
@regionId int =null,
@legalAddress NVARCHAR(200) =NULL, 
@actualAddress NVARCHAR(200) =NULL, 
@email NVARCHAR(200) =NULL, 
@tel NVARCHAR(200) =NULL, 
@date datetime =NULL,
@description nvarchar(500) =NULL,
@parentId int =null,
@typeId INT =NULL,
@docTypeId int =null,
@docCertId int =null,
@docSeriesId int=null,

@contract [Accounting].[UddtContractCustomer] readonly

with encryption
AS 
begin
set xact_abort on;
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;

spAdd:
begin
begin transaction
insert into [Accounting].[Customer]([CustomerName],[ParentId],[TypeId] ,[CustomerLeader],[WorkTypeId],[Voen] ,[CurrencyId] ,[BankId],[BankSwift]  ,[RegionId],[LegalAddress],[ActualAddress],[Email] ,[Tel],[Date],[Description],[CreateId],[DocTypeId],[DocCertId],[DocSeriesId])
values(@customerName,@parentId,@typeId,@customerLeader,@workTypeId,@voen,@currencyId,@bankId,@bankSwift,@regionId,@legalAddress,@actualAddress,@email,@tel,@date,@description,@userId,@docTypeId,@docCertId,@docSeriesId);

set @id=SCOPE_IDENTITY();

insert into [Accounting].[Contract]([CustomerId],[ContractDate],[CurrencyId],[OperationTypeId],[CompanyId],[ContractTypeId],[Description])
select @id,[ContractDate],[CurrencyId],[OperationTypeId] ,[CompanyId] ,[ContractTypeId],[Description] from @contract

if @@TRANCOUNT>0
   commit;


if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
begin transaction

UPDATE [Accounting].[Customer]
   SET
       
	   [CustomerName] = @customerName
	   ,[ParentId]=@parentId
	   ,[TypeId]=@typeId
      ,[CustomerLeader] = @customerLeader
      ,[WorkTypeId] = @WorkTypeId 
      ,[Voen] = @Voen
      ,[CurrencyId] = @CurrencyId
      ,[BankId] = @bankId
	  ,[BankSwift]=@bankSwift
	  ,[RegionId]=@regionId
      ,[LegalAddress] = @LegalAddress
      ,[ActualAddress] = @ActualAddress
      ,[Email] = @Email
      ,[Tel] = @Tel
      ,[Date] = @Date
      ,[Description] = @Description
      ,[UpdateId]=@userId
      ,[UpdateDate]= getdate()
      ,[DocTypeId]=@docTypeId
      ,[DocSeriesId]=@docSeriesId
      ,[DocCertId]=@docCertId

where Id=@id;

merge [Accounting].[Contract] target
using(select [Id],@id [CustomerId],[ContractDate],[ContractTypeId],[CurrencyId],[OperationTypeId],[CompanyId],[Description] 
from @contract) source on target.Id=source.Id
when MATCHED and target.CustomerId=@id THEN 
update 
set [CustomerId]=source.[CustomerId],[ContractDate]=source.[ContractDate],[ContractTypeId]=source.[ContractTypeId],[CurrencyId]=source.[CurrencyId],[OperationTypeId]=source.[OperationTypeId]
,[CompanyId]=source.[CompanyId],[Description]=source.[Description]
when NOT MATCHED BY target then 
insert ([CustomerId] ,[ContractDate] ,[ContractTypeId] ,[CurrencyId] ,[OperationTypeId]  ,[CompanyId],[Description])
values(@id ,[ContractDate],[ContractTypeId],[CurrencyId],[OperationTypeId],[CompanyId],[Description])
when NOT MATCHED BY source and target.CustomerId=@Id  then update set [DeleteId]=@userId,[DeleteDate]=getdate();

if @@TRANCOUNT>0
   commit;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[Customer]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end



spSelect:
select c.[Id]
      ,c.[CustomerName] 
	  ,c.[ParentId]
	  ,c.TypeId
	  ,c.TypeName
      ,c.[CustomerLeader]
      ,c.[Voen]
      ,c.[CurrencyId]
      ,c.[WorkTypeId]
      ,c.[WorkTypeName]
      ,c.[BankId]
	  ,c.[BankName]
	  ,c.[BankSwift]
	  ,c.[RegionId]
	  ,c.[RegionName]
      ,c.[LegalAddress]
      ,c.[ActualAddress]
      ,c.[Email]
      ,c.[Tel]
      ,c.[Date]
      ,c.[Description]
from [Accounting].[VwCustomer] c
join [Accounting].[Contract] co on c.id=co.CustomerId
group by 
       c.[Id]
      ,c.[CustomerName] 
	  ,c.[ParentId]
	  ,c.TypeId,c.TypeName
      ,c.[CustomerLeader]
      ,c.[Voen]
      ,c.[CurrencyId]
      ,c.[WorkTypeId]
      ,c.[WorkTypeName]
      ,c.[BankId]
	  ,c.[BankName]
	  ,c.[BankSwift]
	  ,c.[RegionId]
	  ,c.[RegionName]
      ,c.[LegalAddress]
      ,c.[ActualAddress]
      ,c.[Email]
      ,c.[Tel]
      ,c.[Date]
      ,c.[Description]
   select * from [Accounting].[VwCustomer] ;
RETURN 0
end
GO
PRINT N'Creating [Accounting].[spDocument]...';


GO
 create PROCEDURE [Accounting].[spDocument]
	@userId int ,
	@operationType tinyint = null,
	@id INT = NULL, 
	@menuId INT ,
	@paymentid INT=NULL,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
	@description nvarchar(500)=NULL,
	@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
    @accountCode varchar(40)=null,
	@paymentDate datetime =null, 
	@partnerOrderNo nvarchar(200)=null,
	@additionalCost decimal(26,6) =null, 
	
	--@cashierId int=null,
	@docTypeId int =null,
    @docCertId int =null,
    @docSeriesId int=null,
	
	@detail [Accounting].[UddtIncludeGood] READONLY
	--@isFiltered bit=1
	

AS

BEGIN
IF @operationType IN (1,11)
GOTO spAdd;
ELSE IF @operationType IN (2,12)
GOTO spedit;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4   
GOTO spSelect;


spAdd:
BEGIN
BEGIN TRAN 


INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],[ContractId],[SaleNo],[CreateId],AccountId,[PaymentDate],[PartnerOrderNo],[AdditionalCost],[DocTypeId],[DocCertId],[DocSeriesId])
VALUES (@includeDate,@companyId,@wareHouseId,@description,@paymentTypeId,@contractId,[Accounting].[SFnNewSaleNo](@userId,@accountCode),@userId,3,@paymentDate,@partnerOrderNo,@additionalCost,@docTypeId,@docCertId,@docSeriesId)

SET @id=SCOPE_IDENTITY();

DECLARE @accountId  INT,@payment DECIMAL(26,6),@amountBuy DECIMAL(26,6),@goodId INT,@barcodeId INT,@series NVARCHAR(200),@dateOfProduction DATETIME,@lastExpirationDate DATETIME
,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6),@totalPayment DECIMAL(26,6)=0,@percent NVARCHAR(50)
 ,@costInclude decimal (26,6),@costDeficit decimal (26,6),@discountPrice decimal(26,6)
 
DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],ISNULL([Percent]+' % Endirim','0')
 ,ISNULL([CostInclude] ,'0' ) ,ISNULL([CostDeficit] ,'0' ), ISNULL([DiscountPrice] ,'0' )
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent
 ,@costInclude,@costDeficit,@discountPrice

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalPayment=@totalPayment+(@quantity*(@priceBuy- @discountPrice))


 --set @totalAmount=@totalAmount+(@TQuantity*(@TpriceWholeSale-@discountPrice))
 
INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[Percent]
 ,[CostInclude],[CostDeficit]
 ,[DiscountPrice]
,[CreateId],[CreateDate])
VALUES(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy,@quantity*@priceRetail,@quantity*@priceWholeSale
,@payment,@amountBuy,@percent
 ,@costInclude,@costDeficit
,@discountPrice 
,@userId,GETDATE())


declare @stockgoodId int=0, @p1 DECIMAL (26,6),@p2 DECIMAL (26,6),@p3 DECIMAL (26,6)
select @stockgoodId=isnull(GoodId,0),@p1=PriceBuy,@p2=PrcieRetail,@p3=PriceWholeSale from Accounting.Stock where GoodId=@goodId  AND WarehouseId=@wareHouseId

 

INSERT into [Accounting].[Stock] (DocumentId,WarehouseId,GoodId,CreatId,Series,Quantity,PriceBuy,PrcieRetail,PriceWholeSale,CreateDate)
VALUES (@id,@wareHouseId,@goodId,@userId,@series,@quantity,@priceBuy,@priceRetail,@priceWholeSale,GETDATE())

 


FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent
 ,@costInclude,@costDeficit,@discountPrice


end

close crs
deallocate crs
INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit)
VALUES(@id,@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@totalPayment)


SET @paymentid=SCOPE_IDENTITY();

if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].[Document]
set 





[IncludeDate]=@includeDate,
[AccountId]=3,
[CompanyId]=@companyId,
[WareHouseId]=@wareHouseId,
[Description]=@description,
[PaymentTypeId]=@paymentTypeId,
[ContractId]=@contractId,
[PartnerOrderNo]=@partnerOrderNo,
[PaymentDate]=@paymentDate,
--[CashierId]=@cashierId,
[UpdateId]=@userId,
[UpdateDate]=getdate()

where Id=@id;

-------------PaymentOrder-------------


--SET @totalAmount=@totalAmount+(@TQuantity*(@TpriceWholeSale-@discountPrice))

--SET @totalAmount=@totalAmount+(@TQuantity*(@TpriceWholeSale-@discountPrice))
   
 
 -------------
 
 ---------
UPDATE Accounting.Payment 
SET 
   @totalPayment=@totalPayment+(@quantity*(@priceBuy- @discountPrice))
 
	WHERE AccountId=3
 ----------------------

--------------  Stock -------------

;with chck as (
select d.GoodId,sum(d.Quantity-isnull(dd.Quantity,0)) Quantity from @detail d 
left join [Accounting].[DocumentDetail] dd on d.Id=dd.Id
group by d.GoodId
)


merge [Accounting].[Stock] target
using (select [GoodId] ,Quantity  from chck)source  on target.GoodId=source.GoodId
when Matched then
update set [Quantity]=target.Quantity+source.[Quantity]
when not matched by target then insert ([GoodId],[Quantity]) values(source.GoodId,source.Quantity);
----------------------
 


--------
merge [Accounting].[DocumentDetail] target
using (select [Id],[GoodId],@id [DocumentId],[AccountId],[BarCodeId],[Series],[DateOfProduction]
,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
,[Quantity]*[PriceBuy] [AmountBuy],[Quantity]*[PriceRetail] [AmountRetail]
,[Quantity]*[PriceWholeSale] [AmountWholeSale],ISNULL([Payment],0) [Payment],[AmountBuy]  [Deficit]
from @detail) source on target.Id=source.Id
when MATCHED and target.DocumentId=@id THEN 


update set [AccountId]=source.[AccountId]
,[BarCodeId]=source.[BarCodeId]
,[Series]=source.[Series]
,[DateOfProduction]=source.[DateOfProduction]
,[LastExpirationDate]=source.[LastExpirationDate]
,[Quantity]=source.[Quantity]
,[UnitId]=source.[UnitId]
,[PriceBuy]=source.[PriceBuy]
,[PriceRetail]=source.[PriceRetail]
,[PriceWholeSale]=source.[PriceWholeSale]
,[AmountBuy]=source.[AmountBuy]
,[AmountRetail]=source.[AmountRetail]
,[AmountWholeSale]=source.[AmountWholeSale]
,[Payment]=isnull(target.[Payment],0)
,[Deficit]=source.[Deficit]
,[UpdateDate]=getdate()
,[UpdateId]=@userid


when NOT MATCHED BY target then 
insert  ( [DocumentId] ,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction]
,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy]
,[AmountRetail],[AmountWholeSale],[Payment],[Deficit])
values (@id,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate]
,[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[Quantity]*[PriceBuy]
, [Quantity] * [PriceRetail] ,[Quantity]*[PriceWholeSale] ,isnull([Payment],0),[AmountBuy])

when NOT MATCHED BY source and target.DocumentId=@Id then update set [DeleteId]=@userId
,[DeleteDate]=getdate(); 
if @@TRANCOUNT>0
   commit;
if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
BEGIN
--Silinen qaime nomresine gore mehsullarin sifirlanmasi
UPDATE Accounting.Stock
SET
UpdateDate=GETDATE(),
UpdateId=@userId,
Quantity=0
WHERE DocumentId=@id

--Silinen qaime nomresine gore yaranan borcun silinmesi
DELETE FROM Accounting.Payment 
WHERE DocumentId=@id

--Silinen qaime nomresine gore documentdetail cedveline delete ye silen userin dusmesi
UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id

--Silinen qaime nomresine gore Document cedveline silen userin id sinin dusmesi 
UPDATE [Accounting].[Document]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
WHERE id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
select  d.[Id]   
    ,d.[IncludeDate]  
	,d.[PaymentDate]   
	,d.[PartnerOrderNo]
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[AdditionalCost]
          ,d.[DocTypeId]
      ,d.[DocCertId]
      ,d.[DocSeriesId]
         ,sum(dd.AmountBuy) AmountBuy
         ,sum(dd.AmountRetail) AmountRetail
         ,sum(dd.AmountWholeSale) AmountWholeSale
	     ,sum(dd.Payment) Payment
	     ,sum(dd.Deficit) Deficit
	     --,sum(dd.DiscountNumber) DisocuntPrice
from [Accounting].[VwDocument] d

 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
 left join [Accounting].[VwContract] c on c.id=d.ContractId
JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
 where c.ContractTypeId=1--aliw ucun
  and d.DeleteId is null and AccountId=3
  --and (@isFiltered=0 OR (@isFiltered=1 and isnull([DocTypeId],0) <>1))
   --AND (@docCertId IS NULL OR [DocCertId]=@docCertId)
 group by 
     d.[Id]   
    ,d.[IncludeDate]  
	,d.[PaymentDate]   
    ,d.[PartnerOrderNo]
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[AdditionalCost]
    ,d.[DocTypeId]
    ,d.[DocCertId]
    ,d.[DocSeriesId];
 RETURN 0
end
GO
PRINT N'Creating [Accounting].[spDocumentRetailTmp]...';


GO
create PROCEDURE [Accounting].[spDocumentRetailTmp]
@userId int,
@operationTypeId tinyint=null,
--@payment  decimal(26,6),
@basket Accounting.UddtRetailSaleTmp readonly,
@selectedDelIds [Accounting].[UdttIds]  readonly,
@goodId int=null,
@quantity decimal(18,4)=0,
@barcodeId int=null,
@createDate datetime = null

as

begin

if @operationTypeId =24
begin 

 select
  rr.Id,
  g.Id GoodId
 ,rr.Quantity
 ,prc.PriceRetail Price
 ,prc.PriceBuy
 ,prc.PriceWholeSale
 ,rr.BarcodeId
 ,b.Barcode
 , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
 ,null Account, g.GoodName

from [Accounting].[RetailReceipt] rr 
join Accounting.Good g on g.Id=rr.GoodId
join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
join [dbo].[VwDose] d on g.DoseId=d.Id
cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
join Accounting.Barcode b on b.Id=rr.BarcodeId
where rr.CreateId=@userId and format(rr.CreateDate,'yyyyMMddHHmmss') =  format(@createDate,'yyyyMMddHHmmss')
and rr.CreateId=@userId

return
end
 
 if(@operationTypeId=4) goto spSelect;
 else if(@operationTypeId=3) goto spDelete;
 if exists(select top(1) 0 from [Accounting].[DocumentTmp] where CreateId=@userId and [GoodId]=@goodId)
begin
   update [Accounting].[DocumentTmp] set [Quantity]=@quantity
   
   where CreateId=@userId and [GoodId]=@goodId;
   goto spSelect;
   return;
end 

 insert into [Accounting].[DocumentTmp](CreateId,[GoodId],[Quantity],[BarcodeId]
 )
 values (@userId,@goodId,(case WHEN @quantity=0 THEN 1 else @quantity end), @barcodeId
 );
goto spSelect;
 return;

  spSelect:
 begin
 select
   
 g.Id GoodId
 ,dt.Quantity
 ,prc.PriceRetail Price
 ,prc.PriceBuy
 ,prc.PriceWholeSale
 ,dt.BarcodeId
 ,b.Barcode
 , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
 ,null Account, g.GoodName
 ,dt.Id TempId

from Accounting.DocumentTmp dt 

join Accounting.Good g on g.Id=dt.GoodId
join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
join [dbo].[VwDose] d on g.DoseId=d.Id
cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
join Accounting.Barcode b on b.Id=dt.BarcodeId

where   dt.CreateId=@userId

 RETURN 0
 end

spDelete:

begin
if exists(select top(1) 0 from @selectedDelIds)
begin
    delete t
	from [Accounting].[DocumentTmp] t
	join @selectedDelIds sd on t.Id = sd.Id
	where CreateId=@userId;
	goto spSelect;
end
else
begin
	delete from [Accounting].[DocumentTmp]
	where CreateId=@userId;
end
RETURN 0
end

 
 end


--CREATE PROCEDURE [Accounting].[spDocumentRetailTmp]
--@userId int,
--@operationTypeId tinyint=null,
----@payment  decimal(26,6),
--@basket Accounting.UddtRetailSaleTmp readonly,
--@selectedDelIds [Accounting].[UdttIds]  readonly,
--@goodId int=null,
--@quantity decimal(18,4)=0,
--@barcodeId int=null,
--@createDate datetime = null

--as

--begin

--if @operationTypeId =24
--begin 

-- select
--  rr.Id,
--  g.Id GoodId
-- ,rr.Quantity
-- ,prc.PriceRetail Price
-- ,prc.PriceBuy
-- ,prc.PriceWholeSale
-- ,rr.BarcodeId
-- ,b.Barcode
-- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
-- ,null Account, g.GoodName

--from [Accounting].[RetailReceipt] rr 
--join Accounting.Good g on g.Id=rr.GoodId
--join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
--join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
--join [dbo].[VwDose] d on g.DoseId=d.Id
--cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
--join Accounting.Barcode b on b.Id=rr.BarcodeId
--where rr.CreateId=@userId and format(rr.CreateDate,'yyyyMMddHHmmss') =  format(@createDate,'yyyyMMddHHmmss')
--and rr.CreateId=@userId

--return
--end
 
-- if(@operationTypeId=4) goto spSelect;
-- else if(@operationTypeId=3) goto spDelete;
-- if exists(select top(1) 0 from [Accounting].[DocumentTmp] where CreateId=@userId and [GoodId]=@goodId)
--begin
--   update [Accounting].[DocumentTmp] set [Quantity]=@quantity
   
--   where CreateId=@userId and [GoodId]=@goodId;
--   return;
--end 

-- insert into [Accounting].[DocumentTmp](CreateId,[GoodId],[Quantity],[BarcodeId]
-- )
-- values (@userId,@goodId,(case WHEN @quantity=0 THEN 1 else @quantity end), @barcodeId
-- );
-- return;

--  spSelect:
-- begin
-- select
-- g.Id GoodId
-- ,dt.Quantity
-- ,prc.PriceRetail Price
-- ,prc.PriceBuy
-- ,prc.PriceWholeSale
-- ,dt.BarcodeId
-- ,b.Barcode
-- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
-- ,null Account, g.GoodName

--from Accounting.DocumentTmp dt 

--join Accounting.Good g on g.Id=dt.GoodId
--join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
--join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
--join [dbo].[VwDose] d on g.DoseId=d.Id
--cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
--join Accounting.Barcode b on b.Id=dt.BarcodeId

--where   dt.CreateId=@userId

-- RETURN 0
-- end

--spDelete:

--begin

--if exists(select top(1) 0 from @selectedDelIds)
--begin
--    delete t
--	from [Accounting].[DocumentTmp] t
--	join @selectedDelIds sd on t.Id = sd.Id
--	where CreateId=@userId;
--end
--else
--begin
--	delete from [Accounting].[DocumentTmp]
--	where CreateId=@userId;
--end


--RETURN 0
--end
 
-- end



--create PROCEDURE [Accounting].[spDocumentRetailTmp]
--@userId int,
--@operationTypeId tinyint=null,
----@payment  decimal(26,6),
--@basket Accounting.UddtRetailSaleTmp readonly,
--@selectedDelIds [Accounting].[UdttIds]  readonly,
--@goodId int=null,
--@quantity decimal(18,4)=0,
--@barcodeId int=null,
--@createDate datetime = null

--as

--begin

--if @operationTypeId =24
--begin 

-- select
--  rr.Id,
--  g.Id GoodId
-- ,rr.Quantity
-- ,prc.PriceRetail Price
-- ,prc.PriceBuy
-- ,prc.PriceWholeSale
-- ,rr.BarcodeId
-- ,b.Barcode
-- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
-- ,null Account, g.GoodName

--from [Accounting].[RetailReceipt] rr 
--join Accounting.Good g on g.Id=rr.GoodId
--join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
--join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
--join [dbo].[VwDose] d on g.DoseId=d.Id
--cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
--join Accounting.Barcode b on b.Id=rr.BarcodeId
--where rr.CreateId=@userId and format(rr.CreateDate,'yyyyMMddHHmmss') =  format(@createDate,'yyyyMMddHHmmss')
--and rr.CreateId=@userId

--return
--end
 
-- if(@operationTypeId=4) goto spSelect;
-- else if(@operationTypeId=3) goto spDelete;
-- if exists(select top(1) 0 from [Accounting].[DocumentTmp] where CreateId=@userId and [GoodId]=@goodId)
--begin
--   update [Accounting].[DocumentTmp] set [Quantity]=@quantity
   
--   where CreateId=@userId and [GoodId]=@goodId;
--   return;
--end 

-- insert into [Accounting].[DocumentTmp](CreateId,[GoodId],[Quantity],[BarcodeId]
-- )
-- values (@userId,@goodId,(case WHEN @quantity=0 THEN 1 else @quantity end), @barcodeId
-- );
-- return;

--  spSelect:
-- begin
-- select
--   dt.Id TempId,
-- g.Id GoodId
-- ,dt.Quantity
-- ,prc.PriceRetail Price
-- ,prc.PriceBuy
-- ,prc.PriceWholeSale
-- ,dt.BarcodeId
-- ,b.Barcode
-- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
-- ,null Account, g.GoodName

--from Accounting.DocumentTmp dt 

--join Accounting.Good g on g.Id=dt.GoodId
--join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
--join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
--join [dbo].[VwDose] d on g.DoseId=d.Id
--cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
--join Accounting.Barcode b on b.Id=dt.BarcodeId

--where   dt.CreateId=@userId

-- RETURN 0
-- end

--spDelete:

--begin
--if exists(select top(1) 0 from @selectedDelIds)
--begin
--    delete t
--	from [Accounting].[DocumentTmp] t
--	join @selectedDelIds sd on t.Id = sd.Id
--	where CreateId=@userId;
--	goto spSelect;
--end
--else
--begin
--	delete from [Accounting].[DocumentTmp]
--	where CreateId=@userId;
--end
--RETURN 0
--end

 
-- end


----CREATE PROCEDURE [Accounting].[spDocumentRetailTmp]
----@userId int,
----@operationTypeId tinyint=null,
------@payment  decimal(26,6),
----@basket Accounting.UddtRetailSaleTmp readonly,
----@selectedDelIds [Accounting].[UdttIds]  readonly,
----@goodId int=null,
----@quantity decimal(18,4)=0,
----@barcodeId int=null,
----@createDate datetime = null

----as

----begin

----if @operationTypeId =24
----begin 

---- select
----  rr.Id,
----  g.Id GoodId
---- ,rr.Quantity
---- ,prc.PriceRetail Price
---- ,prc.PriceBuy
---- ,prc.PriceWholeSale
---- ,rr.BarcodeId
---- ,b.Barcode
---- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
---- ,null Account, g.GoodName

----from [Accounting].[RetailReceipt] rr 
----join Accounting.Good g on g.Id=rr.GoodId
----join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
----join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
----join [dbo].[VwDose] d on g.DoseId=d.Id
----cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
----join Accounting.Barcode b on b.Id=rr.BarcodeId
----where rr.CreateId=@userId and format(rr.CreateDate,'yyyyMMddHHmmss') =  format(@createDate,'yyyyMMddHHmmss')
----and rr.CreateId=@userId

----return
----end
 
---- if(@operationTypeId=4) goto spSelect;
---- else if(@operationTypeId=3) goto spDelete;
---- if exists(select top(1) 0 from [Accounting].[DocumentTmp] where CreateId=@userId and [GoodId]=@goodId)
----begin
----   update [Accounting].[DocumentTmp] set [Quantity]=@quantity
   
----   where CreateId=@userId and [GoodId]=@goodId;
----   return;
----end 

---- insert into [Accounting].[DocumentTmp](CreateId,[GoodId],[Quantity],[BarcodeId]
---- )
---- values (@userId,@goodId,(case WHEN @quantity=0 THEN 1 else @quantity end), @barcodeId
---- );
---- return;

----  spSelect:
---- begin
---- select
---- g.Id GoodId
---- ,dt.Quantity
---- ,prc.PriceRetail Price
---- ,prc.PriceBuy
---- ,prc.PriceWholeSale
---- ,dt.BarcodeId
---- ,b.Barcode
---- , (g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
---- ,null Account, g.GoodName

----from Accounting.DocumentTmp dt 

----join Accounting.Good g on g.Id=dt.GoodId
----join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
----join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
----join [dbo].[VwDose] d on g.DoseId=d.Id
----cross apply [Accounting].[IFnPricesByGoodId](g.Id) prc
----join Accounting.Barcode b on b.Id=dt.BarcodeId

----where   dt.CreateId=@userId

---- RETURN 0
---- end

----spDelete:

----begin

----if exists(select top(1) 0 from @selectedDelIds)
----begin
----    delete t
----	from [Accounting].[DocumentTmp] t
----	join @selectedDelIds sd on t.Id = sd.Id
----	where CreateId=@userId;
----end
----else
----begin
----	delete from [Accounting].[DocumentTmp]
----	where CreateId=@userId;
----end


----RETURN 0
----end
 
---- end
GO
PRINT N'Creating [Accounting].[spDocumentRetail]...';


GO
create PROCEDURE [Accounting].[spDocumentRetail]
@userId int,
@payment  decimal(26,6),
@deficit DECIMAL(26,6),
@totalsum DECIMAL(26,6),
@basket Accounting.UddtRetailSale readonly,
@accountCode varchar(20),
@warehouseId int=null,
@paymentTypeId int=null,
@contractId int,
@percent nvarchar(50) null,
@discountNumber nvarchar(50) null
as

BEGIN

if exists(select 0 from (
select d.GoodId,sum(ISNULL(st.quantity,0))- d.Quantity QuantityPerGood from @basket d
join Accounting.VwGoodStock st with(rowlock,holdlock) on d.GoodId=st.Id
WHERE st.WarehouseId=@wareHouseId
group by d.GoodId,d.Quantity
)x where x.QuantityPerGood<0)
begin
raiserror('Stokda kifayet qeder mehsul yoxdur',16,1)
return
end
else 
BEGIN

declare @dayStart date=getdate(),@dayEnd date , @documentId int,@documentDetailId int,@companyId int 
set @dayEnd=DATEADD(day,1,@dayStart)
--select @dayStart,@dayEnd
set @companyId=@userId -- todo:  Burda userId-e  gore CompanyId-ni tapib getiririk. Hleki demo-dur


insert into Accounting.Document(IncludeDate,CompanyId,ContractId,WareHouseId,PaymentTypeId,CreateId,AccountId)
values (GETDATE(),@companyId,@contractId,@warehouseId,@paymentTypeId,@userId,8)



 update  Accounting.Cash  set [Balance] = isnull  (Balance,0) +@payment

   
   where Id=1


set @documentId=SCOPE_IDENTITY() 

DECLARE @quantity DECIMAL(26,6),@barcodeId INT,@goodId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6),@accountId INT,@goodName VARCHAR(50),@fullGoodName VARCHAR(50),@barcode VARCHAR(50)

DECLARE crs CURSOR FOR(SELECT [GoodId],ISNULL([Quantity],1),[FullGoodName],[BarCodeId],[Barcode],[AccountId],[GoodName]
,[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM @basket)
OPEN crs
FETCH NEXT FROM crs INTO @goodId,@quantity,@fullGoodName,@barcodeId,@barcode,@accountId,@goodName,@priceBuy,@priceRetail,@priceWholeSale
WHILE @@FETCH_STATUS=0
BEGIN
 





DECLARE @q1 DECIMAL(25,5),@stockId INT,@t3 DECIMAL(25,5)=0,@Tquantity DECIMAL(25,5)=0,@TpriceBuy DECIMAL(26,6)=0,@TpriceRetail DECIMAL(26,6)=0,@TpriceWholeSale DECIMAL(26,6)=0,@count int=0

DECLARE css CURSOR FOR (SELECT s.Quantity,s.Id FROM Accounting.Stock s WHERE s.GoodId=@goodId and s.Quantity>0 AND s.WarehouseId=@warehouseId AND UpdateId IS null)
OPEN css
FETCH NEXT FROM css INTO @q1,@stockId
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @p1 decimal(25,5),@p2 decimal(25,5),@p3 decimal(25,5),@ff Decimal (25,2)


SET @p1=(
    SELECT s.PriceBuy FROM Accounting.Stock s 
WHERE s.Id=@stockId AND WarehouseId=@wareHouseId)

SET @p2=(
    SELECT s.PrcieRetail FROM Accounting.Stock s 
WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId AND WarehouseId=@wareHouseId) )

SET @p3=(
    SELECT s.PriceWholeSale FROM Accounting.Stock s 
WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId AND WarehouseId=@wareHouseId) )

if(@t3 is not null)
begin
set @count=@count + 1
if(@q1<@quantity and @t3=0)

BEGIN

 set @t3=@quantity-@q1
 SET @ff=(@q1*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId

   set @TQuantity=@Tquantity+@q1
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   set @TpriceWholeSale = @p3


END

else if(@q1<@quantity and @t3>@q1)
BEGIN

 set @t3=@t3-@q1
 SET @ff=(@q1*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId
 
 set @TQuantity=@Tquantity+@q1
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   set @TpriceWholeSale = @p3

END

else if(@q1<@quantity and @t3<=@q1)
BEGIN
SET @ff=(@t3*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

   set @TQuantity=@Tquantity+@t3
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   set @TpriceWholeSale = @p3


 set @t3=null
END

else if(@q1>=@quantity and @t3>0)
BEGIN
SET @ff=(@t3*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

   set @TQuantity=@Tquantity+@t3
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   set @TpriceWholeSale = @p3


 set @t3=null
END

ELSE

BEGIN
      UPDATE Accounting.Stock
SET 
   Quantity =  @q1-@quantity WHERE GoodId=@goodId AND Id=@stockId 
   set @TQuantity=@Tquantity+@quantity
   set @TpriceBuy = (@TpriceBuy + @p1)
   set @TpriceRetail = @p2
   set @TpriceWholeSale = @p3

  set @t3=null
END
end


FETCH NEXT FROM css INTO @q1,@stockId
   end
close css
deallocate css
   
   insert into Accounting.DocumentDetail ([DocumentId],[AccountId],[GoodId],[Percent],DiscountNumber,[Quantity],[PriceRetail],[PriceBuy],[PriceWholeSale] ,[AmountRetail],[AmountBuy],[AmountWholeSale] ,[Payment],[Deficit],[CreateId],[SaleNo])
select 



@documentId
,@accountId
,@goodId
,@percent
,@discountNumber
,@Tquantity
,@TpriceRetail
,@TpriceBuy
,@TpriceWholeSale
,SUM(@TpriceRetail*@Tquantity) [AmountRetail]
,SUM(@TpriceBuy*@Tquantity) [AmountBuy]
,SUM(@TpriceWholeSale*@Tquantity) [AmountWholeSale]
,@payment [Payment]
,@payment-SUM(@TpriceRetail) [Deficit] 
,@userId [CreateId] 
,[Accounting].[SFnNewSaleNo](@userId,@accountCode)
set @documentDetailId=SCOPE_IDENTITY();



insert into Accounting.RetailSale(BarcodeId,DocumentDetailId,AccountId,GoodId,Quantity,PriceRetail,PriceBuy,PriceWholeSale,WareHouseId,CustomerId,CreateId,[Percent],DiscountNumber)
select @barcodeId,@documentDetailId,8,@goodId,@Tquantity,@TpriceRetail,@TpriceBuy,@TpriceWholeSale,@warehouseId,@contractId,@userId,@percent,@discountNumber


FETCH NEXT FROM crs INTO @goodId,@quantity,@fullGoodName,@barcodeId,@barcode,@accountId,@goodName,@priceBuy,@priceRetail,@priceWholeSale

end
close crs
deallocate crs
INSERT INTO Accounting.PaymentRetail (DocumentId,CustomerId,PaymentTypeId,Payment,Deficit,TotalSum,CreateDate,CreateId,[Percent],DiscountNumber) 
VALUES (@documentId,@contractId,isnull(@paymentTypeId,1),@totalsum,@deficit,@payment,GETDATE(),@userId,@percent,@discountNumber
)
end
end
GO
PRINT N'Creating [Accounting].[spDocumentSaleReturn]...';


GO
create PROCEDURE [Accounting].[spDocumentSaleReturn]
	@userId int ,
	@operationType tinyint = null,
	@id INT = NULL,
	@menuId INT,
	@paymentid INT=NULL,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
	@description nvarchar(500)=null,
	@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,  
	@cashierId int=null,
    @accountId varchar(40)=null,
	@paymentDate datetime =null, 
		@partnerOrderNo nvarchar(200)=null,
		@mainNumber   int=null,
    
	@detail [Accounting].[UddtSaleGoodReturn] READONLY
AS

begin
BEGIN
IF @operationType IN (1,11)
GOTO spAdd;
--ELSE IF @operationType IN (2,12)
--GOTO spedit;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4
GOTO spSelect;


spAdd:
--BEGIN
--BEGIN TRAN 

--IF EXISTS(SELECT * FROM @detail d
--JOIN Accounting.VwGoodStock st WITH(ROWLOCK,HOLDLOCK) ON d.GoodId=st.Id
--WHERE ISNULL(st.quantity,0) + d.Quantity<=0 AND st.WarehouseId=@wareHouseId)
--BEGIN
--RAISERROR('Stokda kifayet qeder mehsul yoxdur',16,1)
--ROLLBACK
--RETURN
--END 
--ELSE 
BEGIN
INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],CashierId,[ContractId],[AccountId],[PaymentDate],[PartnerOrderNo],[MainNumber],CreateId,CreateDate)
VALUES                             (@includeDate,@companyId,@wareHouseId,@description,@paymentTypeId,@cashierId,@contractId,@accountId,@paymentDate,@partnerOrderNo,@mainNumber,@userId,GETDATE())

SET @id=SCOPE_IDENTITY();

DECLARE @totalAmount DECIMAL(26,6)=0,@payment DECIMAL(26,6),@amountWholeSale DECIMAL(26,6),@goodId INT,@barcodeId INT,@series nvarchar(200),@dateOfProduction datetime,@lastExpirationDate DATETIME
,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6),@discountPrice DECIMAL(26,6)
--declare sss cursor for 
--(select GoodId,Quantity from Accounting.Stock)
--open sss
--fetch next from sss into @stockgoodId,@stockquantity
--while @@FETCH_STATUS=0
--begin


DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountWholeSale],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[DiscountPrice]
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@discountPrice

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount=@totalAmount+(@quantity*(@priceWholeSale-@discountPrice))

INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[DiscountPrice],[CreateId],[CreateDate])
values                                             (@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy,@quantity*@priceRetail,@quantity*@priceWholeSale,@payment, @amountWholeSale,@discountPrice,@userId,GETDATE())
 
UPDATE Accounting.Stock
SET
Quantity=Quantity+@quantity
WHERE GoodId=@goodId AND Quantity>=0 and WarehouseId=@wareHouseId AND UpdateId IS null


--FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@discountPrice


end

close crs
deallocate crs
END
INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
VALUES(@id,@accountId,@customerId,ISNULL(@paymentTypeId,1),@payment,@totalAmount)
SET @paymentid=SCOPE_IDENTITY();

if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end

 

spDelete:
BEGIN
DECLARE @totalAmount1 DECIMAL(26,6)=0,@payment1 DECIMAL(26,6),@amountWholeSale1 DECIMAL(26,6),@goodId1 INT,@barcodeId1 INT,@series1 nvarchar(200),@dateOfProduction1 datetime,@lastExpirationDate1 DATETIME
,@quantity1 DECIMAL(26,6),@unitId1 INT,@priceBuy1 DECIMAL(26,6),@priceRetail1 DECIMAL(26,6),@priceWholeSale1 DECIMAL(26,6)
DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountWholeSale],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment1 ,@amountWholeSale1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1 
,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1
WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount1=@totalAmount1+@amountWholeSale1
INSERT INTO Accounting.Stock (GoodId,CreatId,CreateDate,WarehouseId,DocumentId,Quantity,PriceBuy,PrcieRetail,PriceWholeSale) VALUES (@goodId1,@userId,GETDATE(),@wareHouseId,@id,@quantity1,@priceBuy1,@priceRetail1,@priceWholeSale1)
FETCH NEXT FROM crs INTO @accountId ,@payment1 ,@amountWholeSale1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1
end
CLOSE crs
deallocate crs
update [Accounting].[Document]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;
DELETE FROM Accounting.Payment 
WHERE DocumentId=@id
UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id
if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
select  d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[PaymentDate]   
		,d.[PartnerOrderNo]
		,d.[MainNumber]
	,d.CashierId
	,d.CashierName
     
         ,max(dd.AmountBuy) AmountBuy
         ,max(dd.AmountRetail) AmountRetail
         ,max(dd.AmountWholeSale) AmountWholeSale
		 ,max(dd.PriceWholeSale) PriceWholeSale
	     ,max(dd.Payment) Payment
	     ,max(dd.Deficit) Deficit
from [Accounting].[VwDocument] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
 left join [Accounting].[VwContract] c on c.id=d.ContractId
 JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
WHERE AccountId=5 and d.DeleteId is null
 group by 
     d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]    
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[PaymentDate]   
		,d.[PartnerOrderNo]
		,d.[MainNumber]
		,d.CashierId
	,d.CashierName
		;
 RETURN 0
end
GO
PRINT N'Creating [Accounting].[spRetailAddTmps]...';


GO
CREATE PROCEDURE [Accounting].[spRetailAddTmps]
	@userId int
AS
begin

	select SaleNo,sum(PriceRetail*Quantity) [Total],CreateDate from Accounting.DocumentDetail
where CreateId=@userId
and SaleNo is not null and CreateDate>cast(getdate() as date)
group by SaleNo,CreateDate


RETURN 0
end
GO
PRINT N'Creating [Accounting].[spPaymentDebt]...';


GO
create  PROCEDURE [Accounting].[spPaymentDebt]
	@userId int,
	
@id int =null,
@operationType TINYINT,
@accountId int=NULL,
@customerId int=null,
@paymentTypeId int=null,

@expenseId int null,
	@cashId int null,
@payment DECIMAL(26,6),
@description VARCHAR(500),
@paymentDate datetime = null

AS

BEGIN
IF @operationType IN (1,11)
GOTO spAdd;
--ELSE IF @operationType IN (2,12)
--GOTO spedit;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4   
GOTO spSelect;


spAdd:

INSERT INTO Accounting.Payment(AccountId,CustomerId,PaymentTypeId,ExpenseId,CashId,Deficit,[Description],[PaymentDate],CreateDate) 
VALUES (@accountId,@customerId,@paymenttypeId,@expenseId,@cashId,@payment,@description,@paymentDate,getdate())
	

	 update  Accounting.Cash  set [Balance] = isnull  (Balance,0) +@payment

   
   where Id=@cashId 
   and @accountId=11



    update  Accounting.Cash  set [Balance] = isnull  (Balance,0) - @payment

   
   where Id=@cashId 
   and @accountId=10
   end

  RETURN 0
 spDelete:
BEGIN
 
   
update [Accounting].Payment
set [DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;
if @operationType=13 goto spSelect;
RETURN 0


spSelect:
select *
from [Accounting].VwPaymentIncludeOrder  
 
 RETURN 0

end
GO
PRINT N'Creating [Accounting].[spDebt]...';


GO
CREATE PROCEDURE [Accounting].[spDebt]
--Kohne Prosedur
	@operationType TINYINT=NULL,
	@userId INT,
	@customerId int=NULL
AS
BEGIN
DECLARE @deficit decimal(26,6)
	,@deficit2 decimal(26,6)
	SELECT @deficit=sum(case 
	WHEN AccountId  like '7' AND CustomerId=@customerId  THEN Deficit 
	WHEN  AccountId LIKE '8' AND  CustomerId=@customerId THEN Deficit
	WHEN  AccountId LIKE '9' AND CustomerId=@customerId THEN Deficit
	WHEN  AccountId LIKE '10' and CustomerId=@customerId then Deficit
	else 0 end),
    
	@deficit2=SUM(CASE 
	WHEN AccountId LIKE '3' AND CustomerId=@customerId THEN  Deficit
	WHEN AccountId LIKE '4' AND CustomerId=@customerId THEN  Deficit
	WHEN AccountId LIKE '5' AND CustomerId=@customerId THEN  Deficit
	WHEN AccountId LIKE '6' AND CustomerId=@customerId THEN  Deficit
	WHEN AccountId LIKE '11' AND CustomerId=@customerId THEN Deficit
	 else 0 end)
	 
	FROM Accounting.Payment p

	SELECT CustomerName,ISNULL((@deficit-@deficit2),0) Borc FROM Accounting.VwPayment
	

 WHERE CustomerId=@customerId
  GROUP BY CustomerName
end
GO
PRINT N'Creating [Accounting].[spDocumentReturnInclude]...';


GO
CREATE PROCEDURE [Accounting].[spDocumentReturnInclude]
	@userId int ,
	@operationType tinyint = null,
	@id INT = NULL,
	@menuId INT,
	@paymentid INT=NULL,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
	@description nvarchar(500)=null,
	@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
	@accountId int=null,
	@paymentDate datetime =null, 
		@partnerOrderNo nvarchar(200)=null,
		@mainNumber   int=null,
    
	@detail [Accounting].[UddtIncludeReturn] READONLY
	


AS

BEGIN
IF @operationType IN (1,11)
GOTO spAdd;
--ELSE IF @operationType IN (2,12)
--GOTO spedit;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4
GOTO spSelect;


spAdd:
BEGIN
BEGIN TRAN 

IF EXISTS(SELECT * FROM @detail d
JOIN Accounting.VwGoodStock st WITH(ROWLOCK,HOLDLOCK) ON d.GoodId=st.Id
WHERE ISNULL(st.quantity,0) - d.Quantity<0 AND st.WarehouseId=@wareHouseId)
BEGIN
RAISERROR('Stokda kifayet qeder mehsul yoxdur',16,1)
ROLLBACK
RETURN
END 
ELSE 
BEGIN
INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],[ContractId],[AccountId],[PaymentDate],[PartnerOrderNo],[MainNumber],CreateId,CreateDate)
VALUES (@includeDate,@companyId,@wareHouseId,@description,@paymentTypeId,@contractId,@accountId,@paymentDate,@partnerOrderNo,@mainNumber,@userId,GETDATE())

SET @id=SCOPE_IDENTITY();

DECLARE @totalAmount DECIMAL(26,6)=0,@payment DECIMAL(26,6),@amountBuy DECIMAL(26,6),@goodId INT,@barcodeId INT,@series nvarchar(200),@dateOfProduction datetime,@lastExpirationDate DATETIME
,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6)
--declare sss cursor for
--(select GoodId,Quantity from Accounting.Stock)
--open sss
--fetch next from sss into @stockgoodId,@stockquantity
--while @@FETCH_STATUS=0
--begin
DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount=@totalAmount+@amountBuy
 

INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[CreateId],[CreateDate])
values(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy,@quantity*@priceRetail,@quantity*@priceWholeSale,@payment, @amountBuy,@userId,GETDATE())
 

UPDATE Accounting.Stock
SET
Quantity=Quantity-@quantity
WHERE GoodId=@goodId AND Quantity>0 and WarehouseId=@wareHouseId AND UpdateId IS null


FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale


end

close crs
deallocate crs
END
INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
VALUES(@id,@accountId,@customerId,ISNULL(@paymentTypeId,1),@payment,@totalAmount)
SET @paymentid=SCOPE_IDENTITY();

if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end

--spEdit:
--begin
--update [Accounting].[Document]
--set

--[IncludeDate]=@includeDate,
--[CompanyId]=@companyId,
--[WareHouseId]=@wareHouseId,
--[Description]=@description,
--[PaymentTypeId]=@paymentTypeId,
--[ContractId]=@contractId,
--[AccountId]=@accountId

--where Id=@id;


----------------  Stock -------------

--;with chck as (
--select d.GoodId,sum(d.Quantity-isnull(dd.Quantity,0)) Quantity from @detail d 
--left join [Accounting].[DocumentDetail] dd on d.Id=dd.Id
--group by d.GoodId
--)


--merge [Accounting].[Stock] target
--using (select [GoodId] ,Quantity  from chck)source  on target.GoodId=source.GoodId
--when Matched then
--update set [Quantity]=target.Quantity-source.[Quantity] 
--when not matched by target then insert ([GoodId],[Quantity]) values(source.GoodId,source.Quantity);


--merge [Accounting].[DocumentDetail] target
--using (select [Id],[GoodId],@id [DocumentId],[AccountId],[BarCodeId],[Series],[DateOfProduction]
--,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
--,[Quantity]*[PriceBuy] [AmountBuy],[Quantity]*[PriceRetail] [AmountRetail]
--,[Quantity]*[PriceWholeSale] [AmountWholeSale],ISNULL([Payment],0) [Payment],[AmountBuy] [Deficit]
--FROM @detail) source on target.Id=source.Id
--when MATCHED and target.DocumentId=@id THEN 


--update set [AccountId]=source.[AccountId],[BarCodeId]=source.[BarCodeId],[Series]=source.[Series]
--,[DateOfProduction]=source.[DateOfProduction],[LastExpirationDate]=source.[LastExpirationDate]
--,[Quantity]=source.[Quantity],[UnitId]=source.[UnitId],[PriceBuy]=source.[PriceBuy]
--,[PriceRetail]=source.[PriceRetail],[PriceWholeSale]=source.[PriceWholeSale]
--,[AmountBuy]=source.[AmountBuy],[AmountRetail]=source.[AmountRetail]
--,[AmountWholeSale]=source.[AmountWholeSale],[Payment]=isnull(target.[Payment],0)
--,[Deficit]=source.[AmountBuy]


--when NOT MATCHED BY target then 
--insert  ( [DocumentId] ,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction]
--,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy]
--,[AmountRetail],[AmountWholeSale],[Payment],[Deficit])
--values (@id,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate]
--,[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[Quantity]*[PriceBuy]
--, [Quantity] * [PriceRetail] ,[Quantity]*[PriceWholeSale] ,isnull([Payment],0),[AmountBuy] )

--when NOT MATCHED BY source and target.DocumentId=@Id then update set [DeleteId]=@userId
--,[DeleteDate]=getdate();

--if @@TRANCOUNT>0
--   commit;
--if @operationType=12 goto spSelect;
--RETURN 0
--end
------------------------------------------------
spDelete:
BEGIN
DECLARE @totalAmount1 DECIMAL(26,6)=0,@payment1 DECIMAL(26,6),@amountBuy1 DECIMAL(26,6),@goodId1 INT,@barcodeId1 INT,@series1 nvarchar(200),@dateOfProduction1 datetime,@lastExpirationDate1 DATETIME
,@quantity1 DECIMAL(26,6),@unitId1 INT,@priceBuy1 DECIMAL(26,6),@priceRetail1 DECIMAL(26,6),@priceWholeSale1 DECIMAL(26,6)
DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1 
,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1
WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount1=@totalAmount1+@amountBuy1
INSERT INTO Accounting.Stock (GoodId,CreatId,CreateDate,WarehouseId,DocumentId,Quantity,PriceBuy,PrcieRetail,PriceWholeSale) VALUES (@goodId1,@userId,GETDATE(),@wareHouseId,@id,@quantity1,@priceBuy1,@priceRetail1,@priceWholeSale1)
FETCH NEXT FROM crs INTO @accountId ,@payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1
end
CLOSE crs
deallocate crs
update [Accounting].[Document]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;
DELETE FROM Accounting.Payment 
WHERE DocumentId=@id
UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id
if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
select  d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[PaymentDate]   
		,d.[PartnerOrderNo]
		,d.[MainNumber]
	
     
         ,max(dd.AmountBuy) AmountBuy
         ,max(dd.AmountRetail) AmountRetail
         ,max(dd.AmountWholeSale) AmountWholeSale
		 ,max(dd.PriceWholeSale) PriceWholeSale
	     ,max(dd.Payment) Payment
	     ,max(dd.Deficit) Deficit
from [Accounting].[VwDocument] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
 left join [Accounting].[VwContract] c on c.id=d.ContractId
 JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
WHERE AccountId=9 and d.DeleteId is null
 group by 
     d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]    
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[PaymentDate]   
		,d.[PartnerOrderNo]
		,d.[MainNumber]
		;
 RETURN 0
end
GO
PRINT N'Creating [Accounting].[spBankGroup]...';


GO
CREATE PROCEDURE [Accounting].[spBankGroup]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [Accounting].[BankGroup]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].[BankGroup]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].[BankGroup]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [Accounting].[VwBankGroup]
RETURN 0
end
GO
PRINT N'Creating [Accounting].[spDocumentRetailReturn]...';


GO
CREATE PROCEDURE [Accounting].[spDocumentRetailReturn]


@userId int ,
@menuId INT,
	@operationType tinyint = null,
	@id INT = NULL,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
	@description nvarchar(500)=NULL,
	@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
	@accountId int=null,
	@paymentid INT=NULL,
	@paymentDate datetime =null, 
    @partnerOrderNo nvarchar(200)=null,
    @mainNumber int =null,
    
	@detail [Accounting].[UddtRetailSaleGoodReturn] readonly
	

with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
--else if @operationType in (2,12)
--goto spedit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
begin tran 

if exists(select * from @detail d
join Accounting.VwGoodStock st with(rowlock,holdlock) on d.GoodId=st.Id
WHERE ISNULL(st.Quantity,0) + d.Quantity<0 AND st.WarehouseId=@wareHouseId)
begin
raiserror('Say duzgun deyil',16,1)
rollback
return
end
else 
BEGIN

INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],[ContractId],[AccountId],[PaymentDate],[PartnerOrderNo],[MainNumber])
VALUES (@includeDate,@companyId,@wareHouseId,@description,@paymentTypeId,@contractId,@accountId,@paymentDate,@partnerOrderNo,@mainNumber)

SET @id=SCOPE_IDENTITY();

DECLARE @totalAmount DECIMAL(26,6)=0,@payment DECIMAL(26,6),@amountretail DECIMAL(26,6),@goodId INT,@barcodeId INT,@series nvarchar(200),@dateOfProduction datetime,@lastExpirationDate DATETIME
,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6)

DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountRetail],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountretail ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale

WHILE @@FETCH_STATUS=0
BEGIN

SET @totalAmount=@totalAmount+@amountretail
DECLARE @element INT=0
SELECT @element=Id FROM DocumentDetail WHERE GoodId=@goodId AND (SELECT SUM(Quantity) FROM DocumentDetail WHERE GoodId=@goodId AND AccountId=8)>=@quantity 
IF(@element>0)
BEGIN

--INSERT INTO Accounting.Payment (AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
--VALUES(@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@amountretail)


INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[CreateId],[CreateDate])
values(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy,@quantity*@priceRetail,@quantity*@priceWholeSale,@payment, @amountretail,@userId,GETDATE())


--INSERT INTO [Accounting].[Stock]( [GoodId],[Quantity],[PriceBuy],[PrcieRetail],[PriceWholeSale],[CreateDate]) 
--values (@goodId,@quantity,@priceBuy,@priceRetail,@priceWholeSale,getdate())

UPDATE Accounting.Stock
SET
Quantity=Quantity+@quantity
WHERE Id=(select max(s.Id) from Accounting.Stock s where s.GoodId=@goodId and s.WarehouseId=@wareHouseId AND s.UpdateId IS null)

end
else
begin
raiserror('Say duzgun deyil',16,1)
rollback
return
end
--update st set st.Quantity=st.Quantity+d.Quantity
--from @detail d 
--join Accounting.Stock st with(rowlock,holdlock) on d.GoodId=st.GoodId WHERE d.GoodId=@goodId AND st.Id=(select max(Id)  from Accounting.Stock where GoodId=@goodId );

FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountretail ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale


end

close crs
deallocate crs
INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
VALUES(@id,@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@totalAmount)
SET @paymentid=SCOPE_IDENTITY();
END

if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end

 
spDelete:
BEGIN

DECLARE @totalAmount1 DECIMAL(26,6)=0,@payment1 DECIMAL(26,6),@amountBuy1 DECIMAL(26,6),@goodId1 INT,@barcodeId1 INT,@series1 NVARCHAR(200),@dateOfProduction1 DATETIME,@lastExpirationDate1 DATETIME
,@quantity1 DECIMAL(26,6),@unitId1 INT,@priceBuy1 DECIMAL(26,6),@priceRetail1 DECIMAL(26,6),@priceWholeSale1 DECIMAL(26,6)

DECLARE crs CURSOR FOR 
(SELECT ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)
OPEN crs
FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1 
,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount1=@totalAmount1+@amountBuy1


declare @g int,@q decimal(25,5),@sId int,@deficitQuantity decimal(25,5)=0

DECLARE css CURSOR FOR 
(SELECT s.Id,s.GoodId,s.Quantity
FROM Accounting.Stock s WHERE s.Quantity>0 AND s.GoodId=@goodId1 AND s.WarehouseId=@wareHouseId AND s.UpdateId IS null)
OPEN css
FETCH NEXT FROM css INTO @sId,@g,@q

WHILE @@FETCH_STATUS=0
BEGIN
if(@deficitQuantity IS NOT null)
begin
if(@quantity1>@q AND @deficitQuantity=0)
begin
SET @deficitQuantity=@quantity1-@q
UPDATE Accounting.Stock
SET
    Quantity = 0
	where Id=@sId AND GoodId=@goodId1 
end

if(@quantity1>@q AND @deficitQuantity>@q)
begin
SET @deficitQuantity=@deficitQuantity-@q
UPDATE Accounting.Stock
SET
    Quantity = 0
	where Id=@sId AND GoodId=@goodId1
END

if(@quantity1>@q AND @deficitQuantity<=@q)
BEGIN
UPDATE Accounting.Stock
SET
    Quantity = @q-@deficitQuantity
	where Id=@sId AND GoodId=@goodId1
SET @deficitQuantity=null
END

ELSE
begin
UPDATE Accounting.Stock
SET
    Quantity = @q-@quantity1
	where Id=@sId AND GoodId=@goodId1
	SET @deficitQuantity=null
END

end
FETCH NEXT FROM css INTO @sId,@g,@q

end

close css
deallocate css


FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1


END

CLOSE crs
DEALLOCATE crs


DELETE FROM Accounting.Payment 
WHERE DocumentId=@id

UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id

update [Accounting].[Document]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
select  
     d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[PaymentDate]   
    ,d.[PartnerOrderNo]
    ,d.[MainNumber]

         ,max(dd.AmountBuy) AmountBuy
         ,max(dd.AmountRetail) AmountRetail
         ,max(dd.AmountWholeSale) AmountWholeSale
		 ,max(dd.PriceWholeSale) PriceWholeSale
	     ,max(dd.Payment) Payment
	     ,max(dd.Deficit) Deficit
from [Accounting].[VwDocument] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
 left join [Accounting].[VwContract] c on c.id=d.ContractId
 JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
 where d.DeleteId is NULL AND AccountId=4
 group by 
     
	 d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[PaymentDate]   
    ,d.[PartnerOrderNo]
    ,d.[MainNumber]

	;
 RETURN 0
end
GO
PRINT N'Creating [Accounting].[spIncludeOrder]...';


GO
CREATE PROCEDURE [Accounting].[spIncludeOrder]
	@userId int 
	 
 as
	SELECT vdd.CustomerName,sum(p.Deficit) Borc FROM Accounting.VwDocumentDetail vdd
	join Accounting.Payment p on vdd.PaymentId=p.Id
JOIN Accounting.VwDocument vd ON vdd.DocumentId=vd.Id
 WHERE vdd.AccountCode=1.1  and  vdd.Deficit<>'0'
  GROUP BY vdd.CustomerName
GO
PRINT N'Creating [Accounting].[spDocumentDeletion]...';


GO
CREATE PROCEDURE [Accounting].[spDocumentDeletion]
	@userId int ,
	@operationType tinyint = null,
	@id INT = NULL,
	@menuId int,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL, 
	@description nvarchar(500)=NULL,
	@contractId int =null,
	@customerId int=null,
	@reasonId int=null,
	@paymentid int = null,
	@accountId int=null,
    
	@detail [Accounting].[UddtDeleteGood] readonly
	

--with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
--else if @operationType in (2,12)
--goto spedit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
begin tran 

if exists(select * from @detail d
join Accounting.VwGoodStock st on d.GoodId=st.Id
where ISNULL(st.quantity,0) - d.Quantity<0 and st.WarehouseId=@wareHouseId)

BEGIN
raiserror('Stokda qeyd etdiyiniz sayda  mehsul yoxdur',16,1)
rollback
return
end
else 
begin
INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[ContractId],[AccountId],[ReasonId],[CreateId])
values (@includeDate,@companyId,@wareHouseId,@description,@contractId,6,@reasonId,@userId)

set @id=SCOPE_IDENTITY();
DECLARE @barcodeId int,@stogoodId int,@companyName nvarchar(20),@customerName nvarchar(20),@goodId int,@series nvarchar(200),@dateofProduction datetime,@lastExpirationdate datetime,@quantity decimal(25,5),@unitId int,@priceBuy decimal(26,6),@priceRetail decimal(26,6),@priceWholeSale decimal(26,6),@amountBuy decimal(26,6),@amountRetail decimal(26,6),@amountWholeSale decimal(26,6),@payment decimal(26,6),@deficit decimal(26,6)
DECLARE css CURSOR FOR
(SELECT d.BarcodeId,d.StoGoodId,d.CompanyName,d.CustomerName,d.AccountId,d.GoodId,d.Series,d.DateOfProduction,d.LastExpirationDate,d.Quantity,d.UnitId,d.PriceBuy,d.PriceRetail,d.PriceWholeSale,d.AmountBuy,d.AmountRetail,d.AmountWholeSale,d.Payment,d.Deficit FROM @detail d)
OPEN css
FETCH NEXT FROM css INTO @barcodeId,@stogoodId,@companyName,@customerName,@accountId,@goodId,@series,@dateofProduction,@lastExpirationdate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@amountBuy,@amountRetail,@amountWholeSale,@payment,@deficit
WHILE @@FETCH_STATUS=0
begin


declare @g int,@q decimal(25,5),@sId int,@deficitQuantity decimal(25,5)=0

DECLARE crs CURSOR FOR 
(SELECT s.Id,s.GoodId,s.Quantity
FROM Accounting.Stock s WHERE s.Quantity>0 AND s.GoodId=@goodId AND s.WarehouseId=@wareHouseId AND s.UpdateId IS null)
OPEN crs
FETCH NEXT FROM crs INTO @sId,@g,@q

WHILE @@FETCH_STATUS=0
BEGIN
if(@deficitQuantity IS NOT null)
begin
if(@quantity>@q AND @deficitQuantity=0)
begin
SET @deficitQuantity=@quantity-@q
UPDATE Accounting.Stock
SET
    Quantity = 0
	where Id=@sId AND GoodId=@goodId
end

if(@quantity>@q AND @deficitQuantity>@q)
begin
SET @deficitQuantity=@deficitQuantity-@q
UPDATE Accounting.Stock
SET
    Quantity = 0
	where Id=@sId AND GoodId=@goodId
END

if(@quantity>@q AND @deficitQuantity<=@q)
BEGIN
UPDATE Accounting.Stock
SET
    Quantity = @q-@deficitQuantity
	where Id=@sId AND GoodId=@goodId
SET @deficitQuantity=null
END

ELSE
begin
UPDATE Accounting.Stock
SET
    Quantity = @q-@quantity
	where Id=@sId AND GoodId=@goodId
	SET @deficitQuantity=null
END

end
FETCH NEXT FROM crs INTO @sId,@g,@q

end

close crs
deallocate crs










insert into [Accounting].[DocumentDetail]([DocumentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[Description],[CreateId],[CreateDate])
values (@id,@accountId, @goodId,@barcodeId,@series,@dateofProduction,@lastExpirationdate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@quantity*@priceBuy ,@quantity*@priceRetail,@quantity*@priceWholeSale,@payment,(@quantity*@priceBuy) - @payment,@description,@userId,GETDATE())


FETCH NEXT FROM css INTO @barcodeId,@stogoodId,@companyName,@customerName,@accountId,@goodId,@series,@dateofProduction,@lastExpirationdate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@amountBuy,@amountRetail,@amountWholeSale,@payment,@deficit
end

close css
deallocate css

END
if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end

--spEdit:
--begin
--update [Accounting].[Document]
--set

--[IncludeDate]=@includeDate,
--[CompanyId]=@companyId,
--[WareHouseId]=@wareHouseId, 
--[Description]=@description,
--[ContractId]=@contractId,
--[AccountId]=@accountId,
--[ReasonId]=@reasonId,
--[UpdateId]=@userId,
--[UpdateDate]=getdate()

--where Id=@id;


----------------  Stock -------------

--;with chck as (
--select d.GoodId,sum(d.Quantity-isnull(dd.Quantity,0)) Quantity from @detail d 
--left join [Accounting].[DocumentDetail] dd on d.Id=dd.Id
--group by d.GoodId
--)


--merge [Accounting].[Stock] target
--using (select [GoodId] ,Quantity  from chck)source  on target.GoodId=source.GoodId
--when Matched then
--update set [Quantity]=target.Quantity-source.[Quantity]
--when not matched by target then insert ([GoodId],[Quantity]) values(source.GoodId,source.Quantity);


--merge [Accounting].[DocumentDetail] target
--using (select [Id],[GoodId],@id [DocumentId],[AccountId],[BarCodeId],[Series],[DateOfProduction]
--,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
--,[Quantity]*[PriceBuy] [AmountBuy],[Quantity]*[PriceRetail] [AmountRetail]
--,[Quantity]*[PriceWholeSale] [AmountWholeSale],[Payment],[AmountBuy] - [Payment] [Deficit],[Description]
--from @detail) source on target.Id=source.Id
--when MATCHED and target.DocumentId=@id THEN 


--update set [AccountId]=source.[AccountId]
--,[BarCodeId]=source.[BarCodeId]
--,[Series]=source.[Series]
--,[DateOfProduction]=source.[DateOfProduction]
--,[LastExpirationDate]=source.[LastExpirationDate]
--,[Quantity]=source.[Quantity]
--,[UnitId]=source.[UnitId]
--,[PriceBuy]=source.[PriceBuy]
--,[PriceRetail]=source.[PriceRetail]
--,[PriceWholeSale]=source.[PriceWholeSale]
--,[AmountBuy]=source.[AmountBuy]
--,[AmountRetail]=source.[AmountRetail]
--,[AmountWholeSale]=source.[AmountWholeSale]
--,[Payment]=source.[Payment]
--,[Deficit]=source.[AmountBuy]-(isnull(target.[Payment],0)+source.[Payment])
--,[Description]=source.[Description] 
--,[UpdateDate]=getdate()
--,[UpdateId]=@userid


--when NOT MATCHED BY target then 
--insert  ( [DocumentId] ,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction]
--,[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy]
--,[AmountRetail],[AmountWholeSale],[Payment],[Deficit],[Description])
--values (@id,[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate]
--,[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[Quantity]*[PriceBuy]
--, [Quantity] * [PriceRetail] ,[Quantity]*[PriceWholeSale] ,[Payment],[AmountBuy]-[Payment],[Description] )

--when NOT MATCHED BY source and target.DocumentId=@Id then update set [DeleteId]=@userId
--,[DeleteDate]=getdate();

--if @@TRANCOUNT>0
--   commit;
--if @operationType=12 goto spSelect;
--RETURN 0
--end

spDelete:
BEGIN

DECLARE @totalAmount1 DECIMAL(26,6)=0,@payment1 DECIMAL(26,6),@amountBuy1 DECIMAL(26,6),@goodId1 INT,@barcodeId1 INT,@series1 NVARCHAR(200),@dateOfProduction1 DATETIME,@lastExpirationDate1 DATETIME
,@quantity1 DECIMAL(26,6),@unitId1 INT,@priceBuy1 DECIMAL(26,6),@priceRetail1 DECIMAL(26,6),@priceWholeSale1 DECIMAL(26,6)

DECLARE crs CURSOR FOR 
(SELECT ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)
OPEN crs
FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1 
,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount1=@totalAmount1+@amountBuy1



INSERT INTO Accounting.Stock (GoodId,CreatId,CreateDate,WarehouseId,DocumentId,Quantity,PriceBuy,PrcieRetail,PriceWholeSale) VALUES (@goodId1,@userId,GETDATE(),@wareHouseId,@id,@quantity1,@priceBuy1,@priceRetail1,@priceWholeSale1)



FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1


END

CLOSE crs
DEALLOCATE crs



UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id


update [Accounting].[Document]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
select  d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName] 
	,d.[Description]
	,d.ContractId
	,d.CustomerId
	,d.CustomerName
	,r.Id ReasonId
	,r.Name ReasonName
	,dd.Series
	

         ,max(dd.AmountBuy) AmountBuy
         ,max(dd.AmountRetail) AmountRetail
         ,max(dd.AmountWholeSale) AmountWholeSale
		 ,max(dd.PriceWholeSale) PriceWholeSale
	     ,max(dd.Payment) Payment
	     ,max(dd.Deficit) Deficit
from [Accounting].[VwDocument] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId 
 LEFT JOIN Accounting.Document dw ON dw.Id=d.Id
 LEFT JOIN [Accounting].[Reason] r ON r.Id=dw.ReasonId
 JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
 where dw.AccountId=6 AND d.DeleteId IS NULL
 
 --c.ContractTypeId=2--satiw ucun
 group by 
     d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName] 	
	,d.[Description]
	,d.ContractId
	,d.CustomerId
	,d.CustomerName
	,r.Id 
	,r.Name 
	,dd.Series;
end
GO
PRINT N'Creating [Accounting].[spDocumentRetailsSale]...';


GO
CREATE PROCEDURE [Accounting].[spDocumentRetailsSale]
	@userId int ,
	@operationType tinyint = null,
	@menuId int,
	@id INT = NULL,
	@paymentid int =null,
	@includeDate DATETIME=NULL,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
		@description nvarchar(500)=null,
	@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
	 @accountCode varchar(40)=null,
	@paymentDate datetime =null, 
		@partnerOrderNo nvarchar(200)=null,
    
	@detail [Accounting].[UddtRetailsSaleGood] readonly
	

--with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
--else if @operationType in (2,12)
--goto spedit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
begin tran 

if exists(select * from @detail d
join Accounting.VwGoodStock st with(rowlock,holdlock) on d.GoodId=st.Id
where ISNULL(st.quantity,0) - d.Quantity<0 AND st.WarehouseId=@wareHouseId)
begin
raiserror('Stokda kifayet qeder mehsul yoxdur',16,1)
rollback
return
end
else 
begin



INSERT INTO [Accounting].[Document]( [IncludeDate],[CompanyId],[WareHouseId],[Description],[PaymentTypeId],[ContractId],[SaleNo],Accounting.Document.CreateId,AccountId,[PaymentDate],[PartnerOrderNo])
VALUES (@includeDate,@companyId,@wareHouseId,@description,@paymentTypeId,@contractId,[Accounting].[SFnNewSaleNo](@userId,@accountCode),@userId,7,@paymentDate,@partnerOrderNo)

SET @id=SCOPE_IDENTITY();

DECLARE @totalAmount DECIMAL(26,6)=0,@accountId  INT,@payment DECIMAL(26,6),@amountWholeSale DECIMAL(26,6),@goodId INT,@barcodeId INT,@series nvarchar(200),@dateOfProduction datetime,@lastExpirationDate DATETIME
,@quantity DECIMAL(26,6),@unitId INT,@priceBuy DECIMAL(26,6),@priceRetail DECIMAL(26,6),@priceWholeSale DECIMAL(26,6),@percent NVARCHAR(50)
DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountWholeSale],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],ISNULL([Percent]+' % Endirim','0')
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate 
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent

WHILE @@FETCH_STATUS=0
BEGIN

 


 

DECLARE @q1 decimal(25,5),@stockId INT,@t3 DECIMAL(25,5)=0,@Tquantity DECIMAL(25,5)=0,@TpriceBuy DECIMAL(26,6)=0,@TpriceRetail DECIMAL(26,6)=0,@TpriceWholeSale DECIMAL(26,6)=0,@count int=0
DECLARE css CURSOR FOR (SELECT s.Quantity,s.Id FROM Accounting.Stock s WHERE s.GoodId=@goodId and s.Quantity>0 and s.WarehouseId=@wareHouseId AND UpdateId IS null)
OPEN css
FETCH NEXT FROM css INTO @q1,@stockId
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @p1 decimal(25,5),@p2 decimal(25,5),@p3 decimal(25,5),@ff Decimal (25,2)


SET @p1=(
    SELECT s.PriceBuy FROM Accounting.Stock s 
WHERE s.Id=@stockId)

SET @p2=(
    SELECT s.PrcieRetail FROM Accounting.Stock s 
WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId) )

SET @p3=(
    SELECT s.PriceWholeSale FROM Accounting.Stock s 
WHERE s.Id=(select max(s2.Id)  from Accounting.Stock s2 where GoodId=@goodId) )

IF(@t3 IS NOT NULL)
BEGIN
set @count=@count + 1
IF(@q1<@quantity AND @t3=0)

BEGIN

 set @t3=@quantity-@q1
 SET @ff=(@q1*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId

   set @TQuantity=@Tquantity+@q1
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3


END

ELSE IF(@q1<@quantity AND @t3>@q1)
BEGIN

 set @t3=@t3-@q1
 SET @ff=(@q1*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId
 
 set @TQuantity=@Tquantity+@q1
   set @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   set @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3

END

ELSE IF(@q1<@quantity AND @t3<=@q1)
BEGIN
SET @ff=(@t3*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

   SET @TQuantity=@Tquantity+@t3
   SET @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   SET @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3


 SET @t3=NULL
END

ELSE IF(@q1>=@quantity AND @t3>0)
BEGIN
SET @ff=(@t3*100)/@quantity
UPDATE Accounting.Stock
SET
   Quantity = @q1-@t3 WHERE GoodId=@goodId AND Id=@stockId

   SET @TQuantity=@Tquantity+@t3
   SET @TpriceBuy = (@TpriceBuy + ((@p1*@ff)/100))
   SET @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3


 SET @t3=NULL
END

ELSE

BEGIN
      UPDATE Accounting.Stock
SET 
   Quantity =  @q1-@quantity WHERE GoodId=@goodId AND Id=@stockId 
   SET @TQuantity=@Tquantity+@quantity
   SET @TpriceBuy = (@TpriceBuy + @p1)
   SET @TpriceRetail = @p2
   SET @TpriceWholeSale = @p3

  SET @t3=NULL



  
END
END



FETCH NEXT FROM css INTO @q1,@stockId
SET @totalAmount=@totalAmount+(@TQuantity*@TpriceRetail)
   END
CLOSE css
DEALLOCATE css


   INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId]
   ,[Series],[DateOfProduction],[LastExpirationDate],[Quantity]
   ,[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[Percent],[CreateId],[CreateDate])
VALUES(@id,@paymentid,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@TQuantity,@unitId
,@TpriceBuy,@TpriceRetail,@TpriceWholeSale,@TQuantity*@TpriceBuy,@TQuantity*@TpriceRetail,@TQuantity*@TpriceWholeSale,@payment, @TQuantity*@TpriceRetail,@percent,@userId,getdate())







FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountWholeSale ,@goodId,@barcodeId,@series ,@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale,@percent
end

close crs
deallocate crs
END
INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerId,PaymentTypeId,Payment,Deficit) 
VALUES(@id,@accountId,@customerId,isnull(@paymentTypeId,1),@payment,@totalAmount)
 SET @paymentid=SCOPE_IDENTITY();

if @@TRANCOUNT>0 
commit;


if @operationType=11 goto spSelect;
RETURN 0
end
 

spDelete:
begin

DECLARE @totalAmount1 DECIMAL(26,6)=0,@payment1 DECIMAL(26,6),@amountBuy1 DECIMAL(26,6),@goodId1 INT,@barcodeId1 INT,@series1 NVARCHAR(200),@dateOfProduction1 DATETIME,@lastExpirationDate1 DATETIME
,@quantity1 DECIMAL(26,6),@unitId1 INT,@priceBuy1 DECIMAL(26,6),@priceRetail1 DECIMAL(26,6),@priceWholeSale1 DECIMAL(26,6)

DECLARE crs CURSOR FOR 
(SELECT ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)
OPEN crs
FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1 
,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount1=@totalAmount1+@amountBuy1


UPDATE Accounting.Stock
SET
UpdateId=@userId,
UpdateDate=GETDATE(),
Quantity=Quantity+@quantity1
WHERE Id=(select max(s.Id) FROM Accounting.Stock s WHERE s.GoodId=@goodId1 AND s.PriceBuy=@priceBuy1 and s.WarehouseId=@wareHouseId AND UpdateId IS null)



FETCH NEXT FROM crs INTO @payment1 ,@amountBuy1 ,@goodId1,@barcodeId1,@series1 ,@dateOfProduction1 ,@lastExpirationDate1,@quantity1,@unitId1,@priceBuy1,@priceRetail1,@priceWholeSale1


END

CLOSE crs
DEALLOCATE crs

DELETE FROM Accounting.Payment WHERE DocumentId=@id

UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id


update [Accounting].[Document]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where Id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end
spSelect:
select  d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[PaymentDate]   
		,d.[PartnerOrderNo]
     
         ,max(dd.AmountBuy) AmountBuy
         ,max(dd.AmountRetail) AmountRetail
         ,max(dd.AmountWholeSale) AmountWholeSale
		 ,max(dd.PriceWholeSale) PriceWholeSale
	     ,max(dd.Payment) Payment
	     ,max(dd.Deficit) Deficit
from [Accounting].[VwDocumentRetailsSale] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
 left join [Accounting].[VwContract] c on c.id=d.ContractId
 JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
 where AccountId=8 and d.DeleteId is null
 group by 
     d.[Id]  
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	,d.[PaymentDate]   
		,d.[PartnerOrderNo];
 RETURN 0
end
GO
PRINT N'Creating [Accounting].[spChangePrice]...';


GO
create PROC Accounting.spChangePrice
@userId int,
@description nvarchar(500)='--',

@detail [Accounting].[UddtChangePrice] READONLY
AS
BEGIN
DECLARE  @goodId INT,@priceBuy decimal(25,5),@priceRetail decimal(25,5),@priceWholeSale decimal(25,5),@newpriceBuy DECIMAL(25,5),@newpriceRetail DECIMAL(25,5),@newpriceWholeSale DECIMAL(25,5)

DECLARE crs CURSOR FOR 
(SELECT [GoodId],[PriceBuy],[PriceRetail],[PriceWholeSale],[NewPriceBuy],[NewPriceRetail],[NewPriceWholeSale]
FROM @detail)
OPEN crs
FETCH NEXT FROM crs INTO @goodId,@priceBuy,@priceRetail,@priceWholeSale,@newpriceBuy,@newpriceRetail,@newpriceWholeSale

WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @stockId int,@quantity DECIMAL(25,5)

SELECT @stockId=s.Id,@quantity=s.Quantity FROM Accounting.Stock s 
WHERE s.Id=(SELECT max(s2.Id) FROM Accounting.Stock s2 WHERE s2.GoodId=@goodId)

UPDATE Accounting.Stock 
SET

    Accounting.Stock.PriceBuy = @newpriceBuy, 
    Accounting.Stock.PrcieRetail = @newpriceRetail, 
    Accounting.Stock.PriceWholeSale = @newpriceWholeSale, 
    Accounting.Stock.UpdateDate = getdate(),
    Accounting.Stock.UpdateId = @userId
WHERE Id=(SELECT MAX(s.Id) FROM Accounting.Stock s WHERE s.GoodId=@goodId)
	

	INSERT INTO Accounting.LastPrice (StockId,GoodId      ,LastPriceBuy,LastPriceRetail,LastPriceWholeSale    ,PriceBuy,PriceRetail,PriceWholeSale  ,Description,CreateId,CreateDate) 
	VALUES (@stockId,@goodId,@priceBuy,@priceRetail,@priceWholeSale                                           ,@newpriceBuy,@newpriceRetail,@newpriceWholeSale,@description,@userId,GETDATE())

UPDATE Accounting.DocumentDetail
SET


    Accounting.DocumentDetail.PriceBuy =@newpriceBuy, 
    Accounting.DocumentDetail.PriceRetail =@newpriceRetail, 
    Accounting.DocumentDetail.PriceWholeSale = @newpriceWholeSale,
	Accounting.DocumentDetail.AmountBuy =@quantity*@newpriceBuy, 
	Accounting.DocumentDetail.AmountRetail =@quantity*@newpriceRetail, 
    Accounting.DocumentDetail.AmountWholeSale = @quantity*@newpriceWholeSale,
    Accounting.DocumentDetail.UpdateId = @userId, 
    Accounting.DocumentDetail.UpdateDate = getdate(),
	Accounting.DocumentDetail.Description='Qiymet Deyisme Edilib'

	WHERE Id=(SELECT MAX(s.Id) FROM Accounting.DocumentDetail s WHERE s.GoodId=@goodId AND s.AccountId=3)
    
	FETCH NEXT FROM crs INTO @goodId,@priceBuy,@priceRetail,@priceWholeSale,@newpriceBuy,@newpriceRetail,@newpriceWholeSale


end

close crs
deallocate crs

	END


--create PROC Accounting.spChangePrice
--@userId int,
--@description nvarchar(500)='--',

--@detail [Accounting].[UddtChangePrice] READONLY
--AS
--BEGIN
--DECLARE  @goodId INT,@priceBuy decimal(25,5),@priceRetail decimal(25,5),@priceWholeSale decimal(25,5),@newpriceBuy DECIMAL(25,5),@newpriceRetail DECIMAL(25,5),@newpriceWholeSale DECIMAL(25,5)

--DECLARE crs CURSOR FOR 
--(SELECT [GoodId],[PriceBuy],[PriceRetail],[PriceWholeSale],[NewPriceBuy],[NewPriceRetail],[NewPriceWholeSale]
--FROM @detail)
--OPEN crs
--FETCH NEXT FROM crs INTO @goodId,@priceBuy,@priceRetail,@priceWholeSale,@newpriceBuy,@newpriceRetail,@newpriceWholeSale

--WHILE @@FETCH_STATUS=0
--BEGIN
--DECLARE @stockId int,@quantity DECIMAL(25,5)

--SELECT @stockId=s.Id,@quantity=s.Quantity FROM Accounting.Stock s 
--WHERE s.Id=(SELECT max(s2.Id) FROM Accounting.Stock s2 WHERE s2.GoodId=@goodId)

--UPDATE Accounting.Stock 
--SET

--    Accounting.Stock.PriceBuy = @newpriceBuy, 
--    Accounting.Stock.PrcieRetail = @newpriceRetail, 
--    Accounting.Stock.PriceWholeSale = @newpriceWholeSale, 
--    Accounting.Stock.UpdateDate = getdate(),
--    Accounting.Stock.UpdateId = @userId
--WHERE Id=(SELECT MAX(s.Id) FROM Accounting.Stock s WHERE s.GoodId=@goodId)
	

--	INSERT INTO Accounting.LastPrice (StockId,GoodId      ,LastPriceBuy,LastPriceRetail,LastPriceWholeSale,PriceBuy,PriceRetail,PriceWholeSale  ,Description,CreateId,CreateDate) 
--	VALUES (@stockId,@goodId,@priceBuy,@priceRetail,@priceWholeSale                             ,@newpriceBuy,@newpriceRetail,@newpriceWholeSale,@description,@userId,GETDATE())

--UPDATE Accounting.DocumentDetail
--SET


--    Accounting.DocumentDetail.PriceBuy =@newpriceBuy, 
--    Accounting.DocumentDetail.PriceRetail =@newpriceRetail, 
--    Accounting.DocumentDetail.PriceWholeSale = @newpriceWholeSale,
--	Accounting.DocumentDetail.AmountBuy =@quantity*@newpriceBuy, 
--	Accounting.DocumentDetail.AmountRetail =@quantity*@newpriceRetail, 
--    Accounting.DocumentDetail.AmountWholeSale = @quantity*@newpriceWholeSale,
--    Accounting.DocumentDetail.UpdateId = @userId, 
--    Accounting.DocumentDetail.UpdateDate = getdate(),
--	Accounting.DocumentDetail.Description='Qiymet Deyisme Edilib'

--	WHERE Id=(SELECT MAX(s.Id) FROM Accounting.DocumentDetail s WHERE s.GoodId=@goodId AND s.AccountId=3)
    
--	FETCH NEXT FROM crs INTO @goodId,@priceBuy,@priceRetail,@priceWholeSale,@newpriceBuy,@newpriceRetail,@newpriceWholeSale


--end

--close crs
--deallocate crs

--	END
GO
PRINT N'Creating [Accounting].[spPayment]...';


GO
CREATE PROC [Accounting].[spPayment]
@userId int
AS
BEGIN
SELECT * FROM Accounting.VwPayment p
END
GO
PRINT N'Creating [Accounting].[spDeficitStock]...';


GO
CREATE PROC [Accounting].[spDeficitStock]
@userId INT
,@menuId int
AS
BEGIN
SELECT * FROM Accounting.VwDeficitGoodStock vdgs
JOIN dbo.WarehouseMenuCollection wmc ON wmc.WarehouseId=vdgs.WarehouseId AND wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId

end
GO
PRINT N'Creating [Accounting].[spCustomerDebt]...';


GO
CREATE PROCEDURE [Accounting].[spCustomerDebt]
@userId int
AS
	BEGIN

DECLARE @accountId int,@accountname varchar(200),@customerId int,@customername varchar(200),@payment decimal(26,6),@createdate datetime
DECLARE crs CURSOR FOR(SELECT vp.AccountId,vp.AccountName,vp.CustomerId,vp.CustomerName,vp.Deficit,vp.CreateDate FROM Accounting.VwPayment vp

  join Accounting.[Contract]  c on c.CustomerId=vp.CustomerId


WHERE  ContractTypeId <>3
)
OPEN crs
FETCH NEXT FROM crs INTO @accountId,@accountname,@customerId,@customername,@payment,@createdate
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @deficit decimal(26,6)=0
	,@deficit2 decimal(26,6)=0
	SELECT @deficit=SUM(CASE 
	WHEN  vp.AccountId  LIKE '7' AND vp.CustomerId=@customerId  THEN Deficit 
	WHEN  vp.AccountId LIKE '8' AND  vp.CustomerId=@customerId THEN Deficit
	WHEN  vp.AccountId LIKE '9' AND vp.CustomerId=@customerId THEN Deficit
	WHEN  vp.AccountId LIKE '10' AND vp.CustomerId=@customerId THEN Deficit
	ELSE 0 END),
    
	@deficit2=SUM(CASE 
	WHEN vp.AccountId LIKE '3' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '4' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '5' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '6' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '11' AND vp.CustomerId=@customerId THEN Deficit
	 ELSE 0 END)
     
	FROM Accounting.VwPayment vp 

	DECLARE @cust int=0
	SELECT @cust=ISNULL(p.CustomerId,0) FROM [Accounting].CustomerDebt p WHERE p.CustomerId=@customerId 
	IF @cust=@customerId and @customerId<>0
UPDATE [Accounting].CustomerDebt
SET
Deficit=@deficit-@deficit2
WHERE CustomerId=@customerId;

else 
insert into [Accounting].CustomerDebt (CustomerId,Deficit)
values(@customerId,@deficit-@deficit2)

	FETCH NEXT FROM crs INTO @accountId,@accountname,@customerId,@customername,@payment,@createdate
	end
 
close crs
deallocate crs
	SELECT * FROM [Accounting].VwCustomerDebt 
	--SELECT CustomerName,ISNULL((@deficit-@deficit2),0) Borc FROM Accounting.VwPayment WHERE CustomerId=@customerId GROUP BY CustomerName
	where Deficit<0
	end
GO
PRINT N'Creating [Accounting].[spInventar]...';


GO
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
GO
PRINT N'Creating [Accounting].[spBarcodeGenerate]...';


GO
CREATE PROCEDURE [Accounting].[spBarcodeGenerate]
	@userId int,
	@barcodeGen bigint output
AS
begin

	SELECT @barcodeGen=convert(bigint,BarcodeGen) from Accounting.BarcodeGenerate where Id = (select max(s.Id) from Accounting.BarcodeGenerate s)

	set @barcodeGen=@barcodeGen+1

	insert into Accounting.BarcodeGenerate (BarcodeGen,CreateId,CreateDate) values (convert(nvarchar(50),@barcodeGen),@userId,GETDATE());	

end
GO
PRINT N'Creating [Accounting].[spRetailPrint]...';


GO
CREATE PROCEDURE [Accounting].[spRetailPrint]
	@id int =null,
	@userId int
	as
	begin
	SELECT
	pr.DocumentId
	,dd.FullGoodName
	,dd.Quantity
	,dd.PriceRetail
	,dd.AmountRetail
	,pr.Payment
	,pr.Deficit
	,pr.TotalSum
	,pt.[Name] PaymentTypeName
	,pr.[Percent]
	,pr.CreateDate
	,pr.CreateId
	,u.[Name]
	,pr.DiscountNumber
	


	FROM Accounting.PaymentRetail pr
join  Accounting.VwDocumentDetail dd ON dd.DocumentId = pr.DocumentId
JOIN Accounting.RetailSale rs ON rs.DocumentDetailId=dd.Id
JOIN Accounting.PaymentType pt ON pt.Id=pr.PaymentTypeId
JOIN dbo.[Principial] u ON u.Id=pr.CreateId
WHERE dd.DocumentId= case when @id is null then (SELECT max(dd2.Id) FROM Accounting.Document dd2 WHERE dd2.AccountId=8 and dd2.CreateId=@userId) else @id end;
end
GO
PRINT N'Creating [Accounting].[spRetailReceipts]...';


GO
create PROCEDURE [Accounting].[spRetailReceipts]
	@details [Accounting].[UddtReceiptsRetail] readonly,
	@userId int=null,
	@date datetime =null,
	@statusId int=null ,
	@infoJson nvarchar(max)=null
AS
begin

if @statusId=2 --novbe

begin
insert into Accounting.RetailReceipt (GoodId,BarcodeId,Quantity,StatusId,CreateId,CreateDate,InfoJson)
select 

GoodId,BarcodeId,Quantity,@statusId,@userId,@date,@infoJson InfoJson
 
from @details
end


else if @statusId=1 --tesdiq
begin
merge [Accounting].[RetailReceipt] target
using (select [Id],GoodId,BarcodeId,Quantity,@statusId StatusId,@userId CreateId,@date CreateDate,@infoJson InfoJson from @details) 
source on target.Id=source.Id 
when MATCHED  THEN update set
StatusId=@statusId,CreateId = @userId,InfoJson = source.InfoJson
when NOT MATCHED BY target then 
INSERT
(GoodId,BarcodeId,Quantity,StatusId,CreateId,CreateDate,InfoJson) 
values(source.GoodId,source.BarcodeId,source.Quantity
,@statusId,@userId,@date,@infoJson);
end

else if @statusId=3 --legv
begin
  update rr set rr.StatusId=3
  from Accounting.RetailReceipt rr
   join @details d on rr.Id=d.Id;
end


end
GO
PRINT N'Creating [Accounting].[spCustomerZero]...';


GO
CREATE PROCEDURE [Accounting].[spCustomerZero]
@userId int
AS
	BEGIN

DECLARE @accountId int,@accountname varchar(200),@customerId int,@customername varchar(200),@payment decimal(26,6),@createdate datetime
DECLARE crs CURSOR FOR(SELECT vp.AccountId,vp.AccountName,vp.CustomerId,vp.CustomerName,vp.Deficit,vp.CreateDate FROM Accounting.VwPayment vp

  join Accounting.[Contract]  c on c.CustomerId=vp.CustomerId


WHERE  ContractTypeId <>3)
OPEN crs
FETCH NEXT FROM crs INTO @accountId,@accountname,@customerId,@customername,@payment,@createdate
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @deficit decimal(26,6)=0
	,@deficit2 decimal(26,6)=0
	SELECT @deficit=SUM(CASE 
	WHEN  vp.AccountId  LIKE '7' AND vp.CustomerId=@customerId  THEN Deficit 
	WHEN  vp.AccountId LIKE '8' AND  vp.CustomerId=@customerId THEN Deficit
	WHEN  vp.AccountId LIKE '9' AND vp.CustomerId=@customerId THEN Deficit
	WHEN  vp.AccountId LIKE '10' AND vp.CustomerId=@customerId THEN Deficit
	ELSE 0 END),
    
	@deficit2=SUM(CASE 
	WHEN vp.AccountId LIKE '3' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '4' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '5' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '6' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '11' AND vp.CustomerId=@customerId THEN Deficit
	 ELSE 0 END)
     
	FROM Accounting.VwPayment vp 

	DECLARE @cust int=0
	SELECT @cust=ISNULL(p.CustomerId,0) FROM [Accounting].CustomerDebt p WHERE p.CustomerId=@customerId 
	IF @cust=@customerId
UPDATE [Accounting].CustomerDebt
SET
Deficit=@deficit-@deficit2
WHERE CustomerId=@customerId;

else 
insert into [Accounting].CustomerDebt (CustomerId,Deficit)
values(@customerId,@deficit-@deficit2)

	FETCH NEXT FROM crs INTO @accountId,@accountname,@customerId,@customername,@payment,@createdate
	end
 
close crs
deallocate crs
	SELECT * FROM [Accounting].VwCustomerDebt 
	--SELECT CustomerName,ISNULL((@deficit-@deficit2),0) Borc FROM Accounting.VwPayment WHERE CustomerId=@customerId GROUP BY CustomerName
	where Deficit=0
	end
GO
PRINT N'Creating [Accounting].[spCustomerCerditor]...';


GO
CREATE PROCEDURE [Accounting].[spCustomerCerditor]
@userId int
AS
	BEGIN

DECLARE @accountId int,@accountname varchar(200),@customerId int,@customername varchar(200),@payment decimal(26,6),@createdate datetime
DECLARE crs CURSOR FOR(SELECT vp.AccountId,vp.AccountName,vp.CustomerId,vp.CustomerName,vp.Deficit,vp.CreateDate FROM Accounting.VwPayment vp

  join Accounting.[Contract]  c on c.CustomerId=vp.CustomerId


WHERE  ContractTypeId <>3
)
OPEN crs
FETCH NEXT FROM crs INTO @accountId,@accountname,@customerId,@customername,@payment,@createdate
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @deficit decimal(26,6)=0
	,@deficit2 decimal(26,6)=0
	SELECT @deficit=SUM(CASE 
	WHEN  vp.AccountId  LIKE '7' AND vp.CustomerId=@customerId  THEN Deficit 
	WHEN  vp.AccountId LIKE '8' AND  vp.CustomerId=@customerId THEN Deficit
	WHEN  vp.AccountId LIKE '9' AND vp.CustomerId=@customerId THEN Deficit
	WHEN  vp.AccountId LIKE '10' AND vp.CustomerId=@customerId THEN Deficit
	ELSE 0 END),
    
	@deficit2=SUM(CASE 
	WHEN vp.AccountId LIKE '3' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '4' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '5' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '6' AND  vp.CustomerId=@customerId THEN  Deficit
	WHEN vp.AccountId LIKE '11' AND vp.CustomerId=@customerId THEN Deficit
	 ELSE 0 END)
     
	FROM Accounting.VwPayment vp 

	DECLARE @cust int=0
	SELECT @cust=ISNULL(p.CustomerId,0) FROM [Accounting].CustomerDebt p WHERE p.CustomerId=@customerId 
	IF @cust=@customerId
UPDATE [Accounting].CustomerDebt
SET
Deficit=@deficit-@deficit2
WHERE CustomerId=@customerId;

else 
insert into [Accounting].CustomerDebt (CustomerId,Deficit)
values(@customerId,@deficit-@deficit2)

	FETCH NEXT FROM crs INTO @accountId,@accountname,@customerId,@customername,@payment,@createdate
	end
 
close crs
deallocate crs
	SELECT * FROM [Accounting].VwCustomerDebt 
	--SELECT CustomerName,ISNULL((@deficit-@deficit2),0) Borc FROM Accounting.VwPayment WHERE CustomerId=@customerId GROUP BY CustomerName
	where Deficit >=0
	end
GO
PRINT N'Creating [Accounting].[spLogisticDocument]...';


GO
 
CREATE PROCEDURE [Accounting].[spLogisticDocument]
@userId int,
@operationType tinyint,
@id int=null,
@driver nvarchar(200) =null,
@fin nvarchar(200)=null,
@transportation nvarchar(200)=null,
@cart nvarchar(200)=null,
@sender nvarchar(200)=null,
@senderAddress nvarchar(200)=null,
@senderManager nvarchar(200)=null,
@received nvarchar(200)=null,
@receivedAddress nvarchar(200)=null,
@receivedManager nvarchar(200)=null,
@date datetime =null,
@deliveryDate datetime=null,
@description nvarchar(500)=null,
@docTypeId INT =null,
@docCertId int =null,
@docSeriesId int =null,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
		@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
@details [Accounting].[UddtLogisticDetail]  readonly 


with encryption
AS 
begin
set xact_abort on;
if @operationType in (1,11)
goto spAdd;
--else if @operationType in (2,12)
--goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;

spAdd:
begin
begin transaction
insert into [Accounting].[Logistic]([Driver],[Fin],[Transportation],[Cart],[Sender],[SenderAddress]
,[SenderManager],[Received],[ReceivedAddress],[ReceivedManager],[Date],[DeliveryDate],[Description],[CreateId],[DocTypeId],[DocCertId],[DocSeriesId],[CompanyId],[WareHouseId],[PaymentTypeId],[ContractId])


VALUES (@driver,@fin,@transportation,@cart,@sender,@senderAddress,@senderManager,@received,@receivedAddress,@receivedManager,@date,@deliveryDate
,@description,@userId,@docTypeId,@docCertId,@docSeriesId,@companyId,@wareHouseId,@paymentTypeId,@contractId);

 set @id=SCOPE_IDENTITY();

 insert into [Accounting].[LogisticDetail]([LogisticId],[BarcodeId],[GoodId],[Quantity],[UnitId],[Description])
                                    select @id,[BarcodeId],[GoodId],[Quantity],[UnitId],[Description] from @details
	if @@TRANCOUNT>0
	COMMIT;
	if @operationType=11 goto spSelect;
RETURN 0
end
spDelete:
begin
update [Accounting].[Logistic]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end

spSelect:
select  
l.[Id]
,l.[Driver]
,l.[Fin]
,l.[Transportation]
,l.[Cart]
,l.[Sender]
,l.[SenderAddress]
,l.[SenderManager]
,l.[Received]
,l.[ReceivedAddress]
,l.[ReceivedManager]
,l.[Date]
,l.[DeliveryDate]
,l.[Description]
,l.CompanyId
,l.CompanyName
,l.WareHouseId
,l.WareHouseName
,l.ContractId
,l.CustomerId
,l.CustomerName
,l.PaymentTypeId
,l.PaymentTypeName
from [Accounting].[VwLogistic] l

join [Accounting].[LogisticDetail] ld on l.id=ld.LogisticId
 group by
 l.[Id]
, l.[Driver]
,l.[Fin]
,l.[Transportation]
,l.[Cart]
,l.[Sender]
,l.[SenderAddress]
,l.[SenderManager]
,l.[Received]
,l.[ReceivedAddress]
,l.[ReceivedManager]
,l.[Date]
,l.[DeliveryDate]
,l.[Description]
,l.CompanyId
,l.CompanyName
,l.WareHouseId
,l.WareHouseName
,l.ContractId
,l.CustomerId
,l.CustomerName
,l.PaymentTypeId
,l.PaymentTypeName
select * from Accounting.VwLogistic ;
RETURN 0
end
GO
PRINT N'Creating [Accounting].[spExpense]...';


GO
CREATE PROCEDURE [Accounting].[spExpense] 
@userId int,
@operationType tinyint,
@parentId int=null,
@code varchar(40) =null,
@expenseName nvarchar(200)=null,
@description nvarchar(500)=null,
@isActive bit=null,
@id int=null
with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [Accounting].Expense([ParentId],[Code],[ExpenseName],[Description])
values(@parentId,@code,@expenseName,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [Accounting].Expense
set
[ParentId]=@parentId,
[Code]=case when @code is null then [Code] else @code end,
[ExpenseName]=case when @expenseName is null then [ExpenseName] else @expenseName end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [Accounting].Expense
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [Accounting].VwExpense
RETURN 0
end
GO
PRINT N'Creating [Accounting].[spCash]...';


GO
CREATE PROCEDURE [Accounting].[spCash] 
    @userId int,
    @operationType tinyint,
	@companyId int =null,
	@cashName nvarchar(100)=null,
	--@wareHouseId int=null, 
	@description nvarchar(500)=null,  
    @isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [Accounting].[Cash] (CompanyId,[CashName],  [Description],CreateId)
values(@companyId,@cashName,  @description,@userId);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update Accounting.Cash
set
[CashName]=case when @cashName is null then [CashName] else @cashName end,
CompanyId=@companyId,
--WareHouseId=@wareHouseId,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update Accounting.Cash
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from Accounting.VwCash
RETURN 0
end
GO
PRINT N'Creating [Accounting].[spOfflineSaleDocument]...';


GO
 
CREATE PROCEDURE [Accounting].[spOfflineSaleDocument]
@userId int,
@operationType tinyint,
@id int=null,
@driver nvarchar(200) =null,
@fin nvarchar(200)=null,
@transportation nvarchar(200)=null,
@cart nvarchar(200)=null,
@sender nvarchar(200)=null,
@senderAddress nvarchar(200)=null,
@senderManager nvarchar(200)=null,
@received nvarchar(200)=null,
@receivedAddress nvarchar(200)=null,
@receivedManager nvarchar(200)=null,
@date datetime =null,
@deliveryDate datetime=null,
@description nvarchar(500)=null,
@docTypeId INT =null,
@docCertId int =null,
@docSeriesId int =null,
	@companyId INT=NULL,
	@wareHouseId INT=NULL,
		@paymentTypeId int=null,
	@contractId int =null,
	@customerId int=null,
@details [Accounting].[UddtOfflineSaleDetail]  readonly 


with encryption
AS 
begin
set xact_abort on;
if @operationType in (1,11)
goto spAdd;
--else if @operationType in (2,12)
--goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;

spAdd:
begin
begin transaction
insert into [Accounting].[OfflineSale]([Driver],[Fin],[Transportation],[Cart],[Sender],[SenderAddress]
,[SenderManager],[Received],[ReceivedAddress],[ReceivedManager],[Date],[DeliveryDate],[Description],[CreateId],[DocTypeId],[DocCertId],[DocSeriesId],[CompanyId],[WareHouseId],[PaymentTypeId],[ContractId])


VALUES (@driver,@fin,@transportation,@cart,@sender,@senderAddress,@senderManager,@received,@receivedAddress,@receivedManager,@date,@deliveryDate
,@description,@userId,@docTypeId,@docCertId,@docSeriesId,@companyId,@wareHouseId,@paymentTypeId,@contractId);

 set @id=SCOPE_IDENTITY();

 insert into [Accounting].[OfflineSaleDetail]([LogisticId],[BarcodeId],[GoodId],[Quantity],[PriceWholeSale],[AmountWholeSale],[Percent],[UnitId],[Description])
                                    select @id,[BarcodeId],[GoodId],[Quantity],[PriceWholeSale],[Quantity]*[PriceWholeSale]  [AmountWholeSale],[Percent],[UnitId],[Description] from @details
	if @@TRANCOUNT>0
	COMMIT;
	if @operationType=11 goto spSelect;
RETURN 0
end
spDelete:
begin
update [Accounting].[OfflineSale]
set
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end

spSelect:
select  
l.[Id]
,l.[Driver]
,l.[Fin]
,l.[Transportation]
,l.[Cart]
,l.[Sender]
,l.[SenderAddress]
,l.[SenderManager]
,l.[Received]
,l.[ReceivedAddress]
,l.[ReceivedManager]
,l.[Date]
,l.[DeliveryDate]
,l.[Description]
,l.CompanyId
,l.CompanyName
,l.WareHouseId
,l.WareHouseName
,l.ContractId
,l.CustomerId
,l.CustomerName
,l.PaymentTypeId
,l.PaymentTypeName

--,ld.[PriceWholeSale]
--,ld.[AmountWholeSale]

from [Accounting].[VwOfflineSale] l

join [Accounting].[OfflineSaleDetail] ld on l.id=ld.LogisticId
 group by
 l.[Id]
, l.[Driver]
,l.[Fin]
,l.[Transportation]
,l.[Cart]
,l.[Sender]
,l.[SenderAddress]
,l.[SenderManager]
,l.[Received]
,l.[ReceivedAddress]
,l.[ReceivedManager]
,l.[Date]
,l.[DeliveryDate]
,l.[Description]
,l.CompanyId
,l.CompanyName
,l.WareHouseId
,l.WareHouseName
,l.ContractId
,l.CustomerId
,l.CustomerName
,l.PaymentTypeId
,l.PaymentTypeName
select * from Accounting.VwOfflineSale ;
RETURN 0
end
GO
PRINT N'Creating [Accounting].[spManagementPaymentDebt]...';


GO

create  PROCEDURE [Accounting].[spManagementPaymentDebt]
	@userId int,
	
@id int =null,
@operationType TINYINT,
@accountId int=NULL,
@customerId int=null,
@paymentTypeId int=null,

--@expenseId int null,
	--@cashId int null,
@payment DECIMAL(26,6),
@description VARCHAR(500),
@paymentDate datetime = null

AS

BEGIN
IF @operationType IN (1,11)
GOTO spAdd;
ELSE IF @operationType IN (2,12)
GOTO spEdit;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4   
GOTO spSelect;


spAdd:

INSERT INTO Accounting.Payment(AccountId,CustomerId,PaymentTypeId,Deficit,[Description],[PaymentDate],CreateDate) 
VALUES (@accountId,@customerId,@paymenttypeId,@payment,@description,@paymentDate,getdate())
	

	 --update  Accounting.Payment  set Deficit = isnull  (Deficit,0) +@payment

   
  -- where 
  -- --Id=@cashId 
  -- --and
  --  @accountId=11



  --  update  Accounting.Payment  set Deficit = isnull  (Deficit,0) - @payment

   
  -- where 
  -- --Id=@cashId 
  -- --and 
  -- @accountId=10
   end
  RETURN 0

   spEdit:
BEGIN
 
   
update [Accounting].Payment
set 
AccountId=@accountId,
CustomerId=@customerId,
--ExpenseId=@expenseId,
[Deficit]=@payment,
[PaymentDate]=@paymentDate,
PaymentTypeId=@paymentTypeId,
[Description]=@description,
[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;
if @operationType=12 goto spSelect;
RETURN 0
 spDelete:
BEGIN
 
   
update [Accounting].Payment
set 
--AccountId=@accountId,
--CustomerId=@customerId,
--ExpenseId=@expenseId,
--[Deficit]=@payment,
--[PaymentDate]=@paymentDate,
--PaymentTypeId=@paymentTypeId,

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
where id=@id;
if @operationType=13 goto spSelect;
end
RETURN 0


spSelect:
select *
from [Accounting].VwCustomerDebt
 end
 RETURN 0
GO
PRINT N'Creating [Accounting].[spIncludeReport]...';


GO
CREATE PROC [Accounting].[spIncludeReport]
@userId INT
,@menuId int
AS
BEGIN
SELECT * FROM Accounting.VwIncludeReport ir



JOIN dbo.WarehouseMenuCollection wmc ON wmc.WarehouseId=ir.WarehouseId AND wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId

end
GO
PRINT N'Creating [Accounting].[spCashToMoney]...';


GO
CREATE PROCEDURE [Accounting].[spCashToMoney]
	@userId int =null,
	@cashId INT =null
AS
	select * from Accounting.Cash c where  c.Id<>@cashId
RETURN 0
GO
PRINT N'Creating [Accounting].[spCashFromMoney]...';


GO
CREATE PROCEDURE [Accounting].[spCashFromMoney]
	@userId int =null,
	@menuId INT =null
AS
BEGIN
	SELECT ch.Id,ch.CashName 
	
	
	FROM Accounting.Cash ch


--JOIN dbo.CashMenuCollection cmc ON ch.Id = cmc.CashId


--AND cmc.Allow=1 
--AND cmc.UserId=@userId 
--AND cmc.MenuId=@menuId

END
GO
PRINT N'Creating [Accounting].[spCashTrasnport]...';


GO
CREATE PROCEDURE [Accounting].[spCashTrasnport]
	@userId int,
	
@operationType TINYINT,
@accountId int=NULL,
@customerId int=null,
@paymentTypeId int=null,

@expenseId int null,
@cashId int null,
@cashFromId int null,
@payment DECIMAL(26,6), 
@description VARCHAR(500),
@paymentDate datetime null




AS
BEGIN

declare @fromCashBalance  DECIMAL(26,6)=0;

select  @fromCashBalance=Balance from Accounting.Cash where Id=@cashFromId;

if @fromCashBalance>=0 and @fromCashBalance>=@payment
begin

   update  Accounting.Cash  set [Balance] = isnull  (Balance,0) - @payment

   
   where Id=@cashFromId


   update  Accounting.Cash  set [Balance] = isnull  (Balance,0) + @payment

   
   where Id=@cashId




INSERT INTO Accounting.Payment(AccountId,CustomerId,PaymentTypeId,ExpenseId,CashId,[CashFromId],Deficit,Description,PaymentDate,CreateDate) 
VALUES (17,@customerId,@paymenttypeId,@expenseId,@cashId,@cashFromId,@payment,@description,@paymentDate,getdate())

end
else
raiserror('Balans kifayet deyil',11,16)
	
end
GO
PRINT N'Creating [WareHouses].[spWareHouseType]...';


GO
CREATE PROCEDURE [WareHouses].[spWareHouseType]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [WareHouses].[WareHouseType]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [WareHouses].[WareHouseType]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [WareHouses].[WareHouseType]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [WareHouses].[WareHouseType] WHERE isnull (IsActive,1)= 1;
RETURN 0
end
GO
PRINT N'Creating [WareHouses].[spWareHouse]...';


GO
CREATE PROCEDURE [WareHouses].[spWareHouse]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@wareHouseTypeId int=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [WareHouses].[WareHouse]([Name],[WareHouseTypeId],[Description])
values(@name,@wareHouseTypeId,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [WareHouses].[WareHouse]
set
[Name]=case when @name is null then [Name] else @name end,
[WareHouseTypeId]= case when @wareHouseTypeId  is null then  [WareHouseTypeId] else  @wareHouseTypeId end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [WareHouses].[WareHouse]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [WareHouses].[VwWareHouse]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spBarcodeSelect]...';


GO
CREATE PROCEDURE [dbo].[spBarcodeSelect]
	@userId int,@wareHouseId int
AS
	SELECT distinct
	 b.[Id]
	,b.[GoodId]
	,g.[FullGoodName]
	,b.[Barcode]
	,g.Quantity
	,g.WarehouseId
	
	
	FROM [Accounting].[Barcode] b
	left join Accounting.VwGoodStock g on b.Id=g.BarcodeId
	where g.Quantity > 0 AND g.WarehouseId=@wareHouseId
RETURN 0
GO
PRINT N'Creating [dbo].[spCashPermitted]...';


GO
CREATE PROCEDURE [dbo].[spCashPermitted]
	@userId int,@menuId int
	AS
	BEGIN
SELECT ch.*,cast((CASE WHEN cmc.Id IS NOT NULL THEN cmc.Allow 
WHEN cmc.Id IS NULL then 0 ELSE 0 END



)AS bit) Allow,cmc.UserId,cmc.MenuId FROM Accounting.Cash ch




LEFT JOIN dbo.CashMenuCollection cmc ON cmc.CashId=ch.Id AND cmc.UserId=@userId AND cmc.MenuId=@menuId
end
GO
PRINT N'Creating [dbo].[spCitizenship]...';


GO
CREATE PROCEDURE [dbo].[spCitizenship]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[Citizenship]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[Citizenship]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[Citizenship]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwCitizenship]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spDocumentRetailDeleteTmp]...';


GO
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
GO
PRINT N'Creating [dbo].[spDose]...';


GO
CREATE PROCEDURE [dbo].[spDose]

@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[Dose]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[Dose]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[Dose]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwDose]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spGetGood]...';


GO
CREATE PROCEDURE [dbo].[spGetGood]
@userId int,
@wareHouseId INT,
@operationType tinyint=4,
@barcodeId int=null,
@barcode varchar(200)=null,
@goodId int=null
AS
if coalesce(@barcodeId,@barcode,@goodId) is null  ---her hansi birine gore axtarish ede bilerik,mutleq 1i qeyd olunmalidi
raiserror('Axtarış parameteri qeyd edilməyib',16,1);
------------son medaxile gore qiymet cixaririq---------------
;with toprecord as (
select 
max(dd.Id) Id
,GoodId
from [Accounting].[DocumentDetail] dd
join [Accounting].[Account] a on dd.AccountId=a.Id 
where a.Code='1.1'
group by GoodId
)
,lastPrices as (
select r.Id,r.GoodId,dd.PriceRetail ,dd.PriceBuy,dd.PriceWholeSale
from [Accounting].[DocumentDetail] dd
join toprecord r on dd.id=r.Id
)
--------------------------------------------------------------
SELECT distinct 
 g.Id GoodId 
,(g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
,gs.Quantity
,b.Id BarcodeId
,b.Barcode
,null Account
,g.GoodName  
,p.PriceRetail Price
,p.PriceBuy 
,p.PriceWholeSale  

FROM Accounting.Good g
join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
join [dbo].[VwDose] d on g.DoseId=d.Id
join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
join Accounting.VwGoodStock gs on  g.Id=gs.Quantity
join [Accounting].[Barcode] b on g.Id=b.GoodId
join [Accounting].[Stock] s on s.GoodId=g.Id
join lastPrices p on p.GoodId=g.Id
where g.DeleteDate is NULL AND gs.WarehouseId=@wareHouseId  and b.DeleteDate is null 
and s.Quantity>0 and (b.Id=@barcodeId or b.Barcode=@barcode or g.id=@goodId)

RETURN 0
GO
PRINT N'Creating [dbo].[spGetGoodStock]...';


GO
CREATE PROCEDURE [dbo].[spGetGoodStock]
	@userId int null,
	@wareHouseId INT 
AS
BEGIN
	SELECT * from Accounting.VwGoodStock  
 
	WHERE WarehouseId=@wareHouseId  
end
GO
PRINT N'Creating [dbo].[spGetInvetnarGood]...';


GO
CREATE PROCEDURE [dbo].[spGetInvetnarGood]
@userId int,
@operationType tinyint=4,
@barcodeId int=null,
@barcode varchar(200)=null,
@goodId int=null
AS
if coalesce(@barcodeId,@barcode,@goodId) is null  ---her hansi birine gore axtarish ede bilerik,mutleq 1i qeyd olunmalidi
raiserror('Axtarış parameteri qeyd edilməyib',16,1);
------------son medaxile gore qiymet cixaririq---------------
;with toprecord as (
select 
max(dd.Id) Id
,GoodId
from [Accounting].[DocumentDetail] dd
join [Accounting].[Account] a on dd.AccountId=a.Id 
where a.Code='1.1' --Mal Alışı
group by GoodId
)
,lastPrices as (
select r.Id,r.GoodId,dd.PriceRetail ,dd.PriceBuy,dd.PriceWholeSale
from [Accounting].[DocumentDetail] dd
join toprecord r on dd.id=r.Id
)
--------------------------------------------------------------
SELECT distinct 
 g.Id GoodId 
,(g.GoodName + ' ' + pt.Name  + ' ' + d.Name + '  ' + c.CompanyName + ' ' + c.RegionName) FullGoodName
,gs.Quantity
,b.Id BarcodeId
,b.Barcode
,null Account
,g.GoodName  
,p.PriceRetail Price
,p.PriceBuy 
,p.PriceWholeSale  
,inven.Quantity 

FROM Accounting.Good g
join [dbo].[VwPackingType] pt on g.PackingTypeId=pt.Id
join [dbo].[VwDose] d on g.DoseId=d.Id
join [Accounting].[VwCompany] c on g.ManufacturerCompanyId=c.Id
join Accounting.VwGoodStock gs on  g.Id=gs.Quantity
join [Accounting].[Barcode] b on g.Id=b.GoodId
join [Accounting].[Stock] s on s.GoodId=g.Id
join lastPrices p on p.GoodId=g.Id
join [Accounting].InventarGood inven on inven.Quantity=g.Id
where g.DeleteDate is null  and b.DeleteDate is null 
and s.Quantity>0 and (b.Id=@barcodeId or b.Barcode=@barcode or g.id=@goodId)

RETURN 0
GO
PRINT N'Creating [dbo].[spHolidayType]...';


GO
CREATE PROCEDURE [dbo].[spHolidayType]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[HolidayType]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[HolidayType]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[HolidayType]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwHolidayType]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spMenuPermitted]...';


GO
CREATE PROCEDURE [dbo].[spMenuPermitted]
@userId int,@forRepermission bit=0
AS
begin

declare @groupId int=null
select @groupId = GroupId from [dbo].[VwSysMember] where UserId=@userId -- istifadecinin qrupunu tapmaq

;WITH cteGroupped AS (
  select distinct [Id],[ParentId],ParentId GroupId
  from [dbo].[Menu] m
  where m.Id in (select MenuItemId from [dbo].[MenuUserAccess] where UserId=@userId  and isnull(Show,0)=1) or  @forRepermission=1
    
  union all
  
  SELECT  m.[Id],m.[ParentId],isnull(g.GroupId,g.Id) GroupId/*, Lavel +1 Lavel*/ 
  FROM cteGroupped g
  inner join [dbo].[Menu] AS m ON m.Id=g.[ParentId]
)
,permission as (
select  top(case when isnull(@groupId,0)=2 or  @forRepermission=1 then 1 else 0 end/*superadmindirse gruplar  tabin gorsun*/) 
20000 Id,1 ParentId,'Groups' [Caption],'group' [TypePath],null [AllowNotify],0 [OrderNumber]
,null Code,null IconId,0 [Parameters],1 GroupId
union
select Id,20000 ParentId,[Name] [Caption],'group' [TypePath],null [AllowNotify],0 [OrderNumber]
,null Code,null IconId,20000 [Parameters],1 GroupId
from [dbo].[VwSysGroup]
where isnull(@groupId,0)=2--superadmindirse gruplari gorsun
 or  @forRepermission=1
union 
select top(case when isnull(@groupId,0)=2 or  @forRepermission=1 then 1 else 0 end/*superadmindirse userler tabin gorsun*/) 
21000 Id,1 ParentId,'Users' [Caption],'user' [TypePath],null [AllowNotify],0 [OrderNumber]
,null Code,null IconId,1 [Parameters],1 GroupId
union
select Id,21000 ParentId,[Name] [Caption],'user' [TypePath],null [AllowNotify],0 [OrderNumber]
,null Code,null IconId,21000 [Parameters],1 GroupId
from [dbo].[VwSysMember]
where isnull(@groupId,0)=2--superadmindirse userlerin siyahisini gorsun
 or  @forRepermission=1
)
,menus as (
SELECT m.Id
	  ,isnull(m.ParentId,0) ParentId
      ,m.[Caption]
      ,m.[TypePath]
      ,m.[AllowNotify]
      ,isnull(m.[OrderNumber],200) [OrderNumber]
	  ,m.Code
	  ,m.IconId
	  ,m.[Parameters]
	  ,g.GroupId
FROM cteGroupped g
join [dbo].[Menu] m on g.Id=m.Id


union all
SELECT m.Id
	  ,isnull(m.ParentId,0) ParentId
      ,m.[Caption]
      ,m.[TypePath]
      ,m.[AllowNotify]
      ,isnull(m.[OrderNumber],200) [OrderNumber]
	  ,m.Code
	  ,m.IconId
	  ,m.[Parameters]
	  ,g.GroupId
FROM cteGroupped g
join [dbo].[Menu] m on g.Id=m.Id
join menus mm on mm.ParentId=m.Id
)

select m.Id
	  ,isnull(m.ParentId,0) ParentId
      ,m.[Caption]
      ,m.[TypePath]
      ,m.[AllowNotify]
      ,isnull(m.[OrderNumber],200) [OrderNumber]
	  ,m.Code
	  ,m.IconId
	  ,m.[Parameters]
	  ,max(GroupId) GroupId from menus m
group by m.Id,isnull(m.ParentId,0),m.[Caption]
      ,m.[TypePath]
      ,m.[AllowNotify]
	  ,isnull(m.[OrderNumber],200)
	  ,m.Code
	  ,m.IconId
	  ,m.[Parameters]
union
select * from permission


end
GO
PRINT N'Creating [dbo].[spPackingType]...';


GO
CREATE PROCEDURE [dbo].[spPackingType]

@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[PackingType]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[PackingType]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[PackingType]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwPackingType]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spPosition]...';


GO
CREATE PROCEDURE [dbo].[spPosition]
	@userId int,
	@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[Position]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[Position]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[Position]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwPosition]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spRegion]...';


GO
CREATE PROCEDURE [dbo].[spRegion]
    @userId int,
    @operationType tinyint,
	@name nvarchar(100)=null,
	@parentId int=null,
	@regionTypeId int=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[Region]([Name],[ParentId],[RegionTypeId],[Description])
values(@name,@parentId,@regionTypeId,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[Region]
set
[Name]=case when @name is null then [Name] else @name end,
[ParentId]=@parentId,
[RegionTypeId]=@regionTypeId,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[Region]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwRegion]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spRegionType]...';


GO
CREATE PROCEDURE [dbo].[spRegionType]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[RegionType]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[RegionType]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[RegionType]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwRegionType]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spReportMoney4]...';


GO
create PROC [dbo].[spReportMoney4]
    @userId int,
	@beginDate datetime,
	@endDate datetime,     /*filterlemek istediyin parametri  prosedurda yazilmalidi */
	@profit decimal(26,6) =null output,
	@cost decimal(26,6) =null output
   ,@goodId varchar(200)=null
   ,@goodTypeId varchar(200)=null,
	@customerId varchar(200)=null,
	@accountId varchar(200)=null,
	@wareHouseId varchar(200)=null


AS
begin
set @endDate=dateadd(DAY,1,@endDate);
if object_id('tempdb..#monthlyReport') is not null 
	       drop table #monthlyReport
    


	;with src as (
	select dd.DocumentId DocumentId,a.Id AccountId, a.ParentId AccountParentId,a.Code AccountCode,a.[Name] AccountName
	,dd2.CreateDate ReportDay,d.CustomerName _CustomerName,d.WareHouseName _WareHouseName,dd.FullGoodName _FullGoodName,pt.[Name] PaymentTypeName,gt.[Name] GoodTypeName,dd.Quantity _Quantity,dd.PriceBuy _PriceBuy,dd.PriceRetail _PriceRetail,dd.PriceWholeSale _PriceWholeSale,dd.Payment _Payment,dd.Deficit _Deficit
	,sum(dd.AmountBuy) TotalBuy,sum(dd.AmountRetail) TotalRetail,sum(dd.AmountWholeSale) TotalWholeSale,dd.[Percent] Percents
from Accounting.VwDocumentDetail dd 
join Accounting.VwDocument d on dd.DocumentId=d.Id
join Accounting.VwAccount a on dd.AccountId=a.Id
JOIN Accounting.DocumentDetail dd2 ON dd.Id = dd2.Id
left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id
   join [Accounting].[GoodType] gt on gt.Id=dd.GoodId





where(@goodId is null or  dd.GoodId=@goodId) And (@customerId is null or d.CustomerId=@customerId) 
And (@accountId is null or dd.AccountId=@accountId) And (@wareHouseId is null or d.WareHouseId=@wareHouseId) 
And (dd2.CreateDate between @beginDate and @endDate) AND dd2.DeleteId is NULL
	group by dd.DocumentId,dd.Id,a.Id ,a.ParentId,a.Code,dd2.CreateDate,a.[Name],d.CustomerName,d.WareHouseName,dd.FullGoodName,pt.[Name],gt.[Name],dd.Quantity,dd.PriceBuy,dd.PriceRetail,dd.PriceWholeSale,dd.Payment,dd.Deficit,dd.[Percent])
	
    ,summary as(
    select DISTINCT  DocumentId,AccountCode,AccountName,ReportDay,_CustomerName,_WareHouseName,_FullGoodName,PaymentTypeName,GoodTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents,
    isnull((select sum(sTotal.TotalBuy) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalBuy) as TotalAmountBuy,
	isnull((select sum(sTotal.TotalRetail) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalRetail) as TotalAmountRetail,
	isnull((select sum(sTotal.TotalWholeSale) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalWholeSale) as TotalWholeSale
     from src s
    )
    SELECT DocumentId,AccountCode,AccountName,ReportDay Column1,sum(TotalAmountBuy) TotalAmountBuy,sum(TotalAmountRetail) TotalAmountRetail,sum(TotalWholeSale) TotalWholeSale,_WareHouseName,_CustomerName,_FullGoodName,PaymentTypeName,GoodTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents
	into #monthlyReport
	from summary group BY DocumentId,AccountCode,AccountName,ReportDay,_WareHouseName,_CustomerName,_FullGoodName,PaymentTypeName,GoodTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents

	select @profit=sum(case 
	when AccountCode like '2.1' then (TotalWholeSale - TotalAmountBuy)
	--when AccountCode like '2.2' then (TotalAmountRetail - TotalAmountBuy)
	--when AccountCode like '2.3' then TotalAmountBuy 
	else 0 end),

	@cost=sum(case 
	when AccountCode like '1.1' then TotalAmountBuy
	--when AccountCode like '1.2' then TotalAmountBuy
	--when AccountCode like '1.3' then TotalWholeSale
	--when AccountCode like '1.4' then TotalAmountBuy
	 else 0 end)
	 from #monthlyReport;

	--insert into Accounting.TotalReport(TotalCost,TotalProfit) values (@profit,@cost)

	

	select @profit=isnull(@profit,0),@cost=isnull(@cost,0);

	select *,isnull(
	sum(case 
	when AccountCode like '2.1' then (TotalWholeSale - TotalAmountBuy)
	--when AccountCode like '2.2' then (TotalAmountRetail - TotalAmountBuy)
	--when AccountCode like '2.3' then TotalAmountBuy 
	else 0 end),0) Profit,
	isnull(sum(case 
	when AccountCode like '1.1' then TotalAmountBuy
	--when AccountCode like '1.2' then TotalAmountBuy
	--when AccountCode like '1.3' then TotalWholeSale
	--when AccountCode like '1.4' then TotalAmountBuy
	 else 0 end),0) Cost
	from #monthlyReport
	group by DocumentId,AccountCode,AccountName,Column1,TotalWholeSale,TotalAmountBuy,TotalAmountRetail,_FullGoodName,_WareHouseName,_CustomerName,PaymentTypeName,GoodTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents
    order by AccountCode

RETURN 0
end
 

--CREATE PROC [dbo].[spReportMoney4]
--    @userId int,
--	@beginDate datetime,
--	@endDate datetime,     /*filterlemek istediyin parametri  prosedurda yazilmalidi */
--	@profit decimal(26,6) =null output,
--	@cost decimal(26,6) =null output
--   ,@goodId varchar(200)=null,
--	@customerId varchar(200)=null,
--	@accountId varchar(200)=null,
--	@wareHouseId varchar(200)=null


--AS
--begin
--set @endDate=dateadd(DAY,1,@endDate);
--if object_id('tempdb..#monthlyReport') is not null 
--	       drop table #monthlyReport
    


--	;with src as (
--	select dd.DocumentId DocumentId,a.Id AccountId, a.ParentId AccountParentId,a.Code AccountCode,a.[Name] AccountName
--	,dd2.CreateDate ReportDay,d.CustomerName _CustomerName,d.WareHouseName _WareHouseName,dd.FullGoodName _FullGoodName,pt.[Name] PaymentTypeName,dd.Quantity _Quantity,dd.PriceBuy _PriceBuy,dd.PriceRetail _PriceRetail,dd.PriceWholeSale _PriceWholeSale,dd.Payment _Payment,dd.Deficit _Deficit
--	,sum(dd.AmountBuy) TotalBuy,sum(dd.AmountRetail) TotalRetail,sum(dd.AmountWholeSale) TotalWholeSale,dd.[Percent] Percents
--from Accounting.VwDocumentDetail dd 
--join Accounting.VwDocument d on dd.DocumentId=d.Id
--join Accounting.VwAccount a on dd.AccountId=a.Id
--JOIN Accounting.DocumentDetail dd2 ON dd.Id = dd2.Id
--left join Accounting.VwPaymentType pt on d.PaymentTypeId=pt.Id




--where(@goodId is null or  dd.GoodId=@goodId) And (@customerId is null or d.CustomerId=@customerId) 
--And (@accountId is null or dd.AccountId=@accountId) And (@wareHouseId is null or d.WareHouseId=@wareHouseId) 
--And (dd2.CreateDate between @beginDate and @endDate) AND dd2.DeleteId is NULL
--	group by dd.DocumentId,dd.Id,a.Id ,a.ParentId,a.Code,dd2.CreateDate,a.[Name],d.CustomerName,d.WareHouseName,dd.FullGoodName,pt.[Name],dd.Quantity,dd.PriceBuy,dd.PriceRetail,dd.PriceWholeSale,dd.Payment,dd.Deficit,dd.[Percent])
	
--    ,summary as(
--    select DISTINCT  DocumentId,AccountCode,AccountName,ReportDay,_CustomerName,_WareHouseName,_FullGoodName,PaymentTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents,
--    isnull((select sum(sTotal.TotalBuy) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalBuy) as TotalAmountBuy,
--	isnull((select sum(sTotal.TotalRetail) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalRetail) as TotalAmountRetail,
--	isnull((select sum(sTotal.TotalWholeSale) from src sTotal where sTotal.AccountParentId=s.AccountId), s.TotalWholeSale) as TotalWholeSale
--     from src s
--    )
--    SELECT DocumentId,AccountCode,AccountName,ReportDay Column1,sum(TotalAmountBuy) TotalAmountBuy,sum(TotalAmountRetail) TotalAmountRetail,sum(TotalWholeSale) TotalWholeSale,_WareHouseName,_CustomerName,_FullGoodName,PaymentTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents
--	into #monthlyReport
--	from summary group BY DocumentId,AccountCode,AccountName,ReportDay,_WareHouseName,_CustomerName,_FullGoodName,PaymentTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents

--	select @profit=sum(case 
--	when AccountCode like '2.1' then (TotalWholeSale - TotalAmountBuy)
--	when AccountCode like '2.2' then (TotalAmountRetail - TotalAmountBuy)
--	when AccountCode like '2.3' then TotalAmountBuy 
--	else 0 end),

--	@cost=sum(case 
--	when AccountCode like '1.1' then TotalAmountBuy
--	when AccountCode like '1.2' then TotalAmountBuy
--	when AccountCode like '1.3' then TotalWholeSale
--	when AccountCode like '1.4' then TotalAmountBuy
--	 else 0 end)
--	 from #monthlyReport;

--	--insert into Accounting.TotalReport(TotalCost,TotalProfit) values (@profit,@cost)

	

--	select @profit=isnull(@profit,0),@cost=isnull(@cost,0);

--	select *,isnull(
--	sum(case 
--	when AccountCode like '2.1' then (TotalWholeSale - TotalAmountBuy)
--	when AccountCode like '2.2' then (TotalAmountRetail - TotalAmountBuy)
--	when AccountCode like '2.3' then TotalAmountBuy 
--	else 0 end),0) Profit,
--	isnull(sum(case 
--	when AccountCode like '1.1' then TotalAmountBuy
--	when AccountCode like '1.2' then TotalAmountBuy
--	when AccountCode like '1.3' then TotalWholeSale
--	when AccountCode like '1.4' then TotalAmountBuy
--	 else 0 end),0) Cost
--	from #monthlyReport
--	group by DocumentId,AccountCode,AccountName,Column1,TotalWholeSale,TotalAmountBuy,TotalAmountRetail,_FullGoodName,_WareHouseName,_CustomerName,PaymentTypeName,_Quantity,_PriceBuy,_PriceRetail,_PriceWholeSale,_Payment,_Deficit,Percents
--    order by AccountCode

--RETURN 0
--end
GO
PRINT N'Creating [dbo].[spSetCashPermissions]...';


GO
CREATE PROCEDURE [dbo].[spSetCashPermissions]
@userId int,
	@principialId int ,
	@permission  dbo.[UddtCashPermission] readonly

AS

begin

merge 	 dbo.CashMenuCollection target
using (select CashId,Allow,ReserveMenuId

 from @permission) source on target.MenuId=source.ReserveMenuId and target.UserId=@principialId AND target.CashId=source.CashId
when MATCHED and target.UserId=@principialId THEN
update set Allow=source.Allow,CashId=source.CashId,MenuId=source.ReserveMenuId
when NOT MATCHED BY target then 
insert (MenuId,UserId,Allow,CashId)
values(ReserveMenuId,@principialId,Allow,CashId);

RETURN 0
end
GO
PRINT N'Creating [dbo].[spSetPermissions]...';


GO
CREATE PROCEDURE [dbo].[spSetPermissions]
@userId int,
	@principialId int ,
	@permission  dbo.[UddtSetPermissions] readonly

AS

begin

merge 	 dbo.MenuUserAccess target
using (select Id, AllowShow, AllowCreate, AllowUpdate, AllowDelete, AllowInContainer,AllowRetail,AllowApplyDocument,ShowCreate,ShowUpdate,ShowDelete,ShowApplyDocument
 from @permission) source on target.MenuItemId=source.Id and target.UserId=@principialId
when MATCHED and target.UserId=@principialId THEN



update set Show=source.AllowShow
,[Create]=source.AllowCreate
,[Update]=source.AllowUpdate
,[Delete]=source.AllowDelete
,AllowInContainer=source.AllowInContainer
,AllowRetail=source.AllowRetail
,ApplyDocument=source.AllowApplyDocument
,ShowCreate=source.ShowCreate
,ShowUpdate=source.ShowUpdate
,ShowDelete=source.ShowDelete 
,ShowApplyDocument=source.ShowApplyDocument
when NOT MATCHED BY target then 



insert (MenuItemId,UserId, [Show], [Create], [Update], [Delete],ApplyDocument, AllowInContainer,AllowRetail,ShowCreate,ShowUpdate,ShowDelete,ShowApplyDocument)
values(Id,@principialId ,AllowShow,AllowCreate,AllowUpdate,AllowDelete,AllowApplyDocument,AllowInContainer,AllowRetail,ShowCreate,ShowUpdate,ShowDelete,ShowApplyDocument);

RETURN 0
end
GO
PRINT N'Creating [dbo].[spSetWareHousePermissions]...';


GO
CREATE PROCEDURE [dbo].[spSetWareHousePermissions]
@userId int,
	@principialId int ,
	@permission  dbo.[UddtWareHousePermission] readonly

AS

begin

merge 	 dbo.WarehouseMenuCollection target
using (select WareHouseId,Allow,ReserveMenuId
 from @permission) source on target.MenuId=source.ReserveMenuId and target.UserId=@principialId AND target.WareHouseId=source.WareHouseId
when MATCHED and target.UserId=@principialId THEN
update set Allow=source.Allow,WareHouseId=source.WareHouseId,MenuId=source.ReserveMenuId
when NOT MATCHED BY target then 
insert (MenuId,UserId,Allow,WareHouseId)
values(ReserveMenuId,@principialId,Allow,WareHouseId);

RETURN 0
end
GO
PRINT N'Creating [dbo].[spSysAddUser]...';


GO
CREATE PROCEDURE [dbo].[spSysAddUser]
	@name nvarchar(200),
	@password varchar(128),
	@personId int=null
AS

begin

if not exists(select top(1) 0 from sys.sysusers where [name]=@name)
begin

if nullif(@name,'') is null
begin
raiserror('name cant be null',16,1);
return;
end

if nullif(@password,'') is null
begin
raiserror('password cant be null',16,1);
return;
end


declare @sql varchar(900)='CREATE USER '+QUOTENAME(@name)+' WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]';
exec sp_sqlexec @sql;
insert into dbo.[Principial]([Name],[Password],[IsMember],PersonId)
values(@name,@password,1,@personId)
end

RETURN 0;

end
GO
PRINT N'Creating [dbo].[spSysGroupAddUser]...';


GO
CREATE PROCEDURE [dbo].[spSysGroupAddUser]
	@groupName nvarchar(200),
	@userName nvarchar(200)
AS
begin
 declare
    @groupId int = dbo.fnSysGroupId(@groupName),
    @userId int = null;

	if @groupId is null
	begin
       raiserror('group could"t found',16,1);
       return -1;
    end
	
	set @userId=dbo.fnSysUserId(@userName);
	if @userId is null
	begin
       raiserror('user could"t found',16,1);
       return -1;
    end

	insert into dbo.MemberGroupPool(GroupId,MemberId)
	select @groupId,@userId
	except select GroupId,MemberId from dbo.MemberGroupPool;

RETURN 0
end
GO
PRINT N'Creating [dbo].[spSysGroupDropUser]...';


GO
CREATE PROCEDURE [dbo].[spSysGroupDropUser]
	@groupName nvarchar(200),
	@userName nvarchar(200)
AS
begin
 declare
    @groupId int = dbo.fnSysGroupId(@groupName),
    @userId int = null;

	if @groupId is null
	begin
       raiserror('group could"t found',16,1);
       return -1;
    end
	
	set @userId=dbo.fnSysUserId(@userName);
	if @userId is null
	begin
       raiserror('user could"t found',16,1);
       return -1;
    end

	delete from dbo.MemberGroupPool where GroupId=@groupId and MemberId=@userId;

RETURN 0
end
GO
PRINT N'Creating [dbo].[spTransport]...';


GO
CREATE PROCEDURE [dbo].[spTransport]
	@userId int,
	@fromWareHouseId INT=NULL,  --source anbar id
	@menuId INT,
	@companyId INT=NULL,
	@description NVARCHAR(200)=NULL,
	@operationtype TINYINT=NULL,
	@id INT = NULL, 
	@paymentId INT=NULL,
	@warehouseId INT=NULL, --destination anbar id
	 @includeDate DATETIME= NULL,
	@detail [Accounting].[UddtTransport] READONLY
AS

BEGIN

DECLARE @totalAmount decimal(26,6)=0, @accountId  INT,@payment decimal(26,6),
@amountBuy decimal(26,6),@goodId INT,@barcodeId INT,@series NVARCHAR(200),
@dateOfProduction DATETIME,@lastExpirationDate DATETIME,
@quantity decimal(26,6),@unitId INT,@priceBuy decimal(26,6),
@priceRetail decimal(26,6),@priceWholeSale decimal(26,6),
@totalPayment decimal(26,6)=0,@percent NVARCHAR(50);


IF @operationType IN (1,11)
GOTO spAdd;
ELSE IF @operationType IN (3,13)
GOTO spDelete;
ELSE IF @operationType =4   
GOTO spSelect;


spAdd:
BEGIN
begin tran 

if exists(select * from @detail d
join Accounting.VwGoodStock st with(rowlock,holdlock) on d.GoodId=st.Id
where ISNULL(st.quantity,0) - d.Quantity<0 AND st.WarehouseId=@fromWareHouseId)
begin
	raiserror('Stokda kifayet qeder mehsul yoxdur',16,1);
	rollback;
	return;
end






else 
begin


INSERT INTO [Accounting].[Document]([IncludeDate],[CompanyId],[WareHouseId],[FromWareHouseId],[ContractId],[Description],[CreateId],[AccountId])
VALUES (@includeDate,@companyId,@warehouseId,@fromWareHouseId,1,@description,@userId,14)

SET @id=SCOPE_IDENTITY();

DECLARE crs CURSOR FOR 
(SELECT AccountId,ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],
[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],
[PriceWholeSale],ISNULL([Percent]+' % Endirim','0')
FROM @detail)

OPEN crs
FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,
@series ,@dateOfProduction ,@lastExpirationDate ,@quantity,@unitId,@priceBuy,
@priceRetail,@priceWholeSale,@percent

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalPayment=@totalPayment+@amountBuy;

DECLARE @sQuantity decimal(25,5), -- stock quantity
@stockId INT,@quantityDiff decimal(25,5)=0,
@tQuantity decimal(25,5)=0,@tPriceBuy decimal(26,6)=0,@tPriceRetail decimal(26,6)=0,
@tPriceWholeSale decimal(26,6)=0,@count int=0;

DECLARE stockList CURSOR FOR (SELECT s.Quantity,s.Id 
FROM Accounting.Stock s 
WHERE s.GoodId=@goodId and s.Quantity>0 AND s.WarehouseId=@fromWareHouseId 
AND UpdateId IS null)

OPEN stockList
FETCH NEXT FROM stockList INTO @sQuantity,@stockId
WHILE @@FETCH_STATUS=0
BEGIN
DECLARE @lastPriceBuy decimal(25,5),@lastPriceRetail decimal(25,5),
@lastPriceWholeSale decimal(25,5),@quantityScale decimal (25,2)


SELECT top (1) @lastPriceBuy=s.PriceBuy,
@lastPriceRetail=s.PrcieRetail,
@lastPriceWholeSale=s.PriceWholeSale 
FROM Accounting.Stock s 
WHERE GoodId=@goodId AND WarehouseId=@fromWareHouseId
order by s.Id desc --sonuncu uzre melumatlar 

IF(@quantityDiff IS NOT NULL)
BEGIN
set @count=@count + 1
IF(@sQuantity<@quantity AND @quantityDiff=0)

BEGIN
select @quantityDiff=@quantity-@sQuantity,
@quantityScale=(@sQuantity*100)/@quantity;

UPDATE Accounting.Stock
SET Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId;

select @tQuantity=@tQuantity+@sQuantity,
@tPriceBuy = @tPriceBuy + (@lastPriceBuy*@quantityScale)/100,
@tPriceRetail = @lastPriceRetail,
@tPriceWholeSale = @lastPriceWholeSale;

END

ELSE IF(@sQuantity<@quantity AND @quantityDiff>@sQuantity)
BEGIN
select @quantityDiff=@quantityDiff-@sQuantity,
@quantityScale=(@sQuantity*100)/@quantity;

UPDATE Accounting.Stock
SET Quantity = 0 WHERE GoodId=@goodId AND Id=@stockId;
 
select @tQuantity=@tQuantity+@sQuantity,
@tPriceBuy = @tPriceBuy + (@lastPriceBuy*@quantityScale)/100,
@tPriceRetail = @lastPriceRetail,
@tPriceWholeSale = @lastPriceWholeSale;

END

ELSE IF(@sQuantity<@quantity AND @quantityDiff<=@sQuantity)
BEGIN
SET @quantityScale=(@quantityDiff*100)/@quantity;

UPDATE Accounting.Stock
SET Quantity = @sQuantity-@quantityDiff WHERE Id=@stockId;

select @tQuantity=@tQuantity+@quantityDiff,
@tPriceBuy = @tPriceBuy + (@lastPriceBuy*@quantityScale)/100,
@tPriceRetail = @lastPriceRetail,
@tPriceWholeSale = @lastPriceWholeSale,
@quantityDiff=NULL;

END

ELSE IF(@sQuantity>=@quantity AND @quantityDiff>0)
BEGIN

SET @quantityScale=(@quantityDiff*100)/@quantity;

UPDATE Accounting.Stock
SET Quantity = @sQuantity-@quantityDiff WHERE Id=@stockId

   select @tQuantity=@tQuantity+@quantityDiff,
   @tPriceBuy = @tPriceBuy + (@lastPriceBuy*@quantityScale)/100,
   @tPriceRetail = @lastPriceRetail,
   @tPriceWholeSale = @lastPriceWholeSale,
   @quantityDiff=NULL;

END

ELSE

BEGIN
   UPDATE Accounting.Stock
	  SET Quantity =  @sQuantity-@quantity WHERE Id=@stockId;

   select @tQuantity=@tQuantity+@quantity,
   @tPriceBuy = @tPriceBuy + @lastPriceBuy,
   @tPriceRetail = @lastPriceRetail,
   @tPriceWholeSale = @lastPriceWholeSale,
   @quantityDiff=NULL;  
END
END

   FETCH NEXT FROM stockList INTO @sQuantity,@stockId;
   SET @totalAmount=@totalAmount+(@tQuantity*@tPriceWholeSale);
END
CLOSE stockList
DEALLOCATE stockList


INSERT INTO [Accounting].[DocumentDetail]([DocumentId],[PaymentId],[AccountId],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale],[AmountBuy], [AmountRetail],[AmountWholeSale],[Payment],[Deficit],[Percent],[CreateId],[CreateDate])
VALUES(@id,@paymentId,@accountId, @goodId,@barcodeId,@series,@dateOfProduction,@lastExpirationDate,@tQuantity,@unitId,@tPriceBuy,@tPriceRetail,@tPriceWholeSale,@tQuantity*@tPriceBuy,@tQuantity*@tPriceRetail,@tQuantity*@tPriceWholeSale,@payment, @tQuantity*@tPriceBuy,@percent,@userId,getdate())


INSERT into [Accounting].[Stock] (DocumentId,WarehouseId,GoodId,CreatId,Series,Quantity,PriceBuy,PrcieRetail,PriceWholeSale,CreateDate)
VALUES (@id,@warehouseId,@goodId,@userId,@series,@tQuantity,@tPriceBuy,@tPriceRetail,@tPriceWholeSale,GETDATE())

FETCH NEXT FROM crs INTO @accountId ,@payment ,@amountBuy ,@goodId,@barcodeId,@series ,
@dateOfProduction ,@lastExpirationDate,@quantity,@unitId,@priceBuy,@priceRetail,
@priceWholeSale,@percent;

end

close crs
deallocate crs

END

INSERT INTO Accounting.Payment (DocumentId,AccountId,CustomerWareHouseId,Payment,Deficit)
VALUES(@id,@accountId,@warehouseId,@payment,@totalPayment);
SET @paymentId=SCOPE_IDENTITY();

if @@TRANCOUNT>0 
commit;

if @operationType=11 goto spSelect;
RETURN 0;
end

spDelete:
BEGIN

UPDATE Accounting.Stock 
SET

UpdateDate=GETDATE(),
UpdateId=@userId
,
Quantity=@quantityScale
WHERE DocumentId=@id AND WarehouseId!=@fromWareHouseId ;

--DECLARE @totalAmount1 decimal(26,6)=0,@payment1 decimal(26,6),
--@amountBuy1 decimal(26,6),@goodId1 INT,@barcodeId1 INT,@series1 NVARCHAR(200),
--@dateOfProduction1 DATETIME,@lastExpirationDate1 DATETIME,
--@quantity1 decimal(26,6),@unitId1 INT,@priceBuy1 decimal(26,6),
--@priceRetail1 decimal(26,6),@priceWholeSale1 decimal(26,6);

DECLARE crd CURSOR FOR 
(SELECT ISNULL(Payment,0),[AmountBuy],[GoodId],[BarCodeId],[Series],[DateOfProduction],[LastExpirationDate],
[Quantity],[UnitId],[PriceBuy],[PriceRetail],[PriceWholeSale]
FROM Accounting.VwDocumentDetail WHERE DocumentId=@id)

OPEN crd
FETCH NEXT FROM crd INTO @payment ,@amountBuy ,@goodId,@barcodeId,@series,
@dateOfProduction ,@lastExpirationDate
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale;

WHILE @@FETCH_STATUS=0
BEGIN
SET @totalAmount=@totalAmount+@amountBuy;

INSERT INTO Accounting.Stock (GoodId,CreatId,CreateDate,WarehouseId,DocumentId,Quantity,PriceBuy,PrcieRetail,PriceWholeSale) 
VALUES (@goodId,@userId,GETDATE(),@fromWareHouseId,@id,@quantity,@priceBuy,@priceRetail,@priceWholeSale)

FETCH NEXT FROM crd INTO @payment ,@amountBuy ,@goodId,@barcodeId,@series,
@dateOfProduction ,@lastExpirationDate
,@quantity,@unitId,@priceBuy,@priceRetail,@priceWholeSale;

END

CLOSE crd
DEALLOCATE crd

DELETE FROM Accounting.Payment WHERE DocumentId=@id;

UPDATE Accounting.DocumentDetail
SET
DeleteDate=GETDATE(),
DeleteId=@userId
WHERE DocumentId=@id;


UPDATE [Accounting].[Document]
set

[DeleteId]=@userId,
[DeleteDate]=GETDATE()
WHERE id=@id;

if @operationType=13 goto spSelect;
RETURN 0
END

spSelect:
BEGIN
select  d.[Id]   
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId]  
    ,d.[FromWarehouseId] 
	,d.[FromWareHouseName]
	,d.[WareHouseName]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
          ,d.[DocTypeId]
      ,d.[DocCertId]
      ,d.[DocSeriesId]
         ,sum(dd.AmountBuy) AmountBuy
         ,sum(dd.AmountRetail) AmountRetail
         ,sum(dd.AmountWholeSale) AmountWholeSale
	     ,sum(dd.Payment) Payment
	     ,sum(dd.Deficit) Deficit
from [Accounting].[VwDocument] d
 left join [Accounting].[DocumentDetail] dd on d.Id=dd.DocumentId
JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId = d.WareHouseId and wmc.UserId=@userId AND wmc.Allow=1 AND wmc.MenuId=@menuId
  and d.DeleteId is null and AccountId=12
 group by 
     d.[Id]   
    ,d.[IncludeDate]  
    ,d.[CompanyId]   
	,d.[CompanyName]  
    ,d.[WareHouseId] 
	
	,d.[FromWareHouseName]
	,d.[WareHouseName]
	,d.[FromWarehouseId]
	,d.[Description]
	,d.[PaymentTypeId]
	,d.[PaymentTypeName]
	,d.[ContractId]
	,d.[CustomerId]
	,d.[CustomerName]
	 ,d.[DocTypeId]
      ,d.[DocCertId]
      ,d.[DocSeriesId];
	  END
 RETURN 0
end
GO
PRINT N'Creating [dbo].[spUnit]...';


GO
CREATE PROCEDURE [dbo].[spUnit]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[Unit]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[Unit]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[Unit]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwUnit]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spUser1]...';


GO
CREATE PROCEDURE [dbo].[spUser1]
	@userId int, 
	@login nvarchar(100)=null,
	@password nvarchar(128)=null,
	@isActive bit=null,	
	@id int=null
WITH ENCRYPTION
AS
BEGIN

 
  begin
 
spSelect:
select * from [dbo].[User]
     where [Login]=@login  and [Password]=@password
END
END
GO
PRINT N'Creating [dbo].[spUserPermissions]...';


GO
CREATE PROCEDURE [dbo].[spUserPermissions]
	@principalId int
AS
begin
select m.[Id]
      ,m.[ParentId]
      ,m.[Code]
      ,m.[Caption]
      ,m.[TypePath]
      ,m.[Parameters]
      ,m.[AllowNotify]
      ,m.[IconId]
      ,m.[OrderNumber] 
	  ,cast(case when  ma.Show is null then 0 else ma.Show end as bit)  AllowShow
	  ,cast(case when  ma.[Create] is null then 0 else ma.[Create] end as bit)  AllowCreate
	  ,cast(case when  ma.[Update] is null then 0 else ma.[Update] end as bit)  AllowUpdate
	  ,cast(case when  ma.[Delete] is null then 0 else ma.[Delete] end as bit)  AllowDelete
	  ,cast(case when  ma.[ApplyDocument] is null then 0 else ma.[ApplyDocument] end as bit)  AllowApplyDocument
	  ,cast(case when  ma.[ShowCreate] is null then 0 else ma.[ShowCreate] end as bit)  ShowCreate
	  ,cast(case when  ma.[ShowUpdate] is null then 0 else ma.[ShowUpdate] end as bit)  ShowUpdate
	  ,cast(case when  ma.[ShowDelete] is null then 0 else ma.[ShowDelete] end as bit)  [ShowDelete]
	  ,cast(case when  ma.ApplyDocument is null then 0 else ma.ApplyDocument end as bit)  [ShowApplyDocument]
	  ,cast(case when  ma.AllowInContainer is null then 0 else ma.AllowInContainer end as bit)  AllowInContainer
	  ,cast(case when  ma.AllowRetail is null then 0 else ma.AllowRetail end as bit)  AllowRetail
	  from [dbo].[Menu] m
      left join [dbo].[MenuUserAccess] ma on m.Id=ma.MenuItemId and isnull(ma.UserId,@principalId)=@principalId
RETURN 0
end
GO
PRINT N'Creating [dbo].[spWareHouseChangedPrice]...';


GO
CREATE PROCEDURE [dbo].[spWareHouseChangedPrice]
	@userId int null,
	@warehouseId INT null
AS
	select * from warehouses.warehouse w where  w.Id<>@warehouseId
RETURN 0
GO
PRINT N'Creating [dbo].[spWareHousePermitted]...';


GO
CREATE PROCEDURE [dbo].[spWareHousePermitted]
	@userId int,@menuId int
	AS
	BEGIN
SELECT wh.*,cast((CASE WHEN wmc.Id IS NOT NULL THEN wmc.Allow 
WHEN wmc.Id IS NULL then 0 ELSE 0 END
)AS bit) Allow,wmc.UserId,wmc.MenuId FROM WareHouses.WareHouse wh
LEFT JOIN dbo.WarehouseMenuCollection wmc ON wmc.WareHouseId=wh.Id AND wmc.UserId=@userId AND wmc.MenuId=@menuId
end
GO
PRINT N'Creating [dbo].[spWareHouseSelect]...';


GO
CREATE PROCEDURE [dbo].[spWareHouseSelect]
	@userId int null,
	@menuId INT null
AS
BEGIN
	SELECT wh.Id,wh.[Name] FROM WareHouses.WareHouse wh
JOIN dbo.WarehouseMenuCollection wmc ON wh.Id = wmc.WareHouseId AND wmc.Allow=1 AND wmc.UserId=@userId AND wmc.MenuId=@menuId

END
GO
PRINT N'Creating [dbo].[spWorkGraphic]...';


GO
CREATE PROCEDURE [dbo].[spWorkGraphic]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[WorkGraphic]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[WorkGraphic]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[WorkGraphic]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwWorkGraphic]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spWorkPlace]...';


GO
CREATE PROCEDURE [dbo].[spWorkPlace]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[WorkPlace]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[WorkPlace]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[WorkPlace]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwWorkPlace]
RETURN 0
end
GO
PRINT N'Creating [dbo].[spWorkType]...';


GO
CREATE PROCEDURE [dbo].[spWorkType]
@userId int,
@operationType tinyint,
	@name nvarchar(100)=null,
	@description nvarchar(500)=null,
	@isActive bit=null,
	@id int=null
	with encryption
AS

begin
if @operationType in (1,11)
goto spAdd;
else if @operationType in (2,12)
goto spEdit;
else if @operationType in (3,13)
goto spDelete;
else if @operationType =4
goto spSelect;


spAdd:
begin
insert into [dbo].[WorkType]([Name],[Description])
values(@name,@description);

if @operationType=11 goto spSelect;
RETURN 0
end

spEdit:
begin
update [dbo].[WorkType]
set
[Name]=case when @name is null then [Name] else @name end,
[Description]=@description
where id=@id;

if @operationType=12 goto spSelect;
RETURN 0
end

spDelete:
begin
update [dbo].[WorkType]
set
[IsActive]=isnull(@isActive,0)
where id=@id;

if @operationType=13 goto spSelect;
RETURN 0
end


spSelect:
   select * from [dbo].[VwWorkType]
RETURN 0
end
GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '953c4cc8-13b1-4512-ae65-9eb1ffb252af')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('953c4cc8-13b1-4512-ae65-9eb1ffb252af')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '36c7d39b-5760-4c5c-9f58-40661a15da79')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('36c7d39b-5760-4c5c-9f58-40661a15da79')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a281162f-106f-45d3-a768-2cf94ee047a0')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a281162f-106f-45d3-a768-2cf94ee047a0')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '55237ec5-faa4-43d9-8d83-d348a0fffc1e')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('55237ec5-faa4-43d9-8d83-d348a0fffc1e')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f28d4de7-1990-4fc3-a002-a2f5a533121c')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f28d4de7-1990-4fc3-a002-a2f5a533121c')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '22ba3c40-b025-41f8-bd8f-dfec8c58f04a')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('22ba3c40-b025-41f8-bd8f-dfec8c58f04a')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '319b1157-463c-4c6b-89e4-e71152e5bcca')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('319b1157-463c-4c6b-89e4-e71152e5bcca')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'cd65fa4a-f722-4b89-96d6-154977cb0b62')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('cd65fa4a-f722-4b89-96d6-154977cb0b62')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f935294a-90e9-4fef-ac5a-d0fd16471a30')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f935294a-90e9-4fef-ac5a-d0fd16471a30')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '87d4001e-5f3b-4c7a-9660-063294d933de')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('87d4001e-5f3b-4c7a-9660-063294d933de')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '8caae87c-c859-45b0-a41b-72f5ab788873')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('8caae87c-c859-45b0-a41b-72f5ab788873')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '7855e3eb-a43d-45c1-b971-078460816b84')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('7855e3eb-a43d-45c1-b971-078460816b84')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a96ff823-12e8-4f24-9394-e4de8140b5e1')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a96ff823-12e8-4f24-9394-e4de8140b5e1')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '0ff5c5bf-cd6a-4033-880f-410c758f1a89')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('0ff5c5bf-cd6a-4033-880f-410c758f1a89')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'fc409f77-c0b8-4752-a31b-e52167cbd5a1')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('fc409f77-c0b8-4752-a31b-e52167cbd5a1')

GO

GO
--if not exists(select top(1) 0 from sys.sysusers where [name]='kamran')
--begin
--   CREATE USER [kamran] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
--   --ALTER ROLE [db_datareader] ADD MEMBER [kamran]
--   insert into dbo.[User](UserName,[Password],PersonId)
--   values('kamran','08FDD1C83E5BF6F855958488E7443DB9',1)
--end

if not exists(select top(1) 0 from sys.sysusers where [name]='kamran')
begin
   --application roles
   insert into dbo.[Principial]([Name],[IsGroup])
   values('public',1),('Superadmin',1),('Admin',1),('Operator',1),('Reporter',1)



   CREATE USER [kamran] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
   --ALTER ROLE [db_datareader] ADD MEMBER [kamran]
   insert into dbo.[Principial]([Name],[Password],[IsMember],PersonId)
   values('kamran','08FDD1C83E5BF6F855958488E7443DB9',1,1)


   
end

--if not exists(select top(1) 0 from dbo.AppRole)
--begin
--   insert into dbo.[AppRole]([Name])
--   values('Public'),('Super Admin'),('Admin'),('Chiefs'),('Operator'),('Cashier'),('Reporter')
--end
GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'{0}', 'ON';
    END


GO
PRINT N'Update complete.';


GO
