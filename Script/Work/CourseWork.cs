using System.Collections.Generic;

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
