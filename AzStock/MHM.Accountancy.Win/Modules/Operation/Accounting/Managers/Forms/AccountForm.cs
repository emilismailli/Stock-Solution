using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Business.Infrastructure.Common;
using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class AccountForm : MHMForm

    {
        public AccountForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }
        internal AccountForm(IManager manager, AccountingDataSet dataSet, OperationType operationType)
           : this(manager, null, dataSet, operationType)
        {
        }

        internal AccountForm(IManager manager, BindingSource bindingSource, AccountingDataSet dataSet, OperationType operationType)
            : this(manager, bindingSource, operationType)
        {
            this.dataSet = dataSet;
            this.ApplyBindingSourcesDataSet(this.dataSet);
        }


        private void AccountForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.VwAccountChoose' table. You can move, or remove it, as needed.
            this.vwAccountChooseTableAdapter.Fill(this.dataSet.VwAccountChoose);


            treeListLookUpEditMain.EditValue = null;

            if (Current == null)
                return;

            var currentRow = Current.GetBindingRow<AccountingDataSet.VwAccountRow>();

            treeListLookUpEditMain.EditValue = currentRow.IsParentIdNull() ? (int?)null : currentRow.ParentId;

            textEditAccountNo.Text = GetSubCode(currentRow.Code);
            textEditAccountName.Text = currentRow.Name;

            memoEditAccountDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;

        }
        string GetSubCode  (string code)
        {
            if (code.EndsWith(".") && code.Replace(".", "").Length > 0)
                code = code.Substring(0, code.LastIndexOf("."));

            if (string.IsNullOrWhiteSpace(code) || code.IndexOf(".") == -1)
                return code;

            int lastPointIndex = code.LastIndexOf(".") + 1;

            return code.Substring(lastPointIndex, code.Length - lastPointIndex);
        }

        private void treeListLookUpEditMain_EditValueChanged(object sender, System.EventArgs e)
        {
            vwAccountChooseBindingSource.Position = -1;

            if (treeListLookUpEditMain.EditValue == null)
                return;

            vwAccountChooseBindingSource.Position = vwAccountChooseBindingSource.Find("Id", treeListLookUpEditMain.GetIntValue());

            //var currentRow = vwAccountChooseBindingSource.GetBindingRow<AccountingDataSet.VwAccountChooseRow>();

            //if (currentRow == null)
            //    return;

            //MHMMessage.ShowInformationMessageBox(currentRow.Id.ToString());
        }

       

        private void treeListLookUpEditMain_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (sender is treeListLookUpEdit)
            //{
            //    if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    {
            //        using (var form = new AccountForm(null, null, OperationType.Add, true))
            //        {
            //            form.ShowDialog();
            //            Manager.Loading();

            //        }
            //    }
            //}
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Parameters.Clear();
                textEditAccountNo.Text = string.Join(".", textEditAccountNo.Text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries));

                if (!textEditAccountNo.Validate()
                || !textEditAccountName.Validate()
                ) return;
                string code = "";
                var current = vwAccountChooseBindingSource.GetBindingRow<AccountingDataSet.VwAccountChooseRow>();
                if (current != null && !string.IsNullOrWhiteSpace(current.Code))
                    code = string.Format("{0}.{1}", current.Code, textEditAccountNo.Text);
                else
                    code = textEditAccountNo.Text;

                Parameters.Add("@operationType", operationType)
                .Add("@name", textEditAccountName.Text)
                .Add("@code", code);

                if (!string.IsNullOrWhiteSpace(memoEditAccountDescription.Text))
                    Parameters.Add("@description", memoEditAccountDescription.Text);
                if (treeListLookUpEditMain.EditValue != null)
                    Parameters.Add("@parentId", treeListLookUpEditMain.GetIntValue());

                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwAccountRow>();

                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwAccount, "[Accounting].[spAccount]", Parameters, true, System.Data.CommandType.StoredProcedure);

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
