namespace AmazonMerchantFulfillment
{
    partial class ParaUI
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
            this.dgPara = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPara)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPara
            // 
            this.dgPara.AllowUserToAddRows = false;
            this.dgPara.AllowUserToDeleteRows = false;
            this.dgPara.ColumnHeadersHeight = 22;
            this.dgPara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgPara.Location = new System.Drawing.Point(12, 12);
            this.dgPara.Name = "dgPara";
            this.dgPara.RowHeadersVisible = false;
            this.dgPara.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPara.Size = new System.Drawing.Size(373, 269);
            this.dgPara.TabIndex = 0;
            this.dgPara.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgPara_CellValidating);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(229, 287);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 1;
            this.update.Text = "&Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(310, 287);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 2;
            this.close.Text = "Cl&ose";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ParaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 322);
            this.Controls.Add(this.close);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dgPara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ParaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParaUI_FormClosing);
            this.Load += new System.EventHandler(this.ParaUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPara;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button close;
    }
}