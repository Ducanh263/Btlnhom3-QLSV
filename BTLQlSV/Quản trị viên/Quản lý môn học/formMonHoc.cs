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
using static System.Net.Mime.MediaTypeNames;

namespace BTLQlSV
{
    public partial class formMonHoc : Form
    {
        private string mmh;
        private string nguoithucthi = "admin";
        public formMonHoc(string mmh)
        {
            InitializeComponent();
            this.mmh = mmh;
        }
        private void formMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mmh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhập môn học";
                var r = new Database().Select("exec selectMH'"+mmh+"'");
                txtTenMH.Text = r["tenmonhoc"].ToString();
                txtSotin.Text = r["sotinchi"].ToString();
            }
        }
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var stc = int.Parse(txtSotin.Text);
                if (stc <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải nguyên dương");
                    txtSotin.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Số tín chỉ phải nguyên dương");
                txtSotin.Select();
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(txtTenMH.Text))
                {
                    MessageBox.Show("Tên môn học không được bỏ trống");
                    txtTenMH.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Tên môn học không được bỏ trống");
                txtTenMH.Select();
                return;
            }
            string sql = "";
            
            // Khai báo danh sách tham số bằng class CustomParameter
            List<CustomParameter> IstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mmh)) // Thêm mới sinh viên
            {
                sql = "AddNewMonHoc"; // Gọi tới procedure thêm mới
                IstPara.Add(new CustomParameter()
                {
                    Key = "@nguoitao",
                    Value = nguoithucthi
                });
            }
            else // Nếu cập nhật sinh viên
            {
                sql = "updateMH"; // Gọi tới procedure cập nhật
                IstPara.Add(new CustomParameter()
                {
                    Key = "@nguoicapnhat",
                    Value = nguoithucthi
                });
                IstPara.Add(new CustomParameter()
                {
                    Key = "@mamonhoc",
                    Value = mmh
                });
            }

            IstPara.Add(new CustomParameter()
            {
                Key = "@tenmonhoc",
                Value = txtTenMH.Text
            }) ;
            IstPara.Add(new CustomParameter()
            {
                Key = "@sotinchi",
                Value = txtSotin.Text
            });

            var rs = new Database().Execute(sql, IstPara);
            if (rs == 1)//nếu thực hiện thành công
            {
                if (string.IsNullOrEmpty(mmh))//nếu thêm mới
                {
                    MessageBox.Show("Thêm mơi môn học thành công");
                }
                else//Nếu cập nhập
                {
                    MessageBox.Show("Cập nhập môn học thành công");
                }
                this.Dispose();//Đóng form
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
