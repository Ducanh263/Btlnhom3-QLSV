using BTLQLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQlSV.Quản_trị_viên.Quản_lý_sinh_viên
{
    public partial class formLopSVNhaphoc : Form
    {
        private int khoahoc = DateTime.Now.Year - 1956;
        private string makhoa;
        private string manganh;
        private string tukhoa = "";
        private string sosinhviencuakhoa;
        private string duoilop;
        private string tennganh;
        private int count = 0;
        public formLopSVNhaphoc(string makhoa, string mn,string tennganh)
        {
            InitializeComponent();
            this.manganh = mn;
            this.makhoa = makhoa;
            this.tennganh = tennganh;
        }

        private void formLopSVNhaphoc_Load_1(object sender, EventArgs e)
        {
            LoadLopSVNhaphoc();
        }
        private void LoadLopSVNhaphoc()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = tukhoa
            });
            lst.Add(new CustomParameter()
            {
                Key = "@manganh",
                Value = manganh
            });
            dgvLopSVNhapHoc.DataSource = new Database().SelectData("selectAllLopNhapHoc", lst);
        }
        private void dgvLopSVNhapHoc_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mlop = dgvLopSVNhapHoc.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
                new formDSSV(mlop).ShowDialog();
                LoadLopSVNhaphoc();  
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadLopSVNhaphoc();
        }
        public static string GetInitials(string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
            {
                return phrase; // Trả về chính chuỗi nếu nó là null hoặc rỗng
            }

            // Tách các từ trong chuỗi
            string[] words = phrase.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Lấy chữ cái đầu tiên của mỗi từ
            StringBuilder initials = new StringBuilder();
            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    initials.Append(char.ToUpper(word[0]));
                }
            }

            return initials.ToString();
        }

        public List<string> PhanLop(int soSinhVien)
        {
            List<string> danhSachLop = new List<string>();

            if (soSinhVien <= 500)
            {
                // Chia thành 5 lớp A, B, C, D, E
                string[] lop5 = { "A", "B", "C", "D", "E" };
                danhSachLop.AddRange(lop5);
            }
            else if (soSinhVien > 500 && soSinhVien <= 1000)
            {
                // Chia thành 10 lớp A1, A2, B1, B2, C1, C2, D1, D2, E1, E2
                string[] lop10 = { "A1", "A2", "B1", "B2", "C1", "C2", "D1", "D2", "E1", "E2" };
                danhSachLop.AddRange(lop10);
            }
            else
            {
                MessageBox.Show("Số sinh viên vượt quá giới hạn cho phép.");
            }

            return danhSachLop;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSoluong.Text)) {
                MessageBox.Show("Nhập số lượng sinh viên lưu ý chỉ tuyển tối đa 1000 sinh viên");
            }
            else
            {
                int sosinhvien = int.Parse(txtSoluong.Text);
                List<string> danhSachLop = PhanLop(sosinhvien);
                string acronym = GetInitials(tennganh);
                string prefix = acronym + khoahoc.ToString();
                foreach (string lop in danhSachLop)
                {
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter()
                    {
                        Key = "@manganh",
                        Value = manganh
                    });
                    lst.Add(new CustomParameter()
                    {
                        Key = "@tenlop",
                        Value = prefix+lop
                    });
                    lst.Add(new CustomParameter()
                    {
                        Key = "@hedaotao",
                        Value = "Chính quy"
                    });
                    lst.Add(new CustomParameter()
                    {
                        Key = "@khoahoc",
                        Value = khoahoc.ToString()
                    });
                    var rs = new Database().Execute("taoLopHocchokhoahocmoi", lst);
                    count = count+1;
                }
                if(danhSachLop.Count()==count) {
                    MessageBox.Show("Thêm các lớp thành công");
                }
                LoadLopSVNhaphoc();
            }
            
        }
    }
}