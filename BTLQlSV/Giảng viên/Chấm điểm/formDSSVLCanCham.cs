using BTLQLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BTLQlSV
{
    public partial class formDSSVLCanCham : Form
    {
        private string mgv;
        private string malophoc;
        public formDSSVLCanCham(string mgv,string malophoc)
        {
            InitializeComponent();
            this.mgv = mgv;
            this.malophoc = malophoc;
        }

        private void formDSSVLCanCham_Load(object sender, EventArgs e)
        {
            LoadDSSVCanCham();
        }
        private void LoadDSSVCanCham()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter() { 
                Key = "@magiaovien",
                Value = mgv,
            });
            lst.Add(new CustomParameter()
            {
                Key = "@malophoc",
                Value = malophoc
            });
            dgvDSSVLCanCham.DataSource = new Database().SelectData("danhsachlopchamdiem",lst) ;
            dgvDSSVLCanCham.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dgvDSSVLCanCham.Columns["hoten"].HeaderText = "Họ và tên";
            dgvDSSVLCanCham.Columns["diemc"].HeaderText = "Điểm C";
            dgvDSSVLCanCham.Columns["diemb"].HeaderText = "Điểm B";
            dgvDSSVLCanCham.Columns["diema"].HeaderText = "Điểm A";
        }
        private string msv;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                MessageBox.Show("Cần chọn 1 sinh viên để nhập điểm");
                return;
            }
            else
            {
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    Key = "@magiaovien",
                    Value = mgv
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@malop",
                    Value = malophoc
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@masinhvien",
                    Value = msv
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@diemc",
                    Value = txtdiemC.Text
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@diemb",
                    Value = txtdiemB.Text
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@diema",
                    Value = txtdiemA.Text
                });
                var rs = new Database().Execute("chamdiem", lst);
                if(rs == 1)
                {
                    MessageBox.Show("Cập nhập điểm của sinh viên :" + msv + "thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhập điểm của sinh viên thất bại");
                }
                LoadDSSVCanCham();
            }
        }

        private void dgvDSSVLCanCham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0){
                txtdiemC.Text = dgvDSSVLCanCham.Rows[e.RowIndex].Cells["diemc"].Value.ToString();
                txtdiemB.Text = dgvDSSVLCanCham.Rows[e.RowIndex].Cells["diemb"].Value.ToString();
                txtdiemA.Text = dgvDSSVLCanCham.Rows[e.RowIndex].Cells["diema"].Value.ToString();
                msv = dgvDSSVLCanCham.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
            }
        }

        private void btnKetthuclop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn kết thúc lớp học không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    Key = "@magiaovien",
                    Value = mgv
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@malop",
                    Value = malophoc
                });
                var rs = new Database().Execute("ketthuchocphan", lst);
                if (rs == 1)
                {
                    MessageBox.Show("Thao tác thành công đã kết thúc học phần");
                    this.Dispose();
                }
            }
        }
    }
}
