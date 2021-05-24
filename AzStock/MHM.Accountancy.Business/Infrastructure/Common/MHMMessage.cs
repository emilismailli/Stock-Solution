using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace MHM.Accountancy.Business.Infrastructure
{
    public static class MHMMessage
    {
        #region MessageBoxs
        public static void ShowErrorMessageBox(string ErrorMessage)
        {
            XtraMessageBox.Show(ErrorMessage, "Səhv", 0, MessageBoxIcon.Error);
        }

        public static void ShowErrorMessageBox(string messageFormat, params object[] args)
        {
            ShowErrorMessageBox(string.Format(messageFormat, args));
        }

        public static void ShowWarningMessageBox(string message)
        {
            XtraMessageBox.Show(message, "Diqqət", 0, MessageBoxIcon.Warning);
        }

        public static void ShowWarningMessageBox(string ErrorMessage, params object[] args)
        {
            ShowWarningMessageBox(string.Format(ErrorMessage, args));
        }

        public static DialogResult ShowQuestionMessageBox(string QuestionMsg)
        {
            return XtraMessageBox.Show(QuestionMsg, "Təsdiqlə", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult ShowInformationMessageBox(string InformationMsg)
        {
            return XtraMessageBox.Show(InformationMsg, "Məlumat", 0, MessageBoxIcon.Information);
        }
        public static void ShowInformationMessageBox(string ErrorMessage, params object[] args)
        {
            ShowInformationMessageBox(string.Format(ErrorMessage, args));
        }

        #endregion
    }
}
