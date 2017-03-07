using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonMerchantFulfillment
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }


        //Check the format of order number
        private bool CheckOrderNumber()
        {
            string on = txtOrderNumber.Text.Trim();
            if (on == string.Empty) return true;

            Regex reg = new Regex(@"^\d{3}-\d{7}-\d{7}$");

            if (!reg.IsMatch(on))
            {
                MessageBox.Show("Invalid Order Number format.\nPlease double check the order number.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            txtOrderNumber.Text = on;
            return true;
        }

        private void txtOrderNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckOrderNumber()) e.Cancel = true;
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            ParaUI ui = new ParaUI();
            ui.Show(this);
        }
    }
}
