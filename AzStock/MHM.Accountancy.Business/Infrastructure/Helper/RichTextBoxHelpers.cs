using System;
using System.Drawing;
using System.Windows.Forms;

namespace MHM.Accountancy.Business.Infrastructure
{
    public static partial class Helper
    {
        public static void AppendText(this RichTextBox richTextBox, string text, Color color)
        {
            richTextBox.SelectionStart = richTextBox.TextLength;
            richTextBox.SelectionLength = 0;

            richTextBox.SelectionColor = color;
            richTextBox.AppendText(text);
            richTextBox.SelectionColor = richTextBox.ForeColor;
            richTextBox.AppendText(Environment.NewLine);
        }
    }
}
