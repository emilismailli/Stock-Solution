namespace MHM.Accountancy.Win
{
    partial class FormLayoutManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.wareHouseTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.wareHouseDataSet = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wareHouseTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSetTableAdapters.WareHouseTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.wareHouseTypeBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // wareHouseTypeBindingSource
            // 
            this.wareHouseTypeBindingSource.DataMember = "WareHouseType";
            this.wareHouseTypeBindingSource.DataSource = this.wareHouseDataSet;
            // 
            // wareHouseDataSet
            // 
            this.wareHouseDataSet.DataSetName = "WareHouseDataSet";
            this.wareHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Qruplamaq istədiyiniz sütunu buraya sürükləyin";
            this.gridView1.Name = "gridView1";
            // 
            // colName
            // 
            this.colName.Caption = "Adı";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 75;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 130;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 100;
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 300;
            // 
            // wareHouseTypeTableAdapter
            // 
            this.wareHouseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FormLayoutManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormLayoutManager";
            this.Text = "FormLayoutManager";
            this.Load += new System.EventHandler(this.FormLayoutManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Modules.Operation.WareHouse.Data.WareHouseDataSet wareHouseDataSet;
        private System.Windows.Forms.BindingSource wareHouseTypeBindingSource;
        private Modules.Operation.WareHouse.Data.WareHouseDataSetTableAdapters.WareHouseTypeTableAdapter wareHouseTypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}