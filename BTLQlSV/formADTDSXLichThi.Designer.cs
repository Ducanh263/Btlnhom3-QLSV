namespace BTLQlSV
{
    partial class formADTDSXLichThi
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
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.BtnTaoLT = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mabLichThi = new System.Windows.Forms.MaskedTextBox();
            this.cbbHinhThucThi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColors
            // 
            this.dgvColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvColors.Location = new System.Drawing.Point(0, 117);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.RowHeadersWidth = 51;
            this.dgvColors.RowTemplate.Height = 24;
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(1068, 486);
            this.dgvColors.TabIndex = 0;
            this.dgvColors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColors_CellDoubleClick);
            // 
            // BtnTaoLT
            // 
            this.BtnTaoLT.Location = new System.Drawing.Point(806, 48);
            this.BtnTaoLT.Name = "BtnTaoLT";
            this.BtnTaoLT.Size = new System.Drawing.Size(141, 30);
            this.BtnTaoLT.TabIndex = 1;
            this.BtnTaoLT.Text = "Tự động xếp lịch thi";
            this.BtnTaoLT.UseVisualStyleBackColor = true;
            this.BtnTaoLT.Click += new System.EventHandler(this.BtnTaoLT_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(485, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm lịch thi";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // mabLichThi
            // 
            this.mabLichThi.Location = new System.Drawing.Point(644, 52);
            this.mabLichThi.Mask = "00/00/0000";
            this.mabLichThi.Name = "mabLichThi";
            this.mabLichThi.Size = new System.Drawing.Size(156, 22);
            this.mabLichThi.TabIndex = 3;
            this.mabLichThi.ValidatingType = typeof(System.DateTime);
            // 
            // cbbHinhThucThi
            // 
            this.cbbHinhThucThi.FormattingEnabled = true;
            this.cbbHinhThucThi.Items.AddRange(new object[] {
            "Trắc nghiệm",
            "Tự luận",
            "Vấn đáp"});
            this.cbbHinhThucThi.Location = new System.Drawing.Point(295, 50);
            this.cbbHinhThucThi.Name = "cbbHinhThucThi";
            this.cbbHinhThucThi.Size = new System.Drawing.Size(164, 24);
            this.cbbHinhThucThi.TabIndex = 4;
            // 
            // formADTDSXLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 603);
            this.Controls.Add(this.cbbHinhThucThi);
            this.Controls.Add(this.mabLichThi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.BtnTaoLT);
            this.Controls.Add(this.dgvColors);
            this.Name = "formADTDSXLichThi";
            this.Text = "formADTDSXLichThi";
            this.Load += new System.EventHandler(this.formADTDSXLichThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.Button BtnTaoLT;
        private System.Windows.Forms.Button btnThem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox mabLichThi;
        private System.Windows.Forms.ComboBox cbbHinhThucThi;
    }
}