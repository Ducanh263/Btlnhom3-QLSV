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
    public partial class formADTDSXLichThi : Form
    {
        private ExamScheduling scheduler;
        private string mgv;
        public formADTDSXLichThi()
        {
            InitializeComponent();
            scheduler = new ExamScheduling();
        }
        private void BtnTaoLT_Click(object sender, EventArgs e)
        {
            // Check if the mabLichThi MaskedTextBox is null or empty
            if (string.IsNullOrEmpty(mabLichThi.Text.Trim()))
            {
                MessageBox.Show("Mời nhập ngày bắt đầu thi");
                return;
            }

            // Attempt to parse the text into a DateTime object
            DateTime ngaythi;
            if (!DateTime.TryParse(mabLichThi.Text, out ngaythi))
            {
                MessageBox.Show("Ngày bắt đầu thi không hợp lệ. Vui lòng nhập ngày đúng định dạng.");
                return;
            }
            // Nạp dữ liệu
            scheduler.LoadData();

            // Xây dựng ma trận trọng số
            scheduler.BuildWeightMatrix();

            // Tính toán số bậc của các môn học
            scheduler.CalculateDegrees();

            // Khởi tạo giới hạn màu
            scheduler.InitializeColorLimits();

            // Sắp xếp các môn học
            scheduler.SortCourses();

            // Gán màu cho các môn học
            scheduler.AssignColors();

            // Hiển thị màu của các môn học
            //scheduler.DisplayColors();

            // Hiển thị màu trong DataGridView
            DisplayColorsInDataGridView(scheduler.courseColors);
            //Hiển thị ma trận trọng số
            //DisplayWeightMatrixInDataGridView(scheduler.weightMatrix);
        }


        // Phương thức hiển thị màu trong DataGridView
        private void DisplayColorsInDataGridView(Dictionary<string, string> courseColors)
        {
            // Xóa dữ liệu trước đó trong DataGridView
            dgvColors.Rows.Clear();
            // Thêm tiêu đề cột
            dgvColors.Columns.Clear();
            dgvColors.Columns.Add("CourseCode", "Mã Môn Học");
            dgvColors.Columns.Add("TimeSlot", "Ca");
            dgvColors.Columns.Add("DayOfWeek", "Ngày thi");
            dgvColors.Columns.Add("Room", "Phòng");

            // Thêm hàng với mã môn học, tiết, thứ và phòng đã được gán
            foreach (var course in courseColors)
            {
                if (!string.IsNullOrEmpty(course.Key) && !string.IsNullOrEmpty(course.Value))
                {
                    string color = course.Value;
                    int dayOfWeek = int.Parse(color.Substring(1, 1));
                    int timeSlot = int.Parse(color.Substring(2, 1));
                    string room = scheduler.GetAssignedRoom(course.Key,dayOfWeek,timeSlot);
                    DateTime ngaythi = DateTime.Parse(mabLichThi.Text);
                    if(dayOfWeek > 7)
                    {
                        dayOfWeek += 1;
                    }
                    DateTime resultDate = ngaythi.AddDays(dayOfWeek);
                    dgvColors.Rows.Add(course.Key, timeSlot, resultDate.ToString("dd/MM/yyyy"), room);
                }
            }
        }
        /*
        private void DisplayWeightMatrixInDataGridView(Dictionary<string, Dictionary<string, int>> weightMatrix)
        {
            dgvWeightMatrix.Rows.Clear();
            dgvWeightMatrix.Columns.Clear();

            // Thêm cột đầu tiên (header cột)
            dgvWeightMatrix.Columns.Add("CourseCode", "Mã Môn Học");

            // Thêm các cột khác dựa trên mã môn học
            foreach (var course in weightMatrix.Keys)
            {
                dgvWeightMatrix.Columns.Add(course, course);
            }

            // Thêm các hàng dựa trên mã môn học và giá trị ma trận trọng số
            foreach (var course1 in weightMatrix.Keys)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvWeightMatrix);
                row.Cells[0].Value = course1;

                int colIndex = 1;
                foreach (var course2 in weightMatrix.Keys)
                {
                    if (weightMatrix[course1].ContainsKey(course2))
                    {
                        row.Cells[colIndex].Value = weightMatrix[course1][course2];
                    }
                    else
                    {
                        row.Cells[colIndex].Value = 0; // Nếu không có giá trị, đặt giá trị là 0
                    }
                    colIndex++;
                }

                dgvWeightMatrix.Rows.Add(row);
            }
        }
        */
        // Lớp quản lý lịch thi
        private class ExamScheduling
        {
            private Dictionary<string, List<string>> courseStudents = new Dictionary<string, List<string>>();//Khoa hoc va list sinh vien tuong ung
            public Dictionary<string, Dictionary<string, int>> weightMatrix = new Dictionary<string, Dictionary<string, int>>();//ma tran trong so
            private Dictionary<string, int> courseDegrees = new Dictionary<string, int>();//bac cua mon hoc
            public Dictionary<string, string> courseColors = new Dictionary<string, string>();
            private Dictionary<string, int> colorLimits = new Dictionary<string, int>();
            private List<string> sortedCourses = new List<string>();
            private int maxScheduleDays = 12; // Giá trị mẫu, nên thiết lập phù hợp
            private int noOfTimeSlots = 4; // Giá trị mẫu, nên thiết lập phù hợp
            private string[] room = { "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "P10", "P11", "P12" };
            private HashSet<int> usedDays = new HashSet<int>();
            private List<string> giangvien = new List<string>();
            // Nạp dữ liệu
            public void LoadData()
            {
                List<CustomParameter> lst = new List<CustomParameter>
                {
                     new CustomParameter { Key = "@tukhoa", Value = "" }
                };

                DataTable dt = new Database().SelectData("laydsmatrantrunglap", lst);

                foreach (DataRow row in dt.Rows)
                {
                    string courseCode = row["mamonhoc"].ToString();
                    string studentId = row["masinhvien"].ToString();

                    if (!courseStudents.ContainsKey(courseCode))
                    {
                        courseStudents[courseCode] = new List<string>();
                    }
                    courseStudents[courseCode].Add(studentId);
                }

                DataTable gv = new Database().SelectData("selectAllGiangVien", lst);
                foreach (DataRow row in gv.Rows)
                {
                    string mgv = row["magiaovien"].ToString();
                    giangvien.Add(mgv);
                }
            }
        // Xây dựng ma trận trọng số
            public void BuildWeightMatrix()
            {
                foreach (var course1 in courseStudents.Keys) // Duyệt qua từng khóa học trong danh sách các khóa học và sinh viên
                {
                    if (!weightMatrix.ContainsKey(course1)) // Nếu ma trận trọng số chưa chứa khóa học này
                    {
                        weightMatrix[course1] = new Dictionary<string, int>(); // Khởi tạo một mục mới cho khóa học trong ma trận trọng số
                    }
                    foreach (var course2 in courseStudents.Keys) // Duyệt qua từng khóa học để so sánh với khóa học course1
                    {
                        if (course1 != course2) // Nếu khóa học hiện tại không phải là khóa học đang so sánh
                        {
                            int commonStudents = GetCommonStudentCount(course1, course2); // Đếm số lượng sinh viên chung giữa hai khóa học
                            if (commonStudents >= 0) // Nếu có sinh viên chung
                            {
                                weightMatrix[course1][course2] = commonStudents; // Gán số lượng sinh viên chung làm trọng số cho khóa học course1 và course2 trong ma trận trọng số
                            }
                        }
                    }
                }
            }


            // Lấy số sinh viên chung giữa hai môn học
            private int GetCommonStudentCount(string course1, string course2)
            {
                var students1 = courseStudents[course1];
                var students2 = courseStudents[course2];
                return students1.Intersect(students2).Count();
            }

            // Tính toán số bậc của các môn học
            public void CalculateDegrees()
            {
                foreach (var course in weightMatrix.Keys)
                {
                    //courseDegrees[course] = weightMatrix[course].Count;
                    int degree = weightMatrix[course].Count(kvp => kvp.Value > 0); // Chỉ đếm các kết nối có trọng số lớn hơn 0
                    courseDegrees[course] = degree;
                }
            }

            // Khởi tạo giới hạn màu
            public void InitializeColorLimits()
            {
                for (int j = 1; j <= maxScheduleDays; j++)
                {
                    for (int k = 1; k <= noOfTimeSlots; k++)
                    {
                        string color = $"R{j}{k}";
                        // Khởi tạo với một số lớn hoặc giới hạn tối đa đồng thời
                        colorLimits[color] = 10; //số phòng học có sẵn
                    }
                }
            }

            // Sắp xếp các môn học
            public void SortCourses()
            {
                // Sắp xếp các khóa học theo tiêu chí sau:
                sortedCourses = courseDegrees
                    .OrderByDescending(c => c.Value) // 1. Sắp xếp giảm dần theo giá trị của courseDegrees (số lượng sinh viên trong khóa học)
                    .ThenByDescending(c => weightMatrix[c.Key].Values.Max()) // 2. Nếu hai khóa học có cùng số sinh viên, sắp xếp tiếp theo giảm dần theo giá trị lớn nhất trong weightMatrix (độ nặng của khóa học)
                    .ThenBy(c => c.Key) // 3. Nếu hai khóa học vẫn bằng nhau, sắp xếp tăng dần theo Key (tên khóa học hoặc mã khóa học)
                    .Select(c => c.Key) // Lấy Key (tên hoặc mã khóa học) của mỗi phần tử đã sắp xếp
                    .ToList(); // Chuyển kết quả thành danh sách
            }
            // Cập nhật phương thức gán màu cho các môn học
            public void AssignColors()
            {
                int noOfColoredCourses = 0; // Số lượng khóa học đã được gán màu
                foreach (var ci in sortedCourses) // Duyệt qua từng khóa học đã được sắp xếp
                {
                    if (noOfColoredCourses == courseDegrees.Count) // Nếu tất cả các khóa học đã được gán màu, thoát khỏi vòng lặp
                        break;

                    if (!courseColors.ContainsKey(ci)) // Nếu khóa học chưa được gán màu
                    {
                        // Lấy màu đầu tiên cho nút hoặc màu nhỏ nhất có sẵn
                        string Rab = noOfColoredCourses == 0 ? GetFirstNodeColor(ci) : GetSmallestAvailableColor(ci);
                        if (Rab == null) // Nếu không thể lấy được màu, báo lỗi và thoát
                        {
                            MessageBox.Show("Không tìm được lịch thi!!!");
                            return;
                        }
                        courseColors[ci] = Rab; // Gán màu cho khóa học
                        noOfColoredCourses++; // Tăng số lượng khóa học đã được gán màu
                        colorLimits[Rab] -= 5; // Giảm số lượng giới hạn màu

                        // Thêm ngày vào danh sách ngày đã sử dụng
                        int dayUsed = int.Parse(Rab.Substring(1, 1));
                        usedDays.Add(dayUsed);

                        var adjCourses = GetOrderedAdjacencyCourses(ci); // Lấy danh sách các khóa học kề
                        foreach (var mj in adjCourses) // Duyệt qua từng khóa học kề
                        {
                            if (!courseColors.ContainsKey(mj)) // Nếu khóa học kề chưa được gán màu
                            {
                                // Kiểm tra xem hai môn học có sinh viên chung hay không
                                if (GetCommonStudentCount(ci, mj) == 0)
                                {
                                    // Nếu không có sinh viên chung, gán cùng một màu nếu số lượng phòng còn đủ
                                    if (colorLimits[Rab] > 0)
                                    {
                                        courseColors[mj] = Rab;
                                        noOfColoredCourses++;
                                        colorLimits[Rab] -= 5;

                                        // Thêm ngày vào danh sách ngày đã sử dụng
                                        dayUsed = int.Parse(Rab.Substring(1, 1));
                                        usedDays.Add(dayUsed);
                                    }
                                    else
                                    {
                                        string Rcd = GetSmallestAvailableColor(mj); // Lấy màu nhỏ nhất có sẵn cho khóa học kề
                                        if (Rcd != null)
                                        {
                                            courseColors[mj] = Rcd; // Gán màu cho khóa học kề
                                            noOfColoredCourses++;
                                            colorLimits[Rcd] -= 5;

                                            // Thêm ngày vào danh sách ngày đã sử dụng
                                            dayUsed = int.Parse(Rcd.Substring(1, 1));
                                            usedDays.Add(dayUsed);
                                        }
                                    }
                                }
                                else
                                {
                                    string Rcd = GetSmallestAvailableColor(mj); // Lấy màu nhỏ nhất có sẵn cho khóa học kề
                                    if (Rcd != null)
                                    {
                                        courseColors[mj] = Rcd; // Gán màu cho khóa học kề
                                        noOfColoredCourses++;
                                        colorLimits[Rcd] -= 1;

                                        // Thêm ngày vào danh sách ngày đã sử dụng
                                        dayUsed = int.Parse(Rcd.Substring(1, 1));
                                        usedDays.Add(dayUsed);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Phương thức để lấy phòng được gán cho một môn học
            // Khai báo từ điển assignedRooms để lưu trữ các phòng đã được gán cho từng khóa thời gian cụ thể
            private Dictionary<string, HashSet<string>> assignedRooms = new Dictionary<string, HashSet<string>>();

            // Phương thức GetAssignedRoom nhận vào thông tin về khóa học, ngày và khung giờ để xác định phòng học phù hợp
            public string GetAssignedRoom(string course, int day, int timeSlot)
            {
                // Truy vấn cơ sở dữ liệu để lấy số lượng sinh viên tham gia khóa học
                var rs = new Database().Select("sosinhvienthamgiahocphandangxet '" + course + "'");
                int studentCount = Convert.ToInt32(rs["soluong"]);

                // Tạo khóa thời gian dựa trên ngày và khung giờ
                string timeKey = $"R{day}{timeSlot}";

                // Kiểm tra xem khóa này đã tồn tại trong từ điển assignedRooms chưa, nếu chưa thì thêm mới
                if (!assignedRooms.ContainsKey(timeKey))
                {
                    assignedRooms[timeKey] = new HashSet<string>();
                }

                // Lấy danh sách các phòng chưa được gán cho khóa thời gian này
                var availableRooms = room.Except(assignedRooms[timeKey]).ToArray();

                // Sử dụng Math.Min để đảm bảo số phòng được chọn không vượt quá số lượng sinh viên hoặc số phòng khả dụng
                string[] selectedRooms = GetRandomRooms(availableRooms, Math.Min(studentCount, availableRooms.Length));

                // Gán các phòng đã chọn vào khóa thời gian tương ứng trong từ điển assignedRooms
                assignedRooms[timeKey].UnionWith(selectedRooms);

                // Trả về danh sách các phòng đã được gán dưới dạng chuỗi, ngăn cách bởi dấu phẩy
                return string.Join(", ", selectedRooms);
            }

            // Phương thức GetRandomRooms nhận vào danh sách các phòng và số lượng phòng cần chọn ngẫu nhiên
            private string[] GetRandomRooms(string[] rooms, int count)
            {
                Random random = new Random();
                // Trộn ngẫu nhiên danh sách phòng và lấy ra số lượng phòng cần thiết
                return rooms.OrderBy(x => random.Next()).Take(count).ToArray();
            }


            // Lấy màu của nút đầu tiên
            private string GetFirstNodeColor(string ci)
            {
                // Tạo danh sách ngày ưu tiên
                var preferredDays = usedDays.OrderBy(day => day).ToList();
                for (int j = 1; j <= maxScheduleDays; j++) // Thêm các ngày chưa được sử dụng vào danh sách ngày ưu tiên
                {
                    if (!preferredDays.Contains(j))
                    {
                        preferredDays.Add(j);
                    }
                }

                // Duyệt qua danh sách ngày ưu tiên
                foreach (var day in preferredDays)
                {
                    for (int k = 1; k <= noOfTimeSlots; k++) // Duyệt qua các khung thời gian
                    {
                        string color = $"R{day}{k}"; // Tạo màu từ ngày và khung thời gian
                        if (colorLimits.ContainsKey(color) && colorLimits[color] >= 1) // Kiểm tra nếu màu còn khả dụng
                            return color; // Trả về màu khả dụng đầu tiên
                    }
                }
                return null; // Không tìm thấy màu khả dụng
            }

            // Lấy màu nhỏ nhất có sẵn
            private string GetSmallestAvailableColor(string ci)
            {
                var adjList = weightMatrix[ci].Keys.ToList(); // Lấy danh sách các khóa học kề

                // Tạo danh sách ngày ưu tiên
                var preferredDays = usedDays.OrderBy(day => day).ToList();
                for (int j = 1; j <= maxScheduleDays; j++) // Thêm các ngày chưa được sử dụng vào danh sách ngày ưu tiên
                {
                    if (!preferredDays.Contains(j))
                    {
                        preferredDays.Add(j);
                    }
                }

                // Duyệt qua danh sách ngày ưu tiên
                foreach (var day in preferredDays)
                {
                    for (int k = 1; k <= noOfTimeSlots; k++) // Duyệt qua các khung thời gian
                    {
                        string color = $"R{day}{k}"; // Tạo màu từ ngày và khung thời gian
                        bool valid = true; // Khởi tạo cờ hợp lệ

                        // Kiểm tra các khóa học kề
                        foreach (var adj in adjList)
                        {
                            if (courseColors.ContainsKey(adj)) // Nếu khóa học kề đã được gán màu
                            {
                                string refColor = courseColors[adj];
                                if (GetDistance(refColor, color) <= 1 || !Check3ExamsConstraint(ci, color, day))
                                {
                                    valid = false; // Nếu màu không hợp lệ, đặt cờ là false
                                    break;
                                }
                            }
                        }

                        // Nếu màu hợp lệ và còn khả dụng
                        if (valid && colorLimits.ContainsKey(color) && colorLimits[color] >= 1)
                        {
                            return color; // Trả về màu nhỏ nhất có sẵn
                        }
                    }
                }
                return null; // Không tìm thấy màu khả dụng
            }

            // Lấy danh sách các môn học liên kết được sắp xếp
            private List<string> GetOrderedAdjacencyCourses(string ci)
            {
                return weightMatrix[ci] // Truy cập vào ma trận trọng số cho khóa học ci
                    .OrderByDescending(x => x.Value) // Sắp xếp các khóa học liên kết theo trọng số giảm dần
                    .Select(x => x.Key) // Lấy khóa (tên hoặc mã khóa học) của các khóa học đã sắp xếp
                    .ToList(); // Chuyển kết quả thành danh sách
            }
            // Lấy khoảng cách giữa hai màu
            private int GetDistance(string color1, string color2)
            {
                int day1 = int.Parse(color1.Substring(1, 1)); // Lấy ngày từ màu thứ nhất
                int slot1 = int.Parse(color1.Substring(2, 1)); // Lấy khung thời gian từ màu thứ nhất
                int day2 = int.Parse(color2.Substring(1, 1)); // Lấy ngày từ màu thứ hai
                int slot2 = int.Parse(color2.Substring(2, 1)); // Lấy khung thời gian từ màu thứ hai

                int D1 = Math.Abs(slot2 - slot1); // Tính khoảng cách khung thời gian
                int D2 = Math.Abs(day2 - day1); // Tính khoảng cách ngày

                return D1 + D2; // Tổng khoảng cách ngày và khung thời gian
            }

            // Kiểm tra ràng buộc 3 kỳ thi
            private bool Check3ExamsConstraint(string ci, string Rjk, int day)
            {
                var studentList = courseStudents[ci]; // Lấy danh sách sinh viên của khóa học ci
                foreach (var student in studentList) // Duyệt qua từng sinh viên trong danh sách
                {
                    int counter = 0; // Bộ đếm số lượng kỳ thi của sinh viên trong cùng một ngày
                    for (int slot = 1; slot <= noOfTimeSlots; slot++) // Duyệt qua từng khung thời gian trong ngày
                    {
                        string color = $"R{day}{slot}"; // Tạo màu từ ngày và khung thời gian
                        if (courseColors.Values.Contains(color)) // Nếu có khóa học được gán màu này
                        {
                            var courses = courseColors.Where(c => c.Value == color).Select(c => c.Key); // Lấy danh sách các khóa học được gán màu này
                            foreach (var course in courses) // Duyệt qua từng khóa học trong danh sách
                            {
                                if (courseStudents[course].Contains(student)) // Nếu sinh viên thuộc khóa học này
                                {
                                    counter++; // Tăng bộ đếm
                                    if (counter >= 2) // Nếu bộ đếm đạt 2 hoặc hơn, vi phạm ràng buộc
                                        return false; // Trả về false vì vi phạm ràng buộc 3 kỳ thi trong cùng một ngày
                                }
                            }
                        }
                    }
                }
                return true; // Trả về true nếu không vi phạm ràng buộc
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (phongArray == null || phongArray.Length == 0) // Kiểm tra mảng có rỗng hay không
            {
                MessageBox.Show("Mời chọn nhóm thi cần thêm");
            }
            else
            {
                foreach (string phong in phongArray)
                {
                    new formthemlichthisaukhisapxepcs(mamonhoc, cathi, ngaythi,hinhthucthi,phong).ShowDialog();
                }
            }
        }
        private string mamonhoc;
        private string cathi;
        private string ngaythi;
        private string tenphongthi;
        private string[] phongArray;
        private string hinhthucthi;
        private void dgvColors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (cbbHinhThucThi.SelectedIndex < 0)
                {
                    MessageBox.Show("Mời chọn hình thức thi");
                    return;
                }
                switch (cbbHinhThucThi.Text)
                {
                    case "Trắc nghiệm":
                        hinhthucthi = "Trắc nghiệm";
                        break;
                    case "Tự luận":
                        hinhthucthi = "Tự luận";
                        break;
                    case "Vấn đáp":
                        hinhthucthi = "Vấn đáp";
                        break;
                }
                mamonhoc = dgvColors.Rows[e.RowIndex].Cells["CourseCode"].Value.ToString();
                cathi = dgvColors.Rows[e.RowIndex].Cells["TimeSlot"].Value.ToString();
                ngaythi = dgvColors.Rows[e.RowIndex].Cells["DayOfWeek"].Value.ToString();
                tenphongthi = dgvColors.Rows[e.RowIndex].Cells["Room"].Value.ToString();
                phongArray = tenphongthi.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private void formADTDSXLichThi_Load(object sender, EventArgs e)
        {
            cbbHinhThucThi.SelectedIndex = -1;
        }
    }
}
