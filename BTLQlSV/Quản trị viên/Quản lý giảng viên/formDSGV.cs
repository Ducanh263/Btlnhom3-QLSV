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

namespace BTLQlSV
{
    public partial class formDSGV : Form
    {
        public formDSGV()
        {
            InitializeComponent();
        }

        private string tukhoa = "";
        private void LoadDSGV()
        {
            //Load danh sách sinh viên khi được load
            List<CustomParameter> Istpara = new List<CustomParameter>();
            Istpara.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData("SelectAllGiangVien", Istpara);

            //Đặt tên cột
            dgvDSGV.Columns["magiaovien"].HeaderText = "Mã giảng viên";
            dgvDSGV.Columns["hoten"].HeaderText = "Họ tên";
            dgvDSGV.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvDSGV.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvDSGV.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvDSGV.Columns["email"].HeaderText = "Email";
            dgvDSGV.Columns["dienthoai"].HeaderText = "Điện thoại";
        }

        private void formDSGV_Load(object sender, EventArgs e)
        {
            LoadDSGV();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Khi double click vaò sinh viên trên thanh datagirdview sẽ hiện ra form cập nhập thông tin giảng
            //Để cập nhập được sinh viên ta cần lấy mã sinh viên
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show("Mã giảng viên: " + dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString());
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                //cần truyền mã giảng viên này vào formSinhVien 
                new formGV(mgv).ShowDialog();
                //Sau khi formSinhViên đóng => Cập nhập lại dgv
                LoadDSGV();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new formGV(null).ShowDialog();
            LoadDSGV();
        }
    }
}
