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
    public partial class formDSMHChuaDK : Form
    {
        private bool duocdangky = true;
        public formDSMHChuaDK(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }
        private string msv;
        private void formDSMHChuaDK_Load(object sender, EventArgs e)
        {
            LoadDSMHCDK();
        }

        private void LoadDSMHCDK()
        {
            List <CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@masinhvien",
                Value = msv
            });
            dgvDSLHCDK.DataSource = new Database().SelectData("dsLopChuaDKy",lst);
            dgvDSLHCDK.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDSLHCDK.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLHCDK.Columns["gvien"].HeaderText = "Giảng viên";
            dgvDSLHCDK.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSLHCDK.Columns["mamonhoc"].HeaderText = "Mã môn học";

        }

        private void dgvDSLHCDK_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //bấm vào 1 dòng
            //chỉ số hàng của dgv bắt đầu từ 0
            if (dgvDSLHCDK.Rows[e.RowIndex].Index >= 0) {
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn đăng ký học phần [" + dgvDSLHCDK.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString() + "]",
                "Xác nhận đăng ký",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
                {
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter()
                    {
                        Key = "@masinhvien",
                        Value = msv
                    });
                    DataTable dadangky = new Database().SelectData("monDaDKy", lst);
                    var kt = new Database().Select("laythongtinlophocmdk '" + dgvDSLHCDK.Rows[e.RowIndex].Cells["malophoc"].Value.ToString() + "'");
                    // DataTable dadangky được trả về từ câu truy vấn SQL

                    foreach (DataRow row in dadangky.Rows)
                    {
                        int tietBatDauDaDangKy = Convert.ToInt32(row["tietbatdau"]);
                        int soTinChiDaDangKy = Convert.ToInt32(row["sotinchi"]);
                        string ngayHocDaDangKy = row["ngayhoc"].ToString();

                        int tietBatDauMoi = Convert.ToInt32(kt["tietbatdau"]);
                        int soTinChiMoi = Convert.ToInt32(kt["sotinchi"]);
                        string ngayHocMoi = kt["ngayhoc"].ToString();

                        if (ngayHocDaDangKy.Equals(ngayHocMoi) &&
                            ((tietBatDauMoi >= tietBatDauDaDangKy && tietBatDauMoi < tietBatDauDaDangKy + soTinChiDaDangKy) ||
                            (tietBatDauMoi + soTinChiMoi > tietBatDauDaDangKy && tietBatDauMoi + soTinChiMoi <= tietBatDauDaDangKy + soTinChiDaDangKy)))
                        {
                            duocdangky = false;
                            break;
                        }
                    }

                    if (duocdangky)
                    {
                        lst.Add(new CustomParameter()
                        {
                            Key = "@malophoc",
                            Value = dgvDSLHCDK.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                        });
                        var rs = new Database().Execute("dkyhoc", lst);
                        if (rs == -1)
                        {
                            MessageBox.Show("Học phần này đã đăng ký");
                            return;
                        }
                        if (rs == 1)
                        {
                            MessageBox.Show("Đã đăng ký học phần thành công");
                            LoadDSMHCDK();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Môn học bị trùng thời gian");
                        duocdangky = true;
                    }
                }
            }
        }
    }
}
