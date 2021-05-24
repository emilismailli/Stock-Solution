namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class UserManager
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
            this.gridControlUser = new DevExpress.XtraGrid.GridControl();
            this.vwUserBindingSource = new System.Windows.Forms.BindingSource();
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserPatryonmic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthOfDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwUserTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwUserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUser
            // 
            this.gridControlUser.DataSource = this.vwUserBindingSource;
            this.gridControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUser.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlUser.Location = new System.Drawing.Point(0, 40);
            this.gridControlUser.MainView = this.gridViewUser;
            this.gridControlUser.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlUser.MenuManager = this.barManager;
            this.gridControlUser.Name = "gridControlUser";
            this.gridControlUser.Size = new System.Drawing.Size(1264, 530);
            this.gridControlUser.TabIndex = 4;
            this.gridControlUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUser});
            // 
            // vwUserBindingSource
            // 
            this.vwUserBindingSource.DataMember = "VwUser";
            this.vwUserBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewUser
            // 
            this.gridViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colUserSurname,
            this.colUserPatryonmic,
            this.colPin,
            this.colRoleTypeName,
            this.colPassword,
            this.colBirthOfDate,
            this.colRegionName,
            this.colAddress,
            this.colDescription});
            this.gridViewUser.GridControl = this.gridControlUser;
            this.gridViewUser.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkin";
            this.gridViewUser.Name = "gridViewUser";
            this.gridViewUser.OptionsBehavior.ReadOnly = true;
            this.gridViewUser.OptionsSelection.MultiSelect = true;
            this.gridViewUser.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewUser.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewUser_FocusedRowChanged_1);
            // 
            // colUserName
            // 
            this.colUserName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUserName.AppearanceCell.Options.UseFont = true;
            this.colUserName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUserName.AppearanceHeader.Options.UseFont = true;
            this.colUserName.Caption = "Ad";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            // 
            // colUserSurname
            // 
            this.colUserSurname.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUserSurname.AppearanceCell.Options.UseFont = true;
            this.colUserSurname.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUserSurname.AppearanceHeader.Options.UseFont = true;
            this.colUserSurname.Caption = "Soyad";
            this.colUserSurname.FieldName = "UserSurname";
            this.colUserSurname.Name = "colUserSurname";
            this.colUserSurname.Visible = true;
            this.colUserSurname.VisibleIndex = 2;
            // 
            // colUserPatryonmic
            // 
            this.colUserPatryonmic.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUserPatryonmic.AppearanceCell.Options.UseFont = true;
            this.colUserPatryonmic.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUserPatryonmic.AppearanceHeader.Options.UseFont = true;
            this.colUserPatryonmic.Caption = "Ata adı";
            this.colUserPatryonmic.FieldName = "UserPatryonmic";
            this.colUserPatryonmic.Name = "colUserPatryonmic";
            this.colUserPatryonmic.Visible = true;
            this.colUserPatryonmic.VisibleIndex = 3;
            // 
            // colPin
            // 
            this.colPin.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPin.AppearanceCell.Options.UseFont = true;
            this.colPin.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPin.AppearanceHeader.Options.UseFont = true;
            this.colPin.Caption = "Fin";
            this.colPin.FieldName = "Pin";
            this.colPin.Name = "colPin";
            this.colPin.Visible = true;
            this.colPin.VisibleIndex = 4;
            // 
            // colRoleTypeName
            // 
            this.colRoleTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRoleTypeName.AppearanceCell.Options.UseFont = true;
            this.colRoleTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRoleTypeName.AppearanceHeader.Options.UseFont = true;
            this.colRoleTypeName.Caption = "Vəzifə";
            this.colRoleTypeName.FieldName = "RoleTypeName";
            this.colRoleTypeName.Name = "colRoleTypeName";
            this.colRoleTypeName.Visible = true;
            this.colRoleTypeName.VisibleIndex = 5;
            // 
            // colPassword
            // 
            this.colPassword.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPassword.AppearanceCell.Options.UseFont = true;
            this.colPassword.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPassword.AppearanceHeader.Options.UseFont = true;
            this.colPassword.Caption = "Şifrə";
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 6;
            // 
            // colBirthOfDate
            // 
            this.colBirthOfDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBirthOfDate.AppearanceCell.Options.UseFont = true;
            this.colBirthOfDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBirthOfDate.AppearanceHeader.Options.UseFont = true;
            this.colBirthOfDate.Caption = "Doğum tarixi";
            this.colBirthOfDate.FieldName = "BirthOfDate";
            this.colBirthOfDate.Name = "colBirthOfDate";
            this.colBirthOfDate.Visible = true;
            this.colBirthOfDate.VisibleIndex = 7;
            // 
            // colRegionName
            // 
            this.colRegionName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRegionName.AppearanceCell.Options.UseFont = true;
            this.colRegionName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRegionName.AppearanceHeader.Options.UseFont = true;
            this.colRegionName.Caption = "Region";
            this.colRegionName.FieldName = "RegionName";
            this.colRegionName.Name = "colRegionName";
            this.colRegionName.Visible = true;
            this.colRegionName.VisibleIndex = 8;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAddress.AppearanceHeader.Options.UseFont = true;
            this.colAddress.Caption = "Ünvan";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 9;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 10;
            // 
            // vwUserTableAdapter
            // 
            this.vwUserTableAdapter.ClearBeforeFill = true;
            // 
            // UserManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlUser);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserManager";
            this.Controls.SetChildIndex(this.gridControlUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUser;
        private System.Windows.Forms.BindingSource vwUserBindingSource;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colUserPatryonmic;
        private DevExpress.XtraGrid.Columns.GridColumn colPin;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthOfDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRegionName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.AccountingDataSetTableAdapters.VwUserTableAdapter vwUserTableAdapter;
    }
}
