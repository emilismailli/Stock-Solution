using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MHM.Accountancy.Business.Infrastructure.Permission
{
    public class User
    {
        public int Id { get; set; }
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

        public SqlConnection CurrentConnection { get; set; }
    }
}
