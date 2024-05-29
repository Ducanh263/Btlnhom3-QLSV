using BTLQlSV.Giảng_viên.Điểm_danh;
using BTLQlSV.Quản_trị_viên;
using BTLQlSV.Quản_trị_viên.Quản_lý_sinh_viên;
using BTLQLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQlSV
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitk;
        private string mk;
        private bool log;
        private void mainForm_Load(object sender, EventArgs e)
        {
            var fn = new formDangNhap();
            fn.ShowDialog();//Cho load form đăng nhập khi form main được gọi

            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            mk = fn.matkhau;
            DangNhap(taikhoan,loaitk,mk);
        }
        
        private void DangNhap(string taikhoan = null, string loaitk = null, string mk = null)
        {
            if (loaitk != null){
                if (loaitk.Equals("admin"))
                {
                    chucNanggvToolStripMenuItem.Visible = false;
                    chucNangToolStripMenuItem.Visible = false;
                    txtName.Text = "Quản trị viên";
                }
                else
                {
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter()
                    {
                        Key = "taikhoan",
                        Value = taikhoan
                    });
                    lst.Add(new CustomParameter()
                    {
                        Key = "loaitaikhoan",
                        Value = loaitk
                    });
                    DataTable resultTable = new Database().SelectData("xinchao", lst);
                    string hoten = resultTable.Rows[0]["hoten"].ToString();
                    txtName.Text = hoten;
                    quanLyToolStripMenuItem.Visible = false;
                    if (loaitk.Equals("gv"))
                    {
                        chucNangToolStripMenuItem.Visible = false;
                        txtName.Text = "Xin chào giảng viên" + " " + txtName.Text;
                    }
                    else
                    {
                        chucNanggvToolStripMenuItem.Visible = false;
                        txtName.Text = "Xin chào sinh viên" + " " + txtName.Text;
                    }
                }
                formGT f = new formGT();
                AddForm(f);
            }
        }
        private void AddForm(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);//them f vvao panel1 
            this.Text = f.Text;
            f.Show();
        }
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (loaitk != null)
            {
                chucNanggvToolStripMenuItem.Visible = true;
                chucNangToolStripMenuItem.Visible = true;
                quanLyToolStripMenuItem.Visible = true;
            }
            var fn = new formDangNhap();
            fn.ShowDialog();//Cho load form đăng nhập khi form main được gọi
            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            mk = fn.matkhau;
            log = fn.log;
            DangNhap(taikhoan, loaitk, mk);
            if (log)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formQuanLyKhoa f = new formQuanLyKhoa();
            AddForm(f);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDSMH f = new formDSMH();
            AddForm(f);
        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDSLopHoc f = new formDSLopHoc();    
            AddForm(f);
        }

        private void giangVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formDSGV f = new formDSGV();
            AddForm(f);
        }
        private void dangKyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new formDSMHDaDK(taikhoan);
            AddForm(f);
        }

        private void traCuudiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new formKetQuaHT(taikhoan);
            AddForm(f);
        }
        //
        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new formdoimatkhau(taikhoan,loaitk,mk).ShowDialog();
        }

        private void xemThoiKhoaBieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new formThoiKhoaBieu(taikhoan,loaitk);
            AddForm(f);
        }

        private void quanLyLopToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new formQuanLyLop(taikhoan);
            AddForm(f);
        }

        private void diemDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new formDSLCDiemDanh(taikhoan);
            AddForm(f);
        }

        private void xemThoikhoabieugvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new formThoiKhoaBieu(taikhoan,loaitk);
            AddForm(f);
        }

        private void thongTinSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new formThongtinsinhvien(taikhoan);
            AddForm(f); 
        }

        private void QLlichThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new formADTDSXLichThi();
            AddForm(f);
        }

        private void xemLichThiSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new formXemLichThiGv(taikhoan,loaitk);
            AddForm(f);
        }

        private void LichthicuasvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new formXemLichThiGv(taikhoan,loaitk);
            AddForm(f);
        }
    }
}
