using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_OOP_Inheritance
{
    /*
     * (Based Class)     Pessoa   
     * (Derived Classes)    - Cliente
     *                      - Fornecedor
     *                      - Funcionario
     *                          - Interno
     *                          - Externo
     *                          - Estagiario
     *                          
     * Não colocar o que é comum a todas elas
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course01 = new Course(1, "Networking");
            course01.ListCourse($"ID: {course01.CourseId} \nName: {course01.CourseName}\n");

            CourseSoftSkills course02 = new CourseSoftSkills(1, "Ticket to your next job", "Job");
            course02.ListCourse($"ID: {course02.CourseId} \nName: {course02.CourseName} \nArea: {course02.Area}");

            CourseIT course03 = new CourseIT(1, "JavaScript Web Developer", "Dev", true);
            course03.ListCourse($"ID: {course03.CourseId} \nName: {course03.CourseName} \nArea: {course03.Area} \nExam: {course03.Exam}");

            Console.WriteLine();
        }
    }
}
