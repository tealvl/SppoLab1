using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class CourseWork : Work
    {
        public CourseWork(string _name, string _workDiscription)
            : base(_name, _workDiscription, "Курсовая работа") { }

        public CourseWork() 
        {
            typeWork = "Курсовая работа";
            listTask = new List<Task>();
        }
    }
}
