using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Polymorphism
{
    internal class Course
    {
        /*
         * Polumorphism
         * The same method
         * The same method with different signatures
         */
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
        // metodo virtual
        internal virtual void ListCourse()
        {
            Console.WriteLine($"Course ID: {CourseId}\nCourse Name: {CourseName}");
        }
    }
}
