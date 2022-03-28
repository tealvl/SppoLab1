using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1.Script.Course.CourseCreator
{
    class CourseBuilder: AbstractCourseBuilder
    {
        CourseBuilder()
        {
            course = new Course();
        }

        public void SetName(string _name)
        {
            course.Name = _name;
        }

        public void SetWorkDiscription(string _workDiscription)
        {
            course.CourseDiscription = _workDiscription;
        }

        public void AddWork(Work _someWork)
        {
            course.AddWork(_someWork);
        }

        public void Reset()
        {
            course = new Course();
        }
    }
}
