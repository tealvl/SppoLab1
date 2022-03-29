using System;
using System.Collections.Generic;

namespace SppoLab1
{
    public class LearnPath : GetInfo
    {
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
                str += (i+1).ToString() + ". " + ((GetInfo)myCourses[i]).GetShortInfo() +  "\n";
            }

            return str;
        }

        public LearnPath(List<ICourse> _myCourses) 
        {
            myCourses = _myCourses;
        }

        public void PrintDetails() 
        {
            string str = "Введите номер курса который хотите просмотреть подробнее (0 чтобы вернуться назад)";

            while (true) 
            {
                UI.Clear();

                UI.Print(GetShortInfo());

                int inputUser = UI.InputSecurityRangeInt(0, myCourses.Count, str);

                if (inputUser == 0) 
                {
                    return;
                }
                
                myCourses[inputUser - 1].SelectCourse().PrintDetails();
            }
        }

    }
}
