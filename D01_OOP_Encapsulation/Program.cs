using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso course01 = new Curso();

            course01.CourseName = "C#";
            course01.CourseId = 1;

            course01.ListCourse();
            Console.ReadLine();
        }
    }
}
