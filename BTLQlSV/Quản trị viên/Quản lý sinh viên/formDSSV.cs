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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BTLQlSV
{
    public partial class formDSSV : Form
    {
        private string malop;
        public formDSSV(string malop)
        {
            InitializeComponent();
            this.malop = malop;
        }

        private string tukhoa = "";
        private void formDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();//Gọi hàm load dssv
        }

        private void LoadDSSV()
        {
            //Load danh sách sinh viên khi được load
            List<CustomParameter> Istpara = new List<CustomParameter>();
            Istpara.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = tukhoa
            });
            Istpara.Add(new CustomParameter()
            {
                Key = "@malop",
                Value = malop
            });
            dgvDSSV.DataSource = new Database().SelectData("SelectAllSinhVien",Istpara);

            //Đặt tên cột
            dgvDSSV.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dgvDSSV.Columns["hoten"].HeaderText = "Họ tên";
            dgvDSSV.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvDSSV.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvDSSV.Columns["quequan"].HeaderText = "Quê quán";
            dgvDSSV.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvDSSV.Columns["email"].HeaderText = "Email";
            dgvDSSV.Columns["dienthoai"].HeaderText = "Điện thoại";
        }
        private void dgvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Khi double click vaò sinh viên trên thanh datagirdview sẽ hiện ra form cập nhập thông tin sinh viên
            //Để cập nhập được sinh viên ta cần lấy mã sinh viên
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show("Mã sinh viên: " + dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());
                var msv = dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                //cần truyền mã sinh viên này vào formSinhVien 
                new formSinhVien(msv,null).ShowDialog();
                //Sau khi formSinhViên đóng => Cập nhập lại dgv
                LoadDSSV();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new formSinhVien(null,malop).ShowDialog();
            LoadDSSV();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSSV(); 
        }

        private string msvcanxoa;
        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                msvcanxoa = dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<CustomParameter> Istpara = new List<CustomParameter>();
            Istpara.Add(new CustomParameter()
            {
                Key = "@masinhvien",
                Value = msvcanxoa
            });
            var rs = new Database().Execute("DeleteSinhVien", Istpara);

            if(rs == 1)
            {
                MessageBox.Show("Xóa sinh viên thành công");
                LoadDSSV();
            }
            if(rs == -1)
            {
                MessageBox.Show("Sinh viên còn học không thể xóa");
            }
        }
       
    }
}





