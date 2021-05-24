using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Win.Modules.Operation.HR.Data;
using MHM.Accountancy.Win.Modules.Operation.HR.Managers.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MHM.Accountancy.Win.Modules.Operation.HR.Managers
{
    public partial class EducationManager : XtraUserControl, IManager
    {
        List<SqlParameter> Parameters;
        OperationType operationType;
        IContainer container;
        EducationManager(IContainer container, int managerId)
        {
            InitializeComponent();
            this.container = container;
            Parameters = new List<SqlParameter>();
            Loading();
        }

        public void Loading()
        {
            this.educationTypesTableAdapter.Fill(hrDataSet.EducationTypes);
        }

      

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnEdit.Enabled = false;

            var selected = educationTypesBindingSource.GetBindingRow<HrDataSet.EducationTypesRow>();

            if (selected == null) return;

            btnEdit.Enabled = true ;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = educationTypesBindingSource.GetBindingRow<HrDataSet.EducationTypesRow>();

            if (selected == null) return;

            using (var form = new EducationForm(educationTypesBindingSource))
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Loading();
                    container.PrintSuccess("Ugurludur");
                }
                else
                    container.PrintError(new System.Exception("Xeta bash verdi"));
            }
        }

        private void btnAdd_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var form = new EducationForm())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Loading();
                    container.PrintSuccess("Ugurludur");
                }
                else
                    container.PrintError(new System.Exception("Xeta bash verdi"));
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
