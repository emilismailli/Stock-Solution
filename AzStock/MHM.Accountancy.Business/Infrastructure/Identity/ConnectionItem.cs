using ERP.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MHM.Accountancy.Business.Infrastructure.Identity
{
    public class ConnectionItem : IEquatable<ConnectionItem>
    {
        internal string salt = "devops@!!*";
        public string ServerName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public bool Remind { get; set; }

        public ConnectionItem(string serverName, string login, string password, string database, bool remind)
        {
            this.ServerName = serverName;
            this.Login = login;
            this.Password = password;
            this.Database = database;
            this.Remind = remind;
        }

        public ConnectionItem(string hexData)
        {
            int pos = 0, dataLength = 0;
            byte[] _attrBuffer;
            byte[] connection = hexData.StringToByteArray();
            if (connection.Length < 1) return;

            while (pos < connection.Length - 1)
            {
                switch (connection[pos])
                {
                    case 1:
                        {
                            dataLength = connection[++pos];
                            _attrBuffer = new byte[dataLength];
                            Array.Copy(connection, ++pos, _attrBuffer, 0, dataLength);
                            ServerName = Encoding.UTF8.GetString(_attrBuffer);
                            pos += dataLength;
                            break;
                        }
                    case 2:
                        {
                            dataLength = connection[++pos];
                            _attrBuffer = new byte[dataLength];
                            Array.Copy(connection, ++pos, _attrBuffer, 0, dataLength);
                            Login = Encoding.UTF8.GetString(_attrBuffer);
                            pos += dataLength;
                            break;
                        }
                    case 3:
                        {
                            dataLength = connection[++pos];
                            _attrBuffer = new byte[dataLength];
                            Array.Copy(connection, ++pos, _attrBuffer, 0, dataLength);
                            Password = Encoding.UTF8.GetString(_attrBuffer);
                            Remind = true;
                            pos += dataLength;
                            break;
                        }
                    case 4:
                        {
                            dataLength = connection[++pos];
                            _attrBuffer = new byte[dataLength];
                            Array.Copy(connection, ++pos, _attrBuffer, 0, dataLength);
                            Database = Encoding.UTF8.GetString(_attrBuffer);
                            pos += dataLength;
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        public ConnectionItem()
        {
        }

        public byte[] Buffer
        {
            get
            {
                List<byte> buffer = new List<byte>();
                byte[] _attrBuffer;
                if (!string.IsNullOrWhiteSpace(ServerName))
                {
                    buffer.Add(1);
                    _attrBuffer = Encoding.UTF8.GetBytes(ServerName);
                    buffer.Add((byte)_attrBuffer.Length);
                    buffer.AddRange(_attrBuffer);
                }
                if (!string.IsNullOrWhiteSpace(Login))
                {
                    buffer.Add(2);//login
                    _attrBuffer = Encoding.UTF8.GetBytes(Login);
                    buffer.Add((byte)_attrBuffer.Length);
                    buffer.AddRange(_attrBuffer);
                }
                if (!string.IsNullOrWhiteSpace(Password) && Remind)
                {
                    buffer.Add(3);//password
                    _attrBuffer = Encoding.UTF8.GetBytes(Password);
                    buffer.Add((byte)_attrBuffer.Length);
                    buffer.AddRange(_attrBuffer);
                }
                if (!string.IsNullOrWhiteSpace(Database))
                {
                    buffer.Add(4);//database
                    _attrBuffer = Encoding.UTF8.GetBytes(Database);
                    buffer.Add((byte)_attrBuffer.Length);
                    buffer.AddRange(_attrBuffer);
                }
                return buffer.ToArray();
            }
        }

        public override string ToString()
        {
            return string.Format("({0}).{1}", ServerName, Database);
        }

        public bool Equals(ConnectionItem other)
        {
            return other.ServerName == this.ServerName && other.Database == this.Database;
        }
    }
}
