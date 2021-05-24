using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using MHM.Accountancy.Business;
using MHM.Accountancy.Business.DataCenter;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Identity;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;





namespace MHM.Accountancy.Win
{
    public partial class MainForm : RibbonForm, IContainer
    {

        Dictionary<string, XtraForm> managerForms = new Dictionary<string, XtraForm>();
        Font font;
        Color color;
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            this.font = Business.Properties.Settings.Default.AppFont;
            this.color = Business.Properties.Settings.Default.AppColor;

            //CurrentUser = new User() { Id = 1, UserName = "kamran" };
            //CurrentUser.SetPassword("123");
            //CurrentUser.CurrentConnection = new System.Data.SqlClient.SqlConnection(Settings.Default.AccountancyConnectionString);
            this.CurrentUser = Program.CurrentUser;


            //this.buttonEdit.ButtonClick += delegate (object sender, ButtonPressedEventArgs e)
            //{
            //    if (string.IsNullOrWhiteSpace(buttonEdit.Text))
            //        return;

            //    MHMMessage.ShowInformationMessageBox(buttonEdit.Text);
            //    buttonEdit.Text = null;
            //};


            FillNavBar();

            popupMenuManagers.ItemLinks.Add(btnReloadCurrent);
            popupMenuManagers.ItemLinks.Add(btnShowNewWindow);
            popupMenuManagers.ItemLinks.Add(btnCloseManager); 
        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        void ChangeLanguage(string language)
        {
            CultureInfo cultureInfo = Program.GetCustomCultureInfo(language);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            this.ChangeRecursion(this, cultureInfo);
        }

        void ChangeRecursion(Control current, CultureInfo cultureInfo)
        {
            foreach (Control control in (ArrangedElementCollection)current.Controls)
            {
                new System.ComponentModel.ComponentResourceManager(typeof(MainForm)).ApplyResources(control, control.Name, cultureInfo);
                if (control.Controls.Count > 0)
                    this.ChangeRecursion(control, cultureInfo);
            }
        }

