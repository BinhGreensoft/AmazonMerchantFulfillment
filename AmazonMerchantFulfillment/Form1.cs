using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MarketplaceWebServiceOrders;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string orderNum;
        public DataTable dimTable { get; private set; }
        private BindingSource pkgBindSource;
        public DataTable shippingRatesTable { get; private set; }
        private BindingSource shippingBindSource;
        //private formHistory history;


        public Form1()
        {
            InitializeComponent();

            dimTable = new DataTable();
            pkgBindSource = new BindingSource();

            dimTable.Columns.Add("Package #");
            dimTable.Columns.Add(new DataColumn("Weight"));
            dimTable.Columns.Add(new DataColumn("Length"));
            dimTable.Columns.Add(new DataColumn("Width"));
            dimTable.Columns.Add(new DataColumn("Height"));
            dimTable.Columns[0].AutoIncrement = true;
            dimTable.Columns[0].AutoIncrementSeed = 1;
            pkgBindSource.AllowNew = false;
            pkgBindSource.DataSource = dimTable;
            dataGridView1.DataSource = pkgBindSource;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.Columns["Package #"].ReadOnly = true;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            shippingRatesTable = new DataTable();
            shippingBindSource = new BindingSource();


            shippingRatesTable.Columns.Add("Carrier");
            shippingRatesTable.Columns.Add("Service");
            shippingRatesTable.Columns.Add("Ship Date");
            shippingRatesTable.Columns.Add("Earliest Delivery");
            shippingRatesTable.Columns.Add("Latest Delivery");
            shippingRatesTable.Columns.Add("Rate");
            shippingBindSource.DataSource = shippingRatesTable;
            dataGridView2.DataSource = shippingBindSource;
            dataGridView2.RowHeadersVisible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boxOrderNum_TextChanged(object sender, EventArgs e)
        {
            orderNum = boxOrderNum.Text;
            // Should change this to enable when valid order number is entered in form of ddd-ddddddd-ddddddd
            boxAddress.Text = "First Name Last Name" + "\r\n" +
                "Street Address 1" + "\r\n" +
                "Street Address 2" + "\r\n" +
                "City, State ZIP";

            if (boxOrderNum.Text.Length > 0)
            {
                btnCopy.Enabled = true;
                btnCopyX.Enabled = true;
                btnNewBox.Enabled = true;
                btnDeleteLast.Enabled = true;
                btnGetRates.Enabled = true;
                if (dimTable.Rows.Count == 0)
                { dimTable.Rows.Add(new object[] { 1, "", "", "", "" }); }
            }
            else
            {
                btnCopy.Enabled = false;
                btnCopyX.Enabled = false;
                btnNewBox.Enabled = false;
                btnDeleteLast.Enabled = false;
                btnGetRates.Enabled = false;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
        
        private void pkgBindSource_Changed(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewBox_Click(object sender, EventArgs e)
        {
            dimTable.Rows.Add(new string[] {(dimTable.Rows.Count + 1).ToString(), "", "", "", ""});
            btnGetRates.Enabled = true;
            btnCopy.Enabled = true;
            btnCopyX.Enabled = true;
            btnDeleteLast.Enabled = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnGetRates_Click(object sender, EventArgs e)
        {
            if (dimTable.Rows.Count > 0)
            {
                shippingRatesTable.Rows.Add(new string[] { "UPS", "Ground", "01/28/2017", "01/29/2017", "01/30/2017", "7.89" });
                shippingRatesTable.Rows.Add(new string[] { "UPS", "Next Day Air", "01/28/2017", "01/29/2017", "01/29/2017", "24.36" });
                shippingRatesTable.Rows.Add(new string[] { "USPS", "Priority Flat Rate", "01/28/2017", "01/29/2017", "01/30/2017", "5.65" });
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            shippingRatesTable.Clear();
            dimTable.Clear();
            boxOrderNum.Clear();
            boxAddress.Text = "";
        }

        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            if (dimTable.Rows.Count > 0)
            {
                dimTable.Rows[dimTable.Rows.Count - 1].Delete();
            }
            if (dimTable.Rows.Count == 0)
            {
                btnGetRates.Enabled = false;
                btnCopy.Enabled = false;
                btnCopyX.Enabled = false;
                btnDeleteLast.Enabled = false;
            }
        }

        private void btnCopyX_Click(object sender, EventArgs e)
        {
            int copyTimes = 0;

            if (dimTable.Rows.Count > 0)
            {
                if (int.TryParse(boxCopyTimes.Text, out copyTimes))
                {
                    DataRow copiedRow = dimTable.Rows[dimTable.Rows.Count - 1];
                    Object[] rowData = copiedRow.ItemArray;
                    foreach (int number in Enumerable.Range(1, copyTimes))
                    {
                        rowData[0] = (int)rowData[0] + 1;
                        dimTable.Rows.Add(rowData);
                    }
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (dimTable.Rows.Count > 0)
            {
                DataRow copiedRow = dimTable.Rows[dimTable.Rows.Count - 1];
                Object[] rowData = copiedRow.ItemArray;
                rowData[0] = (int)rowData[0] + 1;
                dimTable.Rows.Add(rowData);
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //history = new formHistory();
            //history.Show();
        }
    }
}
