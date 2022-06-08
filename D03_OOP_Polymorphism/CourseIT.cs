using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Polymorphism
{
    internal class CourseIT : Course
    {
        internal bool? Exam { get; set; }
        internal string Area { get; set; }

        internal CourseIT() : base()
        {
            Area = string.Empty;
            Exam = null;
        }

        internal CourseIT(int courseId, string courseName, string area, bool? exam) : base(courseId,courseName)
        {
            Exam = exam;
            Area = area;
        }
    }
}
