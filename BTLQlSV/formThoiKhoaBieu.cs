using BTLQLSV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

namespace BTLQlSV
{
    public partial class formThoiKhoaBieu : Form
    {
        private DataTable x;
        private string taikhoan;
        private string loaitaikhoan;
        private List<string> daysOfWeek = new List<string>
        {
            "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật"
        };

        private List<string> timeSlots = new List<string>
        {
            "Tiết 1", "Tiết 2", "Tiết 3", "Tiết 4", "Tiết 5", "Tiết 6", "Tiết 7",
            "Tiết 8", "Tiết 9", "Tiết 10", "Tiết 11", "Tiết 12", "Tiết 13"
        };

        private string[,] courseData = new string[13, 7]
      {
            { "", "", "", "", "", "", "" }, // Tiết 1
            { "", "", "", "", "", "", "" }, // Tiết 2
            { "", "", "", "", "", "", "" }, // Tiết 3
            { "", "", "", "", "", "", "" }, // Tiết 4
            { "", "", "", "", "", "", "" }, // Tiết 5
            { "", "", "", "", "", "", "" }, // Tiết 6
            { "", "", "", "", "", "", "" }, // Tiết 7
            { "", "", "", "", "", "", "" }, // Tiết 8
            { "", "", "", "", "", "", "" }, // Tiết 9
            { "", "", "", "", "", "", "" }, // Tiết 10
            { "", "", "", "", "", "", "" }, // Tiết 11
            { "", "", "", "", "", "", "" }, // Tiết 12
            { "", "", "", "", "", "", "" }  // Tiết 13
      };

        public formThoiKhoaBieu(string taikhoan,string loaitaikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
            this.loaitaikhoan = loaitaikhoan;
            InitializeTimetable();
        }

        private void formThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            LoadTimetableData();
        }

        private void LoadTimetableData()
        {
            if (loaitaikhoan.Equals("sv"))
            {
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    Key = "@masinhvien",
                    Value = taikhoan
                });
                this.x = new Database().SelectData("monDaDKy", lst);

                if (x != null)
                {
                    AddCoursesFromDataTable(x);
                    UpdateDataGridView();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu thời khóa biểu!");
                }
            }
            else {
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    Key = "@magiaovien",
                    Value = taikhoan
                });
                lst.Add(new CustomParameter()
                {
                    Key = "@tukhoa",
                    Value = ""
                });
                this.x = new Database().SelectData("tracuulop", lst);

                if (x != null)
                {
                    AddCoursesFromDataTable(x);
                    UpdateDataGridView();
                }
            }
        }

        private void InitializeTimetable()
        {
            dataGridViewTimetable.ColumnCount = daysOfWeek.Count + 1;
            dataGridViewTimetable.RowCount = timeSlots.Count;

            for (int i = 0; i < daysOfWeek.Count; i++)
            {
                dataGridViewTimetable.Columns[i].HeaderText = daysOfWeek[i];
            }
            dataGridViewTimetable.Columns[daysOfWeek.Count].HeaderText = "Thời gian";
        }

        private void AddCoursesFromDataTable(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int day = Convert.ToInt32(row["ngayhoc"]);
                int startSlot = Convert.ToInt32(row["tietbatdau"]);
                int endSlot = startSlot + Convert.ToInt32(row["sotinchi"]) - 1;
                string courseName = row["tenmonhoc"].ToString();
                string tenphonghoc = row["tenphonghoc"].ToString();
                // Declare the instructor variable here
                string instructor;

                // Nếu là giảng viên thì không cần hiển thị tên giảng viên ở thời khóa biểu
                if (loaitaikhoan.Equals("gv"))
                {
                    instructor = ""; 
                }
                else
                {
                    instructor = row["gvien"].ToString();
                }

                //string room = row["malophoc"].ToString();
                AddCourse(courseName,tenphonghoc, instructor, day, startSlot, endSlot);
            }
        }
        private string courseInfo;
        private void AddCourse(string courseName, string tenphonghoc, string instructor, int day, int startSlot, int endSlot)
        {
            if (loaitaikhoan.Equals("sv"))
            {
               courseInfo = $"P:{tenphonghoc}\n GV:{instructor}";
            }
            else
            {
                courseInfo = $"P:{tenphonghoc}";
            }
            courseData[startSlot-1,day-2] = courseName;
            courseData[startSlot, day - 2] = courseInfo;
            for(int i = startSlot+1; i < Math.Min(endSlot, courseData.GetLength(0)); i++){
                courseData[i, day - 2] ="             ";
            }
   
        }

        private void UpdateDataGridView()
        {
            for (int row = 0; row < dataGridViewTimetable.RowCount; row++)
            {
                dataGridViewTimetable.Rows[row].Cells[daysOfWeek.Count].Value = timeSlots[row];

                for (int col = 0; col < dataGridViewTimetable.ColumnCount - 1; col++)
                {
                    if (row >= 0 && row < courseData.GetLength(0) && col >= 0 && col < courseData.GetLength(1))
                    {
                        string cellValue = courseData[row, col];
                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            dataGridViewTimetable.Rows[row].Cells[col].Value = cellValue;
                            dataGridViewTimetable.Rows[row].Cells[col].Style.BackColor = Color.LightBlue;
                        }
                    }
                }
            }
        }
    }
}
