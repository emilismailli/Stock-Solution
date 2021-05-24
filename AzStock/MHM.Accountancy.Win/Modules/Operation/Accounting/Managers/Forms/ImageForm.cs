using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class ImageForm : XtraForm
    {
        public bool IsMain
        {
            get
            {
                return checkEditMain.Checked;
            }

            set
            {
                checkEditMain.Checked = value;
            }
        }

        public byte[] ImageBuffer
        {
            get
            {
                return Extension.GetBytes(pictureEditGoodImage.Image);
            }
            set
            {
                pictureEditGoodImage.Image = Image.FromStream(new MemoryStream(value));
            }
        }
        public ImageForm()
        {
            InitializeComponent();
        }

        private void buttonEditImageAdd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                buttonEditImageAdd.Text = ofdImage.FileName;
                pictureEditGoodImage.Image = Image.FromFile(ofdImage.FileName);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void btnAcceptImage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
