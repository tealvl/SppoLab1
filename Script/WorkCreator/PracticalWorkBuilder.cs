using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class PracticalWorkBuilder : IWorkBuilder
    {
        private PracticalWork work;

        PracticalWorkBuilder()
        {
            work = new PracticalWork();
        }

        public void Reset()
        {
            work = new PracticalWork();
        }

        public PracticalWork GetResult()
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
