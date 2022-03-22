using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class Teacher : GetInfo
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public string specialization { get; private set; }

        private List<Course> myCourses;
        private List<Work> myWork;
        private WorkBuilder builder;

        public Teacher(string _name, string _specialization, int _age) 
        {
            name = _name;
            specialization = _specialization;
            age = _age;

            myCourses = new List<Course>();
            myWork = new List<Work>();
            builder = new WorkBuilder();
        }

        public void SignIn()
        {
            UI.Print("Учетная запись преподователя.");
            UI.Print("Добро пожаловать: " + GetShortInfo() + "!");
            UI.SpaceLine(1);
            StartMenu();

            


            // Создавать 3 работ
            // Посмотреть все свои курсы
            // Для каждого курса может добавить свою работу

            
        }


        public void StartMenu() 
        {
            UI.Clear();

            string str = "Функции: " + "\n" +
                "\t1. Курсы\n" +
                "\t2. Работы\n" +
                "\t3. Выйти\n";

            int inputUser = UI.InputSecurityRangeInt(1, 3, str);

            switch (inputUser)
            {
                case 1:
                    CourseMenu();
                    break;
                case 2:
                    WorkMenu();
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

        public void WorkMenu() 
        {
            UI.Clear();

            string str = "Функции: " + "\n" +
                "\t1. Посмотреть все свои работы\n" +
                "\t2. Создать новый курс\n" +
                "\t3. Назад\n" +
                "\t4. Выйти\n";

            int inputUser = UI.InputSecurityRangeInt(1, 4, str);

            switch (inputUser)
            {
                case 1:
                    PrintAllWork();
                    break;
                case 2:
                    //
                    break;
                case 3:
                    StartMenu();
                    break;
                case 4:
                    App.SignIn();
                    break;

                default:
                    UI.PrintWarning("Ошибка!");
                    App.SignIn();
                    break;
            }
        }

        public void PrintAllWork() 
        {
            if (myWork.Count <= 0) 
            {
                UI.Print("У вас нет работ!");
                WorkMenu();
            }

            UI.Clear();

            UI.Print("Ваши работы:");

            for (int i = 0; i < myWork.Count; i++)
            {
                UI.Print((i + 1).ToString() +  myWork[i].GetShortInfo());  
            }

            while (true)
            {
                string str = "Напишите число работы, которую хотите посмотреть подробнее (0 чтобы вернуться назад)";

                int inputUser = UI.InputSecurityRangeInt(0, myWork.Count + 1, str);

                if (inputUser == 0)
                {
                    WorkMenu();
                }
                else
                {
                    UI.Print(myWork[inputUser - 1].GetFullInfo());
                }
            }
        }

        public void CourseMenu()
        {
            UI.Clear();

            string str = "Функции: " + "\n" +
                "\t1. Посмотреть все свои курсы\n" +
                "\t2. Добавить работу в курс\n" +
                "\t3. Назад\n" +
                "\t4. Выйти\n";

            int inputUser = UI.InputSecurityRangeInt(1, 4, str);

            switch (inputUser)
            {
                case 1:
                    //
                    break;
                case 2:
                    //
                    break;
                case 3:
                    StartMenu();
                    break;
                case 4:
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
            return ("Преподаватель\n" +
                    "Имя: " + name + "\n" +
                    "Возраст: " + age + "\n" +
                    "Специализация: " + specialization + "\n"
                    );
        }

        public string GetShortInfo() 
        {
            return name;
        }

    }
}
