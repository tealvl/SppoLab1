using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class Course : GetInfo, ICourse
    {
        private string name;
        private string сourseDiscription;
        private List<Work> works;

        public Course(string _name, string _CourseDiscritption)
        {
            name = _name;
            сourseDiscription = _CourseDiscritption;
            works = new List<Work>();
        }

        public Course() 
        {
            name = "";
            сourseDiscription = "";
            works = new List<Work>();
        }

        public string GetFullInfo()
        {
            string str =
                "Дисциплина:" + "'" + name + "'" + "\n" +
                "Описание: " + сourseDiscription + "\n" +
                "Работы:" + "\n";


            for (int i = 0; i < works.Count; i++)
            {
                str += "\t" + (i + 1).ToString() + ". " + works[i].GetShortInfo() + "\n";
            }


            return str;
        }

        public string GetShortInfo()
        {
            return name;
        }

        public void AddWork(Work _work)
        {
            if (works.Contains(_work))
            {
                UI.PrintWarning("Такая работа уже добавлена в курс!");
                return;
            }
            works.Add(_work);
        }

        public Course SelectCourse()
        {
            return this;
        }


        public string Name
        {
            get { return name; }

            set
            {
                if (value.Length <= 2 || value.Length >= 200)
                {
                    UI.PrintWarning("Имя курса должно быть от 2 до 200 символов!");
                }
                else
                {
                    name = value;
                }

            }
        }

        public string CourseDiscription
        {
            get { return сourseDiscription; }

            set
            {
                if (value.Length <= 10 || value.Length >= 1000)
                {
                    UI.PrintWarning("Описание курса должно быть от 10 до 1 000 символов!");
                }
                else
                {
                    сourseDiscription = value;
                }
            }
        }


        /*
        
        interface ICourseState:
            public Course Select();

        ------------------------------------------

        class BranchCourse: ICourseState
            private List<Course> Course;

            public Course Select()
            {
                for i in range...
            }

        -----------------------------------------

        class Course: ICourseState
            private List<Work> work;

            public Course Select()
            {
                return this;
            }

        ----------------------------------------



        */





    }
}
