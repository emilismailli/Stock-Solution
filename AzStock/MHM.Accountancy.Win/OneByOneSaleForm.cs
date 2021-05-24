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
    public partial class OneByOneSaleForm : Form
    {
        public static decimal quantity;
        public OneByOneSaleForm()
        {
            InitializeComponent();
        }

        private void OneByOneSaleForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToDecimal(txtSaleQuantity.Text) /Convert.ToDecimal(txtTotalQuantity.Text) ;
            DialogResult = DialogResult.OK;
        }
    } 
}
