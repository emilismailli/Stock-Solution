using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MHM.Accountancy.Business.Infrastructure
{
    public partial class MHMManager : XtraUserControl, IManager
    {
        List<SqlParameter> parameters;
        protected int managerId;
        private IContainer container;
        //private Color Color;

        private bool AllowShow { get; set; }
        private bool AllowCreate { get; set; }
        private bool AllowUpdate { get; set; }
        private bool AllowDelete { get; set; }
        private bool AllowApplyDocument { get; set; }
        private bool ShowCreate { get; set; }
        private bool ShowUpdate { get; set; }
        private bool ShowDelete { get; set; }
        private bool ShowApplyDocument { get; set; } 

        public IContainer MHMContainer { get; private set; }
        public MHMManager()
        {
            InitializeComponent();
            Font = Settings.Default.AppFont;
            //this.Color = Settings.Default.AppColor;
        }
        public MHMManager(IContainer container, int managerId, bool isFiltered = true)
        {
            InitializeComponent();
            this.MHMContainer = container;
            this.managerId = managerId;
            this.IsFiltered = isFiltered;
            this.parameters = new List<SqlParameter>();

            ApplyPermission();

            btnEdit.Visibility = ShowUpdate ? BarItemVisibility.Always : BarItemVisibility.Never;
        }

        private void ApplyPermission()
        {
            using (var cmd = new SqlCommand(@"select AllowShow,AllowCreate,AllowUpdate,AllowDelete,AllowApplyDocument,ShowCreate,ShowUpdate,ShowDelete,ShowApplyDocument from dbo.fnGetAccess(@userId,@managerId)", MHMContainer.CurrentUser.CurrentConnection))
            {
                //MHMContainer.CurrentUser.OpenConnection();
                cmd.Parameters.AddWithValue("@userId", MHMContainer.CurrentUser.Id);
                cmd.Parameters.AddWithValue("@managerId", managerId);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    AllowShow = Convert.ToBoolean(reader[0]);
                    AllowCreate = Convert.ToBoolean(reader[1]);
                    AllowUpdate = Convert.ToBoolean(reader[2]);
                    AllowDelete = Convert.ToBoolean(reader[3]);
                    ShowCreate = Convert.ToBoolean(reader[4]);
                    ShowUpdate = Convert.ToBoolean(reader[5]);
                    ShowDelete = Convert.ToBoolean(reader[6]);
                    ShowApplyDocument = Convert.ToBoolean(reader[7]);
                    AllowApplyDocument=Convert.ToBoolean(reader[8]) ;
                }
                else
                {
                    AllowShow = AllowCreate = AllowUpdate = AllowDelete=AllowApplyDocument = false;
                }
            }

            MHMContainer.CurrentUser.CloseConnection();
        }

        protected bool EditableButtons
        {
            set
            {
                btnEdit.Enabled = btnDelete.Enabled = btnPrint.Enabled = btnShow.Enabled =btnApplyDocument.Enabled= value;

            }
        }

        public int Id => managerId;

        public bool IsFiltered { get; private set; }
        public int? DocTypeId { get; private set; }
        public int? DocCertId { get; private set; }
        public int? DocSeriesId { get; private set; }

        //public int? DocSeriesId => throw new System.NotImplementedException();

        //public int? DocCertId => throw new System.NotImplementedException();

        //public int? DocTypeId => throw new System.NotImplementedException();

        public List<SqlParameter> Parameters => parameters;

        protected virtual void btnShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //MHMMessage.ShowWarningMessageBox("btnShow_ItemClick");
        }

        protected virtual void btnPosPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MHMMessage.ShowWarningMessageBox("btnSearch_ItemClick");
        }

        protected virtual void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

       

        protected virtual void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
     
        protected virtual void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        protected virtual void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
      

      
       
        public virtual void Loading()
        {
            //manager.Parameters.Clear();
            //manager.Parameters.Add("@operationType", OperationType.Select);
            throw new System.NotImplementedException();

        }

        public virtual void ExportToExcel()
        {
            throw new System.NotImplementedException();
        }

        protected void Redesign()
        {
            foreach (Bar bar in barManager.Bars)
            {

                bar.Appearance.Font =
                bar.BarAppearance.Disabled.Font =
                bar.BarAppearance.Normal.Font =
                bar.BarAppearance.Hovered.Font =
                bar.BarAppearance.Pressed.Font = this.Font;
            }

            SetChild(this);
        }

        void SetChild(Control control)
        {

            if (control is GridControl)
            {
                var gv = ((control as GridControl).FocusedView as GridView);

                gv.Appearance.Row.Font = this.Font;
                gv.Appearance.HeaderPanel.Font = this.Font;

                foreach (GridColumn col in gv.Columns)
                {
                    col.AppearanceCell.Font = this.Font;
                    col.AppearanceHeader.Font = this.Font;
                }
            }
            else
                control.Font = this.Font;

            foreach (Control child in control.Controls)
            {
                if (child.Controls.Count > 0)
                    SetChild(child);
                else
                    child.Font = this.Font;
            }
        }



        protected void SetAddReadonly(bool @readonly = false)
        {
            btnAdd.Enabled = !@readonly && AllowCreate;
        }



        protected void SetEditReadonly(bool @readonly = false)
        {
            btnEdit.Enabled = !@readonly && AllowUpdate;
        }


        protected void SetRemoveReadonly(bool @readonly = false)
        {
            btnDelete.Enabled = !@readonly && AllowDelete;
        }
        protected void SetPrintReadonly(bool @readonly = false)
        {
            btnPrint.Enabled = !@readonly;
        }
        protected void SetShowReadonly(bool @readonly = false)
        {
            btnShow.Enabled = !@readonly && AllowShow;
        }
        protected void SetApplyReadonly(bool @readonly = false)
        {
            btnApplyDocument.Enabled = !@readonly;
        }
        protected void SetApplyDocumentReadonly(bool @readonly = false)
        {
            btnApplyDocument.Enabled = !@readonly && AllowApplyDocument;
        }
        private void MHMManager_Load(object sender, EventArgs e)
        {

        }

        private void MHMManager_KeyDown(object sender, KeyEventArgs e)
        {
            //Shortcut.Del();
        }

        protected virtual void btnApplyDocument_ItemClick(object sender,DevExpress.XtraBars. ItemClickEventArgs e)
        {

        }


        
    }
}
