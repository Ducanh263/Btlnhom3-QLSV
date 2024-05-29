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
    public partial class formThongtinsinhvien : Form
    {
        private string msv;
        public formThongtinsinhvien(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }

        private void formThongtinsinhvien_Load(object sender, EventArgs e)
        {
            LoadThongtinsinhvien();
        }

        private void LoadThongtinsinhvien()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@msv",
                Value = msv
            });
            var r = new Database().Select("selectthongtinsinhvien '" + msv + "'");
            txtMsv.Text = msv;
            txtHovaten.Text = r["hoten"].ToString();
            txtNgaysinh.Text = r["ngaysinh"].ToString();
            txtLop.Text = r["TenLop"].ToString();
            txtKhoa.Text = r["TenKhoa"].ToString();
            
            if (int.Parse(r["gioitinh"].ToString()) == 1)
            {
                txtGioitinh.Text = "Nam";
            }
            else
            {
                txtGioitinh.Text = "Nữ";
            }
            txtEmail.Text = r["email"].ToString();
            txtDienthoai.Text = r["dienthoai"].ToString();
            txtChuyennganh.Text = r["Tennganh"].ToString();
            txtBacdaotao.Text = r["Hedaotao"].ToString();
           

        }
    }
}
