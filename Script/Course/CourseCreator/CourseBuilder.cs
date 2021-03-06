using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class CourseBuilder//: ICourseBuilder
    {
        private Course course;

        public CourseBuilder()
        {
            course = new Course();
        }

        public void SetName(string _name)
        {
            course.Name = _name;
        }

        public void SetCourseDiscription(string _workDiscription)
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

        public Course GetResult() 
        {
            return course;
        }

    }
}
