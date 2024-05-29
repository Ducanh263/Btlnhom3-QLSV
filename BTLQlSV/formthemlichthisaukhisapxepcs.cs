using BTLQLSV;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTLQlSV
{
    public partial class formthemlichthisaukhisapxepcs : Form
    {
        private string mamonhoc;
        private string cathi;
        private string ngaythi;
        private string tenphongthi;
        private string masinhvien;
        private string hinhthucthi;
        public formthemlichthisaukhisapxepcs(string mamonhoc, string cathi, string ngaythi, string hinhthucthi, string tenphongthi)
        {
            InitializeComponent();
            this.mamonhoc = mamonhoc;
            this.cathi = cathi;
            this.tenphongthi = tenphongthi;
            this.ngaythi = ngaythi;
            this.hinhthucthi = hinhthucthi;
        }
        private int countt = 0;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formthemlichthisaukhisapxepcs_Load(object sender, EventArgs e)
        {
            List<CustomParameter> nlst = new List<CustomParameter>();
            nlst.Add(new CustomParameter()
            {
                Key  = "@tukhoa",
                Value = ""
            });
            var dt = new Database().SelectData("selectAllGiangVien", nlst);
            if (dt.Rows.Count >= 0)
{
                // Thiết lập DataSource cho ComboBox
                cbbGiangVien.DataSource = dt;

                // Thiết lập DisplayMember để hiển thị tên giảng viên
                cbbGiangVien.DisplayMember = "hoten";

                // Thiết lập ValueMember nếu bạn muốn giữ lại mã giáo viên
                cbbGiangVien.ValueMember = "magiaovien";
            }
            txtCathi.Text = cathi;
            txtMamonhoc.Text = mamonhoc;
            txtNgaythi.Text = ngaythi;
            txtPhongThi.Text = tenphongthi;

            
            /*
            List<CustomParameter> nnlst = new List<CustomParameter>();
            nlst.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = ""
            });
            var dtt = new Database().SelectData("thongtinsinhvienthamgiathihocphandangxet", nnlst);*/
            

        }
        private string msv;
        List<string> studentList = new List<string>(); 
       
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                masinhvien = dataGridView1.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Mời chọn sinh viên");
            }
        }
        private int Countt = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
                countt++;
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    Key = "@tenphongthi",
                    Value = tenphongthi
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@mamonhoc",
                    Value = mamonhoc
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@magiaovien",
                    Value = cbbGiangVien.SelectedValue.ToString()
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@cathi",
                    Value = cathi
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@ngaythi",
                    Value = ngaythi
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@masinhvien",
                    Value = masinhvien
                });
                lst.Add(new CustomParameter()
                {
                Key = "@hinhthucthi",
                Value = hinhthucthi
                });
            var rs = new Database().Execute("themlichthi", lst);
                LoadDSSV();
                if (countt == 1)
                {
                    MessageBox.Show("Lớp đủ số lượng");
                    this.Dispose();
                }
        }
        private void LoadDSSV()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@mamonhoc",
                Value = mamonhoc
            });

            // Assume that 'SelectData' returns a DataTable
            dataGridView1.DataSource = new Database().SelectData("laytatcasinhvienchohocphan", lst);
        }
    }
}
