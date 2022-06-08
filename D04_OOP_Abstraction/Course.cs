using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_OOP_Abstraction
{
    abstract internal class Course
    {
        // Properties

        internal int CourseId { get; set; }
        internal string CourseName { get; set; }
        internal abstract string Classification { get; set; }

        // Constructors

        internal Course()
        {
            CourseId = 0;
            CourseName = string.Empty;
        }

        internal Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }

        // Methods

        // Metodo para ser substituido nas classes derivadas --> polimorfismo = override

        internal virtual void CourseList()
        {
            Console.WriteLine("ID: {0} \nName: {1} \n", CourseId, CourseName);
        }

        internal abstract void Billing();

    }
}
