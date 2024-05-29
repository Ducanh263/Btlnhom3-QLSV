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
    public partial class formQuanLyKhoa : Form
    {
        private string tukhoa = "";
        public formQuanLyKhoa()
        {
            InitializeComponent();
        }

        private void formQuanLyKhoa_Load(object sender, EventArgs e)
        {
            LoadDSKhoa();
        }

        private void LoadDSKhoa()
        {
            //Load danh sách sinh viên khi được load
            List<CustomParameter> Istpara = new List<CustomParameter>();
            Istpara.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = tukhoa
            });
            dgvDSKhoa.DataSource = new Database().SelectData("selectAllKhoa", Istpara);
            dgvDSKhoa.Columns["TenKhoa"].HeaderText = "Tên khoa";
        }
        private void dgvDSKhoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mk = dgvDSKhoa.Rows[e.RowIndex].Cells["MaKhoa"].Value.ToString();
                new formNganh(mk).ShowDialog();
                LoadDSKhoa();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new formKhoa(null).ShowDialog();
            LoadDSKhoa();
        }
    }
}
