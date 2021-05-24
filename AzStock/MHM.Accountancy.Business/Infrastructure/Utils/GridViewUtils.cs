using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MHM.Accountancy.Business.Infrastructure.Identity;
using System;
using System.IO;

namespace MHM.Accountancy.Business.Infrastructure.Utils
{
    public static partial class Util
    {
        public static void ApplyDefaultSettings(this GridView gridView, bool readOnly = false, bool showGroupPanel = false, bool columnAutoWidth = true)
        {
            gridView.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            gridView.OptionsBehavior.ReadOnly = readOnly;
            gridView.OptionsCustomization.AllowColumnMoving = false;
            gridView.OptionsCustomization.AllowRowSizing = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsView.ShowGroupPanel = showGroupPanel;
            gridView.OptionsView.ColumnAutoWidth = columnAutoWidth;
            gridView.GridControl.UseEmbeddedNavigator = true;

            gridView.GridControl.EmbeddedNavigator.TextStringFormat = "Sətir {0}/{1}";

            gridView.GridControl.EmbeddedNavigator.Buttons.First.Hint = "İlk qeyd";
            gridView.GridControl.EmbeddedNavigator.Buttons.PrevPage.Hint = "Öncəki səhifə";
            gridView.GridControl.EmbeddedNavigator.Buttons.Prev.Hint = "Öncəki";
            gridView.GridControl.EmbeddedNavigator.Buttons.Next.Hint = "Növbəti";
            gridView.GridControl.EmbeddedNavigator.Buttons.NextPage.Hint = "Növbəti səhifə";
            gridView.GridControl.EmbeddedNavigator.Buttons.Last.Hint = "Son qeyd";
            gridView.GridControl.EmbeddedNavigator.Buttons.Append.Hint = "Əlavə et";
            gridView.GridControl.EmbeddedNavigator.Buttons.Remove.Hint = "Sil";
            gridView.GridControl.EmbeddedNavigator.Buttons.Edit.Hint = "Redaktə et";
            gridView.GridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            gridView.GridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;

            foreach (GridColumn gridColumn in gridView.Columns)
            {
                if (gridColumn.ColumnEdit != null && gridColumn.ColumnEdit is RepositoryItemLookUpEdit)
                    (gridColumn.ColumnEdit as RepositoryItemLookUpEdit).NullText = string.Format("[{0}]", (object)gridColumn.Caption);
            }
            gridView.InvalidRowException += (sender, e) =>
            {
                e.ExceptionMode = ExceptionMode.NoAction;
                gridView.SetColumnError(gridView.Columns[0], e.Exception.Message);
            };
        }

        public static void LoadData(this GridView gridView, Action loadAction)
        {
            int focusedRowHandle = gridView.FocusedRowHandle;
            try
            {
                loadAction.Invoke();
            }
            finally
            {
                gridView.BestFitColumns();
                if (focusedRowHandle < gridView.RowCount)
                    gridView.FocusedRowHandle = focusedRowHandle;
            }
        }

        public static void LoadLayoutFromXml(this GridView gridView, string layoutFile, string layoutFolder = @"resource\Layouts")
        {
            if (string.IsNullOrWhiteSpace(layoutFile) || !layoutFile.EndsWith(".xml"))
                throw new ArgumentException("layoutFile* parameter exception.");

            if (string.IsNullOrWhiteSpace(layoutFolder))
                throw new ArgumentException("layoutFolder* parameter exception.");

            gridView.RestoreLayoutFromXml(Path.Combine(layoutFolder, layoutFile), DevExpress.Utils.OptionsLayoutBase.FullLayout);
        }

        public static void SaveLayoutToXml(this GridView gridView, string layoutFile, string layoutFolder = @"resource\Layouts")
        {
            if (string.IsNullOrWhiteSpace(layoutFile) || !layoutFile.EndsWith(".xml"))
                throw new ArgumentException("layoutFile* parameter exception.");

            if (string.IsNullOrWhiteSpace(layoutFolder))
                throw new ArgumentException("layoutFolder* parameter exception.");

            gridView.SaveLayoutToXml(Path.Combine(layoutFolder, layoutFile), DevExpress.Utils.OptionsLayoutBase.FullLayout);
        }

        ////public static .IfnUserPermissionRow ApplyNavigatorPermission(this GridView gridView, ManagerPermission permission, bool inContainerPermission = true, bool andCondition = true, bool orCondition = false)
        ////{
        ////    gridView.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = gridView.GridControl.EmbeddedNavigator.Buttons.Edit.Enabled = gridView.GridControl.EmbeddedNavigator.Buttons.Remove.Enabled = false;
        ////    if (permission == null)
        ////    {
        ////        gridView.GridControl.EmbeddedNavigator.Buttons.Append.Visible = gridView.GridControl.EmbeddedNavigator.Buttons.Edit.Visible = gridView.GridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
        ////        return null;
        ////    }

        ////    gridView.GridControl.EmbeddedNavigator.Buttons.Append.Enabled = gridView.FocusedRowHandle >= 0 && (orCondition || (andCondition && (inContainerPermission ? (permission.ContainerInCreateAccess) : permission.CreateAccess)));
        ////    gridView.GridControl.EmbeddedNavigator.Buttons.Edit.Enabled = gridView.FocusedRowHandle >= 0 && (orCondition || (andCondition && (inContainerPermission ? permission.ContainerInUpdateAccess : permission.UpdateAccess)));
        ////    gridView.GridControl.EmbeddedNavigator.Buttons.Remove.Enabled = gridView.FocusedRowHandle >= 0 && (orCondition || (andCondition && (inContainerPermission ? permission.ContainerInDeleteAccess : permission.DeleteAccess)));

        ////    return null;
        ////}
    }
}
