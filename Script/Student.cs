using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class Student
    {
        public  string name { get; private set; }
        public int age { get; private set; }
        public string group { get; private set; }
        public ID ID { get; private set; }
        public LearnPath myLearningPath { get; private set; }


        public Student(string _name, int _age, string _group, LearnPath _myLearningPath) 
        {
            name = _name;
            age = _age;
            group = _group;
            myLearningPath = _myLearningPath;

            ID = IDManager.CreateNewId(typeID.Student, this);
        }

        public override string ToString()
        {
            return ("Имя: " + name + "\n" +
                    "Возраст: " + age + "\n" +
                    "Группа: " + group + "\n" 
                    );
        }

    }



}
