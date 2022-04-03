using System;
using System.Collections.Generic;

namespace SppoLab1
{
    public class BranchCourse : CourseTest, GetInfo, ICourse
    {
        private List<Course> coursesInBranch = new List<Course>();
        private Course selectCourse = null;

        public BranchCourse(List<Course> _coursesInBranch) 
        {
            coursesInBranch = _coursesInBranch;
        }

        public BranchCourse() 
        {
            coursesInBranch = new List<Course>();
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
                    str += coursesInBranch[i].GetShortInfo();

                    if (i != coursesInBranch.Count - 1)
                    {
                        str += "\x1b[38;5;196m   ИЛИ   \x1b[0m";
                    }
                }

                return str;
            }
            else
            {
                return selectCourse.GetShortInfo();
            }

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
                return selectCourse; 
            }
        }

        public void AddCource(Course course) 
        {
            coursesInBranch.Add(course);
        }
    }
}
