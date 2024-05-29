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
    public partial class formSinhVien : Form
    {
        private string msv;
        private string malop;
        public formSinhVien(string msv,string malop)
        {
            this.msv = msv;//truyền lại msv khi form đang chạy
            this.malop = malop;
            InitializeComponent();
        }
        
        private void formSinhVien_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(msv);
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhập sinh viên";
                var r = new Database().Select("selectsv '" +msv+"'");
                //MessageBox.Show(r[0].ToString());Load thành công
                //Set các giá trị vào component của form
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                txtNgaysinh.Text = r["ngaysinh"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1)
                {
                    RdoNam.Checked = true;
                }
                else
                {
                    RdoNu.Checked = true;
                }
                txtQuequan.Text = r["quequan"].ToString();
                txtDiachi.Text = r["diachi"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //btnLuu sẽ xử lý hai tình huống:
            //1. Thêm mới sinh viên (nếu msv chưa tồn tại)
            //2. Cập nhật sinh viên (nếu tồn tại giá trị msv)
            //Cả hai trường hợp các giá trị đều như nhau tuy nhiên khi cập nhật cần quan tâm tới mã sinh viên

            string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTendem.Text;
            string ten = txtTen.Text;
            // Vì ngày sinh trong MaskedTextBox dưới dạng dd/mm/yy mà trong SQL ta để dưới dạng yy-mm-dd nên cần xét lại định dạng
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(txtNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                txtNgaysinh.Select(); // Trỏ chuột về txtNgaysinh
                return; // Không thực hiện tiếp câu lệnh phía dưới
            }
            string gioitinh = RdoNam.Checked ? "1" : "0"; // Nếu radio check ô nam thì là 1, ngược lại là 0
            string quequan = txtQuequan.Text;
            string diachi = txtDiachi.Text;
            string dienthoai = txtDienthoai.Text;
            string email = txtEmail.Text;

            // Khai báo danh sách tham số bằng class CustomParameter
            List<CustomParameter> IstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv)) // Thêm mới sinh viên
            {
                sql = "AddnewSinhVien"; // Gọi tới procedure thêm mới
                IstPara.Add(new CustomParameter()
                {
                    Key = "@malop",
                    Value = malop
                });
            }
            else // Nếu cập nhật sinh viên
            {
                sql = "UpdateSinhVien"; // Gọi tới procedure cập nhật
                IstPara.Add(new CustomParameter()
                {
                    Key = "@masinhvien",
                    Value = msv
                });
            }

            IstPara.Add(new CustomParameter()
            {
                Key = "@ho",
                Value = ho
            });
            IstPara.Add(new CustomParameter()
            {
                Key = "@tendem",
                Value = tendem
            });
            IstPara.Add(new CustomParameter()
            {
                Key = "@ten",
                Value = ten
            });
            IstPara.Add(new CustomParameter()
            {
                Key = "@ngaysinh",
                Value = ngaysinh.ToString("yyyy-MM-dd")
            });
            IstPara.Add(new CustomParameter()
            {
                Key = "@gioitinh",
                Value = gioitinh
            });
            IstPara.Add(new CustomParameter()
            {
                Key = "@quequan",
                Value = quequan
            });
            IstPara.Add(new CustomParameter()
            {
                Key = "@diachi",
                Value = diachi
            });
            IstPara.Add(new CustomParameter()
            {
                Key = "@dienthoai",
                Value = dienthoai
            });
            IstPara.Add(new CustomParameter()
            {
                Key = "@email",
                Value = email
            });

            var rs = new Database().Execute(sql,IstPara);
            if (rs == 1)//nếu thực hiện thành công
            {
                if (string.IsNullOrEmpty(msv))//nếu thêm mới
                {
                    
                    MessageBox.Show("Thêm mơi sinh viên thành công");
                }
                else//Nếu cập nhập
                {
                    MessageBox.Show("Cập nhập sinh viên thành công");
                }
                this.Dispose();//Đóng form
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
