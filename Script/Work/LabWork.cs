using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class LabWork : Work
    {
        public LabWork(string _name, string _workDiscription) 
            : base(_name, _workDiscription, "Лабараторная работа") {}

        public LabWork() 
        {
            typeWork = "Лабараторная работа";
            listTask = new List<Task>();
        }
    }
}
