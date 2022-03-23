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
        }


        public void StartMenu() 
        {
            string str = "Функции: " + "\n" +
                "\t1. Курсы\n" +
                "\t2. Работы\n" +
                "\t3. Выйти\n";

            int inputUser = UI.InputSecurityRangeInt(1, 3, str);

            UI.Clear();

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
            string str = "Функции: " + "\n" +
                "\t1. Посмотреть все свои работы\n" +
                "\t2. Создать новую работу\n" +
                "\t3. Назад\n";

            int inputUser = UI.InputSecurityRangeInt(1, 3, str);

            UI.Clear();

            switch (inputUser)
            {
                case 1:
                    PrintAllWork();
                    break;
                case 2:
                    CreateNewWork();
                    break;
                case 3:
                    UI.Clear();
                    StartMenu();
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
                return;
            }

            UI.Print("Ваши работы:");

            for (int i = 0; i < myWork.Count; i++)
            {
                UI.Print((i + 1).ToString() + "." +  myWork[i].GetShortInfo());  
            }

            while (true)
            {
                string str = "Напишите номер работы, которую хотите посмотреть подробнее (0 чтобы вернуться назад)";

                int inputUser = UI.InputSecurityRangeInt(0, myWork.Count, str);

                if (inputUser == 0)
                {
                    WorkMenu();
                    return;
                }
                else
                {
                    UI.Print(myWork[inputUser - 1].GetFullInfo());
                }
            }
        }

        public void CreateNewWork()
        {
            UI.Clear();

            string str = "Добавить работу: " + "\n" +
                "\t1. Лабараторную\n" +
                "\t2. Практическую\n" +
                "\t3. Курсовую\n" +
                "\t4. Назад\n";

            int inputUser = UI.InputSecurityRangeInt(1, 4, str);

            switch (inputUser)
            {
                case 1:
                    builder = new LabWorkBuilder();
                    break;
                case 2:
                    builder = new PracticalWorkBuilder();
                    break;
                case 3:
                    builder = new CourseWorkBuilder();
                    break;
                case 4:
                    WorkMenu();
                    break;

                default:
                    UI.PrintWarning("Ошибка!");
                    App.SignIn();
                    break;
            }

            while (true) 
            {
                UI.Clear();

                UI.Print(builder.GetInfo());

                string str1 = "1. Изменить имя" + "\n" +
                              "2. Изменить описание\n" +
                              "3. Добавить Задание\n" +
                              "4. Сохранить";


                int inputUser1 = UI.InputSecurityRangeInt(1, 4, str1);

                string inputUserStr;

                switch (inputUser1)
                {
                    case 1:
                        UI.Print("Новое имя: ");
                        inputUserStr = UI.InputeString(); 
                        builder.SetName(inputUserStr);
                        break;
                    case 2:
                        UI.Print("Новое описание: ");
                        inputUserStr = UI.InputeString();
                        builder.SetWorkDiscription(inputUserStr);
                        break;
                    case 3:
                        UI.Print("Новое задние: ");
                        inputUserStr = UI.InputeString();
                        builder.AddTask(inputUserStr);
                        break;
                    case 4:
                        myWork.Add(builder.GetResult());
                        UI.Clear();
                        WorkMenu();
                        break;

                    default:
                        UI.PrintWarning("Ошибка!");
                        App.SignIn();
                        break;
                }
            }
        }


        public void CourseMenu()
        {
            UI.Clear();

            string str = "Функции: " + "\n" +
                "\t1. Посмотреть все свои курсы\n" +
                "\t2. Добавить работу в курс\n" +
                "\t3. Назад\n";

            int inputUser = UI.InputSecurityRangeInt(1, 3, str);

            switch (inputUser)
            {
                case 1:
                    PrintAllCourse();
                    break;
                case 2:
                    AddWorkInCourse();
                    break;
                case 3:
                    UI.Clear();
                    StartMenu();
                    break;

                default:
                    UI.PrintWarning("Ошибка!");
                    App.SignIn();
                    break;
            }
        }

        public void AddWorkInCourse()
        {
            // -------------------------------------------
        }

        public void PrintAllCourse()
        {
            if (myCourses.Count <= 0)
            {
                UI.Print("У вас нет курсов!");
                CourseMenu();
                return;
            }

            UI.Clear();

            UI.Print("Ваши курсы:");

            for (int i = 0; i < myCourses.Count; i++)
            {
                UI.Print((i + 1).ToString() + myCourses[i].GetShortInfo());
            }

            while (true)
            {
                string str = "Напишите номер курса, который хотите посмотреть подробнее (0 чтобы вернуться назад)";

                int inputUser = UI.InputSecurityRangeInt(0, myCourses.Count, str);

                if (inputUser == 0)
                {
                    CourseMenu();
                    return;
                }
                else
                {
                    UI.Print(myCourses[inputUser - 1].GetFullInfo());
                }
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
