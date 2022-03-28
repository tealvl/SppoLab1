using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class BranchCourse : CourseTest 
    {
        private List<Course> coursesInBranch = new List<Course>();
        private Course selectCourse = null;


        public BranchCourse(List<Course> _coursesInBranch) 
        {
            coursesInBranch = _coursesInBranch;
        }

        public string GetFullInfo()
        {
            if (selectCourse == null)
            {
                string str = "";

                for (int i = 0; i < coursesInBranch.Count; i++)
                {
                    str += coursesInBranch[i].GetFullInfo() + "\n";
                }

                return str;
            }
            else
            {
                for (int i = 0; i < coursesInBranch.Count; i++)
                {
                    if (coursesInBranch[i] == selectCourse)
                    {
                        UI.PrintWithColor(coursesInBranch[i].GetFullInfo() + "\t", ConsoleColor.Green, false);
                    }
                    else
                    {
                        UI.Print(coursesInBranch[i].GetFullInfo() + "\t", false);
                    }
                }
            }

            return "";
        }

        public string GetShortInfo()
        {
            if (selectCourse == null) 
            {
                string str = "";

                for (int i = 0; i < coursesInBranch.Count; i++)
                {
                    //str += (i + 1).ToString() + ". " + coursesInBranch[i].GetShortInfo();
                    str += coursesInBranch[i].GetShortInfo() + "\n";
                }

                return str;
            }
            else 
            {
                for (int i = 0; i < coursesInBranch.Count; i++)
                {
                    // Костыльно - да. Надо ESC-последовательности как в С++, но тут я не знаю как они работают 
                    if (coursesInBranch[i] == selectCourse) 
                    {
                        UI.PrintWithColor(coursesInBranch[i].GetShortInfo() + "\t", ConsoleColor.Green, false);
                    }
                    else 
                    {
                        UI.Print(coursesInBranch[i].GetShortInfo() + "\t", false);
                    }
                }
            }

            return "";
        }

        public Course SelectCourse()
        {
            if (selectCourse == null) 
            {
                if (coursesInBranch.Count == 1)
                    return coursesInBranch[0];

                UI.Print(GetShortInfo());

                int inputuser = UI.InputSecurityRangeInt(1, coursesInBranch.Count, "Выберите курс");

                selectCourse = coursesInBranch[inputuser - 1];

                return selectCourse;
            }
            else 
            {
                UI.Print("Вы хотите выбрать другую ветку? А так пока нельзя...");
                return new Course("","");
            }
        }

        public void AddCouse(Course course) 
        {
            coursesInBranch.Add(course);
        }
    }
}
