using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public abstract class WorkBuilder
    {
        protected Work work;

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

        public Work GetResult()
        {
            return work;
        }

        public string GetInfo() 
        {
            return work.GetFullInfo();
        }
        
    }
}
