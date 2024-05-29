namespace BTLQlSV
{
    partial class formDSMHChuaDK
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
            this.dgvDSLHCDK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLHCDK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSLHCDK
            // 
            this.dgvDSLHCDK.AllowUserToAddRows = false;
            this.dgvDSLHCDK.AllowUserToDeleteRows = false;
            this.dgvDSLHCDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLHCDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLHCDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLHCDK.Location = new System.Drawing.Point(0, 0);
            this.dgvDSLHCDK.MultiSelect = false;
            this.dgvDSLHCDK.Name = "dgvDSLHCDK";
            this.dgvDSLHCDK.ReadOnly = true;
            this.dgvDSLHCDK.RowHeadersWidth = 51;
            this.dgvDSLHCDK.RowTemplate.Height = 24;
            this.dgvDSLHCDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLHCDK.Size = new System.Drawing.Size(1011, 557);
            this.dgvDSLHCDK.TabIndex = 0;
            this.dgvDSLHCDK.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLHCDK_CellDoubleClick);
            // 
            // formDSMHChuaDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 557);
            this.Controls.Add(this.dgvDSLHCDK);
            this.Name = "formDSMHChuaDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDSMHChuaDK";
            this.Load += new System.EventHandler(this.formDSMHChuaDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLHCDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSLHCDK;
    }
}