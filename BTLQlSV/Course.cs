using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQlSV
{
    public class Course
    {
        public string CourseCode { get; set; }
        public List<string> Students { get; set; }

        public Course(string courseCode, List<string> students)
        {
            CourseCode = courseCode;
            Students = students;
        }
    }
}
