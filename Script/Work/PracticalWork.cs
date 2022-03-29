using System.Collections.Generic;

namespace SppoLab1
{
    class PracticalWork : Work
    {
        public PracticalWork(string _name, string _workDiscription)
            : base(_name, _workDiscription, "Практическая работа") { }

        public PracticalWork() 
        {
            typeWork = "Практическая работа";
            listTask = new List<Task>();
        }
    }
}
