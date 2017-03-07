namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.boxOrderNum = new System.Windows.Forms.TextBox();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCopyX = new System.Windows.Forms.Button();
            this.boxCopyTimes = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxAddress = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetRates = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnNewBox = new System.Windows.Forms.Button();
            this.btnDeleteLast = new System.Windows.Forms.Button();
            this.shippingBindSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindSource)).BeginInit();
            this.SuspendLayout();
            // 
            // boxOrderNum
            // 
            this.boxOrderNum.Location = new System.Drawing.Point(149, 33);
            this.boxOrderNum.Name = "boxOrderNum";
            this.boxOrderNum.Size = new System.Drawing.Size(120, 20);
            this.boxOrderNum.TabIndex = 0;
            this.boxOrderNum.TextChanged += new System.EventHandler(this.boxOrderNum_TextChanged);
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(12, 33);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(109, 20);
            this.lblOrderNum.TabIndex = 1;
            this.lblOrderNum.Text = "Order Number";
            this.lblOrderNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 230);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(15, 442);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(90, 23);
            this.btnCopy.TabIndex = 15;
            this.btnCopy.Text = "Copy Last Box";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCopyX
            // 
            this.btnCopyX.Enabled = false;
            this.btnCopyX.Location = new System.Drawing.Point(117, 442);
            this.btnCopyX.Name = "btnCopyX";
            this.btnCopyX.Size = new System.Drawing.Size(130, 23);
            this.btnCopyX.TabIndex = 16;
            this.btnCopyX.Text = "Copy Last Box X Times";
            this.btnCopyX.UseVisualStyleBackColor = true;
            this.btnCopyX.Click += new System.EventHandler(this.btnCopyX_Click);
            // 
            // boxCopyTimes
            // 
            this.boxCopyTimes.Location = new System.Drawing.Point(253, 443);
            this.boxCopyTimes.Name = "boxCopyTimes";
            this.boxCopyTimes.Size = new System.Drawing.Size(34, 20);
            this.boxCopyTimes.TabIndex = 17;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(561, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(617, 330);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Package Dimensions";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Shipping Rates";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Shipping Address";
            // 
            // boxAddress
            // 
            this.boxAddress.AcceptsReturn = true;
            this.boxAddress.AcceptsTab = true;
            this.boxAddress.Enabled = false;
            this.boxAddress.Location = new System.Drawing.Point(149, 66);
            this.boxAddress.Multiline = true;
            this.boxAddress.Name = "boxAddress";
            this.boxAddress.ReadOnly = true;
            this.boxAddress.Size = new System.Drawing.Size(253, 84);
            this.boxAddress.TabIndex = 22;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(948, 459);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 38);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "Confirm Shipment";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(561, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetRates
            // 
            this.btnGetRates.Enabled = false;
            this.btnGetRates.Location = new System.Drawing.Point(368, 459);
            this.btnGetRates.Name = "btnGetRates";
            this.btnGetRates.Size = new System.Drawing.Size(120, 38);
            this.btnGetRates.TabIndex = 26;
            this.btnGetRates.Text = "Get Rates";
            this.btnGetRates.UseVisualStyleBackColor = true;
            this.btnGetRates.Click += new System.EventHandler(this.btnGetRates_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // viewHistoryToolStripMenuItem
            // 
            this.viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.viewHistoryToolStripMenuItem.Text = "View History";
            this.viewHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewHistoryToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1190, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // btnNewBox
            // 
            this.btnNewBox.Enabled = false;
            this.btnNewBox.Location = new System.Drawing.Point(15, 474);
            this.btnNewBox.Name = "btnNewBox";
            this.btnNewBox.Size = new System.Drawing.Size(90, 23);
            this.btnNewBox.TabIndex = 29;
            this.btnNewBox.Text = "New Box";
            this.btnNewBox.UseVisualStyleBackColor = true;
            this.btnNewBox.Click += new System.EventHandler(this.btnNewBox_Click);
            // 
            // btnDeleteLast
            // 
            this.btnDeleteLast.Enabled = false;
            this.btnDeleteLast.Location = new System.Drawing.Point(117, 474);
            this.btnDeleteLast.Name = "btnDeleteLast";
            this.btnDeleteLast.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteLast.TabIndex = 30;
            this.btnDeleteLast.Text = "Delete Last Box";
            this.btnDeleteLast.UseVisualStyleBackColor = true;
            this.btnDeleteLast.Click += new System.EventHandler(this.btnDeleteLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 595);
            this.Controls.Add(this.btnDeleteLast);
            this.Controls.Add(this.btnNewBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGetRates);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.boxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.boxCopyTimes);
            this.Controls.Add(this.btnCopyX);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.boxOrderNum);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Amazon Seller Fulfillment";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxOrderNum;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCopyX;
        private System.Windows.Forms.TextBox boxCopyTimes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxAddress;
        public System.Windows.Forms.Button btnConfirm;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnGetRates;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnNewBox;
        private System.Windows.Forms.Button btnDeleteLast;
    }
}

