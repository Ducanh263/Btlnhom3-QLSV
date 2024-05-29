namespace BTLQlSV
{
    partial class formDSSVLCanCham
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
            this.btnKetthuclop = new System.Windows.Forms.Button();
            this.dgvDSSVLCanCham = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdiemC = new System.Windows.Forms.TextBox();
            this.txtdiemB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiemA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSVLCanCham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKetthuclop
            // 
            this.btnKetthuclop.Location = new System.Drawing.Point(25, 40);
            this.btnKetthuclop.Name = "btnKetthuclop";
            this.btnKetthuclop.Size = new System.Drawing.Size(128, 33);
            this.btnKetthuclop.TabIndex = 3;
            this.btnKetthuclop.Text = "Kết thúc lớp";
            this.btnKetthuclop.UseVisualStyleBackColor = true;
            this.btnKetthuclop.Click += new System.EventHandler(this.btnKetthuclop_Click);
            // 
            // dgvDSSVLCanCham
            // 
            this.dgvDSSVLCanCham.AllowUserToAddRows = false;
            this.dgvDSSVLCanCham.AllowUserToDeleteRows = false;
            this.dgvDSSVLCanCham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSVLCanCham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSVLCanCham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSSVLCanCham.Location = new System.Drawing.Point(0, 106);
            this.dgvDSSVLCanCham.Name = "dgvDSSVLCanCham";
            this.dgvDSSVLCanCham.ReadOnly = true;
            this.dgvDSSVLCanCham.RowHeadersWidth = 51;
            this.dgvDSSVLCanCham.RowTemplate.Height = 24;
            this.dgvDSSVLCanCham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSVLCanCham.Size = new System.Drawing.Size(1051, 477);
            this.dgvDSSVLCanCham.TabIndex = 4;
            this.dgvDSSVLCanCham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSVLCanCham_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Điểm C";
            // 
            // txtdiemC
            // 
            this.txtdiemC.Location = new System.Drawing.Point(492, 51);
            this.txtdiemC.Name = "txtdiemC";
            this.txtdiemC.Size = new System.Drawing.Size(100, 22);
            this.txtdiemC.TabIndex = 6;
            // 
            // txtdiemB
            // 
            this.txtdiemB.Location = new System.Drawing.Point(626, 51);
            this.txtdiemB.Name = "txtdiemB";
            this.txtdiemB.Size = new System.Drawing.Size(100, 22);
            this.txtdiemB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Điểm B";
            // 
            // txtdiemA
            // 
            this.txtdiemA.Location = new System.Drawing.Point(756, 51);
            this.txtdiemA.Name = "txtdiemA";
            this.txtdiemA.Size = new System.Drawing.Size(100, 22);
            this.txtdiemA.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điểm A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhập điểm";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(892, 51);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // formDSSVLCanCham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 583);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdiemA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdiemB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdiemC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDSSVLCanCham);
            this.Controls.Add(this.btnKetthuclop);
            this.Name = "formDSSVLCanCham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDSSVLCanCham";
            this.Load += new System.EventHandler(this.formDSSVLCanCham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSVLCanCham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKetthuclop;
        private System.Windows.Forms.DataGridView dgvDSSVLCanCham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdiemC;
        private System.Windows.Forms.TextBox txtdiemB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiemA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
    }
}