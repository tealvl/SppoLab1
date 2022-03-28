using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SppoLab1
{
    static class Administrator
    {
        /*
        static private AccountRegistrator accountRegistrator = AccountRegistrator.Initialize();
        static private CourseRegistrator courseRegistrator = CourseRegistrator.Initialize(); 
        static private LearningPathRequirements learningPathRequirements = LearningPathRequirements.Initialize();


        static public void SignIn()
        {
            UI.Print("Учетная запись Администратора");


            StartMenu();
        }

        static public void StartMenu()
        {
            string str = "Функции: " + "\n" +
                "\t1. Зарегестрировать новый аккуант\n" +
                "\t2. Зарегестрировать новый курс\n" +
                "\t3. Изменить список обязательных дисциплин\n" +
                "\t4. Изменить минимальное количество необязательных курсов\n" +
                "\t5. Выйти\n";

            int inputUser = UI.InputSecurityRangeInt(1, 5, str);

            UI.Clear();

            switch (inputUser)
            {
                case 1:
                    CreateNewAccount();
                    break;
                case 2:
                    CreateNewCourses();
                    break;
                case 3:
                    ChangeReqirement();
                    break;
                case 4:
                    ChangeReqirement(); //?
                    break;
                case 5:
                    App.SignIn();
                    return;

                default:
                    UI.PrintWarning("Ошибка!");
                    App.SignIn();
                    break;
            }
        }

        public static void CreateNewCourses() 
        {
            string str = "Какой курс создать? (0 вернуться назад)\n" +
                "\t1. Обязательный\n" +
                "\t2. НЕ обязательный";


            while (true)
            {
                UI.Clear();
                int inputUser = UI.InputSecurityRangeInt(0, 2, str);
                
                if (inputUser == 0) 
                {
                    StartMenu();
                    return;
                }

                UI.Print("Имя курса:");
                string name = UI.InputeString();
                UI.Print("Описание курса:");
                string discription = UI.InputeString();

                if (inputUser == 1) 
                {
                    LearningPathRequirements.Initialize().AddRequirementCourse(CourseRegistrator.Initialize().CrateReqirementCourse(name, discription));
                    LearningPathRequirements.Initialize().UpdateLearnPathesRequirements();
                }
                else if (inputUser == 2) 
                {
                    CourseRegistrator.Initialize().CrateNewOptionalCourse(name, discription);
                }

            }
        }

        public static void ChangeReqirement()
        {
            UI.Clear();

            List<ReqirementCourse> reqCourses =  LearningPathRequirements.Initialize().GetReqiremetCourses();

            string str = "Список обязательных дисциплин:\n";

            if (reqCourses.Count == 0) 
            {
                str += "*Пусто*\n";
            }

            for (int i = 0; i < reqCourses.Count; i++)
            {
                str += (i + 1).ToString() + reqCourses[i].GetShortInfo() + "\n";
            }

            List<OptionalCourse> optCourses = LearningPathRequirements.Initialize().GetAllOptionalCourses();

            str += "\nСписок НЕобязательных дисциплин:\n";


            if (optCourses.Count == 0)
            {
                str += "*Пусто*\n";
            }

            for (int i = 0; i < optCourses.Count; i++)
            {
                str += (i + 1).ToString() + optCourses[i].GetShortInfo() + "\n";
            }

            UI.Print(str);

            string str1 = "Введите номер необязательной дисциплины, которую вы хотите сделать обязательной (0 для выхода):";

            while (true) 
            {
                int inputUser = UI.InputSecurityRangeInt(0, optCourses.Count, str1);

                if (inputUser == 0) 
                {
                    StartMenu();
                    return;
                }

                LearningPathRequirements.Initialize().AddRequirementCourse(optCourses[inputUser - 1]);
                LearningPathRequirements.Initialize().UpdateLearnPathesRequirements();
            }
        }

        public static void CreateNewAccount() 
        {
            
            string str = "Какой аккаунт создать? (0 вернуться назад)\n" +
                "\t1.Студент\n" +
                "\t2.Преподователь";

            while (true) 
            {
                UI.Clear();
                int inputUser = UI.InputSecurityRangeInt(0, 2, str);


                switch (inputUser)
                {
                    case 0:
                        StartMenu();
                        return;

                    case 1:
                        UI.Print("ФИО студента:");
                        string FIO = UI.InputeString();
                        UI.Print("Возраст студента:");
                        int age = int.Parse(UI.InputeString());
                        UI.Print("Группа студента:");
                        string group = UI.InputeString();

                        AccountRegistrator.Initialize().CreateStudent(FIO, age, group);

                        UI.Print("Новый студент зарегистрирован!");
                        break;

                    case 2:
                        UI.Print("ФИО преподователя:");
                        string FIO1 = UI.InputeString();
                        UI.Print("Возраст преподователя:");
                        int age1 = int.Parse(UI.InputeString());
                        UI.Print("Специализация преподователя:");
                        string group1 = UI.InputeString();

                        AccountRegistrator.Initialize().CreateTeacher(FIO1, group1, age1);
                        break;
                    default:
                        break;
                }
            }
        }



        private class AccountRegistrator
        {
            static private AccountRegistrator singletoneAccountRegistrator;
          
            private List<Teacher> teachers;
            private List<Student> students;

            AccountRegistrator()
            {
                teachers = new List<Teacher>();
                students = new List<Student>();
            }

            static public AccountRegistrator Initialize()
            {
                if (singletoneAccountRegistrator == null)
                    singletoneAccountRegistrator = new AccountRegistrator();

                return singletoneAccountRegistrator;
            }

            public void CreateTeacher(string _name, string _specialization, int _age)
            {
                Teacher teacher = new Teacher(_name, _specialization, _age);

                if (teachers.Contains(teacher) == true) 
                {
                    UI.PrintWarning("Такой аккаунт уже есть!");
                    return;
                }

                teachers.Add(teacher);
            }

            public void CreateStudent(string _name, int _age, string _group)
            {
                Student student = new Student(_name, _age, _group, new LearnPath());

                if (students.Contains(student) == true)
                {
                    UI.PrintWarning("Такой аккаунт уже есть!");
                    return;
                }

                students.Add(student);
            }

            public List<Teacher> GetListTeacher() 
            {
                return teachers;
            }

            public List<Student> GetListStudent()
            {
                return students;
            }
        }

        private class CourseRegistrator
        {
            static private CourseRegistrator singletoneCourseRegistrator;
          
            private List<ReqirementCourse> reqirementCourses;
            private List<OptionalCourse> optionalCourses;

            CourseRegistrator()
            {
                reqirementCourses = new List<ReqirementCourse>();
                optionalCourses = new List<OptionalCourse>();
            }

            public ReqirementCourse CrateReqirementCourse(string _name, string _description)
            {
                reqirementCourses.Add(new ReqirementCourse(_name, _description));
                LearningPathRequirements.Initialize().AddRequirementCourse(reqirementCourses[reqirementCourses.Count - 1]);
                return reqirementCourses[reqirementCourses.Count - 1];
            }
            public void CrateNewOptionalCourse(string _name, string _description)
            {
                optionalCourses.Add(new OptionalCourse(_name, _description));
                LearningPathRequirements.Initialize().AddOptionalCourse(optionalCourses[optionalCourses.Count - 1]);
            }

            static public CourseRegistrator Initialize()
            {
                if (singletoneCourseRegistrator == null)
                    singletoneCourseRegistrator = new CourseRegistrator();
                return singletoneCourseRegistrator;

            }

            public int CountCourses()
            {
                return reqirementCourses.Count + optionalCourses.Count;
            }
        }

        private class LearningPathRequirements
        {
            private List<ReqirementCourse> reqiremetCourses;
            private List<OptionalCourse> allOptionalCourses;
            private uint minNumOptionalCourses;

            static private LearningPathRequirements singletoneLearningPathRequirements;

            public LearningPathRequirements() 
            {
                reqiremetCourses = new List<ReqirementCourse>();
                allOptionalCourses = new List<OptionalCourse>();
                minNumOptionalCourses = 1;

            }

            public List<ReqirementCourse> GetReqiremetCourses() 
            {
                return reqiremetCourses;
            }

            public List<OptionalCourse> GetAllOptionalCourses()
            {
                return allOptionalCourses;
            }

            public void ChangeMinNumOptionalCourses(uint _minNumOptionalCourses)
            {
                minNumOptionalCourses = _minNumOptionalCourses;
                UpdateLearnPathesRequirements();
            }

            public void SetReqiremetCourses(List<ReqirementCourse> _reqiremetCourses)
            {
                reqiremetCourses = _reqiremetCourses;
                UpdateLearnPathesRequirements();
            }

            public void AddRequirementCourse(Course newReqirementCourse)
            {
                reqiremetCourses.Add( (ReqirementCourse) newReqirementCourse);
                UpdateLearnPathesRequirements();
            }

            public void AddOptionalCourse(Course newOptionalCourse)
            {
                allOptionalCourses.Add((OptionalCourse)newOptionalCourse);
                UpdateLearnPathesRequirements();
            }

            static public LearningPathRequirements Initialize()
            {
                if (singletoneLearningPathRequirements == null)
                    singletoneLearningPathRequirements = new LearningPathRequirements();

                return singletoneLearningPathRequirements;
            }

            public void UpdateLearnPathesRequirements()
            {
                LearnPath.UpdateRequirements(minNumOptionalCourses, reqiremetCourses);
            }
        }
        */
    }
}