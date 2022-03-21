using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class CourseWorkBuilder : IWorkBuilder
    {

        private CourseWork work;

        CourseWorkBuilder()
        {
            work = new CourseWork();
        }

        public void Reset()
        {
            work = new CourseWork();
        }

        public CourseWork GetResult()
        {
            return work;
        }

        public void AddTask(string _taskText)
        {
            work.AddTask(new Task(_taskText));
        }

        public void SetName(string _name)
        {
            work.Name = _name;
        }

        public void SetWorkDiscription(string _workDiscription)
        {
            work.WorkDiscription = _workDiscription;
        }
    }
}
