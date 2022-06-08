using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_OOP_Inheritance
{
    internal class CourseSoftSkills : Course
    {
        internal string Area { get; set; }

        internal CourseSoftSkills() : base()
        {
            Area = string.Empty;
        }

        internal CourseSoftSkills(int courseId, string nome, string area) : base(courseId, nome)
        {
            CourseId = courseId;
            CourseName = nome;
            Area = area;
        }
    }
}
