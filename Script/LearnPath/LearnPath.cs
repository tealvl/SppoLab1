using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class LearnPath : GetInfo
    {
        static private List<ReqirementCourse> reqiremetCourses;
        static private uint minNumOptionalCourses;
        
        private List<OptionalCourse> optionalCourses;


        public LearnPath()
        {
            optionalCourses = new List<OptionalCourse>();
        }


        public void AddOptionalCourses() 
        {
            //------------------------------------------------------------
        }

        public bool CheckNormalCountMinNumOptionalCoursesIfAllOkReturnTrueElseReturnFalse() 
        {
            return minNumOptionalCourses <= optionalCourses.Count;
        }

        public void PrintCourses() 
        {
            if (GetCountCourses() <= 0)
            {
                UI.Print("У вас нет никаких дисциплин!");
                return;
            }

            UI.Print(GetFullInfo());

            while (true)
            {
                string str = "Напишите номер работы, которую хотите посмотреть подробнее (0 чтобы вернуться назад)";

                int inputUser = UI.InputSecurityRangeInt(0, GetCountCourses(), str);

                if (inputUser == 0)
                {
                    return;
                }
                else
                {
                    if (inputUser >= reqiremetCourses.Count) 
                    {
                        UI.Print(optionalCourses[reqiremetCourses.Count - inputUser].GetFullInfo());
                    }
                    else 
                    {
                        UI.Print(reqiremetCourses[inputUser].GetFullInfo());
                    }
                }
            }
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
                str += (i + 1 + reqiremetCourses.Count).ToString() + optionalCourses[i].GetShortInfo() + "\n";
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

        static public void UpdateRequirements(uint _minNumOptionalCourses, List<ReqirementCourse> _reqiremetCourses)
        {
            reqiremetCourses = _reqiremetCourses;
            minNumOptionalCourses = _minNumOptionalCourses;
        }

        public int GetCountCourses() 
        {
            return reqiremetCourses.Count + optionalCourses.Count;
        }

        public enum typeCourses 
        {
            Optional,
            Reqirement
        }
    }
}
