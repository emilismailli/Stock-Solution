namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class LogisticManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogisticManager));
            this.gridControlLogistic = new DevExpress.XtraGrid.GridControl();
            this.vwLogisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewLogistic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwLogisticTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwLogisticTableAdapter();
            this.vwLogisticDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwLogisticDetailTableAdapter();
            this.colTransportation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLogistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwLogisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLogistic)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlLogistic
            // 
            this.gridControlLogistic.DataSource = this.vwLogisticBindingSource;
            this.gridControlLogistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLogistic.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlLogistic.Location = new System.Drawing.Point(0, 40);
            this.gridControlLogistic.MainView = this.gridViewLogistic;
            this.gridControlLogistic.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlLogistic.MenuManager = this.barManager;
            this.gridControlLogistic.Name = "gridControlLogistic";
            this.gridControlLogistic.Size = new System.Drawing.Size(1544, 1064);
            this.gridControlLogistic.TabIndex = 4;
            this.gridControlLogistic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLogistic});
            // 
            // vwLogisticBindingSource
            // 
            this.vwLogisticBindingSource.DataMember = "VwLogistic";
            this.vwLogisticBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewLogistic
            // 
            this.gridViewLogistic.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDriver,
            this.colSender,
            this.colReceived,
            this.colDate,
            this.colTransportation,
            this.colDescription});
            this.gridViewLogistic.GridControl = this.gridControlLogistic;
            this.gridViewLogistic.Name = "gridViewLogistic";
            this.gridViewLogistic.OptionsBehavior.ReadOnly = true;
            this.gridViewLogistic.OptionsSelection.MultiSelect = true;
            this.gridViewLogistic.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewLogistic.OptionsView.ShowGroupPanel = false;
            this.gridViewLogistic.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewContract_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "№";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            // 
            // colDriver
            // 
            this.colDriver.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDriver.AppearanceCell.Options.UseFont = true;
            this.colDriver.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDriver.AppearanceHeader.Options.UseFont = true;
            this.colDriver.Caption = "Sürücü";
            this.colDriver.FieldName = "Driver";
            this.colDriver.Image = ((System.Drawing.Image)(resources.GetObject("colDriver.Image")));
            this.colDriver.Name = "colDriver";
            this.colDriver.Visible = true;
            this.colDriver.VisibleIndex = 2;
            // 
            // colSender
            // 
            this.colSender.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSender.AppearanceCell.Options.UseFont = true;
            this.colSender.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSender.AppearanceHeader.Options.UseFont = true;
            this.colSender.Caption = "Göndərən";
            this.colSender.FieldName = "Sender";
            this.colSender.Image = ((System.Drawing.Image)(resources.GetObject("colSender.Image")));
            this.colSender.Name = "colSender";
            this.colSender.Visible = true;
            this.colSender.VisibleIndex = 3;
            // 
            // colReceived
            // 
            this.colReceived.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colReceived.AppearanceCell.Options.UseFont = true;
            this.colReceived.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colReceived.AppearanceHeader.Options.UseFont = true;
            this.colReceived.Caption = "Qəbul Edən";
            this.colReceived.FieldName = "Received";
            this.colReceived.Image = ((System.Drawing.Image)(resources.GetObject("colReceived.Image")));
            this.colReceived.Name = "colReceived";
            this.colReceived.Visible = true;
            this.colReceived.VisibleIndex = 4;
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDate.AppearanceCell.Options.UseFont = true;
            this.colDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDate.AppearanceHeader.Options.UseFont = true;
            this.colDate.Caption = "Tarix";
            this.colDate.FieldName = "Date";
            this.colDate.Image = ((System.Drawing.Image)(resources.GetObject("colDate.Image")));
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 6;
            // 
            // vwLogisticTableAdapter
            // 
            this.vwLogisticTableAdapter.ClearBeforeFill = true;
            // 
            // vwLogisticDetailTableAdapter
            // 
            this.vwLogisticDetailTableAdapter.ClearBeforeFill = true;
            // 
            // colTransportation
            // 
            this.colTransportation.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colTransportation.AppearanceCell.Options.UseFont = true;
            this.colTransportation.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colTransportation.AppearanceHeader.Options.UseFont = true;
            this.colTransportation.Caption = " N/V";
            this.colTransportation.FieldName = "Transportation";
            this.colTransportation.Image = ((System.Drawing.Image)(resources.GetObject("colTransportation.Image")));
            this.colTransportation.Name = "colTransportation";
            this.colTransportation.Visible = true;
            this.colTransportation.VisibleIndex = 5;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Image = ((System.Drawing.Image)(resources.GetObject("colDescription.Image")));
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            // 
            // LogisticManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlLogistic);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LogisticManager";
            this.Size = new System.Drawing.Size(1544, 1104);
            this.Controls.SetChildIndex(this.gridControlLogistic, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLogistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwLogisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLogistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlLogistic;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLogistic;
        private System.Windows.Forms.BindingSource vwLogisticBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDriver;
        private DevExpress.XtraGrid.Columns.GridColumn colSender;
        private DevExpress.XtraGrid.Columns.GridColumn colReceived;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private Data.AccountingDataSetTableAdapters.VwLogisticTableAdapter vwLogisticTableAdapter;
        private Data.AccountingDataSetTableAdapters.VwLogisticDetailTableAdapter vwLogisticDetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTransportation;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}
