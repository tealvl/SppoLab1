using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public abstract class AbstractCourseBuilder
    {
        protected ICourse course;

        public ICourse GetResult()
        {
            return course;
        }

        public string GetInfo()
        {
            return course.GetFullInfo();
        }

    }
}
