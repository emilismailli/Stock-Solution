using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.HR.Managers.Forms
{
    public partial class CitizenshipForm : XtraForm
    {
        public CitizenshipForm()
        {
            InitializeComponent();
        }


        public CitizenshipForm(BindingSource bindingSource)
           : this()
        {
            //currentRow = bindingSource.GetBindingRow<HrDataSet.CitizenshipRow>();
        }




    }
}
