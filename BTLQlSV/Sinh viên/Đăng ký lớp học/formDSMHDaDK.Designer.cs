namespace BTLQlSV
{
    partial class formDSMHDaDK
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
            this.dgvMonDDK = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDangkymonhoc = new System.Windows.Forms.Button();
            this.btnHuyHocPhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDDK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonDDK
            // 
            this.dgvMonDDK.AllowUserToAddRows = false;
            this.dgvMonDDK.AllowUserToDeleteRows = false;
            this.dgvMonDDK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonDDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonDDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonDDK.Location = new System.Drawing.Point(-1, 101);
            this.dgvMonDDK.Name = "dgvMonDDK";
            this.dgvMonDDK.ReadOnly = true;
            this.dgvMonDDK.RowHeadersWidth = 51;
            this.dgvMonDDK.RowTemplate.Height = 24;
            this.dgvMonDDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonDDK.Size = new System.Drawing.Size(1134, 570);
            this.dgvMonDDK.TabIndex = 0;
            this.dgvMonDDK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonDDK_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ khóa";
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTukhoa.Location = new System.Drawing.Point(385, 43);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(421, 22);
            this.txtTukhoa.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(825, 42);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnDangkymonhoc
            // 
            this.btnDangkymonhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangkymonhoc.Location = new System.Drawing.Point(922, 43);
            this.btnDangkymonhoc.Name = "btnDangkymonhoc";
            this.btnDangkymonhoc.Size = new System.Drawing.Size(178, 23);
            this.btnDangkymonhoc.TabIndex = 5;
            this.btnDangkymonhoc.Text = "Đăng kí môn";
            this.btnDangkymonhoc.UseVisualStyleBackColor = true;
            this.btnDangkymonhoc.Click += new System.EventHandler(this.btnDangkymonhoc_Click);
            // 
            // btnHuyHocPhan
            // 
            this.btnHuyHocPhan.Location = new System.Drawing.Point(121, 43);
            this.btnHuyHocPhan.Name = "btnHuyHocPhan";
            this.btnHuyHocPhan.Size = new System.Drawing.Size(119, 23);
            this.btnHuyHocPhan.TabIndex = 6;
            this.btnHuyHocPhan.Text = "Hủy học phần";
            this.btnHuyHocPhan.UseVisualStyleBackColor = true;
            this.btnHuyHocPhan.Click += new System.EventHandler(this.btnHuyHocPhan_Click);
            // 
            // formDSMHDaDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 671);
            this.Controls.Add(this.btnHuyHocPhan);
            this.Controls.Add(this.btnDangkymonhoc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMonDDK);
            this.Name = "formDSMHDaDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đăng ký môn học";
            this.Load += new System.EventHandler(this.formDSMHDaDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonDDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDangkymonhoc;
        private System.Windows.Forms.Button btnHuyHocPhan;
    }
}