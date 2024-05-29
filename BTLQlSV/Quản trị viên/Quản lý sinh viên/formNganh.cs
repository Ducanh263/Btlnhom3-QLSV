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

namespace BTLQlSV.Quản_trị_viên.Quản_lý_sinh_viên
{
    public partial class formNganh : Form
    {
        private string makhoa;
        private string tukhoa = "";
        public formNganh(string mk)
        {
            InitializeComponent();
            this.makhoa = mk;
        }

        private void formNganh_Load(object sender, EventArgs e)
        {
            LoadDSNganh();
        }

        private void LoadDSNganh()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                Key = "@tukhoa",
                Value = tukhoa
            });
            lst.Add(new CustomParameter()
            {
                Key = "@makhoa",
                Value = makhoa
            });
            dgvDSNganh.DataSource = new Database().SelectData("selectAllNganh", lst);
        }

        private void dgvDSNganh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mn = dgvDSNganh.Rows[e.RowIndex].Cells["Manganh"].Value.ToString();
                var r = new Database().Select("selectTennganh '" +mn+ "'");
                string tennganh = r["tennganh"].ToString();
                new formLopSVNhaphoc(makhoa,mn,tennganh).ShowDialog();
                LoadDSNganh();
            }
        }
    }
}
