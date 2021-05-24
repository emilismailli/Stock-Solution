using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MHM.Accountancy.Business.Infrastructure.Extensions
{
    public static partial class Extension
    {
        public static byte[] StringToByteArray(this string hex)
        {
            var numberChars = hex.Length;
            var Bytes = new byte[numberChars / 2];
            for (var i = 0; i < numberChars; i += 2)
            {
                Bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return Bytes;
        }
        public static string ToHexString(this byte[] Bytes)
        {
            return Bytes != null ? BitConverter.ToString(Bytes).ToLowerInvariant().Replace("-", "") : null;
        }

        public static T GetBindingRow<T>(this BindingSource bindingSource, int rowIndex)
            where T : DataRow
        {
            if (bindingSource.Count > rowIndex)
            {
                bindingSource.Position = rowIndex;
                return (T)(bindingSource.Current as DataRowView).Row;
            }
            else
                return null;
        }
        public static T GetBindingRow<T>(this BindingSource bindingSource)
            where T : DataRow
        {
            if (bindingSource != null && bindingSource.Current != null && bindingSource.Count > 0)
            {
                return (T)(bindingSource.Current  as DataRowView).Row;
            }
            else
                return null;
        }

        public static T GetSelectedRow<T>(this LookUpEdit lookUp)
             where T : DataRow
        {
            return (T)(lookUp.GetSelectedDataRow() as DataRowView).Row;
        }

        public static void ApplyBindingSourcesDataSet(this Control control, DataSet dataSet)
        {
            control.EnumerateComponents().Where(c => typeof(BindingSource).IsInstanceOfType(c)).Select(Item => Item as BindingSource)
                .ToList<BindingSource>().ForEach(bSource =>
                {
                    bSource.DataSource = dataSet;
                });
        }

        public static IEnumerable<Component> EnumerateComponents(this Control control)
        {
            return from field in control.GetType().GetFields(
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                   where typeof(Component).IsAssignableFrom(field.FieldType)
                   let component = (Component)field.GetValue(control)
                   where component != null
                   where component.GetType().GetProperty("Name") == null
                   select component;
        }

        public static byte[] GetBytes(this Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
            return null;
        }

        public static Image ToImage(this byte[] imageBuffer)
        {
            if (imageBuffer == null) return null;

            using (MemoryStream ms = new MemoryStream(imageBuffer))
            {
                return Image.FromStream(ms);
            }
            return null;
        }

        public static byte[] GetBytes(this string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }

        public static int? GetIntValue(this TextEdit textEdit)
        {
            return textEdit.Tag != null ? (int?)Convert.ToInt32(textEdit.Tag) : (int?)null;
        }

        public static int? GetIntValue(this GridLookUpEdit gridLookUpEdit)
        {
            return gridLookUpEdit.EditValue != null ? (int?)Convert.ToInt32(gridLookUpEdit.EditValue) : (int?)null;
        }

        public static int? GetIntValue(this LookUpEditBase lookUpEdit)
        {
            return (lookUpEdit.EditValue == null || lookUpEdit.EditValue == DBNull.Value) ? (int?)null : (int?)Convert.ToInt32(lookUpEdit.EditValue);
        }

        public static int? GetIntValue(this TreeListLookUpEdit treeListLookUpEdit)
        {
            return treeListLookUpEdit.EditValue != null ? (int?)Convert.ToInt32(treeListLookUpEdit.EditValue) : (int?)null;
        }

        public static int? GetIntValue(this SearchLookUpEdit searchLookUpEdit)
        {
            return searchLookUpEdit.EditValue != null ? (int?)Convert.ToInt32(searchLookUpEdit.EditValue) : (int?)null;
        }

        public static long? GetLongValue(this GridLookUpEdit gridLookUpEdit)
        {
            return gridLookUpEdit.EditValue != null ? (long?)Convert.ToInt64(gridLookUpEdit.EditValue) : (long?)null;
        }

        public static long? GetLongValue(this LookUpEditBase lookUpEdit)
        {
            return lookUpEdit.EditValue != null ? (long?)Convert.ToInt64(lookUpEdit.EditValue) : (long?)null;
        }
        public static long? GetLongValue(this TreeListLookUpEdit treeListLookUpEdit)
        {
            return treeListLookUpEdit.EditValue != null ? (long?)Convert.ToInt64(treeListLookUpEdit.EditValue) : (long?)null;
        }

        public static long? GetLongValue(this SearchLookUpEdit searchLookUpEdit)
        {
            return searchLookUpEdit.EditValue != null ? (long?)Convert.ToInt64(searchLookUpEdit.EditValue) : (long?)null;
        }

        public static void SetSplitterPercent(this SplitContainerControl splitContainerControl, double percent, int minSize = 100)
        {
            splitContainerControl.Panel2.MinSize = splitContainerControl.Panel1.MinSize = minSize;
            splitContainerControl.SplitterPosition = (int)((!splitContainerControl.Horizontal ? splitContainerControl.Height : splitContainerControl.Width) * (percent / 100.0));
        }

        public static void TableApplyFilter<T>(this T table, string filter = "", bool distinct = false, params string[] columnNames)
            where T : DataTable
        {
            var tab = table.GetTableByFilter(filter, distinct, columnNames);
            table.Clear();
            table.Merge(tab);
        }

        public static DataTable GetTableByFilter<T>(this T table, string filter = "", bool distinct = false, params string[] columnNames)
            where T : DataTable
        {
            using (var d = new DataView(table)
            {
                RowFilter = filter
            })
            {
                var tab = columnNames.Length > 0
                                ? d.ToTable(table.TableName, distinct, columnNames)
                                : d.ToTable(table.TableName, distinct);
                return tab;
            }
        }

        public static string DateForDVFilter(this DateTime date)
        {
            return "#" + string.Format("{0:MM/dd/yyyy}", date) + "#";
        }
        public static string DateTimeForDVFilter(this DateTime date)
        {
            return "#" + string.Format("{0:MM/dd/yyyy HH:mm:ss}", date) + "#";
        }
    }

}
