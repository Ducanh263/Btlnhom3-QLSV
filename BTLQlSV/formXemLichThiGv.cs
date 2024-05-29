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
    public partial class formXemLichThiGv : Form
    {
        private string loaitk;
        private string taikhoan;
        public formXemLichThiGv(string taikhoan,string loaitk)
        {
            InitializeComponent();
            this.loaitk = loaitk;
            this.taikhoan = taikhoan;
            
        }

        private void formXemLichThiGv_Load(object sender, EventArgs e)
        {
            if(loaitk.Equals("gv")) {
                List<CustomParameter> list = new List<CustomParameter>();
                list.Add(new CustomParameter()
                {
                    Key = "@magiangvien",
                    Value = taikhoan
                });
                dgvLichThigv.DataSource = new Database().SelectData("giangvienxemlichcoithi", list);
                dgvLichThigv.Columns["tenphongthi"].HeaderText = "Tên phòng thi";
                dgvLichThigv.Columns["cathi"].HeaderText = "Ca thi";
                dgvLichThigv.Columns["ngaythi"].HeaderText = "Ngay thi";
                dgvLichThigv.Columns["mamonhoc"].HeaderText = "Mã môn học";
            }
            else
            {
                List<CustomParameter> list = new List<CustomParameter>();
                list.Add(new CustomParameter()
                {
                    Key = "@masinhvien",
                    Value = taikhoan
                });
                dgvLichThigv.DataSource = new Database().SelectData("laylichthichosinhvien", list);
                dgvLichThigv.Columns["tenphongthi"].HeaderText = "Tên phòng thi";
                dgvLichThigv.Columns["cathi"].HeaderText = "Ca thi";
                dgvLichThigv.Columns["ngaythi"].HeaderText = "Ngay thi";
                dgvLichThigv.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            }
        }
    }
}
