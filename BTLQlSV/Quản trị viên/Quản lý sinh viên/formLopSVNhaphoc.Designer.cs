namespace BTLQlSV.Quản_trị_viên.Quản_lý_sinh_viên
{
    partial class formLopSVNhaphoc
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
            this.dgvLopSVNhapHoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopSVNhapHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLopSVNhapHoc
            // 
            this.dgvLopSVNhapHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopSVNhapHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopSVNhapHoc.Location = new System.Drawing.Point(-2, 112);
            this.dgvLopSVNhapHoc.Name = "dgvLopSVNhapHoc";
            this.dgvLopSVNhapHoc.RowHeadersWidth = 51;
            this.dgvLopSVNhapHoc.RowTemplate.Height = 24;
            this.dgvLopSVNhapHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopSVNhapHoc.Size = new System.Drawing.Size(1161, 488);
            this.dgvLopSVNhapHoc.TabIndex = 0;
            this.dgvLopSVNhapHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopSVNhapHoc_CellDoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(382, 40);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(383, 22);
            this.txtTuKhoa.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(785, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1002, 40);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(71, 22);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Thêm";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(881, 40);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(115, 22);
            this.txtSoluong.TabIndex = 6;
            // 
            // formLopSVNhaphoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 601);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLopSVNhapHoc);
            this.Name = "formLopSVNhaphoc";
            this.Text = "formLopSVNhaphoc";
            this.Load += new System.EventHandler(this.formLopSVNhaphoc_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopSVNhapHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLopSVNhapHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSoluong;
    }
}