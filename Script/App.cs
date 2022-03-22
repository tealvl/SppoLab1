using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class App
    {
        static void Main(string[] args)
        {
            UI.Print("Какое-то приветствие!");

            SignIn();
        }

        static public void SignIn() 
        {
            const string chooseAccountStr = "Выбор учетной записи:\n" +
                                            "\t1. Администратор\n" +
                                            "\t2. Учитель\n" +
                                            "\t3. Студент\n";


            int userInput = UI.InputSecurityRangeInt(1, 3, chooseAccountStr);
            
            UI.Clear();
           
            switch(userInput)
            {
                case 1:
                    UI.Print("Выполняется вход как администратор...");
                    Administrator admin = new Administrator();
                    admin.SignIn();
                    break;

                case 2:
                    UI.Print("Выполняется вход как учитель...");
                    Teacher teacher = new Teacher("Дмитрий Николай Василий", "Какать стоя", 42);
                    teacher.SignIn();
                    break;

                case 3:
                    UI.Print("Выполняется вход как студент...");
                    break;

                default:
                    UI.Print("Ошибка");
                    break;
            }
        }


    }
}
