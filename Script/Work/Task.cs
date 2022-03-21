using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class Task : GetInfo
    {
        private string text;

        public Task(string str) 
        {
            text = str;
        }

        public string GetFullInfo() 
        {
            return text;
        }

        public string GetShortInfo()
        {
            return text;
        }
    }
}
