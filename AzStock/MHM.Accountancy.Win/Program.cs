using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Identity;
using MHM.Accountancy.Win.Properties;

namespace MHM.Accountancy.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Debugger.IsAttached)
            {
                string pwd = ConfigurationManager.AppSettings.Get("Password");

                //frame cs
                Settings.Default["AccountancyConnectionString"] = $"Data Source={ConfigurationManager.AppSettings.Get("Server")};Initial Catalog=Somar{ConfigurationManager.AppSettings.Get("Database")};User ID={ConfigurationManager.AppSettings.Get("UserName")};Password=!mhm@{pwd}{string.Join("", pwd.ToCharArray().Reverse())}#;MultipleActiveResultSets=True";

                //business cs
                Business.Properties.Settings.Default["AccountancyConnectionString"] = Settings.Default.AccountancyConnectionString;
            }

            CurrentUser = new User
            {
                CurrentConnection = new System.Data.SqlClient.SqlConnection(Settings.Default.AccountancyConnectionString)
            };
            //MessageBox.Show(Settings.Default.AccountancyConnectionString);
            //Settings.Default.AccountancyConnectionString

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            Application.Run(new LoadingPageForm());
        }

        internal static CultureInfo GetCustomCultureInfo(string lang)
        {
            var ci = new CultureInfo(lang);
            ci.NumberFormat.CurrencySymbol = "AZN";
            ci.NumberFormat.PercentDecimalSeparator = ".";
            ci.NumberFormat.NumberDecimalSeparator = ".";

            return ci;
        }

        //vaxti gelende burdan sil bunu
        //public static User CurrentUser { get { return new User { Id=1,UserName="Admin", CurrentConnection = new System.Data.SqlClient.SqlConnection(Settings.Default.AccountancyConnectionString)}; } }
        public static User CurrentUser { get; set; }
        //        {
        //            get
        //            {
        //                return new User { Id = 2, UserName = "Reporter", CurrentConnection = new System.Data.SqlClient.SqlConnection(Settings.Default.AccountancyConnectionString)
        //    };
        //}
        //        }

        public static int RetailDefaultContractId
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings.Get("RetailDefaultContractId"));
            }
        }
    }
}