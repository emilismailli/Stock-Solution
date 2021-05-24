using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using MHM.Accountancy.Business;

namespace MHM.Accountancy.Business.Infrastructure.Utils
{
    static public class UIUtil
    {
        static long val;

        public static bool IsNull(this PictureEdit pictureEdit)
        {
            return pictureEdit.Image == null;
        }

        public static bool IsNull(this LookUpEditBase lookUpEdit)
        {
            return lookUpEdit.EditValue == DBNull.Value || lookUpEdit.EditValue == null || !long.TryParse((lookUpEdit.EditValue ?? "").ToString(), out val);
        }

        public static bool Validate(this LookUpEditBase lookUpEdit, string errorText)
        {
            lookUpEdit.ErrorText = lookUpEdit.IsNull() ? errorText : null;
            return string.IsNullOrEmpty(lookUpEdit.ErrorText);
        }

        public static bool IsNull(this SearchLookUpEdit lookUpEdit)
        {
            return lookUpEdit.EditValue == DBNull.Value || lookUpEdit.EditValue == null || !long.TryParse((lookUpEdit.EditValue ?? "").ToString(), out val);
        }

        public static bool Validate(this SearchLookUpEdit lookUpEdit, string errorText)
        {
            lookUpEdit.ErrorText = lookUpEdit.IsNull() ? errorText : null;
            return string.IsNullOrEmpty(lookUpEdit.ErrorText);
        }

        public static bool IsNull(this GridLookUpEdit lookUpEdit)
        {
            return lookUpEdit.EditValue == DBNull.Value || lookUpEdit.EditValue == null || !long.TryParse((lookUpEdit.EditValue ?? "").ToString(), out val);
        }

        public static bool Validate(this GridLookUpEdit lookUpEdit, string errorText)
        {
            lookUpEdit.ErrorText = lookUpEdit.IsNull() ? errorText : null;
            return string.IsNullOrEmpty(lookUpEdit.ErrorText);
        }

        public static bool Validate(this LookUpEdit lookUpEdit)
        {
            return UIUtil.Validate((LookUpEditBase)lookUpEdit, "Boş buraxıla bilməz!");
        }

        public static bool Validate(this TreeListLookUpEdit treeListLookUpEdit)
        {
            return UIUtil.Validate((LookUpEditBase)treeListLookUpEdit, "Boş buraxıla bilməz!");
        }

        public static bool Validate(this SearchLookUpEdit searchLookUpEdit)
        {
            return UIUtil.Validate(searchLookUpEdit, "Boş buraxıla bilməz!");
        }

        public static bool Validate(this GridLookUpEdit gridLookUpEdit)
        {
            return UIUtil.Validate(gridLookUpEdit, "Boş buraxıla bilməz!");
        }

        public static bool IsNull(this TextEdit textEdit)
        {
            bool flag;
            switch (textEdit.Properties.Mask.MaskType)
            {
                case DevExpress.XtraEditors.Mask.MaskType.RegEx:
                    flag = Regex.IsMatch(textEdit.Text, textEdit.Properties.Mask.EditMask);
                    break;
                case DevExpress.XtraEditors.Mask.MaskType.DateTime:
                case DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret:
                case DevExpress.XtraEditors.Mask.MaskType.Numeric:
                case DevExpress.XtraEditors.Mask.MaskType.Regular:
                case DevExpress.XtraEditors.Mask.MaskType.Simple:
                case DevExpress.XtraEditors.Mask.MaskType.Custom:
                case DevExpress.XtraEditors.Mask.MaskType.None:
                default:
                    flag = textEdit.EditValue != DBNull.Value;
                    if (flag)
                    {
                        textEdit.Text = textEdit.Text.Trim();
                        flag = textEdit.Text.Length != 0;
                    }
                    break;
            }



            return !flag;
        }

