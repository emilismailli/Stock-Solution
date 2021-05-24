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