        #region Menu
        private void FillNavBar()
        {
            navBarControl.Controls.Clear();
            navBarControl.OptionsNavPane.ShowExpandButton = false;
            navBarControl.OptionsNavPane.ShowHeaderText = false;
            navBarControl.Font = this.font;

            CurrentUser.FillMenuByUser(dataSetMain);

            foreach (var main in dataSetMain.spMenuPermitted.Where(m => m.ParentId == 0).OrderBy(m => m.OrderNumber))
            {

                var navBarGroup = new NavBarGroup()
                {
                    Hint = main.Caption,
                    Caption = main.Caption,
                    GroupClientHeight = 80,
                    GroupStyle = NavBarGroupStyle.ControlContainer,
                    Name = string.Format("navGroup-{0}", main.Id),
                    Tag = main.Id
                    //SmallImage = (mlogo != (Image)null) ? mlogo : Resources.defaultmenu,
                    //LargeImage = mlogo;
                };

                navBarControl.Groups.Add(navBarGroup);

                navBarGroup.ControlContainer = new NavBarGroupControlContainer()
                {
                    Name = string.Format("navContainer-{0}", main.Id),
                    Size = new Size(253, 435),
                    TabIndex = 0,
                    Font = this.font
                };

                AddMenuChilds(navBarGroup, main.Id);
            }
        }
        void AddMenuChilds(NavBarGroup group, int groupId)
        {
            var childs = new TreeList()
            {
                Name = "childs-" + groupId,
                Dock = DockStyle.Fill,
                ParentFieldName = "ParentId",
                KeyFieldName = "Id",
                Cursor = Cursors.Hand
            };

            childs.MouseClick += treeMenu_MouseDoubleClick;

            childs.OptionsView.FocusRectStyle = DrawFocusRectStyle.RowFullFocus;
            childs.OptionsView.ShowColumns = false;
            childs.OptionsView.ShowAutoFilterRow = true;
            childs.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            childs.OptionsFilter.ExpandNodesOnFiltering = true;
            childs.OptionsFilter.FilterMode = FilterMode.Extended;
            childs.Appearance.Row.Font = this.font;



            childs.BeginUpdate();
            var colCaption = new TreeListColumn()
            {
                Caption = "Caption",
                FieldName = "Caption",
                MinWidth = 100,
                Visible = true
            };

            colCaption.OptionsColumn.AllowEdit = false;
            colCaption.OptionsColumn.AllowMove = false;
            colCaption.OptionsColumn.AllowSize = false;
            colCaption.OptionsColumn.AllowSort = false;
            colCaption.OptionsColumn.AllowMoveToCustomizationForm = false;
            colCaption.AppearanceCell.Font = this.font;

            childs.Columns.Add(colCaption);

            childs.DataSource = new BindingSource(dataSetMain, "spMenuPermitted")
            {
                Filter = "GroupId=" + groupId,
                Sort = "OrderNumber ASC"
            };

            childs.BestFitColumns();
            childs.EndUpdate();
            childs.Update();

            group.ControlContainer.Controls.Add(childs);
        }
        private void treeMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var tree = sender as TreeList;
            var info = tree.CalcHitInfo(tree.PointToClient(Control.MousePosition));
            var current = info.Node != null ? tree.GetDataRow(info.Node.Id) as DataSetMain.spMenuPermittedRow : null;
            if (current != null && (!info.Node.HasChildren || (!current.IsTypePathNull() && "user,group".IndexOf(current.TypePath) != -1)))
            {
                //var current = tree.GetDataRow(info.Node.Id) as DataSetMain.spMenuPermittedRow;
                switch (current.IsTypePathNull() ? "" : current.TypePath)
                {
                    case "user":
                        using (var user = new UserPermissionForm(current.Id - 20100))
                        {

                            user.Text = $"* {current.Caption}";
                            if (user.ShowDialog() == DialogResult.OK)
                                PrintSuccess(current.Caption);

                        }
                        return;
                    case "group":
                        PrintSuccess(current.Caption);
                        return;
                    default:
                        break;
                }
                OpenMenu(current);
            }
        }
        private void OpenMenu(DataSetMain.spMenuPermittedRow current)
        {
            InvokeAction(delegate
            {
                if (current == null || current.IsTypePathNull())
                    return;

                var xtp = (XtraTabPage)null;

                if (this.NewTab(current, ref xtp))
                {
                    var values = new List<object> { this, current.Id };

                    if (!current.IsParametersNull() && !string.IsNullOrWhiteSpace(current.Parameters))
                    {
                        var @params = current.Parameters.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Where(v => v.IndexOf(":") != -1).Select(item => item.Split(new[] { ':' }))
                        .Select(v => new { type = v[0], value = v[1] });

                        foreach (var item in @params)
                        {
                            switch (item.type)
                            {
                                case "string":
                                    values.Add(item.value);
                                    break;
                                case "int":
                                    values.Add(int.Parse(item.value.Replace(" ", "")));
                                    break;
                                case "decimal":
                                    values.Add(Convert.ToDecimal(item.value));
                                    break;
                                case "bool":
                                    values.Add(Convert.ToBoolean(item.value));
                                    break;
                                case "object":
                                default:
                                    {
                                        values.Add((object)item.value);
                                        break;
                                    }
                            }
                        }
                    }
                    try
                    {
                        Type manager = this.GetType().Assembly.GetType("MHM.Accountancy.Win." + current.TypePath);
                        if (typeof(XtraUserControl).IsAssignableFrom(manager))
                        {
                            var xtraUserControl = (XtraUserControl)Activator.CreateInstance(manager, BindingFlags.NonPublic | BindingFlags.Instance, null, values.ToArray(), Thread.CurrentThread.CurrentCulture);
                            xtraUserControl.Dock = DockStyle.Fill;
                            xtp.Controls.Add(xtraUserControl);
                        }
                        else if (typeof(XtraForm).IsAssignableFrom(manager))
                            using (var form = (XtraForm)Activator.CreateInstance(manager, BindingFlags.NonPublic | BindingFlags.Instance, null, values.ToArray(), Thread.CurrentThread.CurrentCulture))
                            {
                                form.ShowInTaskbar = true;
                                form.StartPosition = FormStartPosition.CenterScreen;
                                form.ShowDialog();
                            }
                        else
                            throw new Exception(string.Format("***'{0}' - Qəbul edilməyən qoşma tipi.", current.TypePath));
                    }
                    catch (Exception ex)
                    {
                        if (xtp != null)
                            xtp.Dispose();
                        throw;
                    }
                }
            });
        }
        #endregion

        #region Tab Container
        private void tabContainer_CloseButtonClick(object sender, EventArgs e)
        {
            using (XtraTabPage tpage = ((e as ClosePageButtonEventArgs).Page as XtraTabPage))
            {
                if (tpage != null)
                {
                    int index = tabContainer.SelectedTabPageIndex;

                    foreach (System.ComponentModel.Component component in (ArrangedElementCollection)tpage.Controls)
                        component.Dispose();
                    tpage.Dispose();

                    index--;
                    if (tabContainer.TabPages.Count() > 0 && index >= 0 && tabContainer.TabPages.Count() > index)
                        tabContainer.SelectedTabPageIndex = index;
                }
            }
        }
        
        bool cancelTabPagePopup = true;

        public User CurrentUser { get; private set; }

        public string[] LisancedModules => throw new NotImplementedException();

        private void tabContainer_MouseDown(object sender, MouseEventArgs e)
        {
            var info = tabContainer.CalcHitInfo(e.Location);
            if (info.HitTest == XtraTabHitTest.PageHeader && e.Button == MouseButtons.Right)
                cancelTabPagePopup = false;
            else
                cancelTabPagePopup = true;
        }

