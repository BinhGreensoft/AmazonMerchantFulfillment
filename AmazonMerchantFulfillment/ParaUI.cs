using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmazonMerchantFulfillment.DataDefinition;
using AmazonMerchantFulfillment.Business;

namespace AmazonMerchantFulfillment
{
    public partial class ParaUI : Form
    {
        private Para mDsPata = null;
        private BindingSource mBdsPara = null;

        public ParaUI()
        {
            InitializeComponent();
        }

        private void ParaUI_Load(object sender, EventArgs e)
        {
            update.Enabled = InitData();
        }

        private bool InitData()
        {
            ParaBs bs = new Business.ParaBs();
            if (!bs.GetData(ref mDsPata))
            {
                MessageBox.Show(bs.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            mBdsPara = new BindingSource(mDsPata, Para.TableName);
            dgPara.DataSource = mBdsPara;

            dgPara.Columns[Para.PK].Visible = false;
            dgPara.Columns[Para.ParaId].Visible = false;

            dgPara.Columns[Para.ParaName].HeaderText = "Parameter name";
            dgPara.Columns[Para.ParaName].ReadOnly = true;
            dgPara.Columns[Para.ParaName].DefaultCellStyle.BackColor = Color.LightGray;

            dgPara.Columns[Para.ParaValue].HeaderText = "Parameter value";
            dgPara.AutoResizeColumns();

            return true;
        }

        private bool SaveData()
        {
            dgPara.CommitEdit(DataGridViewDataErrorContexts.Commit);
            mBdsPara.EndEdit();

            UIUtility.SetBusy(this, "Updating data...");
            ParaBs bs = new ParaBs();
            if (!bs.Update(mDsPata))
            {
                UIUtility.SetBusy(this, string.Empty);
                MessageBox.Show(bs.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            UIUtility.SetBusy(this, string.Empty);
            MessageBox.Show("Settings updated successfully!");

            return true;
        }

        private void update_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ParaUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mDsPata.HasChanges())
            {
                DialogResult res = MessageBox.Show("Do you want to save changes you made to Settings?", string.Empty, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (!SaveData()) e.Cancel = true;
                }
                else if (res == DialogResult.Cancel) e.Cancel = true;
            }

        }

        private void dgPara_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgPara.Columns[e.ColumnIndex].Name != Para.ParaValue || e.FormattedValue == null) return;

            string v = e.FormattedValue.ToString();
            decimal dec = 0;
            if (!decimal.TryParse(v, out dec))
            {
                MessageBox.Show("Data type is invalid.\nPlease enter a number.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel  = true;
            }
        }
    }
}
