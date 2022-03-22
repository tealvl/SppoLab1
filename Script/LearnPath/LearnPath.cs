using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class LearnPath : GetInfo
    {
        private List<OptionalCourse>  optionalCourses;
        private List<ReqirementCourse> reqiremetCourses;
        private uint minNumOptionalCourses;

        public LearnPath()
        {
            optionalCourses = new List<OptionalCourse>();
            minNumOptionalCourses = 0;
        }


        public void AddOptionalCourses() 
        {
            //------------------------------------------------------------
        }

        public bool CheckNormalCountMinNumOptionalCoursesIfAllOkReturnTrueElseReturnFalse() 
        {
            return minNumOptionalCourses <= optionalCourses.Count;
        }

        public string GetInfoCourses(int count, typeCourses typeCourses) 
        {
            string str = "Что-то пошло не так";

            switch (typeCourses)
            {
                case typeCourses.Optional:
                    str = optionalCourses[count].GetFullInfo();
                    break;
                case typeCourses.Reqirement:
                    str = reqiremetCourses[count].GetFullInfo();
                    break;
                default:
                    UI.PrintWarning("Не понятный тип курса");
                    break;
            }

            return str;
        }

        public string GetFullInfo()
        {
            string str = "Обязательные дисциплины:\n";

            for (int i = 0; i < reqiremetCourses.Count; i++)
            {
                str += (i + 1).ToString() + reqiremetCourses[i].GetShortInfo() + "\n";
            }

            str += "\nДополнительные дисциплины:\n";

            for (int i = 0; i < optionalCourses.Count; i++)
            {
                str += (i + 1).ToString() + optionalCourses[i].GetShortInfo() + "\n";
            }

            return str;
        }

        public string GetShortInfo() 
        {
            return "Количетсво Обязательных курсов: " + reqiremetCourses.Count +
                "\n Количество Дополнительных курсов: " + optionalCourses.Count; 
        }

        public uint MinNumOptionalCourses 
        {
            get { return minNumOptionalCourses; }
            set
            {
                //if (value > CourseRegistrator.CountCourses()) Сначала нужно написать этот класс....
                if (value > 1000000000)
                {
                    UI.PrintWarning("Невозможно поставить такое количество минимальных курсов!");
                }
                else 
                {
                    minNumOptionalCourses = value;
                }

            }
        }

        public enum typeCourses 
        {
            Optional,
            Reqirement
        }
    }
}
