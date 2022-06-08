using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP_Encapsulation
{
    internal class Curso
    {
        internal int CourseId { get; set; }

        private string courseName;

        internal string CourseName
        {
            get { return courseName; }   
            set { courseName = value; }
        }

        internal Curso()
        {
            CourseId = 0;
            CourseName = string.Empty;
        }

        internal Curso(int id, string name)
        {
            CourseId = id;
            CourseName = name;
        }   

        internal void ListCourse()
        {
            Console.WriteLine($"Course ID: {CourseId}\nCourse Name: {CourseName}\n");

        }

    }
}
