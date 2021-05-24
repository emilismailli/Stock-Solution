using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Win.Modules.Operation.HR.Data;
using System;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.HR.Managers.Forms
{
    public partial class EducationForm : XtraForm
    {
        HrDataSet.EducationTypesRow currentRow = null;
        OperationType type = OperationType.Add;
        public EducationForm()
        {
            InitializeComponent();
        }

        public EducationForm(BindingSource bindingSource)
            :this()
        {
            currentRow= bindingSource.GetBindingRow<HrDataSet.EducationTypesRow>();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (type==OperationType.Add)
            {
                educationTypesTableAdapter.InsertQuery(textEditName.Text, textEditDescription.Text);
            }
            else
                educationTypesTableAdapter.UpdateQuery(textEditName.Text, textEditDescription.Text, currentRow.Id);
            DialogResult = DialogResult.OK;
        }

        private void EducationForm_Load(object sender, EventArgs e)
        {
            if (currentRow == null) return;

            textEditName.Text = currentRow.Name;
            textEditDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;

            type = OperationType.Edit;

        }
    }
}
