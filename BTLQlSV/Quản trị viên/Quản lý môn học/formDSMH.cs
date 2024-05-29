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
    public partial class formDSMH : Form
    {
        public formDSMH()
        {
            InitializeComponent();
        }

        private string tukhoa = "";

        private void LoadDSMH()
        {
            //Load danh sách sinh viên khi được load
            List<CustomParameter> Istpara = new List<CustomParameter>();
            Istpara.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = tukhoa
            });
            dgvDSMH.DataSource = new Database().SelectData("SelectAllMonHoc", Istpara);

            dgvDSMH.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvDSMH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSMH.Columns["sotinchi"].HeaderText = "Số tín chỉ";
        }
        private void formDSMH_Load(object sender, EventArgs e)
        {
            LoadDSMH();
        }
        private void dgvDSMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Khi double click vaò sinh viên trên thanh datagirdview sẽ hiện ra form cập nhập thông tin sinh viên
            //Để cập nhập được sinh viên ta cần lấy mã sinh viên
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show("Mã sinh viên: " + dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString());
                var mmh = dgvDSMH.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                //cần truyền mã sinh viên này vào formSinhVien 
                new formMonHoc(mmh).ShowDialog();
                //Sau khi formSinhViên đóng => Cập nhập lại dgv
                LoadDSMH();
            }
        }
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new formMonHoc(null).ShowDialog();
            LoadDSMH();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSMH();
        }
    }
}
