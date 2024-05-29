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
    public partial class formLopHoc : Form
    {
        private bool duocmolop = true;
        private string malophoc;
        private string nguoithuchien = "admin";
        public formLopHoc(string malophoc)
        {
            InitializeComponent();
            this.malophoc = malophoc;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formLopHoc_Load(object sender, EventArgs e)
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value =""
            });
            cbbMonHoc.DataSource = new Database().SelectData("selectAllMonHoc", lst);
            cbbMonHoc.DisplayMember = "tenmonhoc";//thuộc tính hiển thị của cbb
            cbbMonHoc.ValueMember = "mamonhoc";//giá trị của key của cbb
            cbbMonHoc.SelectedIndex = -1;

            cbbGiangVien.DataSource = new Database().SelectData("selectAllGiangVien", lst);
            cbbGiangVien.DisplayMember = "hoten";//thuộc tính hiển thị của cbb
            cbbGiangVien.ValueMember = "magiaovien";//giá trị của key của cbb
            cbbGiangVien.SelectedIndex = -1;

            cbbPhongHoc.DataSource = new Database().SelectData("selectAllPhonghoc", lst);
            cbbPhongHoc.DisplayMember = "tenphonghoc";//thuộc tính hiển thị của cbb
            cbbPhongHoc.ValueMember = "maphonghoc";//giá trị của key của cbb
            cbbPhongHoc.SelectedIndex = -1;

            if (string.IsNullOrEmpty(malophoc))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhập lớp học";
                var r = new Database().Select("exec selectLopHoc '"+malophoc+"'");
                cbbGiangVien.SelectedValue = r["magiaovien"].ToString();
                cbbMonHoc.SelectedValue = r["mamonhoc"].ToString();
                txtTietbd.Text = r["tietbatdau"].ToString();
                txtThu.Text = r["ngayhoc"].ToString();
                cbbPhongHoc.SelectedValue = r["maphonghoc"].ToString();
            }
        }
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if(int.Parse(txtThu.Text)<2 && int.Parse(txtThu.Text) > 8){
                MessageBox.Show("Ngày trong tuần từ thứ 2 đến chủ nhật(8)");
                return;
            }
            string sql = "";
            if (cbbMonHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            if (cbbGiangVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giảng viên");
                return;
            }

            List<CustomParameter> lst = new List<CustomParameter>();
            if (string.IsNullOrEmpty(malophoc))
            {
                sql = "AddNewLopHoc";
                lst.Add(new CustomParameter()
                {
                    Key = "@nguoitao",
                    Value = nguoithuchien

                });

            }
            else
            {
                sql = "UpdateLoHoc";
                lst.Add(new CustomParameter()
                {
                    Key = "@nguoicapnhat",
                    Value = nguoithuchien

                });
                lst.Add(new CustomParameter()
                {
                    Key = "@malophoc",
                    Value = malophoc

                });
            }

            lst.Add(new CustomParameter()
            {
                Key = "@mamonhoc",
                Value = cbbMonHoc.SelectedValue.ToString()

            });
            lst.Add(new CustomParameter()
            {
                Key = "@magiaovien",
                Value = cbbGiangVien.SelectedValue.ToString()

            });
            lst.Add(new CustomParameter()
            {
                Key = "@tietbatdau",
                Value = txtTietbd.Text

            });
            lst.Add(new CustomParameter()
            {
                Key = "@ngayhoc",
                Value = txtThu.Text

            });
            lst.Add(new CustomParameter()
            {
                Key = "@maphonghoc",
                Value = cbbPhongHoc.SelectedValue.ToString()

            });
            List<CustomParameter> Istpara = new List<CustomParameter>();
            Istpara.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = ""
            });
            DataTable allLop = new Database().SelectData("allLopHoc", Istpara);
            foreach (DataRow row in allLop.Rows)
            {
                int tietBatDauDaDangKy = Convert.ToInt32(row["tietbatdau"]);
                int soTinChiDaDangKy = Convert.ToInt32(row["sotinchi"]);
                string ngayHocDaDangKy = row["ngayhoc"].ToString();
                string tenlophocDangKy = row["maphonghoc"].ToString();

                int tietBatDauMoi = Convert.ToInt32(txtTietbd.Text);
                int soTinChiMoi = Convert.ToInt32(cbbMonHoc.SelectedValue.ToString());
                string ngayHocMoi = txtThu.Text;
                string tenlophocMoi = cbbPhongHoc.SelectedValue.ToString();
                if (ngayHocDaDangKy.Equals(ngayHocMoi) &&
                    ((tietBatDauMoi >= tietBatDauDaDangKy && tietBatDauMoi < tietBatDauDaDangKy + soTinChiDaDangKy) ||
                    (tietBatDauMoi + soTinChiMoi > tietBatDauDaDangKy && tietBatDauMoi + soTinChiMoi <= tietBatDauDaDangKy + soTinChiDaDangKy)) && tenlophocDangKy.Equals(tenlophocMoi))
                {
                    duocmolop = false;
                    break;
                }
            }
            if (duocmolop)
            {
                var kq = new Database().Execute(sql, lst);
                if (kq == 1)
                {
                    if (string.IsNullOrEmpty(malophoc))
                    {
                        MessageBox.Show("Thêm mới lớp lớp học thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhập lớp lớp học thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Phòng bị trùng cần đổi phòng");
                duocmolop = true;
            }
           
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
