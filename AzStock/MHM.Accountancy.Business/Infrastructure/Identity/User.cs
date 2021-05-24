using MHM.Accountancy.Business.Infrastructure.Constants;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MHM.Accountancy.Business.Infrastructure.Identity
{
    public class User : IDisposable
    {
        object _lock = new object();
        SqlConnection _connection;
        ConnectionItem connectionItem;
        int connectionTimeout;

        public User()
        {

        }

        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }
        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
                _connection.Close();
        }

        public User(ConnectionItem connectionItem, int connectionTimeout = 15)
        {
            if (connectionTimeout <= 0)
                this.connectionTimeout = 15;
            else
                this.connectionTimeout = connectionTimeout;

            this.connectionItem = connectionItem;
        }

        public User(string connectionHex, int connectionTimeout = 15)
            : this(new ConnectionItem(connectionHex), connectionTimeout)
        {

        }

        static public SqlConnection CreateConnection(ConnectionItem connectionItem, int connectionTimeout = 15)
        {
            return new SqlConnection(string.Format(Configs.connectionFormat, connectionItem.ServerName, connectionItem.Database, GetLoginSalt(connectionItem), GetPasswordSalt(connectionItem), connectionTimeout));
        }

        public SqlConnection CurrentConnection
        {
            get
            {
                if (connectionItem == null && _connection==null)
                    throw new ArgumentNullException("connectionItem");

                if (_connection == null)
                    lock (_lock)
                    {
                        if (_connection == null)
                            _connection = CreateConnection(connectionItem, this.connectionTimeout);
                        //_connection = new SqlConnection(string.Format(Configs.connectionFormat, connectionItem.ServerName, connectionItem.Database, connectionItem.Login, connectionItem.Password, this.connectionTimeout, this.salt));
                    }

                if (_connection.State != ConnectionState.Open)
                    lock (_lock)
                        if (_connection.State != ConnectionState.Open)
                            _connection.Open();

                return _connection;
            }
            set
            {
                _connection = value;
            }
        }
          bool Login(DataTable table)
        {
            try
            {
                string cs = string.Format(Configs.connectionFormat, connectionItem.ServerName, "master", GetLoginSalt(connectionItem), GetPasswordSalt(connectionItem), connectionTimeout);
                if (this.ExecuteScalar<int>(string.Format("SELECT count(0) FROM [master].[dbo].[sysdatabases] WHERE[name] = N'{0}'", connectionItem.Database), null,
                    new SqlConnection(cs)) < 1)
                {
                    if (MHMMessage.ShowQuestionMessageBox("Bu adda verilənlər bazası mövcud deyil.Yaratmaq istəyirsiniz?") == DialogResult.OK)
                    {
                        Process.Start(new ProcessStartInfo() { FileName = Application.ExecutablePath, Arguments = string.Format("\"{0}\" {1}", string.Format(Configs.connectionFormat, connectionItem.ServerName, "master", GetLoginSalt(connectionItem), GetPasswordSalt(connectionItem), connectionTimeout)/*connectionItem.ServerName*/, connectionItem.Database) });
                        Application.Exit();
                    }
                }

                this.ExecuteProcedure(table, string.Format("select Id,FullName from [dbo].[IfnUserInfo]('{0}');", connectionItem.Login));
                foreach (DataRow row in table.Rows)
                {
                    this.Id = Convert.ToInt32(row["Id"]);
                    this.FullName = Convert.ToString(row["FullName"]);
                    break;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                connectionItem = null;
            }
        }

        public int Id { get; set; }

        public string FullName { get; set; }


        //


        public static string GetLoginSalt(ConnectionItem cItem)
        {
            if (cItem.Login == "sa" || cItem.Login == "intelect")
                return string.Format("{0}{1}", cItem.Login, "");
            else
                return string.Format("{0}{1}", cItem.Login, string.IsNullOrWhiteSpace(cItem.salt) ? "devops@!!*" : string.Join("", cItem.salt.ToCharArray().Reverse()));
        }



        public static string GetPasswordSalt(ConnectionItem cItem)
        {
            string _salt = cItem.salt + "щльывц#764";

            if (cItem.Login == "sa" || cItem.Login == "intelect")
                return string.Format("{0}{1}", cItem.Password, "");
            else
                return string.Format("{0}{1}", cItem.Password, string.IsNullOrWhiteSpace(_salt) ? "devops@!!*" : string.Join("", _salt.ToCharArray().Reverse()));
        }

        public string UserName { get; set; }
        public string Password { get; private set; }

        public void SetPassword(string password)
        {
            var crypto = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(string.Format("#mhm{0}!accountancy{1}@{2}", string.Join("", password.ToCharArray().Reverse()), Id, UserName));
            var hash = crypto.ComputeHash(inputBytes);
            var builder = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
                builder.Append(hash[i].ToString("X2"));

            Password = builder.ToString();
        }
    }
}
