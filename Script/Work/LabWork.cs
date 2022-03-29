using System.Collections.Generic;

namespace SppoLab1
{
    class LabWork : Work
    {
        public LabWork(string _name, string _workDiscription) 
            : base(_name, _workDiscription, "Лабараторная работа") {}

        public LabWork() : base() 
        {
            typeWork = "Лабараторная работа";
            listTask = new List<Task>();
        }
    }
}
