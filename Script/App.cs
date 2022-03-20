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

            string str = "Выбор учетной записи:\n" +
                "\t1. Администратор\n" +
                "\t2. Учитель\n" +
                "\t3. Студент\n";

            List<int> countAccount = new List<int>(){ 1, 2, 3 };
            int inputUser = UI.InputSecurityInt(countAccount, str);

            UI.Clear();

            if (inputUser == 1) 
            {
                UI.Print("Выполняется вход как администратор...");
            }
            else if (inputUser == 2) 
            {
                UI.Print("Выполняется вход как учитель...");
            }
            else if(inputUser == 3) 
            {
                UI.Print("Выполняется вход как студент...");
            }
            else 
            {
                UI.Print("Ошибка");
            }
        }


    }
}
