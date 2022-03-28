using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class LearnPath : GetInfo
    {
        //private List<CourseTest> myCourses;

        private List<ICourse> myCourses;

        public void CreateLearnPath() 
        {
            for (int i = 0; i < myCourses.Count; i++)
            {
                myCourses[i].SelectCourse();
            }

        }

        public string GetFullInfo()
        {
            throw new NotImplementedException();
        }

        public string GetShortInfo()
        {
            string str = "";

            for (int i = 0; i < myCourses.Count; i++)
            {
                str += ((GetInfo)myCourses[i]).GetShortInfo() +  "\n";
            }

            return str;
        }

        public bool EnoughOptionalCourses() 
        {
            return false;
        }

        public void PrintCourses() 
        {

        }

        public LearnPath(List<ICourse> _myCourses) 
        {
            myCourses = _myCourses;
        }

        /*
        static private List<ReqirementCourse> reqiremetCourses;
        static private uint minNumOptionalCourses;
        
        private List<OptionalCourse> optionalCourses;

        private List<OptionalCourse> optionalCoursesNON;

        public LearnPath()
        {
            optionalCourses = new List<OptionalCourse>();
            optionalCoursesNON = new List<OptionalCourse>();
            minNumOptionalCourses = 0;
            reqiremetCourses = new List<ReqirementCourse>();
        }

        public void AddNewCourses()
        {
            if (optionalCoursesNON.Count <= optionalCourses.Count) 
            {
                UI.PrintWarning("У вас нет новых курсов на которые можно подписаться!");
                return;
            }

            UI.Print("Список необязательных дисциплин на которые вы еще не подписаны:");

            List<OptionalCourse> optionalCoursesFree = new List<OptionalCourse>();

            for (int i = 0; i < optionalCoursesNON.Count; i++)
            {
                if (optionalCourses.Contains(optionalCoursesNON[i]) == false) 
                {
                    optionalCoursesFree.Add(optionalCoursesNON[i]);
                }
            }

            string str = "";

            for (int i = 0; i < optionalCoursesFree.Count; i++)
            {
                str += (i + 1).ToString() + optionalCoursesFree[i].GetShortInfo() + "\n";
            }

            UI.Print(str);

            while (true)
            {
                UI.Print("Выберите какую дисциплину хотите добавить (напишите 0 чтобы вернуться назад");
                int inputUser = UI.InputSecurityRangeInt(0, optionalCoursesFree.Count);

                if (inputUser == 0) 
                {
                    return;
                }

                AddOptionalCourses(optionalCoursesFree[inputUser - 1]);
            }
        }

        public void AddOptionalCourses(OptionalCourse _optionalCourse) 
        {
            if (optionalCourses.Contains(_optionalCourse)) 
            {
                UI.PrintWarning("Такой дополнительный курс уже есть!");
                return;
            }

            optionalCourses.Add(_optionalCourse);
        }

        public bool EnoughOptionalCourses() 
        {
            return minNumOptionalCourses <= optionalCourses.Count;
        }

        public void PrintCourses() 
        {
            UI.Clear();

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
        */
    }
}
