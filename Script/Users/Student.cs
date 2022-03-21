using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class Student : GetInfo
    {
        public  string name { get; private set; }
        public int age { get; private set; }
        public string group { get; private set; }
        public LearnPath myLearningPath { get; private set; }


        public Student(string _name, int _age, string _group, LearnPath _myLearningPath) 
        {
            name = _name;
            age = _age;
            group = _group;
            myLearningPath = _myLearningPath;
        }

        public string GetFullInfo()
        {
            return ("Студент\n" + 
                    "Имя: " + name + "\n" +
                    "Возраст: " + age + "\n" +
                    "Группа: " + group + "\n" 
                    );
        }

        public string GetShortInfo() 
        {
            return name;
        }
    }



}
