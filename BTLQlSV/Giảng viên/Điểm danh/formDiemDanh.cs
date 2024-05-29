using BTLQLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQlSV
{
    public partial class formDiemDanh : Form
    {
        private string ngaymoi = DateTime.Now.ToString("yyyy-MM-dd");
        private string malophoc;
        private string mgv;
        private string tukhoa = "";
        public formDiemDanh(string malophoc,string mgv)
        {
            InitializeComponent();
            this.malophoc = malophoc;
            this.mgv = mgv;
        }

        private void formDiemDanh_Load(object sender, EventArgs e)
        {
            LoadDSLCDiemDanh();
        }

        private void LoadDSLCDiemDanh()//Danh sách lớp cần điểm danh
        {
            //Gan gia tri cho cbbDiemDanh
            List<CustomParameter> nlst = new List<CustomParameter>();
            nlst.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = tukhoa
            });
            cbbDiemDanh.DataSource = new Database().SelectData("selectAllTrangthaidd",nlst);
            cbbDiemDanh.DisplayMember = "trangthai";//thuộc tính hiển thị của cbb
            cbbDiemDanh.ValueMember = "diemdanh";//giá trị của key của cbb
            //Gan gia tri cho cbbngayHT
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@malophoc",
                Value = malophoc
            });
            cbbNgayHT.DataSource = new Database().SelectData("layngaydadiemdanh",lst);
            cbbNgayHT.DisplayMember = "ngayhientai";
            cbbNgayHT.ValueMember = "ngayhientai";
            //lay danh sach sinh vien de diem danh
            lst.Add(new CustomParameter()
            {
                Key = "@ngayhientai",
                Value = ngaymoi
            });
            dgvDSSVLCDD.DataSource = new Database().SelectData("danhsachdiemdanh", lst);
        }
        private string msv;
        private void dgvDSSVLCDD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                msv = dgvDSSVLCDD.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
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
                lst.Add(new CustomParameter()
                {
                    Key = "@ngayhientai",
                    Value = ngaymoi
                });
                // Assuming Database().SelectData returns a DataTable
                DataTable trangthaiTable = new Database().SelectData("selecttrangthaiddsinhvienduocchon", lst);
               
                if (trangthaiTable.Rows.Count > 0)
                {
                    string trangthai = trangthaiTable.Rows[0][0].ToString();
                    cbbDiemDanh.SelectedValue = trangthai;
                }
            }
        }
      
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string diemdanh = cbbDiemDanh.SelectedIndex.ToString();
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
            lst.Add(new CustomParameter()
            {
                Key = "@magiaovien",
                Value = mgv
            });
            lst.Add(new CustomParameter()
            {
                Key = "@diemdanh",
                Value = diemdanh
            });
            lst.Add(new CustomParameter()
            {
                Key = "@ngayhientai",
                Value = ngaymoi
            });
            var rs = new Database().Execute("Updatediemdanh", lst);
            if(rs == 1)
            {
                MessageBox.Show("Điểm danh thành công cho sinh viên'" + msv +"'");
            }
            LoadDSLCDiemDanh();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = (DateTime)cbbNgayHT.SelectedValue;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            if (!formattedDate.ToString().Equals(ngaymoi))
            {
                cbbDiemDanh.Visible = false;
                btnLuu.Visible = false;
            }
            else
            {
                cbbDiemDanh.Visible = true;
                btnLuu.Visible = true;
            }
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@malophoc",
                Value = malophoc
            });
            lst.Add(new CustomParameter()
            {
                Key = "@ngayhientai",
                Value = formattedDate
            });
            dgvDSSVLCDD.DataSource = new Database().SelectData("danhsachdiemdanh", lst);
     
        }
    }
}
