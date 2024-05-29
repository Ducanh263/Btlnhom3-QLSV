namespace BTLQlSV
{
    partial class formXemLichThiGv
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
            this.dgvLichThigv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThigv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichThigv
            // 
            this.dgvLichThigv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichThigv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichThigv.Location = new System.Drawing.Point(0, 2);
            this.dgvLichThigv.Name = "dgvLichThigv";
            this.dgvLichThigv.RowHeadersWidth = 51;
            this.dgvLichThigv.RowTemplate.Height = 24;
            this.dgvLichThigv.Size = new System.Drawing.Size(953, 508);
            this.dgvLichThigv.TabIndex = 0;
            // 
            // formXemLichThiGv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 509);
            this.Controls.Add(this.dgvLichThigv);
            this.Name = "formXemLichThiGv";
            this.Text = "formXemLichThiGv";
            this.Load += new System.EventHandler(this.formXemLichThiGv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThigv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichThigv;
    }
}