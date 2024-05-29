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

namespace BTLQlSV.Giảng_viên.Điểm_danh
{
    public partial class formDSLCDiemDanh : Form
    {
        private string mgv;
        private string tukhoa = "";
        public formDSLCDiemDanh(string mgv)
        {
            InitializeComponent();
            this.mgv = mgv;
        }
        private void formDSLCDiemDanh_Load(object sender, EventArgs e)
        {
            LoadGVQLLDD();
        }
        private void LoadGVQLLDD()
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
            dgvDSSVDD.DataSource = new Database().SelectData("tracuulop", lst);
            dgvDSSVDD.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDSSVDD.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvDSSVDD.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSSVDD.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSSVDD.Columns["siso"].HeaderText = "Sĩ số";
        }
        private void dgvDSSVDD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Khi double click vaò lớp trên thanh datagirdview sẽ hiện ra form danhsachlopcandiemdanh
            if (e.RowIndex >= 0)
            {
                var malophoc = dgvDSSVDD.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    Key = "@magiaovien",
                    Value = mgv
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@malophoc",
                    Value = malophoc
                });
                DataTable x = new Database().SelectData("loaddldanhsachdiemdanh", lst);
                if(x.Rows.Count > 0)
                {
                    foreach (DataRow row in x.Rows)
                    { 
                        string masinhvien = row["masinhvien"].ToString();
                        List<CustomParameter> nlst = new List<CustomParameter>();
                        nlst.Add(new CustomParameter()
                        {
                            Key = "@magiaovien",
                            Value = mgv
                        });
                        nlst.Add(new CustomParameter()
                        {
                            Key = "@malophoc",
                            Value = malophoc
                        });
                        nlst.Add(new CustomParameter()
                        {
                            Key = "@masinhvien",
                            Value = masinhvien
                        });
                        var rs = new Database().Execute("AddnewDSDiemDanh",nlst);
                    }
                }
                new formDiemDanh(malophoc,mgv).ShowDialog();
                //Sau khi formSinhViên đóng => Cập nhập lại dgv
                LoadGVQLLDD();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadGVQLLDD();
        }
    }
}