        public static bool Validate(this TextEdit textEdit, string errorText)
        {
            switch (textEdit.Properties.Mask.MaskType)
            {
                case DevExpress.XtraEditors.Mask.MaskType.RegEx:
                    textEdit.ErrorText = !Regex.IsMatch(textEdit.Text, textEdit.Properties.Mask.EditMask) ? errorText : (string)null;
                    break;
                case DevExpress.XtraEditors.Mask.MaskType.DateTime:
                case DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret:
                case DevExpress.XtraEditors.Mask.MaskType.Numeric:
                case DevExpress.XtraEditors.Mask.MaskType.Regular:
                case DevExpress.XtraEditors.Mask.MaskType.Simple:
                case DevExpress.XtraEditors.Mask.MaskType.Custom:
                case DevExpress.XtraEditors.Mask.MaskType.None:
                default:
                    textEdit.ErrorText = textEdit.IsNull() ? errorText : (string)null;
                    break;
            }
            return string.IsNullOrEmpty(textEdit.ErrorText);
        }

        public static bool Validate(this TextEdit textEdit)
        {
            return UIUtil.Validate(textEdit, "Boş buraxıla bilməz!");
        }

        public static bool Validate(this ComboBoxEdit comboBoxEdit, string errorText)
        {
            comboBoxEdit.ErrorText = comboBoxEdit.EditValue == null | string.IsNullOrWhiteSpace(comboBoxEdit.Text) ? errorText : (string)null;
            return string.IsNullOrWhiteSpace(comboBoxEdit.ErrorText);
        }

        public static bool IsNull(this ButtonEdit buttonEdit)
        {
            return string.IsNullOrWhiteSpace(buttonEdit.Text);
        }

        public static bool Validate(this ButtonEdit buttonEdit, string errorText)
        {
            buttonEdit.ErrorText = buttonEdit.Tag == DBNull.Value || string.IsNullOrWhiteSpace(buttonEdit.Text) ? errorText : (string)null;
            return string.IsNullOrWhiteSpace(buttonEdit.ErrorText);
        }

        public static bool Validate(this ButtonEdit buttonEdit, string errorText, bool required)
        {
            buttonEdit.ErrorText = buttonEdit.IsNull() ? errorText : (string)null;
            return string.IsNullOrEmpty(buttonEdit.ErrorText);
        }
        public static bool Validate(this ComboBoxEdit comboBoxEdit)
        {
            return UIUtil.Validate(comboBoxEdit, "Boş buraxıla bilməz!");
        }

        public static bool Validate(this ButtonEdit buttonEdit)
        {
            return UIUtil.Validate(buttonEdit, "Boş buraxıla bilməz!");
        }

        public static bool Validate(this ButtonEdit buttonEdit, bool required)
        {
            return UIUtil.Validate(buttonEdit, "Boş buraxıla bilməz!", required);
        }

        public static bool IsNull(this DateEdit dateEdit)
        {
            return dateEdit.EditValue == DBNull.Value || dateEdit.EditValue == null;
        }

        public static bool Validate(this DateEdit dateEdit, string errorText)
        {
            dateEdit.ErrorText = dateEdit.IsNull() ? errorText : (string)null;
            return string.IsNullOrEmpty(dateEdit.ErrorText);
        }

        public static bool Validate(this DateEdit dateEdit)
        {
            return UIUtil.Validate(dateEdit, "Boş buraxıla bilməz!");
        }

        public static bool IsGreaterThanZero(this SpinEdit spinEdit)
        {
            return !(string.IsNullOrWhiteSpace(((TextEdit)spinEdit).Text)
                   || spinEdit.Value <= new Decimal(0, 0, 0, false, (byte)2));
        }

        public static bool IsGreaterThanZero(this CalcEdit spinEdit)
        {
            return !(string.IsNullOrWhiteSpace(((TextEdit)spinEdit).Text)
                   || spinEdit.Value <= new Decimal(0, 0, 0, false, (byte)2));
        }

        public static bool ValidaGreaterThanZero(this SpinEdit spinEdit)
        {
            spinEdit.ErrorText = UIUtil.Validate((TextEdit)spinEdit) && spinEdit.IsGreaterThanZero() ? (string)null : "Sıfırdan böyük rəqəm daxil edilməlidir.";
            return string.IsNullOrWhiteSpace(spinEdit.ErrorText);
        }
        public static bool ValidateGreaterThanZero(this CalcEdit calcEdit)
        {
            calcEdit.ErrorText = UIUtil.Validate((TextEdit)calcEdit) && calcEdit.IsGreaterThanZero() ? (string)null : "Sıfırdan böyük rəqəm daxil edilməlidir.";
            return string.IsNullOrWhiteSpace(calcEdit.ErrorText);
        }
         }
    }
