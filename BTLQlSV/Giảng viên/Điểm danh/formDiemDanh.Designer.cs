namespace BTLQlSV
{
    partial class formDiemDanh
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
            this.dgvDSSVLCDD = new System.Windows.Forms.DataGridView();
            this.cbbNgayHT = new System.Windows.Forms.ComboBox();
            this.cbbDiemDanh = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSVLCDD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSSVLCDD
            // 
            this.dgvDSSVLCDD.AllowUserToAddRows = false;
            this.dgvDSSVLCDD.AllowUserToDeleteRows = false;
            this.dgvDSSVLCDD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSVLCDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSVLCDD.Location = new System.Drawing.Point(1, 106);
            this.dgvDSSVLCDD.Name = "dgvDSSVLCDD";
            this.dgvDSSVLCDD.ReadOnly = true;
            this.dgvDSSVLCDD.RowHeadersWidth = 51;
            this.dgvDSSVLCDD.RowTemplate.Height = 24;
            this.dgvDSSVLCDD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSVLCDD.Size = new System.Drawing.Size(986, 469);
            this.dgvDSSVLCDD.TabIndex = 0;
            this.dgvDSSVLCDD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSVLCDD_CellDoubleClick);
            // 
            // cbbNgayHT
            // 
            this.cbbNgayHT.FormattingEnabled = true;
            this.cbbNgayHT.Location = new System.Drawing.Point(593, 41);
            this.cbbNgayHT.Name = "cbbNgayHT";
            this.cbbNgayHT.Size = new System.Drawing.Size(198, 24);
            this.cbbNgayHT.TabIndex = 1;
            // 
            // cbbDiemDanh
            // 
            this.cbbDiemDanh.FormattingEnabled = true;
            this.cbbDiemDanh.Location = new System.Drawing.Point(356, 42);
            this.cbbDiemDanh.Name = "cbbDiemDanh";
            this.cbbDiemDanh.Size = new System.Drawing.Size(134, 24);
            this.cbbDiemDanh.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(496, 42);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(797, 41);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(113, 23);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Lưu danh sách";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // formDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 573);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbDiemDanh);
            this.Controls.Add(this.cbbNgayHT);
            this.Controls.Add(this.dgvDSSVLCDD);
            this.Name = "formDiemDanh";
            this.Text = "formDiemDanh";
            this.Load += new System.EventHandler(this.formDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSVLCDD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSVLCDD;
        private System.Windows.Forms.ComboBox cbbNgayHT;
        private System.Windows.Forms.ComboBox cbbDiemDanh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDongY;
    }
}