
using ERP.Infrastructure.Identity;

namespace MHM.Accountancy.Business.Infrastructure
{
    static public class ConnectionItemHelper
    {
        static public ConnectionItem SetServer(this ConnectionItem item, string serverName)
        {
            item.ServerName = serverName;
            return item;
        }
        static public ConnectionItem SetLogin(this ConnectionItem item, string login)
        {
            item.Login = login;
            return item;
        }
        static public ConnectionItem SetPassword(this ConnectionItem item, string password)
        {
            item.Password = password;
            return item;
        }
        static public ConnectionItem SetDatabase(this ConnectionItem item, string databaseName)
        {
            item.Database = databaseName;
            return item;
        }
        static public ConnectionItem SetRemindPassword(this ConnectionItem item, bool remind)
        {
            item.Remind = remind;
            return item;
        }

    }
}
