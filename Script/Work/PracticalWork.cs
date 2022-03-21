using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class PracticalWork : Work
    {
        public PracticalWork(string _name, string _workDiscription)
            : base(_name, _workDiscription, "Практическая работа") { }

        public PracticalWork() 
        {
            workDiscription = "Практическая работа";
            listTask = new List<Task>();
        }
    }
}
