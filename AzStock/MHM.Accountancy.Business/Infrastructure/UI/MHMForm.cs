using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MHM.Accountancy.Business.Infrastructure
{
    public partial class MHMForm : XtraForm
    {
        protected OperationType operationType;
        protected BindingSource Current;
        protected List<SqlParameter> Parameters;
        protected IManager Manager { get; private set; }

        public MHMForm()
        {
            InitializeComponent();
        }

        public MHMForm(IManager manager,BindingSource bindingSource,OperationType operationType,bool applyNew=false)
            :this()
        {
            this.Manager = manager;
            this.operationType = operationType;
            this.Current = bindingSource;
            this.Parameters = new List<SqlParameter>();


            checkApplyNew.Visible = applyNew && operationType == OperationType.Add;
        }

        protected virtual void btnAccept_Click(object sender, EventArgs e)
        {
            //Manager.MHMContainer.CurrentUser
            //MHMMessage.ShowWarningMessageBox("btnAccept_Click");
        }

        protected virtual  void btnCancel_Click(object sender, EventArgs e)
        {
            MHMMessage.ShowQuestionMessageBox("Ləğv etmək istədiyinizdən əminsinizmi?");
        }

     
        private void MHMForm_Load(object sender, EventArgs e)
        {
            SetReadOnly();
        }

        private void SetReadOnly()
        {
            if (operationType==OperationType.None)
            {
                foreach (Control control in this.Controls)
                    SetControlReadOnly(control);
            }
        }

        protected void ClearInputs()
        {
            foreach (Control control in this.Controls)
                ClearInputs(control);
        }

        void SetControlReadOnly(Control c, bool isReadOnly=true)
        {
            BaseEdit edit = c as BaseEdit;
            if (edit != null) { edit.Properties.ReadOnly = isReadOnly; return; }

            BaseButton btn = c as BaseButton;
            if (btn != null) { btn.Enabled = !isReadOnly; return; }

            GridControl gridControl = c as GridControl;
            if (gridControl != null)
            {
                foreach (GridView view in gridControl.AvailableViews)
                {
                    if (view != null) view.OptionsBehavior.ReadOnly = isReadOnly;
                }
                return;
            }
        }
        void ClearInputs(Control c, bool isReadOnly = true)
        {
            BaseEdit edit = c as BaseEdit;
            if (edit != null)
            {
                if (edit.Name != "checkApplyNew")
                {
                    edit.EditValue = null;
                }
            }
        }

        protected virtual void RefreshManager()
        {
            if (Manager == null) return;
            Manager.Loading();
        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {
            MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?");
        }

        protected virtual void btnPrintDocument_Click(object sender, EventArgs e)
        {
            
        }
    }
}
