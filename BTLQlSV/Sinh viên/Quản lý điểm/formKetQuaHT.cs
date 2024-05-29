using BTLQLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQlSV
{
    public partial class formKetQuaHT : Form
    {
        private string msv;
        private string tukhoa = "";
        public formKetQuaHT(string msv)
        {
            InitializeComponent();
            this.msv = msv;

        }

        private void formKetQuaHT_Load(object sender, EventArgs e)
        {
           LoadKQHT();
        }
        
        private void LoadKQHT()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = tukhoa
            });
            lst.Add(new CustomParameter()
            {
                Key = "@masinhvien",
                Value = msv
            });
            dgvKQHT.DataSource = new Database().SelectData("tracuudiem", lst);
            dgvKQHT.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvKQHT.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvKQHT.Columns["lanhoc"].HeaderText = "Lần học";
            dgvKQHT.Columns["gvien"].HeaderText = "Giảng viên";
            dgvKQHT.Columns["diemc"].HeaderText = "Điểm C";
            dgvKQHT.Columns["diemb"].HeaderText = "Điểm B";
            dgvKQHT.Columns["diema"].HeaderText = "Điểm A";
            dgvKQHT.Columns["diemchu"].HeaderText = "Điểm chữ";
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadKQHT();
        }
    }
}
