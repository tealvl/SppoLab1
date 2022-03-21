﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class Course : GetInfo
    {
        private string name;
        private string CourseDiscription;
        private List<Work> works;
        //private Teacher teacher;

        public Course(string _name) 
        {
            name = _name;
        }

        public string GetFullInfo()
        {
            string str =
                "Дисциплина:" + "'" + name + "'" + "\n" +
                "Описание: " + CourseDiscription + "\n" +
                "Работы:" + "\n";


            for (int i = 0; i < works.Count; i++)
            {
                str += "\t" + i.ToString() + ". " + works[i].GetShortInfo() + "\n";
            }


            return str;
        }

        public string GetShortInfo() 
        {
            return name;
        }

        public void AddWork(Work _work) 
        {
            works.Add(_work);
        }
    }
}