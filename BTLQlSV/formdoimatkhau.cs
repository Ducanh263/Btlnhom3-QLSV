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
    public partial class formdoimatkhau : Form
    {
        private string loaitaikhoan;
        private string taikhoan;
        private string matkhau;
        public formdoimatkhau(string taikhoan,string loaitk,string mk)
        {
            InitializeComponent();
            this.loaitaikhoan = loaitk;
            this.taikhoan = taikhoan;
            this.matkhau = mk;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtmatkhau.Text == matkhau)
            {
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    Key = "@loaitaikhoan",
                    Value = loaitaikhoan
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@taikhoan",
                    Value = taikhoan
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@matkhau",
                    Value = txtmatkhaumoi.Text
                });
                var rs = new Database().Execute("doimatkhau", lst);
                if(rs == 1)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại");
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hiện tại");
            }
        }
    }
}
