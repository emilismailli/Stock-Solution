namespace MHM.Accountancy.Business.Infrastructure
{
    partial class MHMManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MHMManager));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnPosPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.btnShow = new DevExpress.XtraBars.BarButtonItem();
            this.btnApplyDocument = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnPrint,
            this.btnShow,
            this.btnPosPrinter,
            this.btnApplyDocument});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPosPrinter),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShow),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnApplyDocument)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "";
            this.btnAdd.AccessibleName = "";
            this.btnAdd.Caption = "Əlavə Et";
            this.btnAdd.Description = "Insert";
            this.btnAdd.Hint = " ";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Redaktə Et";
            this.btnEdit.Hint = "   ";
            this.btnEdit.Id = 9;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Sil";
            this.btnDelete.Hint = "   ";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "Çap Et";
            this.btnPrint.Hint = "   ";
            this.btnPrint.Id = 4;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnPosPrinter
            // 
            this.btnPosPrinter.Caption = "Çap Et";
            this.btnPosPrinter.Hint = "  ";
            this.btnPosPrinter.Id = 7;
            this.btnPosPrinter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPosPrinter.ImageOptions.Image")));
            this.btnPosPrinter.ImageOptions.ImageUri.Uri = "PrintDialog;Size16x16;GrayScaled";
            this.btnPosPrinter.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.P));
            this.btnPosPrinter.Name = "btnPosPrinter";
            this.btnPosPrinter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPosPrinter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPosPrinter_ItemClick);
            // 
            // btnShow
            // 
            this.btnShow.Caption = "Bax";
            this.btnShow.Hint = "   ";
            this.btnShow.Id = 5;
            this.btnShow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.ImageOptions.Image")));
            this.btnShow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShow.ImageOptions.LargeImage")));
            this.btnShow.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.btnShow.Name = "btnShow";
            this.btnShow.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnShow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShow_ItemClick);
            // 
            // btnApplyDocument
            // 
            this.btnApplyDocument.Caption = "İcra Et";
            this.btnApplyDocument.Hint = "  ";
            this.btnApplyDocument.Id = 8;
            this.btnApplyDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyDocument.ImageOptions.Image")));
            this.btnApplyDocument.ImageOptions.ImageUri.Uri = "Apply;Size32x32;GrayScaled";
            this.btnApplyDocument.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L));
            this.btnApplyDocument.Name = "btnApplyDocument";
            this.btnApplyDocument.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnApplyDocument.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnApplyDocument.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnApplyDocument_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(689, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 460);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(689, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(689, 40);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "doc_check.png");
            this.imageCollection.Images.SetKeyName(1, "doc_filter.png");
            this.imageCollection.Images.SetKeyName(2, "docAdd.png");
            this.imageCollection.Images.SetKeyName(3, "docEdit.png");
            this.imageCollection.Images.SetKeyName(4, "docPrint.png");
            this.imageCollection.Images.SetKeyName(5, "docRemove.png");
            this.imageCollection.Images.SetKeyName(6, "docSearch.png");
            this.imageCollection.Images.SetKeyName(7, "group.png");
            this.imageCollection.Images.SetKeyName(8, "groupAdd.png");
            this.imageCollection.Images.SetKeyName(9, "groupEdit.png");
            this.imageCollection.Images.SetKeyName(10, "groupRemove.png");
            this.imageCollection.Images.SetKeyName(11, "search.png");
            this.imageCollection.Images.SetKeyName(12, "warehouse.png");
            // 
            // MHMManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MHMManager";
            this.Size = new System.Drawing.Size(689, 460);
            this.Load += new System.EventHandler(this.MHMManager_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MHMManager_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnPosPrinter;
        private DevExpress.XtraBars.BarButtonItem btnShow;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection;
        public DevExpress.XtraBars.BarManager barManager;
        protected DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnApplyDocument;
    }
}
