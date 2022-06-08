using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Não se pode instanciar diretamente uma classe abstrada
            // Course course01 = new Course();

            CouseSoftSkills course02 = new CouseSoftSkills(1,"Devs", "C#", "Top");

            course02.CourseList();
            Console.ReadLine();
        }
    }
}
