using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class Teacher
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public string specialization { get; private set; }
        //public int ID { get; private set; }
        public LearnPath myLearningPath { get; private set; }

        //private List<Course> courses;


    }
}
