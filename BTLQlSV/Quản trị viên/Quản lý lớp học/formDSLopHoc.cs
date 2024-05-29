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
    public partial class formDSLopHoc : Form
    {
        private string tukhoa = "";
        private string ngayhientai = DateTime.Now.ToString("yyyy-MM-dd");
        public formDSLopHoc()
        {
            InitializeComponent();
        }

        private void formDSLopHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
        }
        private void LoadDSLH()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@ngayhientai",
                Value = ngayhientai
            });
            var rs = new Database().Execute("modangky",lst);
            List <CustomParameter> Istpara = new List <CustomParameter>();
            Istpara.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = tukhoa
            });
            dgvDSLH.DataSource = new Database().SelectData("allLopHoc", Istpara);
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã lớp";
            dgvDSLH.Columns["gv"].HeaderText = "Tên giảng viên";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLH.Columns["maphonghoc"].Visible = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSLH();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new formLopHoc(null).ShowDialog();
            LoadDSLH() ;
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var malophoc = dgvDSLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                new formLopHoc(malophoc).ShowDialog();
                LoadDSLH();
            }
        }
    }
}
