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
    public partial class formQuanLyLop : Form
    {
        private string mgv;
        private string tukhoa = "";
        public formQuanLyLop(string mgv)
        {
            InitializeComponent();
            this.mgv = mgv;
        }

        private void formQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadGVQLLH();
        }
        private void LoadGVQLLH()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@magiaovien",
                Value = mgv
            });
            lst.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = tukhoa
            });
            dgvGVQLLH.DataSource = new Database().SelectData("tracuulop", lst);
            dgvGVQLLH.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvGVQLLH.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvGVQLLH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvGVQLLH.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvGVQLLH.Columns["siso"].HeaderText = "Sĩ số";
        }

        private void dgvGVQLLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Khi double click vaò lớp trên thanh datagirdview sẽ hiện ra form danhsachlopcancham
            if (e.RowIndex >= 0)
            {
                var malophoc = dgvGVQLLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                new formDSSVLCanCham(mgv, malophoc).ShowDialog();
                //Sau khi formSinhViên đóng => Cập nhập lại dgv
                LoadGVQLLH();
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadGVQLLH();
        }
    }
}
