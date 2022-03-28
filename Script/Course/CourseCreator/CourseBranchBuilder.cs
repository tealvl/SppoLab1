using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class CourseBranchBuilder: ICourseBuilder
    {
        private CourseBranchBuilder course;

        public ICourse GetResult()
        {
            return course;
        }
      
        CourseBranchBuilder()
        {
            course = new CourseBranch();
        }

        public void Reset()
        {
            course = new CourseBranch();
        }

        public void AddCourse(Course _someCourse)
        {
            course.AddCource(_someCourse);
        }

        public string GetInfo()
        {
            return course.GetFullInfo();
        }
    }
}
