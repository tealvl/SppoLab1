using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class LabWorkBuilder : IWorkBuilder
    {
        private LabWork work;

        LabWorkBuilder()
        {
            work = new LabWork();
        }

        public void Reset()
        {
            work = new LabWork();
        }

        public LabWork GetResult()
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