        private void popupMenuManagers_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cancelTabPagePopup = cancelTabPagePopup || tabContainer.TabPages.Count < 1 || tabContainer.SelectedTabPageIndex < 0;
            e.Cancel = cancelTabPagePopup;
        }

        private void popupMenuManagers_CloseUp(object sender, EventArgs e)
        {
            cancelTabPagePopup = true;
        }

        private void btnShowNewWindow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var page = tabContainer.SelectedTabPage;
            var form = new ManagerForm(page);
            form.Name = "managerFrm" + page.Name;
            form.FormClosed += delegate
            {
                managerForms.Remove(form.Name);
                form.Dispose();
                tabContainer.SelectedTabPage = page;
            };

            managerForms.Add(form.Name, form);
            form.Show(this);
        }

        private void btnReloadCurrent_ItemClick(object sender, ItemClickEventArgs e)
        {
            var page = tabContainer.SelectedTabPage;
            if (page.Controls.Count > 0)
                (page.Controls[0] as IManager).Loading();
        }

        private void btnCloseManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            tabContainer_CloseButtonClick(null, new ClosePageButtonEventArgs(null, tabContainer.SelectedTabPage));
        }

        private bool NewTab(DataSetMain.spMenuPermittedRow current, ref XtraTabPage xtp)
        {
            foreach (XtraTabPage xTpage in (CollectionBase)this.tabContainer.TabPages)
            {
                if (xTpage.Tag != null && xTpage.Tag.ToString().Equals(current.Id.ToString()))
                {
                    this.tabContainer.SelectedTabPage = xTpage;
                    if (managerForms.ContainsKey("managerFrm" + xTpage.Name))
                    {
                        var form = managerForms["managerFrm" + xTpage.Name];
                        form.SendToBack();
                        form.BringToFront();

                        if (form.WindowState == FormWindowState.Minimized)
                            form.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        if (this.tabContainer.SelectedTabPage.Controls.Count > 0 && this.tabContainer.SelectedTabPage.Controls[0] is IManager)
                        {
                            foreach (var item in managerForms)
                                item.Value.WindowState = FormWindowState.Minimized;
                            (this.tabContainer.SelectedTabPage.Controls[0] as IManager).Loading();
                        }
                    }
                    return false;
                }
            }

            var xtraTabPage = new XtraTabPage()
            {
                Name = string.Format("xtraTabPage{0}", current.Id),
                Size = new Size(793, 522),
                Text = current.Caption,
                Tag = current.Id,
                //-------------
                AutoScroll = true,
                MinimumSize = new Size(200, 200)
            };

            //Image mlogo = menu.GetMenuImage(current.Id, currentUser);
            //if (mlogo != null)
            //{
            //    xtraTabPage.Image = new Bitmap(mlogo, new Size(12, 12));
            //}

            this.tabContainer.TabPages.Add(xtraTabPage);

            this.tabContainer.SelectedTabPage = xtraTabPage;
            xtp = xtraTabPage;

            foreach (var item in managerForms)
                item.Value.WindowState = FormWindowState.Minimized;

            return true;
        }
        #endregion

        #region Notify

        public void PrintError(Exception exception, bool clear = false)
        {
            MHMMessage.ShowErrorMessageBox("Əməliyyat xətası!\nƏtraflı məlumat üçün məlumat blokuna baxın.");
            if (clear)
                notifyConsole.Clear();

            notifyConsole.AppendText(">>>  " + exception.Message, Color.Red);
            dockPanelErrors.Show();
        }

        public void PrintSuccess(string message, bool clear = true)
        {
            if (clear)
                notifyConsole.Clear();
            notifyConsole.AppendText(">>>  " + message + Environment.NewLine, Color.Green);
            dockPanelErrors.Show();
        }

        #endregion

        #region IContainer Implementation
        public void InvokeAction(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                PrintError(ex);
            }
        }

        public void RefreshNewCount(IManager manager)
        {
            throw new NotImplementedException();
        }

        public int SendError(Exception exception, IManager manager)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new AboutForm())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        private void btnGoToMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var gotoMenu = new GoToMenuForm() { TopMost = true })
                if (gotoMenu.ShowDialog(this) == DialogResult.OK)
                {
                    var current = dataSetMain.spMenuPermitted
                        .FirstOrDefault(m => !m.IsCodeNull()
                        && m.Code.PadLeft(6, '0').Equals(gotoMenu.btnGoToMenu.Text.PadLeft(6, '0')));

                    if (current != null)
                    {
                        OpenMenu(current);
                    }
                }
        }

        private void btnRestart_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void btnMenuCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            //using (var frm = new MenuCodesForm())
            //{
            //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {

            //    }
            //}
        }

        private void iHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new HelpForm())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        private void tabContainer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.Delete)
            {
                btnCloseManager.PerformClick();
            }
        }
    }
}