using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_OOP_Abstraction
{
    internal class CouseSoftSkills : Course
    {
        // Overrided Classification
        internal override string Classification { get; set; }
        // Properties
        public string Area { get; set; }

        // Constructors
        internal CouseSoftSkills() : base()
        {     
            Area = string.Empty;
            Classification = string.Empty;
        }

        internal CouseSoftSkills(int courseId, string area, string courseName, string classification) : base(courseId, courseName)
        {
            Classification = classification;
            Area = area;
        }


        // Lista tambem a área e a classificação
        internal override void CourseList()
        {
            Console.WriteLine("ID: {0} \nName: {1} \nClassificaion: {2} \nArea: {3}", CourseId, CourseName, Classification, Area);
        }

        internal override void Billing()
        {
            Console.WriteLine("Vou faturar\n");
        }
    }
}
