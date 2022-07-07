using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08_Advanced
{
    internal class ClassEvent
    {
        public delegate void MyEventHandler(object sender, EventArgs e);

        public event MyEventHandler MyLesson
        {
            add
            {
                Console.WriteLine("Lesson Started!");
            }

            remove
            {
                Console.WriteLine("Lesson Ended!");
            }
        }
    }
}
