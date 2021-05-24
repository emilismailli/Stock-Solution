using DevExpress.XtraEditors;
using System.Drawing;

namespace MHM.Accountancy.Business.Infrastructure.Interfaces
{
    public class RequiredStarLabel : LabelControl
    {
        public RequiredStarLabel()
            :base()
        {
            this.Text = "*";
            this.ForeColor = Color.Red;
        }
    }
}
