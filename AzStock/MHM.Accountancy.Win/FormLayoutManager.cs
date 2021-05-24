using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHM.Accountancy.Win
{
    public partial class FormLayoutManager : Form
    {
        public FormLayoutManager()
        {
            InitializeComponent();
        }

        private void FormLayoutManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wareHouseDataSet.WareHouseType' table. You can move, or remove it, as needed.
            this.wareHouseTypeTableAdapter.Fill(this.wareHouseDataSet.WareHouseType);

        }
    }
}
