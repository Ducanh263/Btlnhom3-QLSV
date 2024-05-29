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
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk;
        public string matkhau;
        public bool log = false;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            log = true;
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(cbbLoaiTK.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtTaiKhoan.Text)){
                MessageBox.Show("Vui lòng nhập tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            tendangnhap = txtTaiKhoan.Text;
            matkhau = txtMatKhau.Text;
            switch (cbbLoaiTK.Text)
            {
                case "Quản trị viên":
                        loaitk = "admin";
                        break;
                case "Giảng viên":
                        loaitk = "gv";
                        break;
                case "Sinh viên":
                        loaitk = "sv";
                        break;
            }
            
            List <CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    Key = "@loaitaikhoan",
                    Value = loaitk
                },
                new CustomParameter()
                {
                    Key = "@taikhoan",
                    Value = txtTaiKhoan.Text
                },
                new CustomParameter()
                {
                    Key = "@matkhau",
                    Value = txtMatKhau.Text
                }
            };
            var rs = new Database().SelectData("dangnhap", lst);
            if(rs.Rows.Count > 0) {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
            }
        }
    }
}
