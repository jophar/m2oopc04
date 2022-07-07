using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08_Advanced
{
    internal class ClassEventTest
    {
        public void TestEvent()
        {
            ClassEvent myLesson = new ClassEvent();

            myLesson.MyLesson += MyTestEvent;
            myLesson.MyLesson -= MyTestEvent;
        }

        public void MyTestEvent(object sender, EventArgs e)
        { }
    }
}
