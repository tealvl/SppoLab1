using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class Administrator
    {
        public static Student CreateStudent(string name, int age, string group)
        {
            Student Petya = new Student(name, age, group, new LearnPath());

            ID x = Petya.ID;

            UI.Print(x.ToString());

            return Petya;
        }

    }
}
