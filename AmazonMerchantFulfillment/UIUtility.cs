using System.Text;
using System.Windows.Forms;

namespace AmazonMerchantFulfillment
{
    internal class UIUtility
    {
        internal static void SetBusy(Form frm, string msg, Label lbl = null)
        {
            frm.Refresh();
            if (lbl != null) lbl.Text = msg;

            if (string.IsNullOrEmpty(msg))
            {
                frm.UseWaitCursor = false;
                frm.Cursor = Cursors.Default;
            }
            else
            {
                frm.UseWaitCursor = true;
                frm.Cursor = Cursors.WaitCursor;
            }
            frm.Refresh();
        }

        internal static string GetFilterString(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (c == '*' || c == '%' || c == '[' || c == ']') sb.Append("[").Append(c).Append("]");
                else if (c == '\'') sb.Append("''");
                else sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
