using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    interface IWorkBuilder
    {
        public void Reset();

        public void AddTask(string _taskText);

        public void SetName(string _name);

        public void SetWorkDiscription(string _workDiscription);
    }
}
