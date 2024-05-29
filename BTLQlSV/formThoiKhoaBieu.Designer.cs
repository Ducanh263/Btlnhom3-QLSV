namespace BTLQlSV
{
    partial class formThoiKhoaBieu
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
            this.dataGridViewTimetable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTimetable
            // 
            this.dataGridViewTimetable.AllowUserToAddRows = false;
            this.dataGridViewTimetable.AllowUserToDeleteRows = false;
            this.dataGridViewTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTimetable.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTimetable.Name = "dataGridViewTimetable";
            this.dataGridViewTimetable.ReadOnly = true;
            this.dataGridViewTimetable.RowHeadersWidth = 51;
            this.dataGridViewTimetable.RowTemplate.Height = 24;
            this.dataGridViewTimetable.Size = new System.Drawing.Size(1106, 591);
            this.dataGridViewTimetable.TabIndex = 0;
            // 
            // formThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 591);
            this.Controls.Add(this.dataGridViewTimetable);
            this.Name = "formThoiKhoaBieu";
            this.Text = "formThoiKhoaBieu";
            this.Load += new System.EventHandler(this.formThoiKhoaBieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTimetable;
    }
}