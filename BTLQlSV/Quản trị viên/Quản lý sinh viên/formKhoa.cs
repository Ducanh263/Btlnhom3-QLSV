using BTLQLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQlSV.Quản_trị_viên.Quản_lý_sinh_viên
{
    public partial class formKhoa : Form
    {
        private string makhoa;
        public formKhoa(string makhoa)
        {
            InitializeComponent();
            this.makhoa = makhoa;  
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void formKhoa_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(msv);
            if (string.IsNullOrEmpty(makhoa))
            {
                this.Text = "Thêm mới khoa";
            }
           
        }
    }
}
