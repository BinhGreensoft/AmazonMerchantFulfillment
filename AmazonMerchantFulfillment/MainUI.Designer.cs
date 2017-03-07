namespace AmazonMerchantFulfillment
{
    partial class MainUI
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtShippngAddress = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dgPackage = new System.Windows.Forms.DataGridView();
            this.getRates = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCopyTimes = new System.Windows.Forms.TextBox();
            this.copyCurrentBoxs = new System.Windows.Forms.Button();
            this.copyCurrentBox = new System.Windows.Forms.Button();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.dgRates = new System.Windows.Forms.DataGridView();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRates)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHistory,
            this.tsmiSettings});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1148, 24);
            this.msMain.TabIndex = 0;
            // 
            // tsmiHistory
            // 
            this.tsmiHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewHistory,
            this.toolStripSeparator1,
            this.tsmiQuit});
            this.tsmiHistory.Name = "tsmiHistory";
            this.tsmiHistory.Size = new System.Drawing.Size(57, 20);
            this.tsmiHistory.Text = "&History";
            // 
            // tsmiViewHistory
            // 
            this.tsmiViewHistory.Name = "tsmiViewHistory";
            this.tsmiViewHistory.Size = new System.Drawing.Size(140, 22);
            this.tsmiViewHistory.Text = "&View history";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmiQuit.Size = new System.Drawing.Size(140, 22);
            this.tsmiQuit.Text = "&Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(61, 20);
            this.tsmiSettings.Text = "&Settings";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // ssMain
            // 
            this.ssMain.AutoSize = false;
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMain});
            this.ssMain.Location = new System.Drawing.Point(0, 527);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1148, 24);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsMain
            // 
            this.tsMain.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsMain.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1133, 19);
            this.tsMain.Spring = true;
            this.tsMain.Text = "Ready";
            this.tsMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer1.Size = new System.Drawing.Size(1148, 503);
            this.splitContainer1.SplitterDistance = 483;
            this.splitContainer1.SplitterWidth = 30;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtShippngAddress);
            this.splitContainer2.Panel1.Controls.Add(this.txtOrderNumber);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(483, 503);
            this.splitContainer2.SplitterDistance = 163;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // txtShippngAddress
            // 
            this.txtShippngAddress.Location = new System.Drawing.Point(156, 54);
            this.txtShippngAddress.MaxLength = 19;
            this.txtShippngAddress.Multiline = true;
            this.txtShippngAddress.Name = "txtShippngAddress";
            this.txtShippngAddress.ReadOnly = true;
            this.txtShippngAddress.Size = new System.Drawing.Size(311, 106);
            this.txtShippngAddress.TabIndex = 3;
            this.txtShippngAddress.TabStop = false;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(156, 22);
            this.txtOrderNumber.MaxLength = 19;
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(311, 20);
            this.txtOrderNumber.TabIndex = 2;
            this.txtOrderNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtOrderNumber_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shipping Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number:";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(483, 338);
            this.splitContainer3.SplitterDistance = 40;
            this.splitContainer3.SplitterWidth = 2;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Package Dimensions";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dgPackage);
            this.splitContainer4.Panel1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.getRates);
            this.splitContainer4.Panel2.Controls.Add(this.label4);
            this.splitContainer4.Panel2.Controls.Add(this.txtCopyTimes);
            this.splitContainer4.Panel2.Controls.Add(this.copyCurrentBoxs);
            this.splitContainer4.Panel2.Controls.Add(this.copyCurrentBox);
            this.splitContainer4.Size = new System.Drawing.Size(483, 296);
            this.splitContainer4.SplitterDistance = 242;
            this.splitContainer4.TabIndex = 0;
            this.splitContainer4.TabStop = false;
            // 
            // dgPackage
            // 
            this.dgPackage.AllowUserToDeleteRows = false;
            this.dgPackage.ColumnHeadersHeight = 22;
            this.dgPackage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPackage.Location = new System.Drawing.Point(12, 0);
            this.dgPackage.MultiSelect = false;
            this.dgPackage.Name = "dgPackage";
            this.dgPackage.RowHeadersVisible = false;
            this.dgPackage.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPackage.Size = new System.Drawing.Size(471, 242);
            this.dgPackage.TabIndex = 0;
            // 
            // getRates
            // 
            this.getRates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.getRates.Enabled = false;
            this.getRates.Location = new System.Drawing.Point(370, 2);
            this.getRates.Name = "getRates";
            this.getRates.Size = new System.Drawing.Size(110, 45);
            this.getRates.TabIndex = 4;
            this.getRates.Text = "Get Rates";
            this.getRates.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "times";
            // 
            // txtCopyTimes
            // 
            this.txtCopyTimes.Enabled = false;
            this.txtCopyTimes.Location = new System.Drawing.Point(237, 5);
            this.txtCopyTimes.Name = "txtCopyTimes";
            this.txtCopyTimes.Size = new System.Drawing.Size(34, 20);
            this.txtCopyTimes.TabIndex = 2;
            this.txtCopyTimes.Text = "1";
            // 
            // copyCurrentBoxs
            // 
            this.copyCurrentBoxs.Enabled = false;
            this.copyCurrentBoxs.Location = new System.Drawing.Point(122, 3);
            this.copyCurrentBoxs.Name = "copyCurrentBoxs";
            this.copyCurrentBoxs.Size = new System.Drawing.Size(113, 23);
            this.copyCurrentBoxs.TabIndex = 1;
            this.copyCurrentBoxs.Text = "Copy Current Box X";
            this.copyCurrentBoxs.UseVisualStyleBackColor = true;
            // 
            // copyCurrentBox
            // 
            this.copyCurrentBox.Enabled = false;
            this.copyCurrentBox.Location = new System.Drawing.Point(12, 3);
            this.copyCurrentBox.Name = "copyCurrentBox";
            this.copyCurrentBox.Size = new System.Drawing.Size(104, 23);
            this.copyCurrentBox.TabIndex = 0;
            this.copyCurrentBox.Text = "Copy Current Box";
            this.copyCurrentBox.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(635, 503);
            this.splitContainer5.SplitterDistance = 55;
            this.splitContainer5.SplitterWidth = 2;
            this.splitContainer5.TabIndex = 0;
            this.splitContainer5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Shipping Rates";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.dgRates);
            this.splitContainer6.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.confirm);
            this.splitContainer6.Panel2.Controls.Add(this.cancel);
            this.splitContainer6.Size = new System.Drawing.Size(635, 446);
            this.splitContainer6.SplitterDistance = 394;
            this.splitContainer6.SplitterWidth = 2;
            this.splitContainer6.TabIndex = 0;
            this.splitContainer6.TabStop = false;
            // 
            // dgRates
            // 
            this.dgRates.AllowUserToAddRows = false;
            this.dgRates.AllowUserToDeleteRows = false;
            this.dgRates.ColumnHeadersHeight = 22;
            this.dgRates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRates.Location = new System.Drawing.Point(0, 0);
            this.dgRates.MultiSelect = false;
            this.dgRates.Name = "dgRates";
            this.dgRates.ReadOnly = true;
            this.dgRates.RowHeadersVisible = false;
            this.dgRates.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRates.Size = new System.Drawing.Size(623, 394);
            this.dgRates.TabIndex = 1;
            // 
            // confirm
            // 
            this.confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm.Location = new System.Drawing.Point(513, 3);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(110, 45);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "Confirm Shipment";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(3, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(110, 45);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 551);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazon Seller Fulfillment";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPackage)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtShippngAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dgPackage;
        private System.Windows.Forms.Button copyCurrentBox;
        private System.Windows.Forms.TextBox txtCopyTimes;
        private System.Windows.Forms.Button copyCurrentBoxs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getRates;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.DataGridView dgRates;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button confirm;
    }
}