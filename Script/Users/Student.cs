using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class Student : GetInfo
    {
        public  string name { get; private set; }
        public int age { get; private set; }
        public string group { get; private set; }
        public LearnPath myLearningPath { get; private set; }


        public Student(string _name, int _age, string _group, LearnPath _myLearningPath) 
        {
            name = _name;
            age = _age;
            group = _group;
            myLearningPath = _myLearningPath;
        }

        public void SignIn()
        {
            UI.Print("Учетная запись Студ.");
            UI.Print("Добро пожаловать: " + GetShortInfo() + "!");
            UI.SpaceLine(1);

            if (myLearningPath.EnoughOptionalCourses() == false) 
            {
                UI.PrintWarning("Внимание! Ваше количество необязательных дисциплин меньше чем число N\n" +
                    "Настоятельно рекомендуем добавить себе новую дисциплину!!!");
            }

            StartMenu();


            // Может просматривать свои курсы 
            // Получать оповещение если изменились обязательные курсы или изменилось число N
            // Добавлять новые необязательные дисциплины себе
        }

        public void StartMenu()
        {
            string str = "Функции: " + "\n" +
                "\t1. Просмотреть все свои дисциплины\n" +
                "\t2. Добавить новые необязательные дисциплины\n" +
                "\t3. Выйти\n";

            int inputUser = UI.InputSecurityRangeInt(1, 3, str);

            UI.Clear();

            switch (inputUser)
            {
                case 1:
                    myLearningPath.PrintCourses();
                    StartMenu();
                    break;
                case 2:
                    myLearningPath.PrintCourses();
                    StartMenu();
                    break;
                case 3:
                    App.SignIn();
                    break;

                default:
                    UI.PrintWarning("Ошибка!");
                    App.SignIn();
                    break;
            }
        }


        public string GetFullInfo()
        {
            return ("Студент\n" + 
                    "Имя: " + name + "\n" +
                    "Возраст: " + age + "\n" +
                    "Группа: " + group + "\n" 
                    );
        }

        public string GetShortInfo() 
        {
            return name;
        }
    }



}
