using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_OOP_Inheritance
{
    internal class Course
    {
        internal int CourseId { get; set; }

        private string courseName;

        internal string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        internal Course()
        {
            CourseId = 0;
            CourseName = string.Empty;
        }

        internal Course(int id, string name)
        {
            CourseId = id;
            CourseName = name;
        }

        internal void ListCourse(string message)
        {
            Console.WriteLine(message);

        }
    }
}
