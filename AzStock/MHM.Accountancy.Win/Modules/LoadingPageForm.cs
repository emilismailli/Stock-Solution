
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using WinCustom.Customizer;

namespace MHM.Accountancy.Win
{
    public partial class LoadingPageForm : Form
    {
        MouseMove mover;
        //private string Pass;
        //private string Login;
        public LoadingPageForm()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("az");
            InitializeComponent();
            mover = new MouseMove();
            //txtPassword.Text = Pass;
            //txtLogin.Text = Login;

            txtLogin.Text = MHM.Accountancy.Win.Properties.Settings.Default.UserLogin;
            txtPassword.Text = MHM.Accountancy.Win.Properties.Settings.Default.UserPassword;
            if(txtLogin.Text!="" && txtPassword.Text != "")
            { checkBoxRemember.Checked = true; }
            else
                checkBoxRemember.Checked = false;
        }




      

      private void btnLogin_Click(object sender, EventArgs e)
        {
                Program.CurrentUser.OpenConnection();

            SqlCommand cmd = new SqlCommand("select u.Id,p.Id UserId,u.UserName,u.UserSurname,u.Login,u.Pin,u.UserPatryonmic,u.RoleId from dbo.[User] u " +
                " join  [dbo].[Principial] p on p.PersonId=u.Id where u.login =@login and u.password=@password", Program.CurrentUser.CurrentConnection);
            cmd.Parameters.AddWithValue("@login", txtLogin.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
      SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Program.CurrentUser.Id = Convert.ToInt32(dr["UserId"]);
                Program.CurrentUser.UserName = Convert.ToString(dr["UserName"]);
                Program.CurrentUser.FullName = $"{dr["UserName"]} {dr["UserSurname"]} {dr["UserPatryonmic"]}";

                using (var frm = new MainForm())
                {
                    this.Hide();
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("İstifadəçi Adı və ya  Şifrə düzgün deyil!");
            }
            Program.CurrentUser.CloseConnection();

          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

      
        private void presentationImage_MouseDown(object sender, MouseEventArgs e)
        {
            mover.On(e);
        }

        private void presentationImage_MouseUp(object sender, MouseEventArgs e)
        {
            mover.Off();
        }

        private void presentationImage_MouseMove(object sender, MouseEventArgs e)
        {
            mover.Move(this, e);
        }
    private void btnRetailSale_Click(object sender, EventArgs e)
        {
           
            Program.CurrentUser.OpenConnection();

            SqlCommand cmd = new SqlCommand("select u.Id,p.Id UserId,u.UserName,u.UserSurname,u.Login,u.Pin,u.UserPatryonmic,u.RoleId from dbo.[User] u " +
                     " join  [dbo].[Principial] p on p.PersonId=u.Id where u.login =@login and u.password=@password", Program.CurrentUser.CurrentConnection);
            cmd.Parameters.AddWithValue("@login", txtLogin.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.Read())
            {
                Program.CurrentUser.Id = Convert.ToInt32(dr["UserId"]);
                Program.CurrentUser.UserName = Convert.ToString(dr["UserName"]);
                Program.CurrentUser.FullName = $"{dr["UserName"]} {dr["UserSurname"]} {dr["UserPatryonmic"]}";

                cmd.CommandText= @"SELECT count(0) FROM [dbo].[MenuUserAccess]
                                where UserId = @userId and AllowRetail = 1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@userId", Program.CurrentUser.Id);
                dr.Close();
                Program.CurrentUser.OpenConnection();
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                {
                    ErpMessage.ShowErrorMessageBox("Giriş hüququnuz yoxdur!");
                    goto theEnd;
                }

                try
                {
                    using (var frm = new RetailSaleForm(Program.CurrentUser))
                    {
                        this.Hide();
                        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
                        this.Show();
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("İstifadəçi Adı və ya  Şifrə düzgün deyil!");
            }
            theEnd:
            Program.CurrentUser.CloseConnection();
        }

        private void LoadingPageForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {
                btnRetailSale.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.M)
            {
                btnLogin.PerformClick();
            }


            if (e.Control && e.KeyCode == Keys.E)
            {
                using (var frm = new MainForm())
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                    }
                }
            }

        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                txtPassword.Properties.PasswordChar = '\0';

            }

            else
            {
                txtPassword.Properties.PasswordChar = '*';
            }
        }

        private void LoadingPageForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var frm = new SaleForm(null, null, Business.Infrastructure.Common.OperationType.Add))
            {
                this.Hide();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
                this.Show();
            }
        }

      



      

       


        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
       {
            if (checkBoxRemember.Checked==true)
            {
                MHM.Accountancy.Win.Properties.Settings.Default.UserLogin = txtLogin.Text;
                MHM.Accountancy.Win.Properties.Settings.Default.UserPassword = txtPassword.Text;
                MHM.Accountancy.Win.Properties.Settings.Default.Save();
                

            }
            if (checkBoxRemember.Checked == false)
            {
                MHM.Accountancy.Win.Properties.Settings.Default.UserLogin = "";
                MHM.Accountancy.Win.Properties.Settings.Default.UserPassword = "";
                MHM.Accountancy.Win.Properties.Settings.Default.Save();

            }

           
        }

        private void btnExitForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void presentationImage_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
