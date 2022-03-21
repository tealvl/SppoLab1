using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class Work
    {
        public readonly string name;
        public readonly string workDiscription;
        private List<Task> listTask;

        public Work(string _name, string _workDiscription) 
        {
            name = _name;
            workDiscription = _workDiscription;
        }

        public string GetFullInfo() 
        {
            string str = workDiscription +
                "\n" + "'" + name + "'" + "\n" +
                "Задания:" + "\n";
                

            for (int i = 0; i < listTask.Count; i++)
            {
                str += "\t" + listTask[i].text + "\n";
            }


            return str;
        }

        public void AddTask(Task _task) 
        {
            listTask.Add(_task);
        }
    }

}
