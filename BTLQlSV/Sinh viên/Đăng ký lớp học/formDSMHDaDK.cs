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
    public partial class formDSMHDaDK : Form
    {
        private string msv;
        public formDSMHDaDK(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }

        private void formDSMHDaDK_Load(object sender, EventArgs e)
        {
            LoadDSMHDDK();
        }

        private void LoadDSMHDDK()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@masinhvien",
                Value = msv
            });
            dgvMonDDK.DataSource = new Database().SelectData("monDaDKy", lst);
            dgvMonDDK.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvMonDDK.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvMonDDK.Columns["gvien"].HeaderText = "Giảng viên";
            dgvMonDDK.Columns["sotinchi"].HeaderText = "Số tín chỉ";
        }
        private void btnDangkymonhoc_Click(object sender, EventArgs e)
        {
            var f = new formDSMHChuaDK(msv);
            f.ShowDialog();
            LoadDSMHDDK();
        }
        private string malophoc;
        private void dgvMonDDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                malophoc = dgvMonDDK.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
            }
        }
        private void btnHuyHocPhan_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@masinhvien",
                Value = msv
            });
            lst.Add(new CustomParameter()
            {
                Key = "@malophoc",
                Value = malophoc
            });
            var rs = new Database().Execute("huyhocphan", lst);
            if(rs == 1)
            {
                MessageBox.Show("Hủy học phần thành công");
            }
            else
            {
                MessageBox.Show("Hủy học phần thất bại");
            }
            LoadDSMHDDK();
        }
    }
}
